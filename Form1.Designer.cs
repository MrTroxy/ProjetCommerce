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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listPorts = new ComboBox();
            listeIDScannesCache = new ListBox();
            texteFacture = new RichTextBox();
            button3 = new Button();
            btnViderListeItems = new Button();
            listeItemsScannes = new ListBox();
            button2 = new Button();
            edtItemScanne = new TextBox();
            btnImprimer = new Button();
            btnAjouter = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            btnViderChampsProduit = new Button();
            edtDescriptionProduit = new RichTextBox();
            btnInformationProduit = new Button();
            btnSupprimerProduit = new Button();
            edtQuantiteProduit = new TextBox();
            label8 = new Label();
            label6 = new Label();
            btnAjouterProduit = new Button();
            edtPrixProduit = new TextBox();
            edtNomProduit = new TextBox();
            label7 = new Label();
            label5 = new Label();
            listeProduits = new ListView();
            colonneId = new ColumnHeader();
            colonneNom = new ColumnHeader();
            colonneQuantite = new ColumnHeader();
            colonnePrix = new ColumnHeader();
            label4 = new Label();
            btnImprimerCodeBarre = new Button();
            imageCodeBarre = new PictureBox();
            lblCodeBarreProduitAjoute = new Label();
            panelGestion = new Panel();
            panelConnexion = new Panel();
            btnConnexion = new Button();
            label3 = new Label();
            lblUsager = new Label();
            edtMotDePasse = new TextBox();
            edtUsager = new TextBox();
            lblTitreConnexion = new Label();
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
            tabControl1.Size = new Size(1252, 753);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listPorts);
            tabPage1.Controls.Add(listeIDScannesCache);
            tabPage1.Controls.Add(texteFacture);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btnViderListeItems);
            tabPage1.Controls.Add(listeItemsScannes);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(edtItemScanne);
            tabPage1.Controls.Add(btnImprimer);
            tabPage1.Controls.Add(btnAjouter);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1244, 715);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Caisse";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listPorts
            // 
            listPorts.FormattingEnabled = true;
            listPorts.Location = new Point(759, 659);
            listPorts.Name = "listPorts";
            listPorts.Size = new Size(28, 33);
            listPorts.TabIndex = 11;
            listPorts.Visible = false;
            // 
            // listeIDScannesCache
            // 
            listeIDScannesCache.FormattingEnabled = true;
            listeIDScannesCache.ItemHeight = 25;
            listeIDScannesCache.Location = new Point(58, 593);
            listeIDScannesCache.Name = "listeIDScannesCache";
            listeIDScannesCache.Size = new Size(253, 29);
            listeIDScannesCache.TabIndex = 10;
            listeIDScannesCache.Visible = false;
            // 
            // texteFacture
            // 
            texteFacture.Location = new Point(808, 64);
            texteFacture.Name = "texteFacture";
            texteFacture.ReadOnly = true;
            texteFacture.Size = new Size(404, 558);
            texteFacture.TabIndex = 9;
            texteFacture.Text = "";
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(808, 12);
            button3.Name = "button3";
            button3.Size = new Size(404, 46);
            button3.TabIndex = 8;
            button3.Text = "Facture :";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnViderListeItems
            // 
            btnViderListeItems.Location = new Point(17, 659);
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
            listeItemsScannes.Size = new Size(341, 579);
            listeItemsScannes.TabIndex = 6;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(388, 12);
            button2.Name = "button2";
            button2.Size = new Size(372, 46);
            button2.TabIndex = 5;
            button2.Text = "Scan de codes barres";
            button2.UseVisualStyleBackColor = true;
            // 
            // edtItemScanne
            // 
            edtItemScanne.Location = new Point(388, 82);
            edtItemScanne.Name = "edtItemScanne";
            edtItemScanne.Size = new Size(372, 32);
            edtItemScanne.TabIndex = 4;
            edtItemScanne.TextChanged += edtItemSanne_TextChanged;
            edtItemScanne.KeyPress += edtItemSanne_KeyPress;
            // 
            // btnImprimer
            // 
            btnImprimer.Location = new Point(808, 628);
            btnImprimer.Name = "btnImprimer";
            btnImprimer.Size = new Size(404, 66);
            btnImprimer.TabIndex = 3;
            btnImprimer.Text = "Imprimer";
            btnImprimer.UseVisualStyleBackColor = true;
            btnImprimer.Click += btnImprimer_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(388, 140);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(372, 71);
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
            tabPage2.Controls.Add(btnViderChampsProduit);
            tabPage2.Controls.Add(edtDescriptionProduit);
            tabPage2.Controls.Add(btnInformationProduit);
            tabPage2.Controls.Add(btnSupprimerProduit);
            tabPage2.Controls.Add(edtQuantiteProduit);
            tabPage2.Controls.Add(label8);
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
            tabPage2.Controls.Add(lblCodeBarreProduitAjoute);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1244, 715);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inventaire";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnViderChampsProduit
            // 
            btnViderChampsProduit.Location = new Point(33, 269);
            btnViderChampsProduit.Name = "btnViderChampsProduit";
            btnViderChampsProduit.Size = new Size(183, 33);
            btnViderChampsProduit.TabIndex = 22;
            btnViderChampsProduit.Text = "Vider les champs";
            btnViderChampsProduit.UseVisualStyleBackColor = true;
            btnViderChampsProduit.Click += btnViderChampsProduit_Click;
            // 
            // edtDescriptionProduit
            // 
            edtDescriptionProduit.BorderStyle = BorderStyle.FixedSingle;
            edtDescriptionProduit.Location = new Point(153, 72);
            edtDescriptionProduit.Name = "edtDescriptionProduit";
            edtDescriptionProduit.Size = new Size(353, 96);
            edtDescriptionProduit.TabIndex = 21;
            edtDescriptionProduit.Text = "";
            // 
            // btnInformationProduit
            // 
            btnInformationProduit.Location = new Point(964, 652);
            btnInformationProduit.Name = "btnInformationProduit";
            btnInformationProduit.Size = new Size(272, 58);
            btnInformationProduit.TabIndex = 20;
            btnInformationProduit.Text = "Informations du Produit";
            btnInformationProduit.UseVisualStyleBackColor = true;
            btnInformationProduit.Click += btnInformationProduit_Click;
            // 
            // btnSupprimerProduit
            // 
            btnSupprimerProduit.Location = new Point(677, 652);
            btnSupprimerProduit.Name = "btnSupprimerProduit";
            btnSupprimerProduit.Size = new Size(272, 58);
            btnSupprimerProduit.TabIndex = 19;
            btnSupprimerProduit.Text = "Supprimer le Produit";
            btnSupprimerProduit.UseVisualStyleBackColor = true;
            btnSupprimerProduit.Click += btnSupprimerProduit_Click;
            // 
            // edtQuantiteProduit
            // 
            edtQuantiteProduit.Location = new Point(204, 221);
            edtQuantiteProduit.Name = "edtQuantiteProduit";
            edtQuantiteProduit.Size = new Size(154, 32);
            edtQuantiteProduit.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 224);
            label8.Name = "label8";
            label8.Size = new Size(168, 25);
            label8.TabIndex = 17;
            label8.Text = "Quantité en stock :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 75);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 15;
            label6.Text = "Description :";
            // 
            // btnAjouterProduit
            // 
            btnAjouterProduit.Location = new Point(30, 317);
            btnAjouterProduit.Name = "btnAjouterProduit";
            btnAjouterProduit.Size = new Size(476, 72);
            btnAjouterProduit.TabIndex = 14;
            btnAjouterProduit.Text = "Ajouter le produit";
            btnAjouterProduit.UseVisualStyleBackColor = true;
            btnAjouterProduit.Click += btnAjouterProduit_Click;
            // 
            // edtPrixProduit
            // 
            edtPrixProduit.Location = new Point(86, 180);
            edtPrixProduit.Name = "edtPrixProduit";
            edtPrixProduit.Size = new Size(112, 32);
            edtPrixProduit.TabIndex = 13;
            // 
            // edtNomProduit
            // 
            edtNomProduit.Location = new Point(98, 28);
            edtNomProduit.Name = "edtNomProduit";
            edtNomProduit.Size = new Size(408, 32);
            edtNomProduit.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 183);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 10;
            label7.Text = "Prix :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 31);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 8;
            label5.Text = "Nom :";
            // 
            // listeProduits
            // 
            listeProduits.Columns.AddRange(new ColumnHeader[] { colonneId, colonneNom, colonneQuantite, colonnePrix });
            listeProduits.Location = new Point(677, 41);
            listeProduits.Name = "listeProduits";
            listeProduits.Size = new Size(559, 605);
            listeProduits.TabIndex = 7;
            listeProduits.UseCompatibleStateImageBehavior = false;
            listeProduits.View = View.Details;
            // 
            // colonneId
            // 
            colonneId.Text = "ID";
            // 
            // colonneNom
            // 
            colonneNom.Text = "Nom";
            colonneNom.Width = 260;
            // 
            // colonneQuantite
            // 
            colonneQuantite.Text = "Quantitée";
            colonneQuantite.Width = 130;
            // 
            // colonnePrix
            // 
            colonnePrix.Text = "Prix";
            colonnePrix.Width = 100;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(776, 13);
            label4.Name = "label4";
            label4.Size = new Size(363, 25);
            label4.TabIndex = 6;
            label4.Text = "Liste des produits dans la base de donnée";
            // 
            // btnImprimerCodeBarre
            // 
            btnImprimerCodeBarre.Location = new Point(33, 589);
            btnImprimerCodeBarre.Name = "btnImprimerCodeBarre";
            btnImprimerCodeBarre.Size = new Size(473, 57);
            btnImprimerCodeBarre.TabIndex = 5;
            btnImprimerCodeBarre.Text = "Imprimer le code barre";
            btnImprimerCodeBarre.UseVisualStyleBackColor = true;
            btnImprimerCodeBarre.Visible = false;
            btnImprimerCodeBarre.Click += btnImprimerCodeBarre_Click;
            // 
            // imageCodeBarre
            // 
            imageCodeBarre.Location = new Point(33, 449);
            imageCodeBarre.Name = "imageCodeBarre";
            imageCodeBarre.Size = new Size(473, 134);
            imageCodeBarre.TabIndex = 4;
            imageCodeBarre.TabStop = false;
            imageCodeBarre.Visible = false;
            // 
            // lblCodeBarreProduitAjoute
            // 
            lblCodeBarreProduitAjoute.AutoSize = true;
            lblCodeBarreProduitAjoute.Location = new Point(33, 409);
            lblCodeBarreProduitAjoute.Name = "lblCodeBarreProduitAjoute";
            lblCodeBarreProduitAjoute.Size = new Size(432, 25);
            lblCodeBarreProduitAjoute.TabIndex = 3;
            lblCodeBarreProduitAjoute.Text = "Voici le code barre généré pour le produit ajouté :";
            lblCodeBarreProduitAjoute.Visible = false;
            // 
            // panelGestion
            // 
            panelGestion.Controls.Add(tabControl1);
            panelGestion.Location = new Point(0, 0);
            panelGestion.Name = "panelGestion";
            panelGestion.Size = new Size(1249, 750);
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
            panelConnexion.Size = new Size(1252, 753);
            panelConnexion.TabIndex = 3;
            // 
            // btnConnexion
            // 
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnConnexion.Location = new Point(458, 471);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(306, 87);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(538, 333);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 4;
            label3.Text = "Mot de passe";
            // 
            // lblUsager
            // 
            lblUsager.AutoSize = true;
            lblUsager.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsager.Location = new Point(538, 220);
            lblUsager.Name = "lblUsager";
            lblUsager.Size = new Size(139, 25);
            lblUsager.TabIndex = 3;
            lblUsager.Text = "Nom d'usager";
            // 
            // edtMotDePasse
            // 
            edtMotDePasse.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            edtMotDePasse.Location = new Point(458, 372);
            edtMotDePasse.Name = "edtMotDePasse";
            edtMotDePasse.Size = new Size(306, 32);
            edtMotDePasse.TabIndex = 2;
            edtMotDePasse.Text = "Patate123";
            edtMotDePasse.UseSystemPasswordChar = true;
            // 
            // edtUsager
            // 
            edtUsager.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            edtUsager.Location = new Point(458, 259);
            edtUsager.Name = "edtUsager";
            edtUsager.Size = new Size(306, 32);
            edtUsager.TabIndex = 1;
            edtUsager.Text = "alain";
            // 
            // lblTitreConnexion
            // 
            lblTitreConnexion.AutoSize = true;
            lblTitreConnexion.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitreConnexion.Location = new Point(320, 69);
            lblTitreConnexion.Name = "lblTitreConnexion";
            lblTitreConnexion.Size = new Size(604, 65);
            lblTitreConnexion.TabIndex = 0;
            lblTitreConnexion.Text = "Connexion a l'application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 755);
            Controls.Add(panelGestion);
            Controls.Add(panelConnexion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox edtItemScanne;
        private ListBox listeItemsScannes;
        private PictureBox imageCodeBarre;
        private Label lblCodeBarreProduitAjoute;
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
        private Label label6;
        private TextBox edtQuantiteProduit;
        private Label label8;
        private ColumnHeader colonneQuantite;
        private Button btnSupprimerProduit;
        private Button btnInformationProduit;
        private ListBox listeIDScannesCache;
        private RichTextBox edtDescriptionProduit;
        private Button btnViderChampsProduit;
        private ComboBox listPorts;
    }
}