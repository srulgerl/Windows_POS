namespace WinFormsApp1
{
    partial class newProductForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            idTxtLbl = new TextBox();
            nameTxtLbl = new TextBox();
            priceTxtLbl = new TextBox();
            qtyTxtLbl = new TextBox();
            label5 = new Label();
            cmbBoxCategory = new ComboBox();
            label6 = new Label();
            discTxtLbl = new TextBox();
            label7 = new Label();
            barcodeTxtLbl = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(23, 300);
            label4.MinimumSize = new Size(50, 70);
            label4.Name = "label4";
            label4.Size = new Size(147, 70);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(23, 210);
            label3.MinimumSize = new Size(50, 70);
            label3.Name = "label3";
            label3.Size = new Size(91, 70);
            label3.TabIndex = 7;
            label3.Text = "Price";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(23, 120);
            label2.MinimumSize = new Size(50, 70);
            label2.Name = "label2";
            label2.Size = new Size(107, 70);
            label2.TabIndex = 6;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 30);
            label1.MinimumSize = new Size(50, 70);
            label1.Name = "label1";
            label1.Size = new Size(50, 70);
            label1.TabIndex = 5;
            label1.Text = "Id";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(idTxtLbl);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(nameTxtLbl);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(priceTxtLbl);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(qtyTxtLbl);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(cmbBoxCategory);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(discTxtLbl);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(barcodeTxtLbl);
            flowLayoutPanel1.Controls.Add(saveBtn);
            flowLayoutPanel1.Controls.Add(cancelBtn);
            flowLayoutPanel1.Location = new Point(0, 19);
            flowLayoutPanel1.Margin = new Padding(20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(568, 774);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // idTxtLbl
            // 
            idTxtLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idTxtLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            idTxtLbl.Location = new Point(86, 30);
            idTxtLbl.Margin = new Padding(10);
            idTxtLbl.MinimumSize = new Size(50, 70);
            idTxtLbl.Name = "idTxtLbl";
            idTxtLbl.Size = new Size(432, 70);
            idTxtLbl.TabIndex = 10;
            idTxtLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // nameTxtLbl
            // 
            nameTxtLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameTxtLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameTxtLbl.Location = new Point(143, 120);
            nameTxtLbl.Margin = new Padding(10);
            nameTxtLbl.MinimumSize = new Size(50, 70);
            nameTxtLbl.Name = "nameTxtLbl";
            nameTxtLbl.Size = new Size(375, 70);
            nameTxtLbl.TabIndex = 10;
            nameTxtLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // priceTxtLbl
            // 
            priceTxtLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceTxtLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            priceTxtLbl.Location = new Point(127, 210);
            priceTxtLbl.Margin = new Padding(10);
            priceTxtLbl.MinimumSize = new Size(50, 70);
            priceTxtLbl.Name = "priceTxtLbl";
            priceTxtLbl.Size = new Size(391, 70);
            priceTxtLbl.TabIndex = 11;
            priceTxtLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // qtyTxtLbl
            // 
            qtyTxtLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            qtyTxtLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            qtyTxtLbl.Location = new Point(183, 300);
            qtyTxtLbl.Margin = new Padding(10);
            qtyTxtLbl.MinimumSize = new Size(50, 70);
            qtyTxtLbl.Name = "qtyTxtLbl";
            qtyTxtLbl.Size = new Size(335, 70);
            qtyTxtLbl.TabIndex = 12;
            qtyTxtLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(23, 380);
            label5.MinimumSize = new Size(50, 70);
            label5.Name = "label5";
            label5.Size = new Size(153, 70);
            label5.TabIndex = 13;
            label5.Text = "Category";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbBoxCategory
            // 
            cmbBoxCategory.Anchor = AnchorStyles.None;
            cmbBoxCategory.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBoxCategory.FormattingEnabled = true;
            cmbBoxCategory.Location = new Point(182, 386);
            cmbBoxCategory.Name = "cmbBoxCategory";
            cmbBoxCategory.Size = new Size(299, 58);
            cmbBoxCategory.TabIndex = 21;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(23, 460);
            label6.MinimumSize = new Size(50, 70);
            label6.Name = "label6";
            label6.Size = new Size(149, 70);
            label6.TabIndex = 15;
            label6.Text = "Discount";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discTxtLbl
            // 
            discTxtLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            discTxtLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            discTxtLbl.Location = new Point(185, 460);
            discTxtLbl.Margin = new Padding(10);
            discTxtLbl.MinimumSize = new Size(50, 70);
            discTxtLbl.Name = "discTxtLbl";
            discTxtLbl.Size = new Size(333, 70);
            discTxtLbl.TabIndex = 16;
            discTxtLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(23, 550);
            label7.MinimumSize = new Size(50, 70);
            label7.Name = "label7";
            label7.Size = new Size(143, 70);
            label7.TabIndex = 17;
            label7.Text = "BarCode";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // barcodeTxtLbl
            // 
            barcodeTxtLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            barcodeTxtLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            barcodeTxtLbl.Location = new Point(179, 550);
            barcodeTxtLbl.Margin = new Padding(10);
            barcodeTxtLbl.MinimumSize = new Size(50, 70);
            barcodeTxtLbl.Name = "barcodeTxtLbl";
            barcodeTxtLbl.Size = new Size(339, 70);
            barcodeTxtLbl.TabIndex = 18;
            barcodeTxtLbl.TextAlign = HorizontalAlignment.Center;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            saveBtn.Location = new Point(50, 660);
            saveBtn.Margin = new Padding(30);
            saveBtn.MinimumSize = new Size(0, 60);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(199, 60);
            saveBtn.TabIndex = 19;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cancelBtn.Location = new Point(309, 660);
            cancelBtn.Margin = new Padding(30);
            cancelBtn.MinimumSize = new Size(0, 60);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(199, 60);
            cancelBtn.TabIndex = 20;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // newProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 789);
            Controls.Add(flowLayoutPanel1);
            Name = "newProductForm";
            Text = "newProductForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox idTxtLbl;
        private TextBox nameTxtLbl;
        private TextBox priceTxtLbl;
        private Label label5;
        private Label label6;
        private TextBox discTxtLbl;
        private Label label7;
        private TextBox barcodeTxtLbl;
        private Button saveBtn;
        private Button cancelBtn;
        private TextBox qtyTxtLbl;
        private ComboBox cmbBoxCategory;
    }
}