
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passLbl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            userCombBox = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // passLbl
            // 
            passLbl.Location = new Point(676, 325);
            passLbl.Name = "passLbl";
            passLbl.Size = new Size(291, 39);
            passLbl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 172);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(676, 279);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ScrollBar;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(704, 381);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(226, 67);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // userCombBox
            // 
            userCombBox.FormattingEnabled = true;
            userCombBox.Items.AddRange(new object[] { "Manager", "Cashier1", "Cashier2" });
            userCombBox.Location = new Point(676, 216);
            userCombBox.Name = "userCombBox";
            userCombBox.Size = new Size(291, 40);
            userCombBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(153, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 386);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 595);
            Controls.Add(pictureBox1);
            Controls.Add(userCombBox);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passLbl);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private TextBox passLbl;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private ComboBox userCombBox;
        private PictureBox pictureBox1;
    }
}
