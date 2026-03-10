using DeskQuoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class DisplayQuote : Form
    {
        private MainMenuForm mainMenu;
        private DeskQuote deskQuote;

        public DisplayQuote(MainMenuForm menu, DeskQuote quote)
        {
            mainMenu = menu;
            deskQuote = quote;
            InitializeComponent();
            RenderQuote();
        }

        private void RenderQuote()
        {
            lblCustomerName.Text = deskQuote.CustomerName;
            lblQuoteDate.Text = deskQuote.OrderDate.ToShortDateString();
            lblWidth.Text = deskQuote.Desk.Width.ToString();
            lblDepth.Text = deskQuote.Desk.Depth.ToString();
            lblDrawers.Text = deskQuote.Desk.Drawers.ToString();
            lblTotalSize.Text = (deskQuote.Desk.Width * deskQuote.Desk.Depth).ToString();
            lblMaterial.Text = deskQuote.Desk.MaterialType;
            lblDelivery.Text = deskQuote.Desk.DeliveryDays.ToString();
            lblTotalPrice.Text = "$" + deskQuote.Price.ToString("0.00");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            Close();
        }
    }
}