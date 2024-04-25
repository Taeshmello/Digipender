using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digipender.ucPanel
{
    public partial class settingScreen : UserControl
    {
        // 토글 버튼 상태를 저장하는 변수
        private bool isCheckBoxChecked;

        public settingScreen()
        {
            InitializeComponent();
            isCheckBoxChecked = false; // 초기값은 꺼짐으로 설정
            BackColor = Color.FromArgb(33, 33, 33);
        }

        private void title_Click(object sender, EventArgs e)
        {
            // 다른 코드...
        }

        private void settingScreen_Load(object sender, EventArgs e)
        {
            // 다른 코드...
            panel1.BackColor = Color.FromArgb(45, 40, 40);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1Toggle_CheckedChanged(object sender, EventArgs e)
        {
            // 토글 버튼의 상태에 따라 다른 동작 수행
            if (checkBox1Toggle.Checked)
            {
                // 체크된 상태에서 수행할 동작
            }
            else
            {
                // 체크되지 않은 상태에서 수행할 동작
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLInk();
            }
            catch (Exception ex)
            {
                Console.WriteLine("링크 못 들어감");
            }

        }


        private void VisitLInk()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/");
        }
    }
}
