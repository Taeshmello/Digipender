namespace Digipender.ucPanel
{
    partial class fileScanScreen
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            fileIconPanel = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            fileStatus = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            fileIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 385);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(485, 381);
            button1.Name = "button1";
            button1.Size = new Size(96, 36);
            button1.TabIndex = 1;
            button1.Text = "파일 가져오기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
            button2.Location = new Point(587, 380);
            button2.Name = "button2";
            button2.Size = new Size(82, 37);
            button2.TabIndex = 2;
            button2.Text = "검사";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(fileIconPanel);
            panel1.Controls.Add(fileStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(7, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 585);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // fileIconPanel
            // 
            fileIconPanel.BackColor = Color.Transparent;
            fileIconPanel.Controls.Add(iconPictureBox1);
            fileIconPanel.Location = new Point(405, 206);
            fileIconPanel.Name = "fileIconPanel";
            fileIconPanel.Size = new Size(154, 174);
            fileIconPanel.TabIndex = 7;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.File;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 154;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(154, 174);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // fileStatus
            // 
            fileStatus.BackColor = Color.Transparent;
            fileStatus.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileStatus.ForeColor = Color.White;
            fileStatus.Location = new Point(358, 436);
            fileStatus.Name = "fileStatus";
            fileStatus.Size = new Size(258, 28);
            fileStatus.TabIndex = 6;
            fileStatus.Text = "파일을 가져와주세요.";
            fileStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Yu Gothic Medium", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 80);
            label2.Name = "label2";
            label2.Size = new Size(971, 52);
            label2.TabIndex = 5;
            label2.Text = "(파일 검사가 제대로 안 될 수도 있습니다. 혹시라도 찜찜하시면 프로그램을 재시작 해주세요...)";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(971, 80);
            label1.TabIndex = 4;
            label1.Text = "해당 파일에 있는 악성코드를 검사하고, 악성코드가 포함이 되어있다면 파일을 제거합니다.";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(16, 68);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(7);
            panel2.Size = new Size(985, 599);
            panel2.TabIndex = 4;
            // 
            // fileScanScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel2);
            Margin = new Padding(0);
            Name = "fileScanScreen";
            Size = new Size(1019, 682);
            Load += fileScanScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            fileIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label fileStatus;
        private Panel fileIconPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
