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
            this.rtbUI = new System.Windows.Forms.RichTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMyTrophies = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.btnTravel = new System.Windows.Forms.Button();
            this.btnArena = new System.Windows.Forms.Button();
            this.btnMyGlad = new System.Windows.Forms.Button();
            this.btnGladShop = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.panelTravel = new System.Windows.Forms.Panel();
            this.btnAttelair = new System.Windows.Forms.Button();
            this.btnEllaneraan = new System.Windows.Forms.Button();
            this.btnCthakMij = new System.Windows.Forms.Button();
            this.btnProctoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelList = new System.Windows.Forms.Panel();
            this.labelGold = new System.Windows.Forms.Label();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.btnViewGladiator = new System.Windows.Forms.Button();
            this.dgvUI = new System.Windows.Forms.DataGridView();
            this.cbTournament = new System.Windows.Forms.ComboBox();
            this.panelTournamentSelector = new System.Windows.Forms.Panel();
            this.btnEnterTournament = new System.Windows.Forms.Button();
            this.panelLoadSave = new System.Windows.Forms.Panel();
            this.lblSaveLoadMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbSave3 = new System.Windows.Forms.RadioButton();
            this.rbSave2 = new System.Windows.Forms.RadioButton();
            this.rbSave1 = new System.Windows.Forms.RadioButton();
            this.lblSave3 = new System.Windows.Forms.Label();
            this.lblSave2 = new System.Windows.Forms.Label();
            this.lblSave1 = new System.Windows.Forms.Label();
            this.textBoxSaveName = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTravel.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUI)).BeginInit();
            this.panelTournamentSelector.SuspendLayout();
            this.panelLoadSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbUI
            // 
            this.rtbUI.Location = new System.Drawing.Point(12, 12);
            this.rtbUI.Name = "rtbUI";
            this.rtbUI.ReadOnly = true;
            this.rtbUI.Size = new System.Drawing.Size(549, 213);
            this.rtbUI.TabIndex = 0;
            this.rtbUI.Text = "";
            this.rtbUI.TextChanged += new System.EventHandler(this.rtbUI_TextChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnMyTrophies);
            this.panelMenu.Controls.Add(this.buttonInventory);
            this.panelMenu.Controls.Add(this.btnSaveLoad);
            this.panelMenu.Controls.Add(this.btnTravel);
            this.panelMenu.Controls.Add(this.btnArena);
            this.panelMenu.Controls.Add(this.btnMyGlad);
            this.panelMenu.Controls.Add(this.btnGladShop);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Location = new System.Drawing.Point(12, 229);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(116, 232);
            this.panelMenu.TabIndex = 1;
            // 
            // btnMyTrophies
            // 
            this.btnMyTrophies.Location = new System.Drawing.Point(3, 206);
            this.btnMyTrophies.Name = "btnMyTrophies";
            this.btnMyTrophies.Size = new System.Drawing.Size(109, 23);
            this.btnMyTrophies.TabIndex = 6;
            this.btnMyTrophies.Text = "Trophies";
            this.btnMyTrophies.UseVisualStyleBackColor = true;
            this.btnMyTrophies.Click += new System.EventHandler(this.btnMyTrophies_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Location = new System.Drawing.Point(3, 177);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(109, 23);
            this.buttonInventory.TabIndex = 6;
            this.buttonInventory.Text = "Inventory";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.Location = new System.Drawing.Point(3, 148);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Size = new System.Drawing.Size(109, 23);
            this.btnSaveLoad.TabIndex = 5;
            this.btnSaveLoad.Text = "Save/Load Game";
            this.btnSaveLoad.UseVisualStyleBackColor = true;
            this.btnSaveLoad.Click += new System.EventHandler(this.btnSave_Click);
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
            // btnArena
            // 
            this.btnArena.Location = new System.Drawing.Point(3, 90);
            this.btnArena.Name = "btnArena";
            this.btnArena.Size = new System.Drawing.Size(109, 23);
            this.btnArena.TabIndex = 3;
            this.btnArena.Text = "Arena";
            this.btnArena.UseVisualStyleBackColor = true;
            this.btnArena.Click += new System.EventHandler(this.btnArena_Click);
            // 
            // btnMyGlad
            // 
            this.btnMyGlad.Location = new System.Drawing.Point(3, 61);
            this.btnMyGlad.Name = "btnMyGlad";
            this.btnMyGlad.Size = new System.Drawing.Size(109, 23);
            this.btnMyGlad.TabIndex = 2;
            this.btnMyGlad.Text = "My Gladiators";
            this.btnMyGlad.UseVisualStyleBackColor = true;
            this.btnMyGlad.Click += new System.EventHandler(this.btnMyGlad_Click);
            // 
            // btnGladShop
            // 
            this.btnGladShop.Location = new System.Drawing.Point(3, 32);
            this.btnGladShop.Name = "btnGladShop";
            this.btnGladShop.Size = new System.Drawing.Size(109, 23);
            this.btnGladShop.TabIndex = 1;
            this.btnGladShop.Text = "Gladiator School";
            this.btnGladShop.UseVisualStyleBackColor = true;
            this.btnGladShop.Click += new System.EventHandler(this.btnGladShop_Click);
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(3, 3);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(109, 23);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // panelTravel
            // 
            this.panelTravel.Controls.Add(this.btnAttelair);
            this.panelTravel.Controls.Add(this.btnEllaneraan);
            this.panelTravel.Controls.Add(this.btnCthakMij);
            this.panelTravel.Controls.Add(this.btnProctoria);
            this.panelTravel.Controls.Add(this.label1);
            this.panelTravel.Location = new System.Drawing.Point(150, 242);
            this.panelTravel.Name = "panelTravel";
            this.panelTravel.Size = new System.Drawing.Size(300, 200);
            this.panelTravel.TabIndex = 2;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a City:";
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.labelGold);
            this.panelList.Controls.Add(this.buttonPurchase);
            this.panelList.Controls.Add(this.btnViewGladiator);
            this.panelList.Controls.Add(this.dgvUI);
            this.panelList.Location = new System.Drawing.Point(134, 233);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(410, 220);
            this.panelList.TabIndex = 3;
            this.panelList.Visible = false;
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(325, 71);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(33, 13);
            this.labelGold.TabIndex = 3;
            this.labelGold.Text = "(gold)";
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(298, 107);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(91, 23);
            this.buttonPurchase.TabIndex = 2;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPuchase_Click);
            // 
            // btnViewGladiator
            // 
            this.btnViewGladiator.Location = new System.Drawing.Point(298, 32);
            this.btnViewGladiator.Name = "btnViewGladiator";
            this.btnViewGladiator.Size = new System.Drawing.Size(91, 23);
            this.btnViewGladiator.TabIndex = 1;
            this.btnViewGladiator.Text = "View Gladiator";
            this.btnViewGladiator.UseVisualStyleBackColor = true;
            this.btnViewGladiator.Click += new System.EventHandler(this.btnViewGladiator_click);
            // 
            // dgvUI
            // 
            this.dgvUI.AllowUserToAddRows = false;
            this.dgvUI.AllowUserToDeleteRows = false;
            this.dgvUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUI.Location = new System.Drawing.Point(3, 4);
            this.dgvUI.Name = "dgvUI";
            this.dgvUI.ReadOnly = true;
            this.dgvUI.Size = new System.Drawing.Size(100, 200);
            this.dgvUI.TabIndex = 0;
            // 
            // cbTournament
            // 
            this.cbTournament.FormattingEnabled = true;
            this.cbTournament.Location = new System.Drawing.Point(2, 6);
            this.cbTournament.Name = "cbTournament";
            this.cbTournament.Size = new System.Drawing.Size(121, 21);
            this.cbTournament.TabIndex = 4;
            this.cbTournament.SelectedIndexChanged += new System.EventHandler(this.cbTournament_SelectedIndexChanged);
            // 
            // panelTournamentSelector
            // 
            this.panelTournamentSelector.Controls.Add(this.btnEnterTournament);
            this.panelTournamentSelector.Controls.Add(this.cbTournament);
            this.panelTournamentSelector.Location = new System.Drawing.Point(456, 242);
            this.panelTournamentSelector.Name = "panelTournamentSelector";
            this.panelTournamentSelector.Size = new System.Drawing.Size(126, 161);
            this.panelTournamentSelector.TabIndex = 5;
            this.panelTournamentSelector.Visible = false;
            // 
            // btnEnterTournament
            // 
            this.btnEnterTournament.Location = new System.Drawing.Point(14, 50);
            this.btnEnterTournament.Name = "btnEnterTournament";
            this.btnEnterTournament.Size = new System.Drawing.Size(102, 23);
            this.btnEnterTournament.TabIndex = 5;
            this.btnEnterTournament.Text = "Enter Tournament";
            this.btnEnterTournament.UseVisualStyleBackColor = true;
            this.btnEnterTournament.Click += new System.EventHandler(this.btnEnterTournament_Click);
            // 
            // panelLoadSave
            // 
            this.panelLoadSave.Controls.Add(this.lblSaveLoadMessage);
            this.panelLoadSave.Controls.Add(this.label5);
            this.panelLoadSave.Controls.Add(this.rbSave3);
            this.panelLoadSave.Controls.Add(this.rbSave2);
            this.panelLoadSave.Controls.Add(this.rbSave1);
            this.panelLoadSave.Controls.Add(this.lblSave3);
            this.panelLoadSave.Controls.Add(this.lblSave2);
            this.panelLoadSave.Controls.Add(this.lblSave1);
            this.panelLoadSave.Controls.Add(this.textBoxSaveName);
            this.panelLoadSave.Controls.Add(this.btnLoad);
            this.panelLoadSave.Controls.Add(this.btnSave);
            this.panelLoadSave.Location = new System.Drawing.Point(150, 229);
            this.panelLoadSave.Name = "panelLoadSave";
            this.panelLoadSave.Size = new System.Drawing.Size(333, 221);
            this.panelLoadSave.TabIndex = 4;
            this.panelLoadSave.Visible = false;
            // 
            // lblSaveLoadMessage
            // 
            this.lblSaveLoadMessage.AutoSize = true;
            this.lblSaveLoadMessage.Location = new System.Drawing.Point(192, 113);
            this.lblSaveLoadMessage.Name = "lblSaveLoadMessage";
            this.lblSaveLoadMessage.Size = new System.Drawing.Size(99, 13);
            this.lblSaveLoadMessage.TabIndex = 14;
            this.lblSaveLoadMessage.Text = "SaveLoadMessage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // rbSave3
            // 
            this.rbSave3.AutoSize = true;
            this.rbSave3.Location = new System.Drawing.Point(108, 148);
            this.rbSave3.Name = "rbSave3";
            this.rbSave3.Size = new System.Drawing.Size(14, 13);
            this.rbSave3.TabIndex = 12;
            this.rbSave3.TabStop = true;
            this.rbSave3.UseVisualStyleBackColor = true;
            this.rbSave3.Click += new System.EventHandler(this.rbSave3_Click);
            // 
            // rbSave2
            // 
            this.rbSave2.AutoSize = true;
            this.rbSave2.Location = new System.Drawing.Point(108, 99);
            this.rbSave2.Name = "rbSave2";
            this.rbSave2.Size = new System.Drawing.Size(14, 13);
            this.rbSave2.TabIndex = 11;
            this.rbSave2.TabStop = true;
            this.rbSave2.UseVisualStyleBackColor = true;
            this.rbSave2.Click += new System.EventHandler(this.rbSave2_Click);
            // 
            // rbSave1
            // 
            this.rbSave1.AutoSize = true;
            this.rbSave1.Location = new System.Drawing.Point(108, 49);
            this.rbSave1.Name = "rbSave1";
            this.rbSave1.Size = new System.Drawing.Size(14, 13);
            this.rbSave1.TabIndex = 10;
            this.rbSave1.TabStop = true;
            this.rbSave1.UseVisualStyleBackColor = true;
            this.rbSave1.Click += new System.EventHandler(this.rbSave1_Click);
            // 
            // lblSave3
            // 
            this.lblSave3.AutoSize = true;
            this.lblSave3.Location = new System.Drawing.Point(52, 149);
            this.lblSave3.Name = "lblSave3";
            this.lblSave3.Size = new System.Drawing.Size(36, 13);
            this.lblSave3.TabIndex = 9;
            this.lblSave3.Text = "save3";
            // 
            // lblSave2
            // 
            this.lblSave2.AutoSize = true;
            this.lblSave2.Location = new System.Drawing.Point(52, 99);
            this.lblSave2.Name = "lblSave2";
            this.lblSave2.Size = new System.Drawing.Size(36, 13);
            this.lblSave2.TabIndex = 8;
            this.lblSave2.Text = "save2";
            // 
            // lblSave1
            // 
            this.lblSave1.AutoSize = true;
            this.lblSave1.Location = new System.Drawing.Point(52, 49);
            this.lblSave1.Name = "lblSave1";
            this.lblSave1.Size = new System.Drawing.Size(36, 13);
            this.lblSave1.TabIndex = 7;
            this.lblSave1.Text = "save1";
            // 
            // textBoxSaveName
            // 
            this.textBoxSaveName.Location = new System.Drawing.Point(199, 90);
            this.textBoxSaveName.Name = "textBoxSaveName";
            this.textBoxSaveName.Size = new System.Drawing.Size(105, 20);
            this.textBoxSaveName.TabIndex = 6;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(212, 149);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(212, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.panelLoadSave);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.rtbUI);
            this.Controls.Add(this.panelTravel);
            this.Controls.Add(this.panelTournamentSelector);
            this.Name = "UI";
            this.Text = "Gladius";
            this.panelMenu.ResumeLayout(false);
            this.panelTravel.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUI)).EndInit();
            this.panelTournamentSelector.ResumeLayout(false);
            this.panelLoadSave.ResumeLayout(false);
            this.panelLoadSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUI;
        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSaveLoad;
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
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dgvUI;
        private System.Windows.Forms.Button btnViewGladiator;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.ComboBox cbTournament;
        private System.Windows.Forms.Panel panelTournamentSelector;
        private System.Windows.Forms.Button btnEnterTournament;
        private System.Windows.Forms.Button btnMyTrophies;
        private System.Windows.Forms.Panel panelLoadSave;
        private System.Windows.Forms.Label lblSave3;
        private System.Windows.Forms.Label lblSave2;
        private System.Windows.Forms.Label lblSave1;
        private System.Windows.Forms.TextBox textBoxSaveName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbSave3;
        private System.Windows.Forms.RadioButton rbSave2;
        private System.Windows.Forms.RadioButton rbSave1;
        private System.Windows.Forms.Label lblSaveLoadMessage;
    }
}