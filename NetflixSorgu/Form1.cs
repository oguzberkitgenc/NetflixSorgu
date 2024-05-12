using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace NetflixSorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBrowser("https://www.netflix.com/tr/redeem");
            IpAl();
        }
      
        static HttpClient client = new HttpClient();
        string ipAddress;
        string countryName;
        private async Task IpAl()
        {
            try
            {
                //Ip adresini web üzerinden çek
                ipAddress = await client.GetStringAsync("http://icanhazip.com");
                ipAddress = ipAddress.Trim();

                // Ip konumlarımda servisine sorgu yap
                string apiUrl = $"http://ip-api.com/json/{ipAddress}";

                string jsonResult = await client.GetStringAsync(apiUrl);

                //JSON verisini ayrıştır
                JObject resultObject = JObject.Parse(jsonResult);

                //Ülke Bilgisini Al
                countryName = (string)resultObject["country"];

                //sonucu yazdır
                //  lblIp.Invoke((MethodInvoker)(() => lblIp.Text = ipAddress + " " + countryName));
                lblIp.Text = ipAddress + " " + countryName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InitializeBrowser(string webAdress)
        {
            webView21.Source = new Uri(webAdress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnNetflix_Click(object sender, EventArgs e)
        {
            InitializeBrowser("https://www.netflix.com/tr/redeem");
        }
       
        private async void btnIp_Click(object sender, EventArgs e)
        {
            lblIp.Text = "IP Sorgulanıyor ....";
            IpAl();
        }
        private void btnGoogle_Click(object sender, EventArgs e)
        {
            InitializeBrowser("https://www.google.com");
        }
        private  void btnCerez_Click(object sender, EventArgs e)
        {
         
        }
    }
}
