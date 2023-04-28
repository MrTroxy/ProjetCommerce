using BarcodeLib;
using Newtonsoft.Json;
using ProjetCommerce.Objets;
using System.Collections;
using System.Drawing.Printing;
using System.Net.Http.Headers;
using System.Text;
using static ProjetCommerce.Objets.Produit;

namespace ProjetCommerce
{
    public partial class Form1 : Form
    {
        bool usagerConnecte = false;
        string token = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Fonction pour créer la facture qui sera ensuite imprimée
        private string CreerFacture(IList items)
        {
            StringBuilder creationDeFacture = new StringBuilder();

            foreach (var item in items)
            {
                // Ajoutez les détails de l'élément à la facture (nom, prix, etc.)
                creationDeFacture.AppendLine(item.ToString());
            }

            // Ajoutez d'autres informations à la facture, telles que le total et la TVA
            // ...

            return creationDeFacture.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (edtItemScanne.Text.Length > 0)
            {
                listeItemsScannes.Items.Add(edtItemScanne.Text);
                edtItemScanne.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un item à ajouter à la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            edtItemScanne.Focus();
        }

        private void edtItemSanne_TextChanged(object sender, EventArgs e)
        {
            if (edtItemScanne.Text.EndsWith("\r") || edtItemScanne.Text.EndsWith("\n"))
            {
                btnAjouter.PerformClick();
            }
        }

        private void btnCreerCodeBarre_Click(object sender, EventArgs e)
        {
            // Vérifier que le champ n'est pas vide
            if (edtTexteCodeBarre.Text.Length > 0)
            {
                string texte = edtTexteCodeBarre.Text;
                // Vérifier si le chemin existe et si non, on le créer
                if (!Directory.Exists(@"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres"))
                {
                    Directory.CreateDirectory(@"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres");
                }
                string chemin = @"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres\\" + texte + ".png";

                Barcode codeBarre = new Barcode();
                Image imgCodeBarre = codeBarre.Encode(TYPE.CODE128, texte, Color.Black, Color.White, 400, 100);
                imgCodeBarre.Save(chemin, System.Drawing.Imaging.ImageFormat.Png);

                imageCodeBarre.Image = imgCodeBarre;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            edtItemScanne.Focus();
            AcceptButton = btnConnexion;
        }

        private void edtItemSanne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAjouter.PerformClick();
            }
        }

        private void btnViderListeItems_Click(object sender, EventArgs e)
        {
            listeItemsScannes.Items.Clear();
        }

