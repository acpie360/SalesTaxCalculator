namespace SalesTaxCalculator
{
    partial class Form1
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
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSaleTax = new System.Windows.Forms.Label();
            this.txtSaleTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(74, 53);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(121, 17);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales Amount ($):";
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(202, 46);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(163, 30);
            this.txtSales.TabIndex = 1;
            this.txtSales.Click += new System.EventHandler(this.txtSales_Enter);
            this.txtSales.Enter += new System.EventHandler(this.txtSales_Enter);
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Location = new System.Drawing.Point(77, 91);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(95, 17);
            this.lblTaxRate.TabIndex = 2;
            this.lblTaxRate.Text = "Tax Rate (%):";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Location = new System.Drawing.Point(202, 84);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(163, 30);
            this.txtTaxRate.TabIndex = 3;
            this.txtTaxRate.Click += new System.EventHandler(this.txtTaxRate_Enter);
            this.txtTaxRate.Enter += new System.EventHandler(this.txtTaxRate_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatAppearance.BorderSize = 10;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(76, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 40);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 10;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(203, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 10;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(330, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSaleTax
            // 
            this.lblSaleTax.AutoSize = true;
            this.lblSaleTax.Location = new System.Drawing.Point(80, 129);
            this.lblSaleTax.Name = "lblSaleTax";
            this.lblSaleTax.Size = new System.Drawing.Size(96, 17);
            this.lblSaleTax.TabIndex = 4;
            this.lblSaleTax.Text = "Sales Tax ($):";
            // 
            // txtSaleTax
            // 
            this.txtSaleTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleTax.Location = new System.Drawing.Point(202, 122);
            this.txtSaleTax.Name = "txtSaleTax";
            this.txtSaleTax.Size = new System.Drawing.Size(163, 30);
            this.txtSaleTax.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 336);
            this.Controls.Add(this.txtSaleTax);
            this.Controls.Add(this.lblSaleTax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.lblSales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSaleTax;
        private System.Windows.Forms.TextBox txtSaleTax;
    }
}

