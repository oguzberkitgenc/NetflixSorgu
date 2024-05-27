using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixSorgu
{
    public class Islemler
    {
        public void KodlariEkle(Form1 form)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFile.FileName;

                try
                {
                    if (File.Exists(dosyaYolu))
                    {
                        using (StreamReader sr = new StreamReader(dosyaYolu))
                        {
                            string satir;
                            while ((satir = sr.ReadLine()) != null)
                            {
                                form.listKodlar.Items.Add(satir);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dosya bulunamadı");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya okunurken bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Dosya seçilmedi");
            }
        }
        public async Task IpAl(Form1 form)
        {
            try
            {
                 HttpClient client = new HttpClient();
                string ipAddress;
                string countryName;
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
               form.lblIp.Text = ipAddress + " " + countryName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
    }
}

