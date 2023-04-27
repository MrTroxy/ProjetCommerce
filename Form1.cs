using BarcodeLib;
using Newtonsoft.Json;
using System.Collections;
using System.Drawing.Printing;
using System.Text;

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

        // Fonction pour cr�er la facture qui sera ensuite imprim�e
        private string CreerFacture(IList items)
        {
            StringBuilder creationDeFacture = new StringBuilder();

            foreach (var item in items)
            {
                // Ajoutez les d�tails de l'�l�ment � la facture (nom, prix, etc.)
                creationDeFacture.AppendLine(item.ToString());
            }

            // Ajoutez d'autres informations � la facture, telles que le total et la TVA
            // ...

            return creationDeFacture.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            listeItemsScannes.Items.Add(edtItemSanne.Text);
            edtItemSanne.Clear();
            edtItemSanne.Focus();
        }

        private void edtItemSanne_TextChanged(object sender, EventArgs e)
        {
            if (edtItemSanne.Text.EndsWith("\r") || edtItemSanne.Text.EndsWith("\n"))
            {
                btnAjouter.PerformClick();
            }
        }

        private void btnCreerCodeBarre_Click(object sender, EventArgs e)
        {
            // V�rifier que le champ n'est pas vide
            if (edtTexteCodeBarre.Text.Length > 0)
            {
                string texte = edtTexteCodeBarre.Text;
                // V�rifier si le chemin existe et si non, on le cr�er
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
            edtItemSanne.Focus();
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

        // Fonction pour g�n�rer la facture et l'imprimer
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            // V�rifier que la liste n'est pas vide
            if (listeItemsScannes.Items.Count > 0)
            {
                // G�n�rer la facture avec la fonction CreerFacture
                string facture = CreerFacture(listeItemsScannes.Items);

                // Cr�er un objet PrintDocument
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
                // Cr�er un client HTTP
                var httpClient = new HttpClient();

                // Cr�er les param�tres de la requ�te POST
                var parametres = new Dictionary<string, string>
                {
                    { "usager", edtUsager.Text },
                    { "mot_de_passe", edtMotDePasse.Text }
                };

                // Encodage des param�tres en tant que contenu de la requ�te
                var contenu = new FormUrlEncodedContent(parametres);

                // Envoyer la requ�te POST � l'API de connexion
                var reponse = await httpClient.PostAsync("http://api.qc-ca.ovh:2222/api/connexion", contenu);
                var reponseContenu = await reponse.Content.ReadAsStringAsync();
                var resultat = JsonConvert.DeserializeObject<dynamic>(reponseContenu);
                // V�rifier si la connexion a r�ussi ou non
                if (reponse.IsSuccessStatusCode)
                {
                    // Stocker le token d'authentification
                    usagerConnecte = true;
                    token = resultat.token;

                    // Changer de page
                    panelConnexion.Visible = false;
                    panelGestion.Visible = true;
                    edtItemSanne.Focus();
                    AcceptButton = btnAjouter;

                    // Utiliser le token pour acc�der � d'autres ressources prot�g�es
                    //MessageBox.Show("Connexion r�ussie !", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Afficher le message d'erreur
                    MessageBox.Show("Erreur : " + resultat.message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // G�rer les erreurs �ventuelles
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                edtItemSanne.Focus();
            }
        }

        private void btnImprimerCodeBarre_Click(object sender, EventArgs e)
        {
            string chemin = @"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres\\" + edtTexteCodeBarre.Text + ".png";
            // Charger l'image � imprimer
            var image = Image.FromFile(chemin);

            // Calculer la largeur et la hauteur de l'image r�duite
            var factor = 0.5f; // Facteur de r�duction de l'image
            var width = (int)(image.Width * factor);
            var height = (int)(image.Height * factor);

            // Cr�er un nouveau document d'impression
            var document = new PrintDocument();

            // G�rer l'�v�nement PrintPage pour dessiner l'image sur la page
            document.PrintPage += (s, ev) =>
            {
                // Dessiner l'image r�duite sur la page
                ev.Graphics.DrawImage(image, new Rectangle(0, 0, width, height));
            };

            // Afficher la bo�te de dialogue d'impression
            var printDialog = new PrintDialog();
            printDialog.Document = document;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private async void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            // R�cup�rer les valeurs des champs nom, description et prix
            var nom = edtNomProduit.Text;
            var prix = double.Parse(edtPrixProduit.Text);
            var description = edtDescriptionProduit.Text;

            var url = "http://api.qc-ca.ovh:2222/api/ajouter/produit";

            // Cr�er un objet HttpClient
            using (var client = new HttpClient())
            {
                // Cr�er un objet StringContent contenant le corps de la requ�te JSON
                var requestBody = new { nom = nom, description = description, prix = prix };
                var jsonBody = JsonConvert.SerializeObject(requestBody);
                var httpContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Envoyer la requ�te HTTP POST
                var response = await client.PostAsync(url, httpContent);

                // Traiter la r�ponse HTTP
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    MessageBox.Show("Produit ajout� avec succ�s !", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur : " + response.StatusCode, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Effacer les valeurs des champs de saisie
            edtNomProduit.Text = "";
            edtDescriptionProduit.Text = "";
            edtPrixProduit.Text = "";
        }

    }
}