        // Fonction pour générer la facture et l'imprimer
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            // Vérifier que la liste n'est pas vide
            if (listeItemsScannes.Items.Count > 0)
            {
                // Générer la facture avec la fonction CreerFacture
                string facture = CreerFacture(listeItemsScannes.Items);

                // Créer un objet PrintDocument
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, args) => ImprimerFacture(args, facture);
                printDocument.Print();
            }
        }

        private void ImprimerFacture(PrintPageEventArgs e, string facture)
        {
            Font police = new Font("Arial", 12);
            float margeGauche = e.MarginBounds.Left;
            float margeSuperieure = e.MarginBounds.Top;

            using (StringReader lecteur = new StringReader(facture))
            {
                string ligne;
                while ((ligne = lecteur.ReadLine()) != null)
                {
                    SizeF tailleLigne = e.Graphics.MeasureString(ligne, police);
                    e.Graphics.DrawString(ligne, police, Brushes.Black, margeGauche, margeSuperieure);
                    margeSuperieure += tailleLigne.Height;
                }
            }
        }

        private async void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                // Créer un client HTTP
                var httpClient = new HttpClient();

                // Créer les paramètres de la requête POST
                var parametres = new Dictionary<string, string>
                {
                    { "usager", edtUsager.Text },
                    { "mot_de_passe", edtMotDePasse.Text }
                };

                // Encodage des paramètres en tant que contenu de la requête
                var contenu = new FormUrlEncodedContent(parametres);

                // Envoyer la requête POST à l'API de connexion
                var reponse = await httpClient.PostAsync("http://api.qc-ca.ovh:2222/api/connexion", contenu);
                var reponseContenu = await reponse.Content.ReadAsStringAsync();
                var resultat = JsonConvert.DeserializeObject<dynamic>(reponseContenu);
                // Vérifier si la connexion a réussi ou non
                if (reponse.IsSuccessStatusCode)
                {
                    // Stocker le token d'authentification
                    usagerConnecte = true;
                    token = resultat.token;

                    // Changer de page
                    panelConnexion.Visible = false;
                    panelGestion.Visible = true;
                    edtItemScanne.Focus();
                    AcceptButton = btnAjouter;

                    // Utiliser le token pour accéder à d'autres ressources protégées
                    //MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Afficher le message d'erreur
                    MessageBox.Show("Erreur : " + resultat.message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs éventuelles
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                edtItemScanne.Focus();
            }
        }

        private void btnImprimerCodeBarre_Click(object sender, EventArgs e)
        {
            string chemin = @"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres\\" + edtTexteCodeBarre.Text + ".png";
            // Charger l'image à imprimer
            var image = Image.FromFile(chemin);

            // Calculer la largeur et la hauteur de l'image réduite
            var factor = 0.5f; // Facteur de réduction de l'image
            var width = (int)(image.Width * factor);
            var height = (int)(image.Height * factor);

            // Créer un nouveau document d'impression
            var document = new PrintDocument();

            // Gérer l'événement PrintPage pour dessiner l'image sur la page
            document.PrintPage += (s, ev) =>
            {
                // Dessiner l'image réduite sur la page
                ev.Graphics.DrawImage(image, new Rectangle(0, 0, width, height));
            };

            // Afficher la boîte de dialogue d'impression
            var printDialog = new PrintDialog();
            printDialog.Document = document;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private async void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs nom, description et prix
            var nom = edtNomProduit.Text;
            var prix = double.Parse(edtPrixProduit.Text);
            var quantite = int.Parse(edtQuantiteProduit.Text);
            var description = edtDescriptionProduit.Text;

            var url = "http://api.qc-ca.ovh:2222/api/ajouter/produit";

            // Créer un objet HttpClient
            using (var client = new HttpClient())
            {
                // Ajouter l'en-tête d'autorisation à la requête HTTP
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
                // Créer un objet StringContent contenant le corps de la requête JSON
                var requestBody = new { nom = nom, description = description, quantite = quantite, prix = prix };
                var jsonBody = JsonConvert.SerializeObject(requestBody);
                var httpContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Envoyer la requête HTTP POST
                var response = await client.PostAsync(url, httpContent);

                // Traiter la réponse HTTP
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    MessageBox.Show("Produit ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur : " + response.StatusCode, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Effacer les valeurs des champs de saisie
            edtNomProduit.Text = "";
            edtDescriptionProduit.Text = "";
            edtQuantiteProduit.Text = "";
            edtPrixProduit.Text = "";
        }

        private async Task<List<Produit>> ObtenirProduits(string token)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.qc-ca.ovh:2222");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

                var response = await client.GetAsync("/api/produits/obtenir");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var produits = JsonConvert.DeserializeObject<List<Produit>>(json);
                    return produits;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la récupération de la liste des produits. Code: " + response.StatusCode);
                    return null;
                }
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var produits = await ObtenirProduits(token);

            if (produits != null)
            {
                listeProduits.Items.Clear();
                foreach (var produit in produits)
                {
                    var item = new ListViewItem(produit.Id.ToString());
                    item.SubItems.Add(produit.Nom);
                    item.SubItems.Add(produit.Quantite.ToString());
                    item.SubItems.Add(produit.Prix.ToString());
                    // Ajoutez d'autres sous-éléments si nécessaire en fonction des propriétés de la classe 'Produit'

                    listeProduits.Items.Add(item);
                }
            }
        }
    }
}