namespace Digipender.ucPanel
{
    partial class settingScreen
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
            label1 = new Label();
            checkBox1Toggle = new CheckBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(353, 77);
            label1.Name = "label1";
            label1.Size = new Size(143, 31);
            label1.TabIndex = 12;
            label1.Text = "실시간 분석";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBox1Toggle
            // 
            checkBox1Toggle.AutoSize = true;
            checkBox1Toggle.BackColor = Color.Transparent;
            checkBox1Toggle.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            checkBox1Toggle.ForeColor = Color.White;
            checkBox1Toggle.Location = new Point(484, 76);
            checkBox1Toggle.Name = "checkBox1Toggle";
            checkBox1Toggle.Size = new Size(114, 31);
            checkBox1Toggle.TabIndex = 13;
            checkBox1Toggle.Text = "예/아니요";
            checkBox1Toggle.UseVisualStyleBackColor = false;
            checkBox1Toggle.CheckedChanged += checkBox1Toggle_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkBox1Toggle);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 68);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(7);
            panel1.Size = new Size(982, 599);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.BottomLeft;
            label4.Location = new Point(7, 516);
            label4.Name = "label4";
            label4.Size = new Size(968, 30);
            label4.TabIndex = 18;
            label4.Text = "Developed by:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 546);
            label3.Name = "label3";
            label3.Size = new Size(968, 23);
            label3.TabIndex = 17;
            label3.Text = "김태윤(Github: git_taeyoon)";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 569);
            label2.Name = "label2";
            label2.Size = new Size(968, 23);
            label2.TabIndex = 16;
            label2.Text = "김태호(Github: Taeshmello)";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(303, 118);
            label5.Name = "label5";
            label5.Size = new Size(244, 31);
            label5.TabIndex = 19;
            label5.Text = "라이트 모드";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(482, 116);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 20;
            button1.Text = "ON/OFF";
            button1.UseVisualStyleBackColor = false;
            // 
            // settingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "settingScreen";
            Size = new Size(1019, 682);
            Load += settingScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private CheckBox checkBox1Toggle;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel linkLabel2;
        private Label label5;
        private Button button1;
    }
}
