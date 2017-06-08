namespace Gladius
{
    partial class EquipItemScreen
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
            this.cbItemToEquip = new System.Windows.Forms.ComboBox();
            this.btnEquipItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbItemToEquip
            // 
            this.cbItemToEquip.FormattingEnabled = true;
            this.cbItemToEquip.Location = new System.Drawing.Point(12, 70);
            this.cbItemToEquip.Name = "cbItemToEquip";
            this.cbItemToEquip.Size = new System.Drawing.Size(119, 21);
            this.cbItemToEquip.TabIndex = 0;
            // 
            // btnEquipItem
            // 
            this.btnEquipItem.Location = new System.Drawing.Point(137, 70);
            this.btnEquipItem.Name = "btnEquipItem";
            this.btnEquipItem.Size = new System.Drawing.Size(135, 23);
            this.btnEquipItem.TabIndex = 1;
            this.btnEquipItem.Text = "Equip";
            this.btnEquipItem.UseVisualStyleBackColor = true;
            this.btnEquipItem.Click += new System.EventHandler(this.btnEquipItem_Click);
            // 
            // EquipItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.btnEquipItem);
            this.Controls.Add(this.cbItemToEquip);
            this.Name = "EquipItemScreen";
            this.Text = "Equip Item";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItemToEquip;
        private System.Windows.Forms.Button btnEquipItem;
    }
}