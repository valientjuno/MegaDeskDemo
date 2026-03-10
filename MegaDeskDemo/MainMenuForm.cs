using MegaDeskDemo;
using System;
using System.Windows.Forms;

namespace DeskQuoteApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuote searchForm = new SearchQuote();
            searchForm.Show();
            this.Hide();
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new ViewQuotes(this);
            viewQuotes.Show();
            Hide();
        }

        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            // Reuse existing logic
            BtnViewQuotes_Click(sender, e);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}