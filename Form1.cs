using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VİZE3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yasananZaman;

            DateTime dogumTarihiGir = dateTimePicker1.Value;
            DateTime bugun = DateTime.Now;

            int farkYil = bugun.Year - dogumTarihiGir.Year;
            int farkAy = bugun.Month - dogumTarihiGir.Month;
            int farkGun = bugun.Day - dogumTarihiGir.Day;

            yasananZaman = (bugun - dogumTarihiGir).Days;
            textBox2.Text = yasananZaman.ToString() + " gün" + " " + "(" + farkYil + " yıl/" + farkAy + " ay/" + farkGun + " gün)";

            DateTime sonrakiDogumGunu;
            if (bugun.Month < dogumTarihiGir.Month || bugun.Month == dogumTarihiGir.Month && bugun.Day < dogumTarihiGir.Day)
            {
                sonrakiDogumGunu = new DateTime(bugun.Year, dogumTarihiGir.Month, dogumTarihiGir.Day);
            }
            else
            {
                sonrakiDogumGunu = new DateTime(bugun.Year + 1, dogumTarihiGir.Month, dogumTarihiGir.Day);
            }

            int kalanGun = (sonrakiDogumGunu - bugun).Days;
            textBox3.Text = kalanGun.ToString() + " gün";

            if (dogumTarihiGir.Month == 1 && dogumTarihiGir.Day >= 21 || dogumTarihiGir.Month == 2 && dogumTarihiGir.Day <= 19)
            {
                textBox1.Text = "Kova";
                textBox4.Text = "Arkadaş ve dost canlısı, sosyal, yenilikçi, sıradışı, marjinal";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\basak.jpg   ";
            }
            else if (dogumTarihiGir.Month == 2 && dogumTarihiGir.Day >= 20 || dogumTarihiGir.Month == 3 && dogumTarihiGir.Day <= 20)
            {
                textBox1.Text = "Balık";
                textBox4.Text = "Hassas, duyarlı, empatik, vicdanlı, duyarlı, sanatsal, hayırsever, yardımsever, kolay etkilenen";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\balik.jpg";
            }
            else if (dogumTarihiGir.Month == 3 && dogumTarihiGir.Day >= 21 || dogumTarihiGir.Month == 4 && dogumTarihiGir.Day <= 20)
            {
                textBox1.Text = "Koç";
                textBox4.Text = "Aktif, dinamik, insiyatif sahibi, hızlı, lider, yönetici";
                pictureBox1.ImageLocation = "C:\\C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\koc.jpg";
            }
            else if (dogumTarihiGir.Month == 4 && dogumTarihiGir.Day >= 21 || dogumTarihiGir.Month == 5 && dogumTarihiGir.Day <= 20)
            {
                textBox1.Text = "Boğa";
                textBox4.Text = "Güvenilir, rahatına, konforuna, yemeğe düşkün, gurme, harekete geçmekte zorlanan";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\boga.jpg";
            }
            else if (dogumTarihiGir.Month == 5 && dogumTarihiGir.Day >= 21 || dogumTarihiGir.Month == 6 && dogumTarihiGir.Day <= 21)
            {
                textBox1.Text = "İkizler";
                textBox4.Text = "Esnek, uyumlu, çevik, konuşkan, meraklı, arkadaş canlısı";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\ikizler.jpg";
            }
            else if (dogumTarihiGir.Month == 6 && dogumTarihiGir.Day >= 22 || dogumTarihiGir.Month == 7 && dogumTarihiGir.Day <= 22)
            {
                textBox1.Text = "Yengeç";
                textBox4.Text = "Evine, annesine, ailesine, yurduna düşkün, duyarlı, hassas, yemeğe, sofraya meraklı, tarihsel konulara ilgili, müzik yeteneğine sahip";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\yengec.jpg";
            }
            else if (dogumTarihiGir.Month == 7 && dogumTarihiGir.Day >= 23 || dogumTarihiGir.Month == 8 && dogumTarihiGir.Day <= 23)
            {
                textBox1.Text = "Aslan";
                textBox4.Text = "Özgüvenli, gururlu, mağrur, koruyan, kollayan, gösterişli, sanata, estetiğe düşkün";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\aslan.jpg";
            }
            else if (dogumTarihiGir.Month == 8 && dogumTarihiGir.Day >= 24 || dogumTarihiGir.Month == 9 && dogumTarihiGir.Day <= 23)
            {
                textBox1.Text = "Başak";
                textBox4.Text = "Titiz, çalışkan, mükemmeliyetçi, eleştirel, detaycı, emektar, hizmet odaklı";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\basak.jpg";
            }
            else if (dogumTarihiGir.Month == 9 && dogumTarihiGir.Day >= 24 || dogumTarihiGir.Month == 10 && dogumTarihiGir.Day <= 23)
            {
                textBox1.Text = "Terazi";
                textBox4.Text = "Adil, eşitlikçi, dengeli, uyumlu, sakin, sabırlı, akıllı, kibar";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\terazi.jpg";
            }
            else if (dogumTarihiGir.Month == 10 && dogumTarihiGir.Day >= 24 || dogumTarihiGir.Month == 11 && dogumTarihiGir.Day <= 22)
            {
                textBox1.Text = "Akrep";
                textBox4.Text = "Mücadeleci, güçlü, yılmaz, hırslı kişilerdir. Pes ettiğini düşündüğünüz anda küllerinden yeniden doğabilir. Güvenilir, kaliteli insanlardır.";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\akrep.jpg";
            }
            else if (dogumTarihiGir.Month == 11 && dogumTarihiGir.Day >= 23 || dogumTarihiGir.Month == 12 && dogumTarihiGir.Day <= 21)
            {
                textBox1.Text = "Yay";
                textBox4.Text = "Bağımsız, özgür, hareketli, dinamik, sportif, keşif ve macera ruhuna sahip";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\yay.jpg";
            }
            else if (dogumTarihiGir.Month == 12 && dogumTarihiGir.Day >= 22 || dogumTarihiGir.Month == 1 && dogumTarihiGir.Day <= 20)
            {
                textBox1.Text = "Oğlak";
                textBox4.Text = "Ciddi, soğukkanlı, gereğinde mesafeli, planlı, organize, disiplinli, iş ve kariyer odaklı";
                pictureBox1.ImageLocation = "C:\\Users\\user\\Desktop\\gorselprogramlama1\\VİZE3\\burç fotoğraflar\\oglak.jpg";
            }
        }
    }
}