using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        YapaySinirAgi ysa;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ysa = new YapaySinirAgi();
            buttonHesapla.Enabled = false;
            buttonTemizle.Enabled = false;
            buttonDosyadanAl.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Black;
            }
            else if (btn.BackColor == Color.Black)
            {
                btn.BackColor = Color.White;
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Button[] btn = {
                button1,  button2,  button3,  button4,  button5,
                button6,  button7,  button8,  button9,  button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20 ,
                button21, button22, button23, button24, button25 ,
                button26, button27, button28, button29, button30 ,
                button31, button32, button33, button34, button35 ,
                  };
            for (int i = 0; i < 35; i++)
            {

                if (btn[i].BackColor == Color.Black)
                {
                    btn[i].BackColor = Color.White;
                }
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


            Array.Clear(ysa.GirisAgirliklari, 0, ysa.GirisAgirliklari.Length);
            // 0 dan itibaren diziyi temizler.
            Array.Clear(ysa.CikisAgirliklari, 0, ysa.CikisAgirliklari.Length);
            Array.Clear(ysa.GirilenDizi, 0, ysa.GirilenDizi.Length);
            Array.Clear(ysa.AraKatmanEsik, 0, ysa.AraKatmanEsik.Length);
            Array.Clear(ysa.CikisKatmanEsik, 0, ysa.CikisKatmanEsik.Length);
            Array.Clear(ysa.AraKatman, 0, ysa.AraKatman.Length);

            //Array.Clear(ysa.GirisAgirliklariDosyadan, 0, ysa.GirisAgirliklariDosyadan.Length);
            //Array.Clear(ysa.AraKatmanEsikAgirliklariDosyadan, 0, ysa.AraKatmanEsikAgirliklariDosyadan.Length);
            //Array.Clear(ysa.CikisKatmanEsikAgirliklariDosyadan, 0, ysa.CikisKatmanEsikAgirliklariDosyadan.Length);
            //Array.Clear(ysa.CikisAgirliklariDosyadan, 0, ysa.CikisAgirliklariDosyadan.Length);

            buttonTemizle.Enabled = false;
        }

        private void buttonTanýmla_Click(object sender, EventArgs e)
        {
            Button[] btn = {
                button1,  button2,  button3,  button4,  button5,
                button6,  button7,  button8,  button9,  button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20 ,
                button21, button22, button23, button24, button25 ,
                button26, button27, button28, button29, button30 ,
                button31, button32, button33, button34, button35 ,
                  };
            ysa = new YapaySinirAgi(Convert.ToDouble(numericUpDown3.Value), Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(numericUpDown1.Value));
            ysa.harfiMatriseCevir(btn);
            ysa.randomAgirlikHesabý();
            buttonHesapla.Enabled = true;
            buttonTanýmla.Enabled = false;
            buttonTemizle.Enabled = false;
            buttonDosyadanAl.Enabled = true;
        }
        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            TextBox[] textBox =
            {
                textBox1,textBox2,textBox3,textBox4,textBox5
             };
            ysa.harfTespiti();

            for (int i = 0; i < 5; i++)
            {
                // A B C D E HARFLERÝ ÝÇÝN TARAMA YAPAR.

                if (ysa.Index == i)
                {
                    //MessageBox.Show("ÝNDEX"+ysa.Index.ToString());

                    ysa.ileriHesaplama(ysa.GirilenDizi, ysa.GirisAgirliklari, ysa.CikisAgirliklari, ysa.AraKatmanEsik, ysa.CikisKatmanEsik);
                    ysa.geriyeHesaplama(ysa.GirisAgirliklari, ysa.CikisAgirliklari, ysa.AraKatmanEsik, ysa.CikisKatmanEsik, ysa.AraKatman, i);

                    textBox[i].Text = ysa.Cikti.ToString();


                }// EÞLEÞEN ÝÇÝN BURASI ÇALIÞIR
                else if (ysa.Index != i)
                {
                    //MessageBox.Show("ÝNDEX Ý YE EÞÝT DEÐÝLSE" + ysa.Index.ToString());

                    ysa.eslesmeyenIcinIleriHesabi(ysa.Veriler, ysa.GirisAgirliklari, ysa.CikisAgirliklari, ysa.AraKatmanEsik, ysa.CikisKatmanEsik, i);
                    ysa.eslesmeyenIcinGeriHesabi(ysa.GirisAgirliklari, ysa.CikisAgirliklari, ysa.AraKatmanEsik, ysa.CikisKatmanEsik, ysa.AraKatman, i);

                    double son = 1 - ysa.Cikti;
                    textBox[i].Text = son.ToString();

                    // EÞLEÞME YOKSA KALAN 4 HARF ÝÇÝN BURASI ÇALIÞACAK.
                }
            }
            buttonHesapla.Enabled = false;
            buttonTanýmla.Enabled = true;
            buttonTemizle.Enabled = true;
        }





        private void buttonDosyadanAl_Click(object sender, EventArgs e)
        {
            Button[] btn = {
                button1,  button2,  button3,  button4,  button5,
                button6,  button7,  button8,  button9,  button10,
                button11, button12, button13, button14, button15,
                button16, button17, button18, button19, button20 ,
                button21, button22, button23, button24, button25 ,
                button26, button27, button28, button29, button30 ,
                button31, button32, button33, button34, button35 ,
                  };

            ysa = new YapaySinirAgi(Convert.ToDouble(numericUpDown3.Value), Convert.ToDouble(numericUpDown2.Value), Convert.ToDouble(numericUpDown1.Value));
            ysa.harfiMatriseCevir(btn);
            ysa.agirliklariDosyadanAl();
            buttonHesapla.Enabled = false;
            buttonTemizle.Enabled = false;
            buttonDosyadanAl.Enabled = true;

        }

        private void buttonDosyadanHesapla_Click(object sender, EventArgs e)
        {

            TextBox[] textBox =
            {
                textBox1,textBox2,textBox3,textBox4,textBox5
             };
            ysa.harfTespiti();

            for (int i = 0; i < 5; i++)
            {
                // A B C D E HARFLERÝ ÝÇÝN TARAMA YAPAR.

                if (ysa.Index == i)
                {
                    //MessageBox.Show(GirisAgirliklari[0,9].ToString());
                    //MessageBox.Show(ysa.GirilenDizi[0].ToString());

                    //MessageBox.Show("ÝNDEX"+ysa.Index.ToString());
                    ysa.ileriHesaplama(ysa.GirilenDizi, ysa.GirisAgirliklariDosyadan, ysa.CikisAgirliklariDosyadan, ysa.AraKatmanEsikAgirliklariDosyadan, ysa.CikisKatmanEsikAgirliklariDosyadan);
                    ysa.geriyeHesaplama(ysa.GirisAgirliklariDosyadan, ysa.CikisAgirliklariDosyadan, ysa.AraKatmanEsikAgirliklariDosyadan, ysa.CikisKatmanEsikAgirliklariDosyadan, ysa.AraKatman, i);

                    textBox[i].Text = ysa.Cikti.ToString();


                }// EÞLEÞEN ÝÇÝN BURASI ÇALIÞIR
                else if (ysa.Index != i)
                {
                    //MessageBox.Show("ÝNDEX Ý YE EÞÝT DEÐÝLSE" + ysa.Index.ToString());

                    ysa.eslesmeyenIcinIleriHesabi(ysa.Veriler, ysa.GirisAgirliklariDosyadan, ysa.CikisAgirliklariDosyadan, ysa.AraKatmanEsikAgirliklariDosyadan, ysa.CikisKatmanEsikAgirliklariDosyadan, i);
                    ysa.eslesmeyenIcinGeriHesabi(ysa.GirisAgirliklariDosyadan, ysa.CikisAgirliklariDosyadan, ysa.AraKatmanEsikAgirliklariDosyadan, ysa.CikisKatmanEsikAgirliklariDosyadan, ysa.AraKatman, i);

                    double son = 1 - ysa.Cikti;
                    textBox[i].Text = son.ToString();

                    // EÞLEÞME YOKSA KALAN 4 HARF ÝÇÝN BURASI ÇALIÞACAK.
                }
            }
            buttonHesapla.Enabled = false;
            buttonTanýmla.Enabled = true;
            buttonTemizle.Enabled = true;
        }
    }
}