using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Digipender.ucPanel
{
    public partial class fileScanScreen : UserControl
    {
        // VirusTotal API 키
        private const string VirustotalApiKey = "27cbcc64d8597c76e5b78f3508757237f2d1e4b11ffdcf7d848de2c4bb0ff533";

        public fileScanScreen()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            panel1.BackColor = System.Drawing.Color.FromArgb(45, 40, 40);
            panel2.BackColor = System.Drawing.Color.FromArgb(45, 40, 40);
        }

        private void fileScanScreen_Load(object sender, EventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(45, 40, 40);
            panel2.BackColor = System.Drawing.Color.FromArgb(45, 40, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 파일 선택 다이얼로그 열기
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.ShowDialog();

            if (openFileDlg.FileName.Length > 0)
            {
                textBox1.Text = openFileDlg.FileName;
                fileStatus.Text = "검사하기 버튼을 눌러주세요.";
                fileStatus.ForeColor = Color.White;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("파일을 먼저 선택해주세요");
                return;
            }

            try
            {
                using (var client = new HttpClient())
                {
                    var fileContent = new ByteArrayContent(File.ReadAllBytes(textBox1.Text));
                    fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    using (var formData = new MultipartFormDataContent())
                    {
                        formData.Add(fileContent, "file", Path.GetFileName(textBox1.Text));

                        client.DefaultRequestHeaders.Add("x-apikey", VirustotalApiKey);

                        using (var response = await client.PostAsync("https://www.virustotal.com/api/v3/files", formData))
                        {
                            response.EnsureSuccessStatusCode();
                            var responseBody = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(responseBody);

                            // 응답에서 분석 ID 추출
                            var analysisId = GetAnalysisIdFromResponse(responseBody);

                            // 얻은 ID를 사용하여 분석 결과 가져오기
                            await GetAnalysisResult(analysisId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private bool IsMalware(JObject result)
        {
            try
            {
                var stats = result["data"]["attributes"]["stats"] as JObject;

                if (stats != null)
                {
                    // 악성 코드 또는 의심스러운 감지 여부 확인
                    int maliciousCount = stats["malicious"]?.Value<int>() ?? 0;
                    int suspiciousCount = stats["suspicious"]?.Value<int>() ?? 0;

                    return maliciousCount > 0 || suspiciousCount > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking for malware: {ex.Message}");
                return false;
            }
        }

        // 응답에서 분석 ID 추출
        private string GetAnalysisIdFromResponse(string responseBody)
        {
            var json = JObject.Parse(responseBody);
            return json["data"]["id"].ToString();
        }

        // 분석 결과 가져오기
        private async Task GetAnalysisResult(string analysisId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://www.virustotal.com/api/v3/analyses/{analysisId}"),
                        Headers =
                        {
                            { "accept", "application/json" },
                            { "x-apikey", VirustotalApiKey },
                        },
                    };

                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Analysis Result Body: " + body);

                        var result = JObject.Parse(body);

                        if (IsMalware(result))
                        {
                            fileStatus.Text = "악성코드 감지";
                            fileStatus.ForeColor = Color.Red;

                            var confirmResult = MessageBox.Show("악성코드가 감지되었습니다. 파일을 지우시겠습니까?", "확인", MessageBoxButtons.YesNo);

                            if (confirmResult == DialogResult.Yes)
                            {
                                File.Delete(textBox1.Text);
                                MessageBox.Show("파일이 성공적으로 지워졌습니다.");
                                fileStatus.Text = "파일이 지워졌습니다.";
                                fileStatus.ForeColor = Color.Green;
                            }
                        }
                        else
                        {
                            MessageBox.Show("악성코드가 감지되지 않았습니다.");

                            fileStatus.Text = "파일이 안전합니다.";
                            fileStatus.ForeColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting analysis result: {ex.Message}");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
