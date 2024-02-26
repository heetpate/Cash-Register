namespace Cash_Register
{
    partial class cashRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.techShopLabel = new System.Windows.Forms.Label();
            this.noOfPhone = new System.Windows.Forms.Button();
            this.noOfLaptop = new System.Windows.Forms.Button();
            this.noOfVr = new System.Windows.Forms.Button();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.laptopInput = new System.Windows.Forms.TextBox();
            this.vrInput = new System.Windows.Forms.TextBox();
            this.caculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChange = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.receiptPrinter = new System.Windows.Forms.Label();
            this.reOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // techShopLabel
            // 
            this.techShopLabel.AutoSize = true;
            this.techShopLabel.BackColor = System.Drawing.Color.Transparent;
            this.techShopLabel.Font = new System.Drawing.Font("Stencil", 21.75F);
            this.techShopLabel.ForeColor = System.Drawing.Color.Cyan;
            this.techShopLabel.Location = new System.Drawing.Point(299, 9);
            this.techShopLabel.Name = "techShopLabel";
            this.techShopLabel.Size = new System.Drawing.Size(169, 34);
            this.techShopLabel.TabIndex = 0;
            this.techShopLabel.Text = "Tech Shop";
            // 
            // noOfPhone
            // 
            this.noOfPhone.BackColor = System.Drawing.Color.DarkBlue;
            this.noOfPhone.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.noOfPhone.ForeColor = System.Drawing.Color.Lime;
            this.noOfPhone.Location = new System.Drawing.Point(12, 99);
            this.noOfPhone.Name = "noOfPhone";
            this.noOfPhone.Size = new System.Drawing.Size(217, 37);
            this.noOfPhone.TabIndex = 1;
            this.noOfPhone.Text = "Number of Phone";
            this.noOfPhone.UseVisualStyleBackColor = false;
            // 
            // noOfLaptop
            // 
            this.noOfLaptop.BackColor = System.Drawing.Color.DarkBlue;
            this.noOfLaptop.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.noOfLaptop.ForeColor = System.Drawing.Color.Lime;
            this.noOfLaptop.Location = new System.Drawing.Point(12, 143);
            this.noOfLaptop.Name = "noOfLaptop";
            this.noOfLaptop.Size = new System.Drawing.Size(217, 37);
            this.noOfLaptop.TabIndex = 2;
            this.noOfLaptop.Text = "Number of Laptop";
            this.noOfLaptop.UseVisualStyleBackColor = false;
            // 
            // noOfVr
            // 
            this.noOfVr.BackColor = System.Drawing.Color.DarkBlue;
            this.noOfVr.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold);
            this.noOfVr.ForeColor = System.Drawing.Color.Lime;
            this.noOfVr.Location = new System.Drawing.Point(12, 186);
            this.noOfVr.Name = "noOfVr";
            this.noOfVr.Size = new System.Drawing.Size(217, 37);
            this.noOfVr.TabIndex = 3;
            this.noOfVr.Text = "Number of VR";
            this.noOfVr.UseVisualStyleBackColor = false;
            // 
            // phoneInput
            // 
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.phoneInput.Location = new System.Drawing.Point(251, 107);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(62, 21);
            this.phoneInput.TabIndex = 4;
            // 
            // laptopInput
            // 
            this.laptopInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.laptopInput.Location = new System.Drawing.Point(251, 151);
            this.laptopInput.Name = "laptopInput";
            this.laptopInput.Size = new System.Drawing.Size(62, 21);
            this.laptopInput.TabIndex = 5;
            // 
            // vrInput
            // 
            this.vrInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.vrInput.Location = new System.Drawing.Point(251, 194);
            this.vrInput.Name = "vrInput";
            this.vrInput.Size = new System.Drawing.Size(62, 21);
            this.vrInput.TabIndex = 6;
            // 
            // caculateButton
            // 
            this.caculateButton.BackColor = System.Drawing.Color.Black;
            this.caculateButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caculateButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.caculateButton.Location = new System.Drawing.Point(119, 248);
            this.caculateButton.Name = "caculateButton";
            this.caculateButton.Size = new System.Drawing.Size(171, 41);
            this.caculateButton.TabIndex = 7;
            this.caculateButton.Text = "Calculate";
            this.caculateButton.UseVisualStyleBackColor = false;
            this.caculateButton.Click += new System.EventHandler(this.caculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.Color.Lime;
            this.subTotalLabel.Location = new System.Drawing.Point(389, 85);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(87, 19);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Lime;
            this.taxLabel.Location = new System.Drawing.Point(374, 117);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(112, 19);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "TaxAmount:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Lime;
            this.totalLabel.Location = new System.Drawing.Point(401, 152);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 19);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.Lime;
            this.tenderedLabel.Location = new System.Drawing.Point(389, 196);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(94, 19);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.Click += new System.EventHandler(this.tenderedLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.ForeColor = System.Drawing.Color.White;
            this.subTotalOutput.Location = new System.Drawing.Point(536, 85);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(16, 13);
            this.subTotalOutput.TabIndex = 14;
            this.subTotalOutput.Text = "...";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.ForeColor = System.Drawing.Color.White;
            this.taxOutput.Location = new System.Drawing.Point(536, 121);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(16, 13);
            this.taxOutput.TabIndex = 15;
            this.taxOutput.Text = "...";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.ForeColor = System.Drawing.Color.White;
            this.totalOutput.Location = new System.Drawing.Point(536, 156);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(16, 13);
            this.totalOutput.TabIndex = 16;
            this.totalOutput.Text = "...";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tenderedInput.Location = new System.Drawing.Point(522, 195);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(62, 21);
            this.tenderedInput.TabIndex = 17;
            this.tenderedInput.TextChanged += new System.EventHandler(this.tenderedInput_TextChanged);
            // 
            // calculateChange
            // 
            this.calculateChange.BackColor = System.Drawing.Color.Black;
            this.calculateChange.Enabled = false;
            this.calculateChange.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.calculateChange.ForeColor = System.Drawing.Color.PaleGreen;
            this.calculateChange.Location = new System.Drawing.Point(366, 240);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(229, 41);
            this.calculateChange.TabIndex = 18;
            this.calculateChange.Text = "Calculate the Change";
            this.calculateChange.UseVisualStyleBackColor = false;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Lime;
            this.changeLabel.Location = new System.Drawing.Point(392, 299);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(79, 19);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change:";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.ForeColor = System.Drawing.Color.White;
            this.changeOutput.Location = new System.Drawing.Point(545, 303);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(16, 13);
            this.changeOutput.TabIndex = 20;
            this.changeOutput.Text = "...";
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.Black;
            this.printReceiptButton.Enabled = false;
            this.printReceiptButton.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.printReceiptButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.printReceiptButton.Location = new System.Drawing.Point(366, 333);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(229, 41);
            this.printReceiptButton.TabIndex = 21;
            this.printReceiptButton.Text = "Print the Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // receiptPrinter
            // 
            this.receiptPrinter.BackColor = System.Drawing.Color.AliceBlue;
            this.receiptPrinter.Location = new System.Drawing.Point(632, 9);
            this.receiptPrinter.Name = "receiptPrinter";
            this.receiptPrinter.Size = new System.Drawing.Size(296, 385);
            this.receiptPrinter.TabIndex = 22;
            this.receiptPrinter.Click += new System.EventHandler(this.receiptPrinter_Click);
            // 
            // reOrder
            // 
            this.reOrder.BackColor = System.Drawing.Color.Black;
            this.reOrder.Enabled = false;
            this.reOrder.Font = new System.Drawing.Font("Stencil", 12.75F);
            this.reOrder.ForeColor = System.Drawing.Color.PaleGreen;
            this.reOrder.Location = new System.Drawing.Point(673, 397);
            this.reOrder.Name = "reOrder";
            this.reOrder.Size = new System.Drawing.Size(229, 41);
            this.reOrder.TabIndex = 23;
            this.reOrder.Text = "New Order";
            this.reOrder.UseVisualStyleBackColor = false;
            this.reOrder.Click += new System.EventHandler(this.reOrder_Click);
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(945, 511);
            this.Controls.Add(this.reOrder);
            this.Controls.Add(this.receiptPrinter);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.caculateButton);
            this.Controls.Add(this.vrInput);
            this.Controls.Add(this.laptopInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.noOfVr);
            this.Controls.Add(this.noOfLaptop);
            this.Controls.Add(this.noOfPhone);
            this.Controls.Add(this.techShopLabel);
            this.Name = "cashRegister";
            this.Text = "Tech Shop";
            this.Load += new System.EventHandler(this.cashRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label techShopLabel;
        private System.Windows.Forms.Button noOfPhone;
        private System.Windows.Forms.Button noOfLaptop;
        private System.Windows.Forms.Button noOfVr;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox laptopInput;
        private System.Windows.Forms.TextBox vrInput;
        private System.Windows.Forms.Button caculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label receiptPrinter;
        private System.Windows.Forms.Button reOrder;
    }
}

