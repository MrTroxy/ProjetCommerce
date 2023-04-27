namespace ProjetCommerce
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            texteFacture = new RichTextBox();
            button3 = new Button();
            btnViderListeItems = new Button();
            listeItemsScannes = new ListBox();
            button2 = new Button();
            edtItemSanne = new TextBox();
            btnImprimer = new Button();
            btnAjouter = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            btnAjouterProduit = new Button();
            edtPrixProduit = new TextBox();
            edtNomProduit = new TextBox();
            label7 = new Label();
            label5 = new Label();
            listeProduits = new ListView();
            colonneId = new ColumnHeader();
            colonneNom = new ColumnHeader();
            colonnePrix = new ColumnHeader();
            label4 = new Label();
            btnImprimerCodeBarre = new Button();
            imageCodeBarre = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            edtTexteCodeBarre = new TextBox();
            btnCreerCodeBarre = new Button();
            panelGestion = new Panel();
            panelConnexion = new Panel();
            btnConnexion = new Button();
            label3 = new Label();
            lblUsager = new Label();
            edtMotDePasse = new TextBox();
            edtUsager = new TextBox();
            lblTitreConnexion = new Label();
            edtDescriptionProduit = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageCodeBarre).BeginInit();
            panelGestion.SuspendLayout();
            panelConnexion.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1176, 612);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(texteFacture);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btnViderListeItems);
            tabPage1.Controls.Add(listeItemsScannes);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(edtItemSanne);
            tabPage1.Controls.Add(btnImprimer);
            tabPage1.Controls.Add(btnAjouter);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1168, 574);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Caisse";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // texteFacture
            // 
            texteFacture.Location = new Point(808, 64);
            texteFacture.Name = "texteFacture";
            texteFacture.Size = new Size(341, 502);
            texteFacture.TabIndex = 9;
            texteFacture.Text = "";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(808, 12);
            button3.Name = "button3";
            button3.Size = new Size(341, 46);
            button3.TabIndex = 8;
            button3.Text = "Facture :";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnViderListeItems
            // 
            btnViderListeItems.Location = new Point(17, 531);
            btnViderListeItems.Name = "btnViderListeItems";
            btnViderListeItems.Size = new Size(341, 35);
            btnViderListeItems.TabIndex = 7;
            btnViderListeItems.Text = "Vider la liste d'items";
            btnViderListeItems.UseVisualStyleBackColor = true;
            btnViderListeItems.Click += btnViderListeItems_Click;
            // 
            // listeItemsScannes
            // 
            listeItemsScannes.FormattingEnabled = true;
            listeItemsScannes.ItemHeight = 25;
            listeItemsScannes.Location = new Point(17, 64);
            listeItemsScannes.Name = "listeItemsScannes";
            listeItemsScannes.Size = new Size(341, 454);
            listeItemsScannes.TabIndex = 6;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(435, 12);
            button2.Name = "button2";
            button2.Size = new Size(341, 46);
            button2.TabIndex = 5;
            button2.Text = "Items scannés :";
            button2.UseVisualStyleBackColor = true;
            // 
            // edtItemSanne
            // 
            edtItemSanne.Location = new Point(435, 61);
            edtItemSanne.Name = "edtItemSanne";
            edtItemSanne.Size = new Size(341, 32);
            edtItemSanne.TabIndex = 4;
            edtItemSanne.TextChanged += edtItemSanne_TextChanged;
            edtItemSanne.KeyPress += edtItemSanne_KeyPress;
            // 
            // btnImprimer
            // 
            btnImprimer.Location = new Point(435, 233);
            btnImprimer.Name = "btnImprimer";
            btnImprimer.Size = new Size(341, 66);
            btnImprimer.TabIndex = 3;
            btnImprimer.Text = "Imprimer";
            btnImprimer.UseVisualStyleBackColor = true;
            btnImprimer.Click += btnImprimer_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(435, 129);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(341, 66);
            btnAjouter.TabIndex = 2;
            btnAjouter.Text = "Ajouter Manuellement";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(17, 12);
            button1.Name = "button1";
            button1.Size = new Size(341, 46);
            button1.TabIndex = 1;
            button1.Text = "Items scannés :";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(edtDescriptionProduit);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnAjouterProduit);
            tabPage2.Controls.Add(edtPrixProduit);
            tabPage2.Controls.Add(edtNomProduit);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(listeProduits);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnImprimerCodeBarre);
            tabPage2.Controls.Add(imageCodeBarre);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(edtTexteCodeBarre);
            tabPage2.Controls.Add(btnCreerCodeBarre);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1168, 574);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventaire";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAjouterProduit
            // 
            btnAjouterProduit.Location = new Point(393, 152);
            btnAjouterProduit.Name = "btnAjouterProduit";
            btnAjouterProduit.Size = new Size(253, 42);
            btnAjouterProduit.TabIndex = 14;
            btnAjouterProduit.Text = "Ajouter le produit";
            btnAjouterProduit.UseVisualStyleBackColor = true;
            btnAjouterProduit.Click += btnAjouterProduit_Click;
            // 
            // edtPrixProduit
            // 
            edtPrixProduit.Location = new Point(461, 114);
            edtPrixProduit.Name = "edtPrixProduit";
            edtPrixProduit.Size = new Size(185, 32);
            edtPrixProduit.TabIndex = 13;
            // 
            // edtNomProduit
            // 
            edtNomProduit.Location = new Point(461, 29);
            edtNomProduit.Name = "edtNomProduit";
            edtNomProduit.Size = new Size(185, 32);
            edtNomProduit.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 117);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 10;
            label7.Text = "Prix :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(393, 33);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 8;
            label5.Text = "Nom :";
            // 
            // listeProduits
            // 
            listeProduits.Columns.AddRange(new ColumnHeader[] { colonneId, colonneNom, colonnePrix });
            listeProduits.Location = new Point(652, 78);
            listeProduits.Name = "listeProduits";
            listeProduits.Size = new Size(477, 449);
            listeProduits.TabIndex = 7;
            listeProduits.UseCompatibleStateImageBehavior = false;
            listeProduits.View = View.Details;
            // 
            // colonneId
            // 
            colonneId.Text = "ID";
            colonneId.Width = 80;
            // 
            // colonneNom
            // 
            colonneNom.Text = "Nom";
            colonneNom.Width = 290;
            // 
            // colonnePrix
            // 
            colonnePrix.Text = "Prix";
            colonnePrix.Width = 100;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 26);
            label4.Name = "label4";
            label4.Size = new Size(363, 25);
            label4.TabIndex = 6;
            label4.Text = "Liste des produits dans la base de donnée";
            // 
            // btnImprimerCodeBarre
            // 
            btnImprimerCodeBarre.Location = new Point(30, 403);
            btnImprimerCodeBarre.Name = "btnImprimerCodeBarre";
            btnImprimerCodeBarre.Size = new Size(322, 64);
            btnImprimerCodeBarre.TabIndex = 5;
            btnImprimerCodeBarre.Text = "Imprimer le code barre";
            btnImprimerCodeBarre.UseVisualStyleBackColor = true;
            btnImprimerCodeBarre.Click += btnImprimerCodeBarre_Click;
            // 
            // imageCodeBarre
            // 
            imageCodeBarre.Location = new Point(30, 253);
            imageCodeBarre.Name = "imageCodeBarre";
            imageCodeBarre.Size = new Size(473, 134);
            imageCodeBarre.TabIndex = 4;
            imageCodeBarre.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 213);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 3;
            label2.Text = "Voici le code barre généré :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 2;
            label1.Text = "Entrez le texte du code barre :";
            // 
            // edtTexteCodeBarre
            // 
            edtTexteCodeBarre.Location = new Point(30, 78);
            edtTexteCodeBarre.Name = "edtTexteCodeBarre";
            edtTexteCodeBarre.Size = new Size(310, 32);
            edtTexteCodeBarre.TabIndex = 1;
            // 
            // btnCreerCodeBarre
            // 
            btnCreerCodeBarre.Location = new Point(30, 130);
            btnCreerCodeBarre.Name = "btnCreerCodeBarre";
            btnCreerCodeBarre.Size = new Size(195, 56);
            btnCreerCodeBarre.TabIndex = 0;
            btnCreerCodeBarre.Text = "Créer le code barre";
            btnCreerCodeBarre.UseVisualStyleBackColor = true;
            btnCreerCodeBarre.Click += btnCreerCodeBarre_Click;
            // 
            // panelGestion
            // 
            panelGestion.Controls.Add(tabControl1);
            panelGestion.Location = new Point(0, 0);
            panelGestion.Name = "panelGestion";
            panelGestion.Size = new Size(1176, 612);
            panelGestion.TabIndex = 2;
            panelGestion.Visible = false;
            // 
            // panelConnexion
            // 
            panelConnexion.Controls.Add(btnConnexion);
            panelConnexion.Controls.Add(label3);
            panelConnexion.Controls.Add(lblUsager);
            panelConnexion.Controls.Add(edtMotDePasse);
            panelConnexion.Controls.Add(edtUsager);
            panelConnexion.Controls.Add(lblTitreConnexion);
            panelConnexion.Location = new Point(0, 0);
            panelConnexion.Name = "panelConnexion";
            panelConnexion.Size = new Size(1176, 612);
            panelConnexion.TabIndex = 3;
            // 
            // btnConnexion
            // 
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConnexion.Location = new Point(496, 458);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(181, 54);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(521, 308);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 4;
            label3.Text = "Mot de passe";
            // 
            // lblUsager
            // 
            lblUsager.AutoSize = true;
            lblUsager.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsager.Location = new Point(521, 195);
            lblUsager.Name = "lblUsager";
            lblUsager.Size = new Size(139, 25);
            lblUsager.TabIndex = 3;
            lblUsager.Text = "Nom d'usager";
            // 
            // edtMotDePasse
            // 
            edtMotDePasse.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            edtMotDePasse.Location = new Point(439, 342);
            edtMotDePasse.Name = "edtMotDePasse";
            edtMotDePasse.Size = new Size(306, 32);
            edtMotDePasse.TabIndex = 2;
            edtMotDePasse.Text = "Patate123";
            edtMotDePasse.UseSystemPasswordChar = true;
            // 
            // edtUsager
            // 
            edtUsager.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            edtUsager.Location = new Point(439, 229);
            edtUsager.Name = "edtUsager";
            edtUsager.Size = new Size(306, 32);
            edtUsager.TabIndex = 1;
            edtUsager.Text = "alain";
            // 
            // lblTitreConnexion
            // 
            lblTitreConnexion.AutoSize = true;
            lblTitreConnexion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitreConnexion.Location = new Point(439, 60);
            lblTitreConnexion.Name = "lblTitreConnexion";
            lblTitreConnexion.Size = new Size(306, 32);
            lblTitreConnexion.TabIndex = 0;
            lblTitreConnexion.Text = "Connexion a l'application";
            // 
            // edtDescriptionProduit
            // 
            edtDescriptionProduit.Location = new Point(506, 76);
            edtDescriptionProduit.Name = "edtDescriptionProduit";
            edtDescriptionProduit.Size = new Size(140, 32);
            edtDescriptionProduit.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 79);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 15;
            label6.Text = "Description :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 614);
            Controls.Add(panelGestion);
            Controls.Add(panelConnexion);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application de Gestion de Commerce";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageCodeBarre).EndInit();
            panelGestion.ResumeLayout(false);
            panelConnexion.ResumeLayout(false);
            panelConnexion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Button btnImprimer;
        private Button btnAjouter;
        private Button button2;
        private TextBox edtItemSanne;
        private ListBox listeItemsScannes;
        private Label label1;
        private TextBox edtTexteCodeBarre;
        private Button btnCreerCodeBarre;
        private PictureBox imageCodeBarre;
        private Label label2;
        private Button btnImprimerCodeBarre;
        private Button btnViderListeItems;
        private RichTextBox texteFacture;
        private Button button3;
        private Panel panelGestion;
        private Panel panelConnexion;
        private Button btnConnexion;
        private Label label3;
        private Label lblUsager;
        private TextBox edtMotDePasse;
        private TextBox edtUsager;
        private Label lblTitreConnexion;
        private Label label4;
        private ListView listeProduits;
        private ColumnHeader colonneId;
        private ColumnHeader colonneNom;
        private Button btnAjouterProduit;
        private TextBox edtPrixProduit;
        private TextBox edtNomProduit;
        private Label label7;
        private Label label5;
        private ColumnHeader colonnePrix;
        private TextBox edtDescriptionProduit;
        private Label label6;
    }
}