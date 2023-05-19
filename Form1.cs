using BarcodeLib;
using Newtonsoft.Json;
using ProjetCommerce.Objets;
using System.Collections;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using static ProjetCommerce.Objets.Produit;
using static ProjetCommerce.Objets.Jeton;

namespace ProjetCommerce
{
    public partial class Form1 : Form
    {
        // Dictionary pour stocker les produits
        Dictionary<string, Produit> inventaireProduits = new Dictionary<string, Produit>();
        bool usagerConnecte = false;
        string token = "";
        string dernierIdDeProduitAjoute = "";

        public Form1()
        {
            InitializeComponent();
        }

        // Fonction pour cr�er la facture qui sera ensuite imprim�e
        private string CreerFacture(IList items)
        {
            StringBuilder creationDeFacture = new StringBuilder();
            double sousTotal = 0;
            const double TPS = 0.05;
            const double TVQ = 0.09975;
            string dateActuelleEtHeure = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            creationDeFacture.AppendLine(" - ");
            creationDeFacture.AppendLine("Facture de la boutique");
            creationDeFacture.AppendLine("No de Facture : #" + DateTime.Now.ToString("yyyyMMddHHmmss"));
            creationDeFacture.AppendLine(" - ");
            creationDeFacture.AppendLine("Items : ");
            creationDeFacture.AppendLine(" - ");

            foreach (var item in items)
            {
                // Utiliser le dictionnaire 'inventaireProduits' pour obtenir les d�tails du produit en fonction de l'ID scann�
                if (inventaireProduits.TryGetValue(item.ToString(), out Produit produit))
                {
                    // Ajoutez les d�tails de l'�l�ment � la facture (nom, prix, etc.)
                    string ligne = produit.Nom + " : " + produit.Prix.ToString("0.00$");
                    creationDeFacture.AppendLine(ligne);

                    // Mettez � jour le sous-total
                    sousTotal += produit.Prix;
                }
            }

            // Calculez les taxes et le total
            double montantTPS = sousTotal * TPS;
            double montantTVQ = sousTotal * TVQ;
            double total = sousTotal + montantTPS + montantTVQ;

            // Ajoutez d'autres informations � la facture, telles que le sous-total, les taxes et le total
            creationDeFacture.AppendLine(" - ");
            creationDeFacture.AppendLine("Sous-total : " + sousTotal.ToString("0.00$"));
            creationDeFacture.AppendLine("TPS (5%) : " + montantTPS.ToString("0.00$"));
            creationDeFacture.AppendLine("TVQ (9.975%) : " + montantTVQ.ToString("0.00$"));
            creationDeFacture.AppendLine("Total : " + total.ToString("0.00$"));
            creationDeFacture.AppendLine(" - ");
            creationDeFacture.AppendLine("Merci d'avoir magasin� chez nous!");
            creationDeFacture.AppendLine("Date : " + dateActuelleEtHeure);

            return creationDeFacture.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (edtItemScanne.Text.Length > 0)
            {
                // Aller chercher le nom du produit en fonction de l'ID scann� (celui dans edtItemScanne.Text)
                // Utiliser le dictionnaire 'inventaireProduits' pour obtenir les d�tails du produit en fonction de l'ID scann�
                if (inventaireProduits.TryGetValue(edtItemScanne.Text, out Produit produit))
                {
                    // Ajouter le nom du produit � la liste
                    listeItemsScannes.Items.Add(produit.Nom);
                    listeIDScannesCache.Items.Add(produit.Id);
                }
                else
                {
                    MessageBox.Show("L'item scann� n'existe pas dans l'inventaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                edtItemScanne.Clear();
                // G�n�rer la facture avec la fonction CreerFacture
                string facture = CreerFacture(listeIDScannesCache.Items);
                texteFacture.Text = String.Empty;
                // Afficher la facture dans le champ de texte
                texteFacture.Text = facture;
            }
            else
            {
                MessageBox.Show("Veuillez entrer un item � ajouter � la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            edtItemScanne.Focus();
        }

        private void edtItemSanne_TextChanged(object sender, EventArgs e)
        {
            // V�rication pour l'ajout a la liste si l'utilisateur appuie sur Entr�e
            if (edtItemScanne.Text.EndsWith("\r") || edtItemScanne.Text.EndsWith("\n"))
            {
                btnAjouter.PerformClick();
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
            listeIDScannesCache.Items.Clear();
            texteFacture.Text = string.Empty;
            edtItemScanne.Focus();
        }

        // Fonction pour g�n�rer la facture et l'imprimer
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            // V�rifier que la liste n'est pas vide
            if (listeItemsScannes.Items.Count > 0)
            {
                // G�n�rer la facture avec la fonction CreerFacture
                string facture = CreerFacture(listeIDScannesCache.Items);

                // Cr�er un objet PrintDocument
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, args) => ImprimerFacture(args, facture);
                printDocument.Print();
                texteFacture.Text = facture;

                // Ouvrir le tiroir-caisse
                OuvrirTiroirCaisse();
            }
            else
            {
                MessageBox.Show("Veuillez scanner des produits avant de faire cela!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            edtItemScanne.Focus();
        }

        private void ImprimerFacture(PrintPageEventArgs e, string facture)
        {
            Font police = new Font("Helvetica", 10);
            float margeGauche = 5;
            float margeSuperieure = 0;

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

        private void OuvrirTiroirCaisse()
        {
            // Cr�er une instance de la classe SerialPort
            SerialPort serialPort = new SerialPort();

            // R�cup�rer la liste des ports COM disponibles
            string[] ports = SerialPort.GetPortNames();

            // Si aucun port n'est trouv�, afficher un message d'erreur
            if (ports.Length == 0)
            {
                MessageBox.Show("Le tiroir caisse n'est pas branch�!");
            }
            else
            {
                // S�lectionner automatiquement le premier port COM disponible
                serialPort.PortName = ports[0];
                foreach (string port in ports)
                {
                    serialPort.PortName = port;
                    listPorts.Items.Add(port);
                }
                listPorts.SelectedIndex = 0;

                SerialPort rsPort = new SerialPort(listPorts.Text);

                byte[] openCmd = new byte[5];
                openCmd[0] = 27;
                openCmd[1] = 112;
                openCmd[2] = 0;
                openCmd[3] = 60;
                openCmd[4] = 255;

                rsPort.Open();
                Thread.Sleep(100);
                rsPort.Write(openCmd, 0, 5);
                Thread.Sleep(100);
                rsPort.Close();
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
                    edtItemScanne.Focus();
                    AcceptButton = btnAjouter;

                    // Utiliser le token pour acc�der � d'autres ressources prot�g�es
                    // Obtention de la liste des produits
                    ObtenirListeProduitsDB();
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

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                edtItemScanne.Focus();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                ObtenirListeProduitsDB();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                ObtenirListeJetonsDB();
            }
        }

        private void btnImprimerCodeBarre_Click(object sender, EventArgs e)
        {
            string chemin = @"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres\\" + dernierIdDeProduitAjoute + ".png";
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

            if (btnImprimerCodeBarre.Visible)
            {
                btnImprimerCodeBarre.Visible = false;
                imageCodeBarre.Visible = false;
                lblCodeBarreProduitAjoute.Visible = false;
            }
        }

        private async void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            bool successAjoutProduit;

            if (edtNomProduit.Text != String.Empty && edtDescriptionProduit.Text != String.Empty && edtPrixProduit.Text != String.Empty && edtQuantiteProduit.Text != String.Empty)
            {
                // R�cup�rer les valeurs des champs nom, description et prix
                var nom = edtNomProduit.Text;
                var description = edtDescriptionProduit.Text;
                double prix = 0;
                int quantite = 0;
                bool parsed = false;

                try
                {
                    prix = double.Parse(edtPrixProduit.Text);
                    quantite = int.Parse(edtQuantiteProduit.Text);
                    parsed = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (parsed)
                {
                    // Les deux valeurs sont valides et pars�es avec succ�s
                    var url = "http://api.qc-ca.ovh:2222/api/ajouter/produit";

                    // Cr�er un objet HttpClient
                    using (var client = new HttpClient())
                    {
                        // Ajouter l'en-t�te d'autorisation � la requ�te HTTP
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
                        // Cr�er un objet StringContent contenant le corps de la requ�te JSON
                        var requestBody = new { nom = nom, description = description, quantite = quantite, prix = prix };
                        var jsonBody = JsonConvert.SerializeObject(requestBody);
                        var httpContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                        // Envoyer la requ�te HTTP POST
                        var response = await client.PostAsync(url, httpContent);

                        // Traiter la r�ponse HTTP
                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<dynamic>(responseContent);
                            // Obtenir la liste des produits pour la mettre � jour
                            ObtenirListeProduitsDB();
                            successAjoutProduit = true;
                            MessageBox.Show("Produit ajout� avec succ�s !", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            successAjoutProduit = false;
                            MessageBox.Show("Erreur : " + response.StatusCode, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (successAjoutProduit)
                    {
                        // Obtien le id du produit qui vient d'�tre ajout�
                        string idProduit = await ObtenirDernierIdProduit();

                        // G�n�rer le code-barre
                        // V�rifier si le chemin existe et si non, on le cr�er
                        if (!Directory.Exists(@"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres"))
                        {
                            Directory.CreateDirectory(@"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres");
                        }
                        string chemin = @"C:\\Users\\" + Environment.UserName + "\\Pictures\\CodesBarres\\" + idProduit + ".png";

                        Barcode codeBarre = new Barcode();
                        Image imgCodeBarre = codeBarre.Encode(TYPE.CODE128, idProduit, Color.Black, Color.White, 400, 100);
                        imgCodeBarre.Save(chemin, System.Drawing.Imaging.ImageFormat.Png);

                        imageCodeBarre.Image = imgCodeBarre;

                        lblCodeBarreProduitAjoute.Visible = true;
                        imageCodeBarre.Visible = true;
                        btnImprimerCodeBarre.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs pour ajouter un produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    MessageBox.Show("Erreur lors de la r�cup�ration de la liste des produits. Code: " + response.StatusCode);
                    return null;
                }
            }
        }

        // M�thode pour obtenir la liste des produits
        private async void ObtenirListeProduitsDB()
        {
            var produits = await ObtenirProduits(token);
            if (produits != null)
            {
                listeProduits.Items.Clear();
                inventaireProduits.Clear();
                foreach (var produit in produits)
                {
                    inventaireProduits[produit.Id.ToString()] = produit;
                    var item = new ListViewItem(produit.Id.ToString());
                    item.SubItems.Add(produit.Nom);
                    item.SubItems.Add(produit.Quantite.ToString());
                    item.SubItems.Add(produit.Prix.ToString("0.00$"));
                    listeProduits.Items.Add(item);
                }
            }
        }

        private async Task<List<Jeton>> ObtenirJetons(string token)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api.qc-ca.ovh:2222");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

                var response = await client.GetAsync("/api/jetons/obtenir");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var jetons = JsonConvert.DeserializeObject<List<Jeton>>(json);
                    return jetons;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la r�cup�ration de la liste des jetons. Code: " + response.StatusCode);
                    return null;
                }
            }
        }

        // M�thode pour obtenir la liste des jetons et les mettre dans la ListView
        private async void ObtenirListeJetonsDB()
        {
            var jetons = await ObtenirJetons(token);
            if (jetons != null)
            {
                listeJetons.Items.Clear();
                foreach (var jeton in jetons)
                {
                    var item = new ListViewItem(jeton.Numtag);
                    item.SubItems.Add(jeton.Nom);
                    item.SubItems.Add(jeton.Date.ToString());
                    listeJetons.Items.Add(item);
                }
            }
        }

        private async void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            // V�rifier qu'un �l�ment est s�lectionn� dans la ListView
            if (listeProduits.SelectedItems.Count > 0)
            {
                // Appel de l'API pour supprimer le produit (en POST)
                var id = listeProduits.SelectedItems[0].Text;
                var url = "http://api.qc-ca.ovh:2222/api/supprimer/produit";

                using (var client = new HttpClient())
                {
                    // Ajouter le token d'autorisation au client
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);

                    var content = new StringContent(JsonConvert.SerializeObject(new { id = id }), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        ObtenirListeProduitsDB();
                        MessageBox.Show("Produit supprim� avec succ�s !", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erreur : " + response.StatusCode, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner le ID du produit � supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInformationProduit_Click(object sender, EventArgs e)
        {
            // V�rifier qu'un �l�ment est s�lectionn� dans la ListView
            if (listeProduits.SelectedItems.Count > 0)
            {
                // R�cup�rer l'ID du produit s�lectionn�
                var id = listeProduits.SelectedItems[0].Text;

                // Recherchez le produit dans le dictionnaire en utilisant l'ID
                if (inventaireProduits.TryGetValue(id, out Produit produit))
                {
                    // R�cup�rer les informations du produit � partir du dictionnaire
                    var nom = produit.Nom;
                    var description = produit.Description;
                    var quantite = produit.Quantite;
                    var prix = produit.Prix;

                    var message = $"ID: {id}\nNom: {nom}\nDescription: {description}\nQuantit�: {quantite}\nPrix: {prix}";

                    // Afficher le MessageBox avec les informations du produit
                    MessageBox.Show(message, "Informations produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Le produit s�lectionn� est introuvable dans le dictionnaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez s�lectionner le ID d'un produit dans la liste pour afficher ses informations.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> ObtenirDernierIdProduit()
        {
            string dernierId = "";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
                string url = "http://api.qc-ca.ovh:2222/api/produits/dernier";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    var resultat = JsonConvert.DeserializeObject<dynamic>(jsonContent);
                    dernierId = resultat.id;
                    dernierIdDeProduitAjoute = dernierId;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la r�cup�ration du dernier ID de produit : " + response.StatusCode, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dernierId;
        }

        private void btnViderChampsProduit_Click(object sender, EventArgs e)
        {
            // Effacer les valeurs des champs de saisie
            edtNomProduit.Text = "";
            edtDescriptionProduit.Text = "";
            edtQuantiteProduit.Text = "";
            edtPrixProduit.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ObtenirListeJetonsDB();
        }
    }
}