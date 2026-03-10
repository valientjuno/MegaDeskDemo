namespace MegaDeskDemo
{
    partial class DisplayQuote
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCustomerName;
        private Label lblQuoteDate;
        private Label lblWidth;
        private Label lblDepth;
        private Label lblDrawers;
        private Label lblTotalSize;
        private Label lblMaterial;
        private Label lblDelivery;
        private Label lblTotalPrice;
        private Button BtnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCustomerName = new Label();
            this.lblQuoteDate = new Label();
            this.lblWidth = new Label();
            this.lblDepth = new Label();
            this.lblDrawers = new Label();
            this.lblTotalSize = new Label();
            this.lblMaterial = new Label();
            this.lblDelivery = new Label();
            this.lblTotalPrice = new Label();
            this.BtnBack = new Button();
            this.SuspendLayout();
            // 
            // Labels positioning
            int startY = 20;
            int gap = 30;
            lblCustomerName.Location = new System.Drawing.Point(20, startY);
            lblCustomerName.Size = new System.Drawing.Size(300, 20);
            lblQuoteDate.Location = new System.Drawing.Point(20, startY + gap);
            lblQuoteDate.Size = new System.Drawing.Size(300, 20);
            lblWidth.Location = new System.Drawing.Point(20, startY + gap * 2);
            lblWidth.Size = new System.Drawing.Size(300, 20);
            lblDepth.Location = new System.Drawing.Point(20, startY + gap * 3);
            lblDepth.Size = new System.Drawing.Size(300, 20);
            lblDrawers.Location = new System.Drawing.Point(20, startY + gap * 4);
            lblDrawers.Size = new System.Drawing.Size(300, 20);
            lblTotalSize.Location = new System.Drawing.Point(20, startY + gap * 5);
            lblTotalSize.Size = new System.Drawing.Size(300, 20);
            lblMaterial.Location = new System.Drawing.Point(20, startY + gap * 6);
            lblMaterial.Size = new System.Drawing.Size(300, 20);
            lblDelivery.Location = new System.Drawing.Point(20, startY + gap * 7);
            lblDelivery.Size = new System.Drawing.Size(300, 20);
            lblTotalPrice.Location = new System.Drawing.Point(20, startY + gap * 8);
            lblTotalPrice.Size = new System.Drawing.Size(300, 20);
            // 
            // BtnBack
            BtnBack.Location = new System.Drawing.Point(100, startY + gap * 9);
            BtnBack.Size = new System.Drawing.Size(100, 30);
            BtnBack.Text = "Back";
            BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DisplayQuote Form
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(lblCustomerName);
            this.Controls.Add(lblQuoteDate);
            this.Controls.Add(lblWidth);
            this.Controls.Add(lblDepth);
            this.Controls.Add(lblDrawers);
            this.Controls.Add(lblTotalSize);
            this.Controls.Add(lblMaterial);
            this.Controls.Add(lblDelivery);
            this.Controls.Add(lblTotalPrice);
            this.Controls.Add(BtnBack);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);
        }
    }
}