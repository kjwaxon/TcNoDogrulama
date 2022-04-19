using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * Web servisler http protokolünü kullanarak hizmet sağlarlar.
             * İstemci yani client istek atar ve bir geri dönüş gerçekleşir.
             * Bu geri dönüşte kullanılan servise göre xml,json vb yapılar kullanılır.
             * Ve bilgi alışverişi sağlanmış olur.
             * Burada textboxlar üzerinden girilen veriler alınıp sorgulama yapılır ve geri dönüş olarak true ya da false bir değer döndürdük.
             * Ayrıca projemize add service diyerek referansımızı ekledik.
             */
            long kimlikno = long.Parse(txt_tc.Text);
            int yıl = int.Parse(txt_year.Text);
            bool durum;

            try
            {
                using (KSPTC.KPSPublicSoapClient service = new KSPTC.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikno, txt_name.Text, txt_surname.Text, yıl);
                }
            }

            catch (Exception)
            {
                throw;
            }
            MessageBox.Show(durum.ToString());
        }
    }
    }

