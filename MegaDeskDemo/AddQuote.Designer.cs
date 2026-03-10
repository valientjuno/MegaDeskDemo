namespace MegaDeskDemo
{
    partial class AddQuote
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtCustomerName;
        private TextBox txtWidth;
        private TextBox txtDepth;
        private TextBox txtDrawers;
        private ComboBox cmbDelivery;
        private Button BtnSubmit;
        private Button BtnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            txtWidth = new TextBox();
            txtDepth = new TextBox();
            txtDrawers = new TextBox();
            cmbDelivery = new ComboBox();
            BtnSubmit = new Button();
            BtnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtQuoteDate = new TextBox();
            txtTotalSize = new TextBox();
            label7 = new Label();
            label8 = new Label();
            cmbMaterial = new ComboBox();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(150, 9);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(150, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(150, 75);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(150, 27);
            txtWidth.TabIndex = 1;
            // 
            // txtDepth
            // 
            txtDepth.Location = new Point(150, 108);
            txtDepth.Name = "txtDepth";
            txtDepth.Size = new Size(150, 27);
            txtDepth.TabIndex = 2;
            // 
            // txtDrawers
            // 
            txtDrawers.Location = new Point(150, 141);
            txtDrawers.Name = "txtDrawers";
            txtDrawers.Size = new Size(150, 27);
            txtDrawers.TabIndex = 3;
            // 
            // cmbDelivery
            // 
            cmbDelivery.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDelivery.Items.AddRange(new object[] { "3", "5", "7", "14" });
            cmbDelivery.Location = new Point(150, 241);
            cmbDelivery.Name = "cmbDelivery";
            cmbDelivery.Size = new Size(150, 28);
            cmbDelivery.TabIndex = 5;
            cmbDelivery.SelectedIndexChanged += cmbDelivery_SelectedIndexChanged;
            // 
            // BtnSubmit
            // 
            BtnSubmit.Location = new Point(46, 287);
            BtnSubmit.Name = "BtnSubmit";
            BtnSubmit.Size = new Size(100, 30);
            BtnSubmit.TabIndex = 6;
            BtnSubmit.Text = "Submit";
            BtnSubmit.Click += BtnSubmit_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(152, 287);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(100, 30);
            BtnBack.TabIndex = 7;
            BtnBack.Text = "Back";
            BtnBack.Click += BtnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 8;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 42);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 9;
            label2.Text = "Quote Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 75);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Width:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 108);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Depth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 144);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 12;
            label5.Text = "Drawers:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 178);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 13;
            label6.Text = "Total Sixe in^2";
            // 
            // txtQuoteDate
            // 
            txtQuoteDate.Location = new Point(150, 42);
            txtQuoteDate.Name = "txtQuoteDate";
            txtQuoteDate.Size = new Size(150, 27);
            txtQuoteDate.TabIndex = 14;
            // 
            // txtTotalSize
            // 
            txtTotalSize.Location = new Point(150, 174);
            txtTotalSize.Name = "txtTotalSize";
            txtTotalSize.Size = new Size(150, 27);
            txtTotalSize.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 212);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 16;
            label7.Text = "Material Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 241);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 17;
            label8.Text = "Order Delivery Time";
            // 
            // cmbMaterial
            // 
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.Items.AddRange(new object[] { "3", "5", "7", "14" });
            cmbMaterial.Location = new Point(150, 207);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(150, 28);
            cmbMaterial.TabIndex = 18;
            cmbMaterial.SelectedIndexChanged += txtMaterial_SelectedIndexChanged;
            // 
            // AddQuote
            // 
            ClientSize = new Size(350, 320);
            Controls.Add(cmbMaterial);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTotalSize);
            Controls.Add(txtQuoteDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Controls.Add(txtWidth);
            Controls.Add(txtDepth);
            Controls.Add(txtDrawers);
            Controls.Add(cmbDelivery);
            Controls.Add(BtnSubmit);
            Controls.Add(BtnBack);
            Name = "AddQuote";
            Text = "Add Quote";
            Load += AddQuote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtQuoteDate;
        private TextBox txtTotalSize;
        private Label label7;
        private Label label8;
        private ComboBox cmbMaterial;
    }
}