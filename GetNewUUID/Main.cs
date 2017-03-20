using System;
using System.Windows.Forms;

namespace GetNewUUID
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadTitleAndDescription();
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