namespace GetNewUUID
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonNewUUID = new System.Windows.Forms.Button();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonNewUUID
            // 
            this.buttonNewUUID.Location = new System.Drawing.Point(12, 39);
            this.buttonNewUUID.Name = "buttonNewUUID";
            this.buttonNewUUID.Size = new System.Drawing.Size(300, 23);
            this.buttonNewUUID.TabIndex = 0;
            this.buttonNewUUID.Text = "Create new UUID";
            this.buttonNewUUID.UseVisualStyleBackColor = true;
            this.buttonNewUUID.Click += new System.EventHandler(this.NewUuidClick);
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.Location = new System.Drawing.Point(12, 68);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.ReadOnly = true;
            this.textBoxUUID.Size = new System.Drawing.Size(300, 20);
            this.textBoxUUID.TabIndex = 1;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(300, 21);
            this.comboBoxLanguage.TabIndex = 2;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguageSelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 100);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.textBoxUUID);
            this.Controls.Add(this.buttonNewUUID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "GetNewUUID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewUUID;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}

