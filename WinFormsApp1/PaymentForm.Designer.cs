
namespace WinFormsApp1
{
    partial class PaymentForm
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
            PayBtn = new Button();
            label2 = new Label();
            label4 = new Label();
            CashTxtBox = new TextBox();
            TotalPriceLbl = new Label();
            label1 = new Label();
            ChangeLbl = new Label();
            SuspendLayout();
            // 
            // PayBtn
            // 
            PayBtn.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayBtn.Location = new Point(149, 871);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(536, 112);
            PayBtn.TabIndex = 0;
            PayBtn.Text = "Төлөх";
            PayBtn.UseVisualStyleBackColor = true;
            PayBtn.Click += PayBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label2.Location = new Point(64, 329);
            label2.Name = "label2";
            label2.Size = new Size(196, 50);
            label2.TabIndex = 2;
            label2.Text = "Нийт Дүн:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label4.Location = new Point(64, 451);
            label4.Name = "label4";
            label4.Size = new Size(390, 50);
            label4.TabIndex = 4;
            label4.Text = "Бэлнээр оруулах дүн:";
            // 
            // CashTxtBox
            // 
            CashTxtBox.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            CashTxtBox.Location = new Point(512, 451);
            CashTxtBox.Name = "CashTxtBox";
            CashTxtBox.Size = new Size(225, 46);
            CashTxtBox.TabIndex = 5;
            // 
            // TotalPriceLbl
            // 
            TotalPriceLbl.AutoSize = true;
            TotalPriceLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            TotalPriceLbl.Location = new Point(512, 336);
            TotalPriceLbl.Name = "TotalPriceLbl";
            TotalPriceLbl.Size = new Size(92, 40);
            TotalPriceLbl.TabIndex = 6;
            TotalPriceLbl.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold);
            label1.Location = new Point(64, 588);
            label1.Name = "label1";
            label1.Size = new Size(171, 50);
            label1.TabIndex = 7;
            label1.Text = "Хариулт:";
            // 
            // ChangeLbl
            // 
            ChangeLbl.AutoSize = true;
            ChangeLbl.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold);
            ChangeLbl.Location = new Point(512, 595);
            ChangeLbl.Name = "ChangeLbl";
            ChangeLbl.Size = new Size(33, 40);
            ChangeLbl.TabIndex = 8;
            ChangeLbl.Text = "0";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 1066);
            Controls.Add(ChangeLbl);
            Controls.Add(label1);
            Controls.Add(TotalPriceLbl);
            Controls.Add(CashTxtBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(PayBtn);
            Name = "PaymentForm";
            Text = "MainForm";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button PayBtn;
        private Label label2;
        private Label label4;
        private TextBox CashTxtBox;
        private Label TotalPriceLbl;
        private Label label1;
        private Label ChangeLbl;
    }
}