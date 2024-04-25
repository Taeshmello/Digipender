namespace Digipender
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel5 = new Panel();
            settingsIconBtn = new FontAwesome.Sharp.IconButton();
            fileScanIconBtn = new FontAwesome.Sharp.IconButton();
            searchIconBtn = new FontAwesome.Sharp.IconButton();
            homeIconBtn = new FontAwesome.Sharp.IconButton();
            title = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            main_panel = new Panel();
            panel1 = new Panel();
            panel5.SuspendLayout();
            main_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(settingsIconBtn);
            panel5.Controls.Add(fileScanIconBtn);
            panel5.Controls.Add(searchIconBtn);
            panel5.Controls.Add(homeIconBtn);
            panel5.Controls.Add(title);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 682);
            panel5.TabIndex = 7;
            // 
            // settingsIconBtn
            // 
            settingsIconBtn.Dock = DockStyle.Bottom;
            settingsIconBtn.FlatAppearance.BorderSize = 0;
            settingsIconBtn.FlatStyle = FlatStyle.Flat;
            settingsIconBtn.Font = new Font("Yu Gothic", 12.75F, FontStyle.Bold);
            settingsIconBtn.ForeColor = Color.White;
            settingsIconBtn.IconChar = FontAwesome.Sharp.IconChar.Gear;
            settingsIconBtn.IconColor = Color.White;
            settingsIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            settingsIconBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsIconBtn.Location = new Point(0, 627);
            settingsIconBtn.Margin = new Padding(0);
            settingsIconBtn.Name = "settingsIconBtn";
            settingsIconBtn.Size = new Size(192, 55);
            settingsIconBtn.TabIndex = 8;
            settingsIconBtn.Text = "Settings";
            settingsIconBtn.UseVisualStyleBackColor = true;
            settingsIconBtn.Click += settingsIconBtn_Click;
            // 
            // fileScanIconBtn
            // 
            fileScanIconBtn.FlatAppearance.BorderSize = 0;
            fileScanIconBtn.FlatStyle = FlatStyle.Flat;
            fileScanIconBtn.Font = new Font("Yu Gothic", 12.75F, FontStyle.Bold);
            fileScanIconBtn.ForeColor = Color.White;
            fileScanIconBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleQuestion;
            fileScanIconBtn.IconColor = Color.White;
            fileScanIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            fileScanIconBtn.ImageAlign = ContentAlignment.MiddleLeft;
            fileScanIconBtn.Location = new Point(2, 572);
            fileScanIconBtn.Margin = new Padding(0);
            fileScanIconBtn.Name = "fileScanIconBtn";
            fileScanIconBtn.Size = new Size(192, 55);
            fileScanIconBtn.TabIndex = 7;
            fileScanIconBtn.Text = "File Scan";
            fileScanIconBtn.UseVisualStyleBackColor = true;
            fileScanIconBtn.Click += fileScanIconBtn_Click;
            // 
            // searchIconBtn
            // 
            searchIconBtn.FlatAppearance.BorderSize = 0;
            searchIconBtn.FlatStyle = FlatStyle.Flat;
            searchIconBtn.Font = new Font("Yu Gothic", 12.75F, FontStyle.Bold);
            searchIconBtn.ForeColor = Color.White;
            searchIconBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            searchIconBtn.IconColor = Color.White;
            searchIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchIconBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchIconBtn.Location = new Point(-2, 517);
            searchIconBtn.Margin = new Padding(0);
            searchIconBtn.Name = "searchIconBtn";
            searchIconBtn.Size = new Size(192, 55);
            searchIconBtn.TabIndex = 6;
            searchIconBtn.Text = "검사";
            searchIconBtn.UseVisualStyleBackColor = true;
            searchIconBtn.Click += searchIconBtn_Click;
            // 
            // homeIconBtn
            // 
            homeIconBtn.BackColor = Color.Black;
            homeIconBtn.FlatAppearance.BorderSize = 0;
            homeIconBtn.FlatStyle = FlatStyle.Flat;
            homeIconBtn.Font = new Font("Yu Gothic", 12.75F, FontStyle.Bold);
            homeIconBtn.ForeColor = Color.White;
            homeIconBtn.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            homeIconBtn.IconColor = Color.White;
            homeIconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeIconBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeIconBtn.Location = new Point(-4, 462);
            homeIconBtn.Margin = new Padding(0);
            homeIconBtn.Name = "homeIconBtn";
            homeIconBtn.Size = new Size(192, 55);
            homeIconBtn.TabIndex = 5;
            homeIconBtn.Text = "Home";
            homeIconBtn.UseVisualStyleBackColor = false;
            homeIconBtn.Click += homeIconBtn_Click;
            // 
            // title
            // 
            title.Dock = DockStyle.Top;
            title.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(192, 44);
            title.TabIndex = 4;
            title.Text = "Home";
            title.TextAlign = ContentAlignment.BottomCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // main_panel
            // 
            main_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            main_panel.BackColor = SystemColors.WindowFrame;
            main_panel.Controls.Add(panel1);
            main_panel.Dock = DockStyle.Right;
            main_panel.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            main_panel.Location = new Point(192, 0);
            main_panel.Margin = new Padding(0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1019, 682);
            main_panel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 51);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1211, 682);
            Controls.Add(main_panel);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Digifender";
            Load += Form1_Load;
            panel5.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel5;
        private ContextMenuStrip contextMenuStrip1;
        private Panel main_panel;
        private Label title;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton homeIconBtn;
        private FontAwesome.Sharp.IconButton searchIconBtn;
        private FontAwesome.Sharp.IconButton fileScanIconBtn;
        private FontAwesome.Sharp.IconButton settingsIconBtn;
    }
}
