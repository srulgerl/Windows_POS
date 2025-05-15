namespace WinFormsApp1
{
    partial class ProductMenu
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
            label1 = new Label();
            dgvProducts = new DataGridView();
            insertBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 40);
            label1.Name = "label1";
            label1.Size = new Size(170, 50);
            label1.TabIndex = 22;
            label1.Text = "Products";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(54, 119);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 82;
            dgvProducts.Size = new Size(1765, 889);
            dgvProducts.TabIndex = 24;
            dgvProducts.CellValueChanged += dgvProducts_CellValueChanged;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(1906, 119);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(220, 100);
            insertBtn.TabIndex = 25;
            insertBtn.Text = "Шинэ бараа нэмэх";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // ProductMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(insertBtn);
            Controls.Add(dgvProducts);
            Controls.Add(label1);
            Name = "ProductMenu";
            Size = new Size(2162, 1091);
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvProducts;
        private Button insertBtn;
    }
}