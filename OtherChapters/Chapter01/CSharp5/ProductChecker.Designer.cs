namespace Chapter01.CSharp5
{
    partial class ProductChecker
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idInput = new System.Windows.Forms.TextBox();
            this.productCheckButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.nameValue = new System.Windows.Forms.Label();
            this.priceValue = new System.Windows.Forms.Label();
            this.stockValue = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.stockValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.priceValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.idInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productCheckButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameValue, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(93, 3);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(100, 20);
            this.idInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            label1.Size = new System.Drawing.Size(84, 29);
            label1.TabIndex = 1;
            label1.Text = "Product ID";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 29);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            label2.Size = new System.Drawing.Size(84, 17);
            label2.TabIndex = 2;
            label2.Text = "Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productCheckButton
            // 
            this.productCheckButton.Location = new System.Drawing.Point(199, 3);
            this.productCheckButton.Name = "productCheckButton";
            this.productCheckButton.Size = new System.Drawing.Size(75, 23);
            this.productCheckButton.TabIndex = 1;
            this.productCheckButton.Text = "Check";
            this.productCheckButton.UseVisualStyleBackColor = true;
            this.productCheckButton.Click += new System.EventHandler(this.CheckProduct);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 46);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            label4.Size = new System.Drawing.Size(84, 17);
            label4.TabIndex = 5;
            label4.Text = "Price";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 63);
            label5.Name = "label5";
            label5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            label5.Size = new System.Drawing.Size(84, 21);
            label5.TabIndex = 6;
            label5.Text = "Number in stock";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 139);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Enter a product ID to check";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nameValue, 2);
            this.nameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameValue.Location = new System.Drawing.Point(93, 29);
            this.nameValue.Name = "nameValue";
            this.nameValue.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.nameValue.Size = new System.Drawing.Size(188, 17);
            this.nameValue.TabIndex = 7;
            this.nameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceValue
            // 
            this.priceValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.priceValue, 2);
            this.priceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceValue.Location = new System.Drawing.Point(93, 46);
            this.priceValue.Name = "priceValue";
            this.priceValue.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.priceValue.Size = new System.Drawing.Size(188, 17);
            this.priceValue.TabIndex = 8;
            this.priceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stockValue
            // 
            this.stockValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.stockValue, 2);
            this.stockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockValue.Location = new System.Drawing.Point(93, 63);
            this.stockValue.Name = "stockValue";
            this.stockValue.Padding = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.stockValue.Size = new System.Drawing.Size(188, 21);
            this.stockValue.TabIndex = 9;
            this.stockValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductChecker
            // 
            this.AcceptButton = this.productCheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductChecker";
            this.Text = "Product Checker";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Button productCheckButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label stockValue;
        private System.Windows.Forms.Label priceValue;
        private System.Windows.Forms.Label nameValue;
    }
}