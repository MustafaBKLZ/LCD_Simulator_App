using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCD_simulatır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // bu proje github da yok. Şimdi gelin bu projeyi githuba yükleyelim.
            // bu projeyi kapatacağım ve yeni bir proje açacağım (Kodsuz başlangıç yapaqcağız.)
        }

        PictureBox[,] ekransatir;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            EkranGetir();
        }
        void EkranGetir()
        { 
            ekransatir = new PictureBox[8, 80];
            int xpos = 0;
            int ypos = 20;
            int width = 8;
            int height = 8;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    ekransatir[i, j] = new PictureBox();
                    panel1.Controls.Add(ekransatir[i, j]);
                    ekransatir[i, j].Image = led0.Image;
                    ekransatir[i, j].SetBounds(xpos, ypos, width, height);
                    ekransatir[i, j].Show();
                    xpos += 8;
                }
                xpos = 0;
                ypos += 8;
            }
        }


        public void yaz()
        {
            int gonder = 0;
            int i, j;
            char[] gelen = textBox1.Text.ToUpper().ToCharArray();
            for (i = 0, j = 0; i < gelen.Length && j < gelen.Length; i++, j++)
            {
                harfyaz(gonder, gelen[j]);
                gonder += 8;
            }
        }

        public void harfyaz(int a, char c)
        {
            int x = a;
            harfsec(c);
            for (int i = 0; i < 8; i++)
            {
                x = a;
                for (int j = 0; j < 8; j++)
                {
                    if (Harf[i, j] == 1)
                    {
                        ekransatir[i, x].Image = led1.Image;

                    }
                    else if (Harf[i, j] == 0)
                    {
                        ekransatir[i, x].Image = led0.Image;
                    }
                    x++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 79; j++)
                {
                    ekransatir[i, j].Image = ekransatir[i, j + 1].Image;
                }
            }
        }

        int[,] Harf;
        public void harfsec(char karakter)
        {
            switch (karakter)
            {
                case 'A':
                    Harf = Harfler.A();
                    break;
                case 'B':
                    Harf = Harfler.B();
                    break;
                case 'C':
                    Harf = Harfler.C();
                    break;
                case 'D':
                    Harf = Harfler.D();
                    break;
                case 'E':
                    Harf = Harfler.E();
                    break;
                case 'F':
                    Harf = Harfler.F();
                    break;
                case 'G':
                    Harf = Harfler.G();
                    break;
                case 'H':
                    Harf = Harfler.H();
                    break;
                case 'I':
                    Harf = Harfler.I();
                    break;
                case 'J':
                    Harf = Harfler.J();
                    break;
                case 'K':
                    Harf = Harfler.K();
                    break;
                case 'L':
                    Harf = Harfler.L();
                    break;
                case 'M':
                    Harf = Harfler.M();
                    break;
                case 'N':
                    Harf = Harfler.N();
                    break;
                case 'O':
                    Harf = Harfler.O();
                    break;
                case 'P':
                    Harf = Harfler.P();
                    break;
                case 'R':
                    Harf = Harfler.R();
                    break;
                case 'S':
                    Harf = Harfler.S();
                    break;
                case 'T':
                    Harf = Harfler.T();
                    break;
                case 'U':
                    Harf = Harfler.U();
                    break;
                case 'V':
                    Harf = Harfler.V();
                    break;
                case 'Y':
                    Harf = Harfler.Y();
                    break;
                case 'Z':
                    Harf = Harfler.Z();
                    break;






                //case 'a':
                //    Harf = Harfler.a();
                //    break;
                //case 'b':
                //    Harf = Harfler.b();
                //    break;
                //case 'c':
                //    Harf = Harfler.c();
                //    break;
            }
        }

        // KÜÇÜK HARFLER EKSİK O YÜZDEN SORUN OLABİLİR.
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); 
            EkranGetir();
            yaz();
        }
    }
}
