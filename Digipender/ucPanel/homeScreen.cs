using System;
using System.Drawing;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Digipender.ucPanel
{
    public partial class homeScreen : UserControl
    {
        private IWebDriver driver;

        public homeScreen()
        {
            InitializeComponent();

            // WebDriver 초기화
            InitializeWebDriver();

            // 폰트 설정
            BackColor = Color.FromArgb(33, 33, 33);
            richResult.BackColor = Color.FromArgb(45, 40, 40);
            panel1.BackColor = Color.FromArgb(45, 40, 40);
        }

        private void InitializeWebDriver()
        {
            // 크롬 드라이버 초기화
          try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");
                driver = new ChromeDriver(options);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"크롬 드라이버 초기화 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // 웹 페이지로 이동
                driver.Navigate().GoToUrl("https://m.boannews.com/html/search.html?search=%EC%82%AC%EA%B1%B4%EC%82%AC%EA%B3%A0&mtype=1&tab_type=3");

                // 결과를 RichTextBox에 표시
                DisplayResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults()
        {
            // XPath로 원하는 엘리먼트 선택
            var elements = driver.FindElements(By.XPath("/html/body/section[1]/ul[1]/li"));

            // RichTextBox 초기화
            richResult.Clear();

            richResult.AppendText("보안뉴스 \r\n\r\n");

            // 결과를 RichTextBox에 추가 (한 문단씩 떨어뜨리기)
            foreach (var element in elements)
            {
                // 기사 제목 텍스트 가져오기
                string title = element.Text.Trim();

                // 기사 URL 가져오기
                var linkElement = element.FindElement(By.XPath(".//a"));
                string url = linkElement.GetAttribute("href");

                // RichTextBox에 기사 제목 추가
                richResult.AppendText(title + Environment.NewLine);

                // RichTextBox에 기사 제목에 대한 클릭 이벤트 추가
                richResult.SelectionStart = richResult.Text.Length - (title.Length + 1);
                richResult.SelectionLength = title.Length;
                richResult.SelectionColor = Color.Blue;
                richResult.SelectionFont = new Font(richResult.Font, FontStyle.Underline);
                richResult.SelectionStart = richResult.Text.Length;
                richResult.SelectionLength = 0;
                richResult.SelectionColor = richResult.ForeColor;
                richResult.SelectionFont = new Font(richResult.Font, FontStyle.Regular);

                // 기사 제목에 클릭 이벤트 추가
                richResult.Click += (sender, e) =>
                {
                    // 기사 URL로 이동
                    System.Diagnostics.Process.Start(url);
                };

                richResult.AppendText(Environment.NewLine + Environment.NewLine);
            }
        }


        private void homeScreen_Load(object sender, EventArgs e)
        {
            // 폼이 로드될 때 WebDriver 초기화
            InitializeWebDriver();
        }

        // 폼이 닫힐 때 WebDriver 종료
        private void homeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver.Quit();
        }
    }
}
