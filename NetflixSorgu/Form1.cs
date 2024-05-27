using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixSorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }
        public async void InitBrowser()
        {
            await initialized();
            webView21.CoreWebView2.Navigate("https://www.netflix.com/tr/redeem");
        }
        Islemler islemler = new Islemler();
        private async Task initialized()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            islemler.KodlariEkle(this);
        }

       
        private async void btnIp_Click(object sender, EventArgs e)
        {
            lblIp.Text = "IP Sorgulanıyor ....";
            await islemler.IpAl(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            MouseOlaylari.SolMouseClick(375, 375);
            // listKodlar listbox'ındaki değeri alır
            string ilkSatir = listKodlar.Items[i].ToString();
            // Her bir karakteri tek tek yazdırır
            foreach (char karakter in ilkSatir)
            {
                SendKeys.Send(karakter.ToString());
            }
            // İşlem tamamlandıktan sonra listKodlar listesinden tıklanan öğeyi kaldırır
            listKodlar.Items.RemoveAt(i);

            // En son sorgula butonuna basar
            MouseOlaylari.SolMouseClick(365, 450);

        }

        private void btnKod_Click(object sender, EventArgs e)
        {
            // Butona tıklama işlemini gerçekleştir
            webView21.ExecuteScriptAsync("document.getElementsByClassName('btn btn-red btn-large')[0].click();");
        }


        private void btnSorgulamaSayfasi_Click(object sender, EventArgs e)
        {
            InitBrowser();
        }
    }
}
