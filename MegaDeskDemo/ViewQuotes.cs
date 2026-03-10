using DeskQuoteApp;
using System;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class ViewQuotes : Form
    {
        private MainMenuForm mainMenu;

        public ViewQuotes(MainMenuForm menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }

        private void GoBack(object sender, EventArgs e)
        {
            mainMenu.Show();
            Close();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}