using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digipender.ucPanel
{
    public partial class checkScreen : UserControl
    {
        public checkScreen()
        {
            InitializeComponent();

            BackColor = Color.FromArgb(33, 33, 33);



        }



        private void checkScreen_Load(object sender, EventArgs e)
        {

            panel3.BackColor = Color.FromArgb(45, 40, 40);
            iconPictureBox1.BackColor = Color.FromArgb(45, 40, 40);

        }



        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


}

