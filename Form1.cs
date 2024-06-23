using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        bool pasStep = false;


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();


            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kesimindeki bölgesi?";
                b1.BackColor = Color.Yellow;
                button25.Text = b1.Text;


            }
            if (soruno == 2) 
            {
                richTextBox1.Text = "Yeşiliyle ünlü ilimiz?";
                b2.BackColor = Color.Yellow;
                button25.Text = b2.Text;

            }
            if (soruno == 3) 
            {
                richTextBox1.Text = "Haftanın 5. günü?";
                b3.BackColor = Color.Yellow;
                button25.Text = b3.Text;

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                b4.BackColor = Color.Yellow;
                button25.Text = b4.Text;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
                b5.BackColor = Color.Yellow;
                button25.Text = b5.Text;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Eyfel Kulasinin olduğu ülke?";
                b6.BackColor = Color.Yellow;
                button25.Text = b6.Text;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Fındığıyla meşhur ilimiz?";
                b7.BackColor = Color.Yellow;
                button25.Text = b7.Text;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Yerde serili üzerine bastığımız?";
                b8.BackColor = Color.Yellow;
                button25.Text = b8.Text;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Sıcak veya soğuk olmayan?";
                b9.BackColor = Color.Yellow;
                button25.Text = b9.Text;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Vali yönetiminde olan bölge?";
                b10.BackColor = Color.Yellow;
                button25.Text = b10.Text;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Uzak doğu ülkesi?";
                b11.BackColor = Color.Yellow;
                button25.Text = b11.Text;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Serinlemeye yarayan alet?";
                b12.BackColor = Color.Yellow;
                button25.Text = b12.Text;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Sarı renkli sulu, ekşi yiyecek?";
                b13.BackColor = Color.Yellow;
                button25.Text = b13.Text;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                b14.BackColor = Color.Yellow;
                button25.Text = b14.Text;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti?";
                b15.BackColor = Color.Yellow;
                button25.Text = b15.Text;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Ağaçların bir arada olduğu alan?";
                b16.BackColor = Color.Yellow;
                button25.Text = b16.Text;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Değerli taş?";
                b17.BackColor = Color.Yellow;
                button25.Text = b17.Text;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "İnsani duyguların soyut hali?";
                b18.BackColor = Color.Yellow;
                button25.Text = b18.Text;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Sarı yapraklı mevsim?";
                b19.BackColor = Color.Yellow;
                button25.Text = b19.Text;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Ayağa giyilir?";
                b20.BackColor = Color.Yellow;
                button25.Text = b20.Text;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Şans Böceği?";
                b21.BackColor = Color.Yellow;
                button25.Text = b21.Text;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Canavarıyla meşhur gölü olan ilimiz?";
                b22.BackColor = Color.Yellow;
                button25.Text = b22.Text;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Bitki örtüsü rengi?";
                b23.BackColor = Color.Yellow;
                button25.Text = b23.Text;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Siyah kahvaltılık yıyecek?";
                b24.BackColor = Color.Yellow;
                button25.Text = b24.Text;
            }
            if (soruno == 25)
            {
                b1.BackColor = Color.White;
                b2.BackColor = Color.White;
                b3.BackColor = Color.White;
                b4.BackColor = Color.White;
                b5.BackColor = Color.White;
                b6.BackColor = Color.White;
                b7.BackColor = Color.White;
                b8.BackColor = Color.White;
                b9.BackColor = Color.White;
                b10.BackColor = Color.White;
                b11.BackColor = Color.White;
                b12.BackColor = Color.White;
                b13.BackColor = Color.White;
                b14.BackColor = Color.White;
                b15.BackColor = Color.White;
                b16.BackColor = Color.White;
                b17.BackColor = Color.White;
                b18.BackColor = Color.White;
                b19.BackColor = Color.White;
                b20.BackColor = Color.White;
                b21.BackColor = Color.White;
                b22.BackColor = Color.White;
                b23.BackColor = Color.White;
                b24.BackColor = Color.White;
                soruno = 0;
                button25.Text = " ";
                richTextBox1.Text = " ";
                MessageBox.Show("Tebrikler oyunu tamamladınız.");
            }

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //e nesnedir.e harfı klavyeden herhangı bır tusla atama yapmamız ıcın kullanabıldıgımız
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            b1.BackColor = Color.Green;
                            dogru++;
                            LblD.Text =dogru.ToString();
                        }
                        else
                        {
                            b1.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b2.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b2.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            b3.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b3.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            b4.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b4.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            b5.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b5.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 6:
                        if (textBox1.Text == "fransa")
                        {
                            b6.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b6.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 7:
                        if (textBox1.Text == "giresun")
                        {
                            b7.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b7.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            b8.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b8.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 9:
                        if (textBox1.Text == "ılık")
                        {
                            b9.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b9.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 10:
                        if (textBox1.Text == "il")
                        {
                            b10.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b10.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 11:
                        if (textBox1.Text == "japonya")
                        {
                            b11.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b11.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 12:
                        if (textBox1.Text == "klima")
                        {
                            b12.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b12.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 13:
                        if (textBox1.Text == "limon")
                        {
                            b13.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b13.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            b14.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b14.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            b15.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b15.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 16:
                        if (textBox1.Text == "orman")
                        {
                            b16.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b16.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 17:
                        if (textBox1.Text == "pırlanta")
                        {
                            b17.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b17.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır


                    case 18:
                        if (textBox1.Text == "ruh")
                        {
                            b18.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b18.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 19:
                        if (textBox1.Text == "sonbahar")
                        {
                            b19.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b19.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır


                    case 20:
                        if (textBox1.Text == "terlik")
                        {
                            b20.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b20.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 21:
                        if (textBox1.Text == "uğur böceği")
                        {
                            b21.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b21.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 22:
                        if (textBox1.Text == "van")
                        {
                            b22.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b22.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 23:
                        if (textBox1.Text == "yeşil")
                        {
                            b23.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b23.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            b24.BackColor = Color.Green;
                            dogru++;
                            LblD.Text = dogru.ToString();
                        }
                        else
                        {
                            b24.BackColor = Color.Red;
                            yanlis++;
                            LblY.Text = yanlis.ToString();
                        }
                        break;//her case break komutuyla sonlanır

                }
            }
        }


        

    }
}
