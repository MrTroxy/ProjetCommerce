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
            btnViderListeItems = new Button();
            listeItemsScannes = new ListBox();
            button2 = new Button();
            edtItemSanne = new TextBox();
            btnImprimer = new Button();
            btnAjouter = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            btnImprimerCodeBarre = new Button();
            imageCodeBarre = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            edtTexteCodeBarre = new TextBox();
            btnCreerCodeBarre = new Button();
            button3 = new Button();
            texteFacture = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageCodeBarre).BeginInit();
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
            // btnImprimerCodeBarre
            // 
            btnImprimerCodeBarre.Location = new Point(51, 463);
            btnImprimerCodeBarre.Name = "btnImprimerCodeBarre";
            btnImprimerCodeBarre.Size = new Size(322, 64);
            btnImprimerCodeBarre.TabIndex = 5;
            btnImprimerCodeBarre.Text = "Imprimer le code barre";
            btnImprimerCodeBarre.UseVisualStyleBackColor = true;
            // 
            // imageCodeBarre
            // 
            imageCodeBarre.Location = new Point(51, 323);
            imageCodeBarre.Name = "imageCodeBarre";
            imageCodeBarre.Size = new Size(473, 134);
            imageCodeBarre.TabIndex = 4;
            imageCodeBarre.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 276);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 3;
            label2.Text = "Voici le code barre généré :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 2;
            label1.Text = "Entrez le texte du code barre :";
            // 
            // edtTexteCodeBarre
            // 
            edtTexteCodeBarre.Location = new Point(51, 78);
            edtTexteCodeBarre.Name = "edtTexteCodeBarre";
            edtTexteCodeBarre.Size = new Size(310, 32);
            edtTexteCodeBarre.TabIndex = 1;
            // 
            // btnCreerCodeBarre
            // 
            btnCreerCodeBarre.Location = new Point(51, 141);
            btnCreerCodeBarre.Name = "btnCreerCodeBarre";
            btnCreerCodeBarre.Size = new Size(195, 56);
            btnCreerCodeBarre.TabIndex = 0;
            btnCreerCodeBarre.Text = "Créer le code barre";
            btnCreerCodeBarre.UseVisualStyleBackColor = true;
            btnCreerCodeBarre.Click += btnCreerCodeBarre_Click;
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
            // texteFacture
            // 
            texteFacture.Location = new Point(808, 64);
            texteFacture.Name = "texteFacture";
            texteFacture.Size = new Size(341, 502);
            texteFacture.TabIndex = 9;
            texteFacture.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 612);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Application de Gestion de Commerce";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageCodeBarre).EndInit();
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
    }
}