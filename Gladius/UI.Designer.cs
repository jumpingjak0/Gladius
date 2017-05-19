namespace Gladius
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbTownDescription = new System.Windows.Forms.RichTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnGladShop = new System.Windows.Forms.Button();
            this.btnMyGlad = new System.Windows.Forms.Button();
            this.btnArena = new System.Windows.Forms.Button();
            this.btnTravel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelTravel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProctoria = new System.Windows.Forms.Button();
            this.btnCthakMij = new System.Windows.Forms.Button();
            this.btnEllaneraan = new System.Windows.Forms.Button();
            this.btnAttelair = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTravel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTownDescription
            // 
            this.rtbTownDescription.Location = new System.Drawing.Point(12, 12);
            this.rtbTownDescription.Name = "rtbTownDescription";
            this.rtbTownDescription.ReadOnly = true;
            this.rtbTownDescription.Size = new System.Drawing.Size(549, 213);
            this.rtbTownDescription.TabIndex = 0;
            this.rtbTownDescription.Text = "";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Controls.Add(this.btnTravel);
            this.panelMenu.Controls.Add(this.btnArena);
            this.panelMenu.Controls.Add(this.btnMyGlad);
            this.panelMenu.Controls.Add(this.btnGladShop);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Location = new System.Drawing.Point(12, 275);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(116, 178);
            this.panelMenu.TabIndex = 1;
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(3, 3);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(109, 23);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            // 
            // btnGladShop
            // 
            this.btnGladShop.Location = new System.Drawing.Point(3, 32);
            this.btnGladShop.Name = "btnGladShop";
            this.btnGladShop.Size = new System.Drawing.Size(109, 23);
            this.btnGladShop.TabIndex = 1;
            this.btnGladShop.Text = "Gladiator School";
            this.btnGladShop.UseVisualStyleBackColor = true;
            // 
            // btnMyGlad
            // 
            this.btnMyGlad.Location = new System.Drawing.Point(3, 61);
            this.btnMyGlad.Name = "btnMyGlad";
            this.btnMyGlad.Size = new System.Drawing.Size(109, 23);
            this.btnMyGlad.TabIndex = 2;
            this.btnMyGlad.Text = "My Gladiators";
            this.btnMyGlad.UseVisualStyleBackColor = true;
            // 
            // btnArena
            // 
            this.btnArena.Location = new System.Drawing.Point(3, 90);
            this.btnArena.Name = "btnArena";
            this.btnArena.Size = new System.Drawing.Size(109, 23);
            this.btnArena.TabIndex = 3;
            this.btnArena.Text = "Arena";
            this.btnArena.UseVisualStyleBackColor = true;
            // 
            // btnTravel
            // 
            this.btnTravel.Location = new System.Drawing.Point(3, 119);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(109, 23);
            this.btnTravel.TabIndex = 4;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 148);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panelTravel
            // 
            this.panelTravel.Controls.Add(this.btnAttelair);
            this.panelTravel.Controls.Add(this.btnEllaneraan);
            this.panelTravel.Controls.Add(this.btnCthakMij);
            this.panelTravel.Controls.Add(this.btnProctoria);
            this.panelTravel.Controls.Add(this.label1);
            this.panelTravel.Location = new System.Drawing.Point(150, 230);
            this.panelTravel.Name = "panelTravel";
            this.panelTravel.Size = new System.Drawing.Size(300, 200);
            this.panelTravel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a City:";
            // 
            // btnProctoria
            // 
            this.btnProctoria.Location = new System.Drawing.Point(26, 36);
            this.btnProctoria.Name = "btnProctoria";
            this.btnProctoria.Size = new System.Drawing.Size(75, 23);
            this.btnProctoria.TabIndex = 1;
            this.btnProctoria.Text = "Proctoria";
            this.btnProctoria.UseVisualStyleBackColor = true;
            this.btnProctoria.Click += new System.EventHandler(this.btnProctoria_Click);
            // 
            // btnCthakMij
            // 
            this.btnCthakMij.Location = new System.Drawing.Point(195, 36);
            this.btnCthakMij.Name = "btnCthakMij";
            this.btnCthakMij.Size = new System.Drawing.Size(75, 23);
            this.btnCthakMij.TabIndex = 2;
            this.btnCthakMij.Text = "Cthak Mij";
            this.btnCthakMij.UseVisualStyleBackColor = true;
            this.btnCthakMij.Click += new System.EventHandler(this.btnCthakMij_Click);
            // 
            // btnEllaneraan
            // 
            this.btnEllaneraan.Location = new System.Drawing.Point(26, 145);
            this.btnEllaneraan.Name = "btnEllaneraan";
            this.btnEllaneraan.Size = new System.Drawing.Size(75, 23);
            this.btnEllaneraan.TabIndex = 3;
            this.btnEllaneraan.Text = "Ellaneraan";
            this.btnEllaneraan.UseVisualStyleBackColor = true;
            this.btnEllaneraan.Click += new System.EventHandler(this.btnEllaneraan_Click);
            // 
            // btnAttelair
            // 
            this.btnAttelair.Location = new System.Drawing.Point(195, 145);
            this.btnAttelair.Name = "btnAttelair";
            this.btnAttelair.Size = new System.Drawing.Size(75, 23);
            this.btnAttelair.TabIndex = 4;
            this.btnAttelair.Text = "Attelair";
            this.btnAttelair.UseVisualStyleBackColor = true;
            this.btnAttelair.Click += new System.EventHandler(this.btnAttelair_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.panelTravel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.rtbTownDescription);
            this.Name = "UI";
            this.Text = "Gladius";
            this.panelMenu.ResumeLayout(false);
            this.panelTravel.ResumeLayout(false);
            this.panelTravel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTownDescription;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Button btnArena;
        private System.Windows.Forms.Button btnMyGlad;
        private System.Windows.Forms.Button btnGladShop;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel panelTravel;
        private System.Windows.Forms.Button btnAttelair;
        private System.Windows.Forms.Button btnEllaneraan;
        private System.Windows.Forms.Button btnCthakMij;
        private System.Windows.Forms.Button btnProctoria;
        private System.Windows.Forms.Label label1;
    }
}