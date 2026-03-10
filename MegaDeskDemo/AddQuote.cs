using DeskQuoteApp;
using System;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class AddQuote : Form
    {
        private MainMenuForm mainMenu;

        public AddQuote(MainMenuForm menu)
        {
            mainMenu = menu;
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk
            {
                Width = int.Parse(txtWidth.Text),
                Depth = int.Parse(txtDepth.Text),
                Drawers = int.Parse(txtDrawers.Text),
                MaterialType = cmbMaterial.Text,
                DeliveryDays = int.Parse(cmbDelivery.Text)
            };

            DeskQuote quote = new DeskQuote
            {
                CustomerName = txtCustomerName.Text,
                OrderDate = DateTime.Now,
                Desk = desk
            };

            // Correctly open DisplayQuote
            DisplayQuote display = new DisplayQuote(mainMenu, quote);
            display.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}