namespace WinFormsApp1
{
    partial class CategoryMenu
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
            dgvCategories = new DataGridView();
            label2 = new Label();
            insertBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(42, 112);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 82;
            dgvCategories.Size = new Size(1765, 889);
            dgvCategories.TabIndex = 26;
            dgvCategories.CellValueChanged += dgvCategories_CellValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 33);
            label2.Name = "label2";
            label2.Size = new Size(201, 50);
            label2.TabIndex = 25;
            label2.Text = "Categories";
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(1880, 112);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(220, 100);
            insertBtn.TabIndex = 27;
            insertBtn.Text = "Шинэ категори нэмэх";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // CategoryMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(insertBtn);
            Controls.Add(dgvCategories);
            Controls.Add(label2);
            Name = "CategoryMenu";
            Size = new Size(2137, 1075);
            Load += CategoryMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private Label label2;
        private Button insertBtn;
    }
}