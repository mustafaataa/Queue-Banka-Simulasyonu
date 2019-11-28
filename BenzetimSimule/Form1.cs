using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenzetimSimule
{
    public partial class Form1 : Form
    {

        Queue<Kuyruk> gelenler = new Queue<Kuyruk>();
        Random rastgele = new Random();
        int gelsinMi;
        int kackisigelsin;
        int isSuresiRandom;
        double saniye = 0;
        double toplambekleme = 0;
        bool yenikisiGeldiMi = true;
        double ToplamKisiSayisi = 0;
        double KuyruktakiMusteriSayisi = 0;
        double SistemdekiKisiSayisi = 0;
        double SistemdekiOrtlamaKisiSayisi = 0;
        double KuyruktakikisiSayisi = 0;
        double IsSureleriToplami = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Sistem.Enabled = true;
            Hesap.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            this.chart1.Series["Series1"].Points.AddXY(saniye, SistemdekiKisiSayisi.ToString());
            if (saniye == 20)
            {
                timer1.Enabled = false;
                Sistem.Enabled = false;
                KuyruktakiOrtalamaBeklemeSuresi();
                KuyruktakiOrtalamaMusteriSayisi();
                SistemdekiOrtlamaMusteriSayisi();
                SistemdekiOrtalamaBeklemeZamani();

            }
            else
            {

                gelsinMi = rastgele.Next(0, 100);
                if (gelsinMi < 25)
                {
                    kackisigelsin = rastgele.Next(0, 10);
                    if (kackisigelsin < 5)//bir kisi geldiği durum
                    {
                        isSuresiRandom = rastgele.Next(1, 5);
                        gelenler.Enqueue(new Kuyruk() { gelmeZamani = saniye, isZamani = isSuresiRandom });
                        ToplamKisiSayisi++;
                        SistemdekiKisiSayisi++;
                        IsSureleriToplami += isSuresiRandom;
                    }
                    else if (kackisigelsin >= 5 && kackisigelsin < 7)//iki geldı
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            isSuresiRandom = rastgele.Next(1, 5);
                            gelenler.Enqueue(new Kuyruk() { gelmeZamani = saniye, isZamani = isSuresiRandom });
                            ToplamKisiSayisi++;
                            SistemdekiKisiSayisi++;
                            IsSureleriToplami += isSuresiRandom;
                        }
                    }
                    else if (kackisigelsin >= 7 && kackisigelsin < 9)//uc geldı
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            isSuresiRandom = rastgele.Next(1, 5);
                            gelenler.Enqueue(new Kuyruk() { gelmeZamani = saniye, isZamani = isSuresiRandom });
                            ToplamKisiSayisi++;
                            SistemdekiKisiSayisi++;
                            IsSureleriToplami += isSuresiRandom;
                        }
                    }
                    else//dort geldı
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            isSuresiRandom = rastgele.Next(1, 5);
                            gelenler.Enqueue(new Kuyruk() { gelmeZamani = saniye, isZamani = isSuresiRandom });
                            ToplamKisiSayisi++;
                            SistemdekiKisiSayisi++;
                            IsSureleriToplami += isSuresiRandom;
                        }
                    }
                }
            }

        }

       

        public void KuyruktakiOrtalamaMusteriSayisi()
        {
            kuyruktakiOrtElemanSayisi.Text = (KuyruktakikisiSayisi / saniye) + "";
        }
        public void SistemdekiOrtlamaMusteriSayisi()
        {
            SisOrtKisi.Text = (SistemdekiOrtlamaKisiSayisi / saniye) + "";

        }
        public void KuyruktakiOrtalamaBeklemeSuresi()
        {
            OrtalamaKuyruk.Text = (toplambekleme / ToplamKisiSayisi) + "";
        }
        public void SistemdekiOrtalamaBeklemeZamani()
        {//vezne
            SisOrtBekSuresi.Text = ((toplambekleme + IsSureleriToplami) / ToplamKisiSayisi) + "";
        }
      

        private void Sistem_Tick_1(object sender, EventArgs e)
        {
            foreach (var item in gelenler)
            {
                if (yenikisiGeldiMi)
                {
                    toplambekleme += saniye - item.gelmeZamani;
                    yenikisiGeldiMi = false;
                }

                item.isZamani--;

                if (item.isZamani == 0)
                {
                    gelenler.Dequeue();
                    SistemdekiKisiSayisi--;
                    yenikisiGeldiMi = true;
                }
                break;
            }
        }

        private void Hesap_Tick_1(object sender, EventArgs e)
        {
            SistemdekiOrtlamaKisiSayisi += SistemdekiKisiSayisi;
            if (SistemdekiKisiSayisi != 0)
            {
                KuyruktakikisiSayisi += SistemdekiKisiSayisi - 1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].Points.AddXY(saniye, SistemdekiKisiSayisi.ToString());

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
