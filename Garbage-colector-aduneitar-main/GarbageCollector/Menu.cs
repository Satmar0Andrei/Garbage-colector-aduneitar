using System;
using System.Windows.Forms;

namespace GarbageCollector
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            FormGame form = new FormGame();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            Tutorial form = new Tutorial();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
