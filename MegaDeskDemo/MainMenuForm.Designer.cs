namespace DeskQuoteApp
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnAddQuote;
        private Button ExitBtn;
        private Button btnSearchQuote;
        private Button btnViewAllQuotes;
        private PictureBox pictureBoxDesk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            btnAddQuote = new Button();
            ExitBtn = new Button();
            btnSearchQuote = new Button();
            btnViewAllQuotes = new Button();
            pictureBoxDesk = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDesk).BeginInit();
            SuspendLayout();
            // 
            // btnAddQuote
            // 
            btnAddQuote.Location = new Point(20, 51);
            btnAddQuote.Name = "btnAddQuote";
            btnAddQuote.Size = new Size(198, 52);
            btnAddQuote.TabIndex = 0;
            btnAddQuote.Text = "Add Quote";
            btnAddQuote.Click += btnAddQuote_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(20, 225);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(198, 52);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.Click += ExitBtn_Click;
            // 
            // btnSearchQuote
            // 
            btnSearchQuote.Location = new Point(20, 167);
            btnSearchQuote.Name = "btnSearchQuote";
            btnSearchQuote.Size = new Size(198, 52);
            btnSearchQuote.TabIndex = 1;
            btnSearchQuote.Text = "Search Quote";
            btnSearchQuote.Click += btnSearchQuote_Click;
            // 
            // btnViewAllQuotes
            // 
            btnViewAllQuotes.Location = new Point(20, 109);
            btnViewAllQuotes.Name = "btnViewAllQuotes";
            btnViewAllQuotes.Size = new Size(198, 52);
            btnViewAllQuotes.TabIndex = 2;
            btnViewAllQuotes.Text = "View All Quotes";
            btnViewAllQuotes.Click += btnViewAllQuotes_Click;
            // 
            // pictureBoxDesk
            // 
            pictureBoxDesk.Image = (Image)resources.GetObject("pictureBoxDesk.Image");
            pictureBoxDesk.Location = new Point(245, 51);
            pictureBoxDesk.Name = "pictureBoxDesk";
            pictureBoxDesk.Size = new Size(217, 190);
            pictureBoxDesk.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDesk.TabIndex = 4;
            pictureBoxDesk.TabStop = false;
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(500, 320);
            Controls.Add(btnAddQuote);
            Controls.Add(btnSearchQuote);
            Controls.Add(btnViewAllQuotes);
            Controls.Add(ExitBtn);
            Controls.Add(pictureBoxDesk);
            Name = "MainMenuForm";
            Text = "Main Menu";
            Load += MainMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDesk).EndInit();
            ResumeLayout(false);
        }
    }
}