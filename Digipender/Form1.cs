namespace Digipender
{
    public partial class Form1 : Form
    {

        

        // 화면들을 한 번만 생성하도록 수정
        ucPanel.homeScreen sc1;
        ucPanel.checkScreen sc2;
        ucPanel.fileScanScreen sc3;
        ucPanel.settingScreen sc4;

        public Form1()
        {
            InitializeComponent();



            // 생성자에서 화면들을 초기화
            sc1 = new ucPanel.homeScreen();
            sc2 = new ucPanel.checkScreen();
            sc3 = new ucPanel.fileScanScreen();
            sc4 = new ucPanel.settingScreen();

            this.MaximizeBox = false;

            // Remove minimize button (optional)
            // this.MinimizeBox = false;





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  main_panel.BackColor = Color.FromArgb(45, 40, 40);


          


            main_panel.BackColor = Color.White;

            main_panel.Controls.Add(sc1);
            main_panel.Controls.Add(sc4);
            main_panel.Controls.Add(sc3);
            main_panel.Controls.Add(sc2);
            panel5.BackColor = Color.FromArgb(16, 16, 16);
            homeIconBtn.BackColor = Color.FromArgb(16, 16, 16);
            searchIconBtn.BackColor = Color.FromArgb(16, 16, 16);
            fileScanIconBtn.BackColor = Color.FromArgb(16, 16, 16);
            settingsIconBtn.BackColor = Color.FromArgb(16, 16, 16);
            panel1.BackColor = Color.FromArgb(16, 16, 16);

           

        }




        // 모든 스크린을 숨기는 도우미 메서드
        private void HideAllScreens()
        {
            sc1.Visible = false;
            sc2.Visible = false;
            sc3.Visible = false;
            sc4.Visible = false;
        }

        private void homeIconBtn_Click(object sender, EventArgs e)
        {
            HideAllScreens();
            Console.WriteLine("Home Button Clicked");
            sc1.Visible = true;
            title.Text = "Home";
        }

        private void searchIconBtn_Click(object sender, EventArgs e)
        {
            HideAllScreens();
            Console.WriteLine("Check Button Clicked");
            sc2.Visible = true;
            title.Text = "Scan";
        }

        private void fileScanIconBtn_Click(object sender, EventArgs e)
        {
            HideAllScreens();
            Console.WriteLine("File Scan Button Clicked");
            sc3.Visible = true;
            title.Text = "File Scan";
        }

        private void settingsIconBtn_Click(object sender, EventArgs e)
        {
            HideAllScreens();
            Console.WriteLine("Settings Button Clicked");
            sc4.Visible = true;
            title.Text = "Settings";
        }

        
    }
}
