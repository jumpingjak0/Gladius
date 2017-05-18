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
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 530);
            this.Controls.Add(this.rtbTownDescription);
            this.Name = "UI";
            this.Text = "Gladius";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTownDescription;
    }
}