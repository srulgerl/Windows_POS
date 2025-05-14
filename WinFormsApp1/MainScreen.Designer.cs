using posLibrary;

namespace WinFormsApp1
{
    partial class MainScreen
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            UserNameLbl = new Label();
            menuStrip1 = new MenuStrip();
            productsToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mainContentPanel = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            payBtn = new Button();
            panel2 = new Panel();
            TotalPrice = new Label();
            label8 = new Label();
            categoryflowPanel = new FlowLayoutPanel();
            productFlowPanel = new FlowLayoutPanel();
            searchTxtBox = new TextBox();
            label1 = new Label();
            transactionPanel = new FlowLayoutPanel();
            startToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            mainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Location = new Point(1886, 89);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(108, 32);
            UserNameLbl.TabIndex = 19;
            UserNameLbl.Text = "manager";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startToolStripMenuItem, productsToolStripMenuItem, categoryToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2162, 42);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(98, 38);
            productsToolStripMenuItem.Text = "Бараа";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(223, 38);
            categoryToolStripMenuItem.Text = "Барааны ангилал";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(130, 38);
            helpToolStripMenuItem.Text = "Тусламж";
            // 
            // mainContentPanel
            // 
            mainContentPanel.Controls.Add(UserNameLbl);
            mainContentPanel.Controls.Add(pictureBox1);
            mainContentPanel.Controls.Add(label2);
            mainContentPanel.Controls.Add(button1);
            mainContentPanel.Controls.Add(panel3);
            mainContentPanel.Controls.Add(payBtn);
            mainContentPanel.Controls.Add(panel2);
            mainContentPanel.Controls.Add(categoryflowPanel);
            mainContentPanel.Controls.Add(productFlowPanel);
            mainContentPanel.Controls.Add(searchTxtBox);
            mainContentPanel.Controls.Add(label1);
            mainContentPanel.Controls.Add(transactionPanel);
            mainContentPanel.Location = new Point(0, 43);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(2162, 1228);
            mainContentPanel.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1055000_profle_person_profile_user_icon__2_;
            pictureBox1.Location = new Point(2024, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 108);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.search_icon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(1914, 157);
            button1.Name = "button1";
            button1.Size = new Size(42, 43);
            button1.TabIndex = 31;
            button1.UseVisualStyleBackColor = true;
            button1.Click += SearchBtn_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(59, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 80);
            panel3.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(593, 21);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 7;
            label3.Text = "Dis%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveBorder;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(25, 21);
            label9.Name = "label9";
            label9.Size = new Size(140, 32);
            label9.TabIndex = 4;
            label9.Text = "Item Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveBorder;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(692, 21);
            label10.Name = "label10";
            label10.Size = new Size(70, 32);
            label10.TabIndex = 8;
            label10.Text = "Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveBorder;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(269, 21);
            label11.Name = "label11";
            label11.Size = new Size(113, 32);
            label11.TabIndex = 5;
            label11.Text = "Quantity";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveBorder;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(451, 21);
            label12.Name = "label12";
            label12.Size = new Size(99, 32);
            label12.TabIndex = 6;
            label12.Text = "U/Price";
            // 
            // payBtn
            // 
            payBtn.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payBtn.Location = new Point(59, 1114);
            payBtn.Name = "payBtn";
            payBtn.Size = new Size(843, 98);
            payBtn.TabIndex = 27;
            payBtn.Text = "Pay";
            payBtn.UseVisualStyleBackColor = true;
            payBtn.Click += payBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(TotalPrice);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(59, 1011);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 97);
            panel2.TabIndex = 28;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TotalPrice.Location = new Point(440, 23);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(56, 65);
            TotalPrice.TabIndex = 12;
            TotalPrice.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(48, 23);
            label8.Name = "label8";
            label8.Size = new Size(277, 65);
            label8.TabIndex = 13;
            label8.Text = "Total Price:";
            // 
            // categoryflowPanel
            // 
            categoryflowPanel.AutoScroll = true;
            categoryflowPanel.Location = new Point(933, 735);
            categoryflowPanel.Name = "categoryflowPanel";
            categoryflowPanel.Size = new Size(1170, 477);
            categoryflowPanel.TabIndex = 26;
            // 
            // productFlowPanel
            // 
            productFlowPanel.AutoScroll = true;
            productFlowPanel.Location = new Point(933, 218);
            productFlowPanel.Name = "productFlowPanel";
            productFlowPanel.Size = new Size(1170, 518);
            productFlowPanel.TabIndex = 25;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxtBox.Location = new Point(1140, 157);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(816, 43);
            searchTxtBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 58);
            label1.Name = "label1";
            label1.Size = new Size(418, 50);
            label1.TabIndex = 24;
            label1.Text = "RETAIL SUPERMARKET";
            // 
            // transactionPanel
            // 
            transactionPanel.AutoScroll = true;
            transactionPanel.AutoSize = true;
            transactionPanel.FlowDirection = FlowDirection.TopDown;
            transactionPanel.Location = new Point(59, 243);
            transactionPanel.Margin = new Padding(0);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(843, 770);
            transactionPanel.TabIndex = 29;
            transactionPanel.WrapContents = false;
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(97, 38);
            startToolStripMenuItem.Text = "Эхлэл";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2162, 1271);
            Controls.Add(menuStrip1);
            Controls.Add(mainContentPanel);
            Cursor = Cursors.Hand;
            MainMenuStrip = menuStrip1;
            Name = "MainScreen";
            Text = "MainScreen";
            Load += MainScreen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainContentPanel.ResumeLayout(false);
            mainContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label UserNameLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Panel mainContentPanel;
        private Panel panel3;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button payBtn;
        private Panel panel2;
        private Label TotalPrice;
        private Label label8;
        private FlowLayoutPanel categoryflowPanel;
        private FlowLayoutPanel productFlowPanel;
        private TextBox searchTxtBox;
        private Label label1;
        private FlowLayoutPanel transactionPanel;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private ToolStripMenuItem startToolStripMenuItem;
    }
}