using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class YapaySinirAgi
    {
        private double momentumK;
        private double ogrenmeK;
        private double girilenHata;
        private int[] girilenDizi;

        private int[,] veriler =
        {
            {
            1,1,1,1,1,
            1,0,0,0,1,
            1,0,0,0,1,
            1,1,1,1,1,
            1,0,0,0,1,
            1,0,0,0,1,
            1,0,0,0,1,
             },
            {
            1,1,1,1,0,
            1,0,0,0,1,
            1,0,0,0,1,
            1,1,1,1,0,
            1,0,0,0,1,
            1,0,0,0,1,
            1,1,1,1,0,
            },
            {
            1,1,1,1,1,
            1,0,0,0,0,
            1,0,0,0,0,
            1,0,0,0,0,
            1,0,0,0,0,
            1,0,0,0,0,
            1,1,1,1,1,
            },
            {
            1,1,1,1,0,
            1,0,0,0,1,
            1,0,0,0,1,
            1,0,0,0,1,
            1,0,0,0,1,
            1,0,0,0,1,
            1,1,1,1,0,
            },
            {
            1,1,1,1,1,
            1,0,0,0,0,
            1,0,0,0,0,
            1,1,1,1,1,
            1,0,0,0,0,
            1,0,0,0,0,
            1,1,1,1,1,
            }

        };
        public double MomentumK { get => momentumK; set => momentumK = value; }
        public double OgrenmeK { get => ogrenmeK; set => ogrenmeK = value; }
        public double GirilenHata { get => girilenHata; set => girilenHata = value; }
        public int[] GirilenDizi { get => girilenDizi; set => girilenDizi = value; }
        public double[,] GirisAgirliklari { get => girisAgirliklari; set => girisAgirliklari = value; }
        public double[] AraKatmanEsik { get => araKatmanEsik; set => araKatmanEsik = value; }
        public double[] CikisKatmanEsik { get => cikisKatmanEsik; set => cikisKatmanEsik = value; }
        public double[] CikisAgirliklari { get => cikisAgirliklari; set => cikisAgirliklari = value; }
        public int[,] Veriler { get => veriler; set => veriler = value; }
        public double[,] AraKatman { get => araKatman; set => araKatman = value; }
        public double Hata { get => hata; set => hata = value; }
        public double Cikti { get => cıktı; set => cıktı = value; }
        public double Net { get => net; set => net = value; }
        public double[] Sigma { get => sigma; set => sigma = value; }
        public bool A { get => a; set => a = value; }
        public int[] Yerinde { get => yerinde; set => yerinde = value; }
        public int Index { get => index; set => index = value; }

        public double[,] GirisAgirliklariDosyadan { get => girisAgirliklariDosyadan; set => girisAgirliklariDosyadan = value; }
        public double[] AraKatmanEsikAgirliklariDosyadan { get => araKatmanEsikAgirliklariDosyadan; set => araKatmanEsikAgirliklariDosyadan = value; }
        public double[] CikisKatmanEsikAgirliklariDosyadan { get => cikisKatmaniEsikAgirliklariDosyadan; set => cikisKatmaniEsikAgirliklariDosyadan = value; }
        public double[] CikisAgirliklariDosyadan { get => cikisAgirliklariDosyadan; set => cikisAgirliklariDosyadan = value; }
        public string[] GirisAgirlik { get => girisAgirlik; set => girisAgirlik = value; }
        public string[] CikisAgirlik { get => cikisAgirlik; set => cikisAgirlik = value; }
        public string[] AraKatmanEsikAgirlik { get => araKatmanEsikAgirlik; set => araKatmanEsikAgirlik = value; }
        public string[] CikisKatmaniEsikAgirlik { get => cikisKatmaniEsikAgirlik; set => cikisKatmaniEsikAgirlik = value; }

        public YapaySinirAgi(double momentumK, double ogrenmeK, double girilenHata)
        {
            this.momentumK = momentumK;
            this.ogrenmeK = ogrenmeK;
            this.girilenHata = girilenHata;

        }
        public YapaySinirAgi()
        {
            GirisAgirliklari = new double[35, 3];
            AraKatmanEsik = new double[3];
            CikisKatmanEsik = new double[5];
            CikisAgirliklari = new double[3];
            Veriler = new int[5, 35];
            GirilenDizi = new int[35];

        }

        public void harfiMatriseCevir(Button[] btn)
        {
            GirilenDizi = new int[35];
            for (int i = 0; i < 35; i++)
            {

                if (btn[i].BackColor == Color.Black)
                {
                    GirilenDizi[i] = 1;
                }
                else if (btn[i].BackColor == Color.White)
                {
                    GirilenDizi[i] = 0;
                }
            }
        }


        private double[,] girisAgirliklari;
        private double[] araKatmanEsik;
        private double[] cikisKatmanEsik;
        private double[] cikisAgirliklari;
        public void randomAgirlikHesabı()
        {
            List<double> girisAgirliklariListesi = new List<double>();
            List<double> cikisAgirliklariListesi = new List<double>();
            List<double> araKatmanEsikAgirliklariListesi = new List<double>();
            List<double> cikisKatmanEsikAgirligi = new List<double>();


            girisAgirliklari = new double[3, 35];
            araKatmanEsik = new double[3];
            cikisKatmanEsik = new double[1];
            CikisAgirliklari = new double[3];
            Random rnd = new Random();
            Thread.Sleep(500);
            Random rnd1 = new Random();
            Thread.Sleep(500);
            Random rnd2 = new Random();
           

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 35; j++)
                {
                    double giris = rnd.NextDouble();

                    giris = Math.Round(giris, 2);
                    GirisAgirliklari[i, j] = giris;
                    girisAgirliklariListesi.Add(GirisAgirliklari[i, j]);
                }

            }
            // giriş ağırlıkları belirlendi. heri girişten 3 tane parça çıkacağı için
            // 3x35
         

            for (int i = 0; i < 4; i++)
            {
                double esik = rnd1.NextDouble();

                esik = Math.Round(esik, 2);
                if (i < 3)
                {
                    AraKatmanEsik[i] = esik;
                    araKatmanEsikAgirliklariListesi.Add(AraKatmanEsik[i]);
                }
                else if (i >= 3)
                {
                    CikisKatmanEsik[i - 3] = esik;
                    cikisKatmanEsikAgirligi.Add(CikisKatmanEsik[i - 3]);
                }
            }
            // eşik ağırlıkları belirlendi.  eşik1 ara katmanın eşik 1 in 3 tane, eşik 2 çıkışın eşik 2 nin 1 tane.

            for (int i = 0; i < 3; i++)
            {

                double cıktı = rnd2.NextDouble();

                cıktı = Math.Round(cıktı, 2);

                CikisAgirliklari[i] = cıktı;
                cikisAgirliklariListesi.Add(CikisAgirliklari[i]);

            }
            // çıkış ağırlıkları belirlendi. ara dan 3 tane parça gelecek.

            using (StreamWriter writer = new StreamWriter("giris_katmani_agirliklari.txt"))
            {
                foreach (double line in girisAgirliklariListesi)
                {
                    writer.WriteLine(line.ToString());
                }
            }

            using (StreamWriter writer = new StreamWriter("ara_katmani_esik_agirliklari.txt"))
            {
                foreach (double line in araKatmanEsikAgirliklariListesi)
                {
                    writer.WriteLine(line.ToString());
                }
            }
            using (StreamWriter writer = new StreamWriter("cikis_katmani_esik_agirliklari.txt"))
            {
                foreach (double line in cikisKatmanEsikAgirligi)
                {
                    writer.WriteLine(line.ToString());
                }
            }

            using (StreamWriter writer = new StreamWriter("cikis_katmani_agirliklari.txt"))
            {
                foreach (double line in cikisAgirliklariListesi)
                {
                    writer.WriteLine(line.ToString());
                }
            }
        }
        private double[,] girisAgirliklariDosyadan;
        private double[] araKatmanEsikAgirliklariDosyadan;
        private double[] cikisKatmaniEsikAgirliklariDosyadan;
        private double[] cikisAgirliklariDosyadan;
        private string[] girisAgirlik;
        private string[] cikisAgirlik;
        private string[] araKatmanEsikAgirlik;
        private string[] cikisKatmaniEsikAgirlik;
        public void agirliklariDosyadanAl()
        {
            girisAgirliklariDosyadan = new double[3, 35];
            cikisAgirliklariDosyadan = new double[3];
            araKatmanEsikAgirliklariDosyadan = new double[3];
            cikisKatmaniEsikAgirliklariDosyadan = new double[1];

            girisAgirlik = File.ReadAllLines("giris_katmani_agirliklari.txt");
            cikisAgirlik = File.ReadAllLines("cikis_katmani_agirliklari.txt");
            araKatmanEsikAgirlik = File.ReadAllLines("ara_katmani_esik_agirliklari.txt");
            cikisKatmaniEsikAgirlik = File.ReadAllLines("cikis_katmani_esik_agirliklari.txt");

            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 35; j++)
                {
                    if (girisAgirlik != null)
                    {
                        GirisAgirliklariDosyadan[i, j] = double.Parse(girisAgirlik[index]);
                        index++;
                    }

                }

            }

            for (int i = 0; i < 4; i++)
            {
                if (i < 3)
                {
                    if (araKatmanEsikAgirlik != null)
                    {
                    AraKatmanEsikAgirliklariDosyadan[i] = double.Parse(araKatmanEsikAgirlik[i]);

                    }

                }
                else if (i >= 3)
                {
                    if (cikisKatmaniEsikAgirlik != null)
                    {
                    CikisKatmanEsikAgirliklariDosyadan[i - 3] = double.Parse(cikisKatmaniEsikAgirlik[i - 3]);

                    }

                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (cikisAgirlik != null)
                {
                CikisAgirliklariDosyadan[i] = double.Parse(cikisAgirlik[i]);

                }
            }
        }

        private int[] yerinde;
        private int index;
        public void harfTespiti()
        {
            // harf tespiti burada yapılır. girilen matrise göre A girilirse yerindeminin sayisi 35 olur.

            yerinde = new int[5];
            int harfYerindemi = 0;
            for (int i = 0; i < 5; i++)
            {
                harfYerindemi = 0;
                for (int j = 0; j < 35; j++)
                {
                    if (GirilenDizi[j] == Veriler[i, j])
                    {
                        harfYerindemi++;
                    }

                }

                yerinde[i] = harfYerindemi;
            }

            for (int i = 0; i < 5; i++)
            {
                if (yerinde[i] == 35)
                {
                    Index = i;
                    return;

                }
                else
                {
                    Index = -1;
                    // tam eşleşmeyen varsa Index -1 olur.
                }



            }
        }

        private double[,] araKatman;
        private double hata;
        private double cıktı;
        private double net;
        public void ileriHesaplama(int[] girilenDizi, double[,] girisAgirliklari, double[] cikisAgirliklari, double[] araKatmanEsik, double[] cikisKatmaniEsik)
        {
            araKatman = new double[3, 2];
            Net = 0;
            Cikti = 0;
            Hata = 0;
            double gecici = 0;
            for (int i = 0; i < 3; i++)
            {
                gecici = 0;
                for (int j = 0; j < 35; j++)
                {
                    gecici += girilenDizi[j] * girisAgirliklari[i, j];
                }
                gecici += gecici + araKatmanEsik[i];
                araKatman[i, 1] = (1 / (1 + Math.Exp(-gecici))); // sigmoid
            }

            // MessageBox.Show(araKatman.Length.ToString());


            for (int i = 0; i < 3; i++)
            {
                Net += AraKatman[i, 1] * cikisAgirliklari[i];
            }

            double sonuc = Net + cikisKatmaniEsik[0];
            Cikti = (1 / (1 + Math.Exp(-sonuc)));
            Hata = 1 - Cikti;
            // beklenen - çıktı
            // MessageBox.Show(Cıktı.ToString());
            // MessageBox.Show(Hata.ToString());

        }
      
        
        private double[] sigma;

        private bool a;
        public void geriyeHesaplama(double[,] girisAgirliklari, double[] cikisAgirliklari, double[] araKatmanEsik, double[] cikisKatmanEsik, double[,] araKatman, int delta)
        {

            sigma = new double[3];
            A = true;

            while (A == true)
            {
                double dagitilacakHata = Cikti * (1 - Cikti) * Hata;
                // çıkış katmanı için dağıtılacak hatanın hesaplanması

                for (int i = 0; i < 3; i++)
                {
                    cikisAgirliklari[i] = cikisAgirliklari[i] + ((OgrenmeK * dagitilacakHata * araKatman[i, 1]) + MomentumK * delta);
                } // çıkışların ağırlıklarını güncelleme
                  // ((OgrenmeK * dagitilacakHata * araKatman[i, 1]) + MomentumK * delta) -> ağırlıkların değişim miktarını
                  // hesaplama 

                cikisKatmanEsik[0] = cikisKatmanEsik[0] + ((OgrenmeK * dagitilacakHata * 1) + MomentumK * delta);
                // eşik2nin ağırlıklarını güncelleme

                for (int i = 0; i < 3; i++)
                {
                    sigma[i] = AraKatman[i, 1] * (1 - AraKatman[i, 1]) * cikisAgirliklari[i] * dagitilacakHata;
                    // ara katmandan hücrelere dağıtılacak hata hesabı
                    // AraKatman[i, 1] * (1 - AraKatman[i, 1]) * CikisAgirliklari[i] * dagitilacakHata -> formül
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 35; j++)
                    {
                        girisAgirliklari[i, j] = girisAgirliklari[i, j] + ((OgrenmeK * sigma[i] * girisAgirliklari[i, j]) + MomentumK * delta);
                    }
                }  // girişlerin ağırlıklarını güncelleme
                // ((OgrenmeK * sigma[i] * girisAgirliklari[i, j]) + MomentumK * delta) -> giriş-ara katman arası ağırlık hesabı
                for (int i = 0; i < 3; i++)
                {
                    araKatmanEsik[i] = araKatmanEsik[i] + ((OgrenmeK * sigma[i] * 1) + MomentumK * delta);
                    // eşik1in ağırlıklarını güncelleme
                }
   
            

                ileriHesaplama(GirilenDizi, GirisAgirliklari, CikisAgirliklari, AraKatmanEsik, CikisKatmanEsik);


                if (Hata < GirilenHata)
                {
                    A = false;


                }
            }
        }

      
        public void eslesmeyenIcinIleriHesabi(int[,] veriler, double[,] girisAgirliklari, double[] cikisAgirliklari, double[] araKatmanEsik, double[] cikisKatmanEsik, int a)
        {
            araKatman = new double[3, 2];
            Net = 0;
            Cikti = 0;
            Hata = 0;
            double gecici = 0;
            for (int i = 0; i < 3; i++)
            {
                gecici = 0;
                for (int j = 0; j < 35; j++)
                {
                    gecici += veriler[a, j] * girisAgirliklari[i, j];
                }
                gecici += gecici + araKatmanEsik[i];
                araKatman[i, 1] = (1 / (1 + Math.Exp(-gecici)));

            }

            // MessageBox.Show(araKatman.Length.ToString());


            for (int i = 0; i < 3; i++)
            {
                Net += AraKatman[i, 1] * cikisAgirliklari[i];
            }

            double sonuc = Net + cikisKatmanEsik[0];
            Cikti = (1 / (1 + Math.Exp(-sonuc)));
            Hata = 0 - Cikti;

            // MessageBox.Show(Cıktı.ToString());
            // MessageBox.Show(Hata.ToString());

        }

        public void eslesmeyenIcinGeriHesabi(double[,] girisAgirliklari, double[] cikisAgirliklari, double[] araKatmanEsik, double[] cikisKatmanEsik, double[,] araKatman, int delta)
        {
            sigma = new double[3];
            A = true;


            while (A == true)
            {

                double dagitilacakHata = Cikti * (1 - Cikti) * Hata;
                for (int i = 0; i < 3; i++)
                {
                    cikisAgirliklari[i] = cikisAgirliklari[i] + ((OgrenmeK * dagitilacakHata * araKatman[i, 1]) + MomentumK * delta);
                }
                cikisKatmanEsik[0] = cikisKatmanEsik[0] + ((OgrenmeK * dagitilacakHata * 1) + MomentumK * delta);

                for (int i = 0; i < 3; i++)
                {
                    sigma[i] = AraKatman[i, 1] * (1 - AraKatman[i, 1]) * cikisAgirliklari[i] * dagitilacakHata;
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 35; j++)
                    {
                        girisAgirliklari[i, j] = girisAgirliklari[i, j] + ((OgrenmeK * sigma[i] * girisAgirliklari[i, j]) + MomentumK * delta);
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    araKatmanEsik[i] = araKatmanEsik[i] + ((OgrenmeK * sigma[i] * 1) + MomentumK * delta);
                }
               

                eslesmeyenIcinIleriHesabi(Veriler, GirisAgirliklari, CikisAgirliklari, AraKatmanEsik, CikisKatmanEsik, delta);

                if (Hata < GirilenHata)
                {
                    A = false;

                }
            }

        }
       
    }
}
