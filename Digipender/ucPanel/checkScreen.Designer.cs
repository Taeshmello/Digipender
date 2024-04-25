namespace Digipender.ucPanel
{
    partial class checkScreen
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
            button1 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(430, 355);
            button1.Name = "button1";
            button1.Size = new Size(152, 34);
            button1.TabIndex = 3;
            button1.Text = "검사하기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(iconPictureBox1);
            panel3.Location = new Point(16, 68);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(7);
            panel3.Size = new Size(985, 599);
            panel3.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(331, 405);
            label1.Name = "label1";
            label1.Size = new Size(347, 35);
            label1.TabIndex = 5;
            label1.Text = "pc를 검사하여 악성코드를 찾아내 제거합니다.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            iconPictureBox1.ForeColor = Color.Red;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.VirusSlash;
            iconPictureBox1.IconColor = Color.Red;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 190;
            iconPictureBox1.Location = new Point(23, 180);
            iconPictureBox1.Margin = new Padding(0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(971, 190);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // checkScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel3);
            Name = "checkScreen";
            Size = new Size(1019, 682);
            Load += checkScreen_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
    }
}
