// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Main.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GetNewUUID
{
    using System;
    using System.Windows.Forms;

    using Languages.Implementation;
    using Languages.Interfaces;

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// The language manager.
        /// </summary>
        private readonly ILanguageManager languageManager = new LanguageManager();

        /// <summary>
        /// The language.
        /// </summary>
        private ILanguage language;

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            this.LoadTitleAndDescription();
            this.InitializeLanguageManager();
            this.LoadLanguagesToCombo();
        }

        /// <summary>
        /// Initializes the language manager.
        /// </summary>
        private void InitializeLanguageManager()
        {
            this.languageManager.SetCurrentLanguage("de-DE");
            this.languageManager.OnLanguageChanged += this.OnLanguageChanged;
        }

        /// <summary>
        /// Loads all languages to the combo box.
        /// </summary>
        private void LoadLanguagesToCombo()
        {
            foreach (var lang in this.languageManager.GetLanguages())
            {
                this.comboBoxLanguage.Items.Add(lang.Name);
            }

            this.comboBoxLanguage.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the selected index changed event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ComboBoxLanguageSelectedIndexChanged(object sender, EventArgs e)
        {
            this.languageManager.SetCurrentLanguageFromName(this.comboBoxLanguage.SelectedItem.ToString());
        }

        /// <summary>
        /// Handles the language changed event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void OnLanguageChanged(object sender, EventArgs e)
        {
            this.language = this.languageManager.GetCurrentLanguage();
            this.buttonNewUUID.Text = this.language.GetWord("CreateNewUUID");
        }

        /// <summary>
        /// Loads the title and description.
        /// </summary>
        private void LoadTitleAndDescription()
        {
            this.Text = Application.ProductName + @" " + Application.ProductVersion;
        }

        /// <summary>
        /// Handles the event to generate a new UUID.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void NewUuidClick(object sender, EventArgs e)
        {
            this.textBoxUUID.Text = Guid.NewGuid().ToString();
        }
    }
}