namespace Digipender.ucPanel
{
    partial class homeScreen
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
            richResult = new RichTextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richResult
            // 
            richResult.BackColor = Color.MintCream;
            richResult.BorderStyle = BorderStyle.None;
            richResult.Dock = DockStyle.Fill;
            richResult.Font = new Font("Yu Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richResult.ForeColor = Color.White;
            richResult.Location = new Point(7, 7);
            richResult.Name = "richResult";
            richResult.ReadOnly = true;
            richResult.Size = new Size(971, 585);
            richResult.TabIndex = 0;
            richResult.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(richResult);
            panel1.Location = new Point(16, 68);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(7);
            panel1.Size = new Size(985, 599);
            panel1.TabIndex = 1;
            // 
            // homeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "homeScreen";
            Size = new Size(1019, 682);
            Load += homeScreen_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private RichTextBox richResult;
        private Panel panel1;
    }
}
