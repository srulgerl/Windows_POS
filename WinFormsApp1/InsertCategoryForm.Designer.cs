namespace WinFormsApp1
{
    partial class InsertCategoryForm
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 41);
            label1.Name = "label1";
            label1.Size = new Size(303, 37);
            label1.TabIndex = 0;
            label1.Text = "Шинэ категори нэмэх";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 225);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 1;
            label2.Text = "Нэр";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 144);
            label3.Name = "label3";
            label3.Size = new Size(34, 32);
            label3.TabIndex = 2;
            label3.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 4;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(38, 365);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(188, 65);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(266, 365);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(188, 65);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // InsertCategoryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 466);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InsertCategoryForm";
            Text = "InsertCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button saveBtn;
        private Button cancelBtn;
    }
}