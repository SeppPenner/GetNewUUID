using System;
using System.Windows.Forms;
using Languages.Implementation;
using Languages.Interfaces;

namespace GetNewUUID
{
    public partial class Main : Form
    {
        private readonly ILanguageManager _lm = new LanguageManager();
        private ILanguage _lang;

        public Main()
        {
            InitializeComponent();
            LoadTitleAndDescription();
            InitializeLanguageManager();
            LoadLanguagesToCombo();
        }

        private void InitializeLanguageManager()
        {
            _lm.SetCurrentLanguage("de-DE");
            _lm.OnLanguageChanged += OnLanguageChanged;
        }

        private void LoadLanguagesToCombo()
        {
            foreach (var lang in _lm.GetLanguages())
                comboBoxLanguage.Items.Add(lang.Name);
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lm.SetCurrentLanguageFromName(comboBoxLanguage.SelectedItem.ToString());
        }

        private void OnLanguageChanged(object sender, EventArgs eventArgs)
        {
            _lang = _lm.GetCurrentLanguage();
            buttonNewUUID.Text = _lang.GetWord("CreateNewUUID");
        }

        private void LoadTitleAndDescription()
        {
            Text = Application.ProductName + @" " + Application.ProductVersion;
        }

        private void buttonNewUUID_Click(object sender, EventArgs e)
        {
            textBoxUUID.Text = Guid.NewGuid().ToString();
        }
    }
}