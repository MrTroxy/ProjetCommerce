using BarcodeLib;
using System.Collections;
using System.Drawing.Printing;
using System.Text;

namespace ProjetCommerce
{
    public partial class Form1 : Form
    {
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
            edtItemSanne.Focus();
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
    }
}