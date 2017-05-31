namespace Gladius
{
    partial class BattlefieldForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbBattle = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEndBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 272);
            this.panel1.TabIndex = 1;
            // 
            // rtbBattle
            // 
            this.rtbBattle.Location = new System.Drawing.Point(12, 74);
            this.rtbBattle.Name = "rtbBattle";
            this.rtbBattle.Size = new System.Drawing.Size(556, 142);
            this.rtbBattle.TabIndex = 2;
            this.rtbBattle.Text = "";
            this.rtbBattle.TextChanged += new System.EventHandler(this.rtbBattle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(556, 47);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Proctoria Arena";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEndBattle
            // 
            this.btnEndBattle.Location = new System.Drawing.Point(228, 222);
            this.btnEndBattle.Name = "btnEndBattle";
            this.btnEndBattle.Size = new System.Drawing.Size(75, 23);
            this.btnEndBattle.TabIndex = 4;
            this.btnEndBattle.Text = "Close ";
            this.btnEndBattle.UseVisualStyleBackColor = true;
            this.btnEndBattle.Click += new System.EventHandler(this.btnEndBattle_Click);
            // 
            // BattlefieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.btnEndBattle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbBattle);
            this.Controls.Add(this.panel1);
            this.Name = "BattlefieldForm";
            this.Text = "Battlefield";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BattlefieldForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbBattle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEndBattle;
    }
}