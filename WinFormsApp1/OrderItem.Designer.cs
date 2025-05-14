

namespace WinFormsApp1
{
    partial class OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            subBtn = new Button();
            productNameLbl = new Label();
            QtyLbl = new Label();
            unitPriceLbl = new Label();
            discountLbl = new Label();
            addBtn = new Button();
            totalLbl = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // subBtn
            // 
            subBtn.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            subBtn.Location = new Point(228, 26);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(50, 50);
            subBtn.TabIndex = 0;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += subBtn_Click;
            // 
            // productNameLbl
            // 
            productNameLbl.AutoSize = true;
            productNameLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            productNameLbl.Location = new Point(24, 33);
            productNameLbl.Name = "productNameLbl";
            productNameLbl.Size = new Size(92, 40);
            productNameLbl.TabIndex = 2;
            productNameLbl.Text = "label1";
            // 
            // QtyLbl
            // 
            QtyLbl.AutoSize = true;
            QtyLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            QtyLbl.Location = new Point(308, 35);
            QtyLbl.Name = "QtyLbl";
            QtyLbl.Size = new Size(29, 40);
            QtyLbl.TabIndex = 3;
            QtyLbl.Text = "1";
            // 
            // unitPriceLbl
            // 
            unitPriceLbl.AutoSize = true;
            unitPriceLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            unitPriceLbl.Location = new Point(450, 31);
            unitPriceLbl.Name = "unitPriceLbl";
            unitPriceLbl.Size = new Size(33, 40);
            unitPriceLbl.TabIndex = 4;
            unitPriceLbl.Text = "0";
            // 
            // discountLbl
            // 
            discountLbl.AutoSize = true;
            discountLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            discountLbl.Location = new Point(592, 31);
            discountLbl.Name = "discountLbl";
            discountLbl.Size = new Size(33, 40);
            discountLbl.TabIndex = 5;
            discountLbl.Text = "0";
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            addBtn.Location = new Point(364, 26);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(50, 50);
            addBtn.TabIndex = 6;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click_1;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            totalLbl.Location = new Point(691, 33);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(33, 40);
            totalLbl.TabIndex = 7;
            totalLbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 72);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 10;
            // 
            // OrderItem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label2);
            Controls.Add(totalLbl);
            Controls.Add(addBtn);
            Controls.Add(discountLbl);
            Controls.Add(unitPriceLbl);
            Controls.Add(QtyLbl);
            Controls.Add(productNameLbl);
            Controls.Add(subBtn);
            Name = "OrderItem";
            Size = new Size(840, 101);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button subBtn;
        private Label productNameLbl;
        public Label QtyLbl;
        private Label unitPriceLbl;
        private Label discountLbl;
        private Button addBtn;
        public Label totalLbl;
        private Label label2;
    }
}
