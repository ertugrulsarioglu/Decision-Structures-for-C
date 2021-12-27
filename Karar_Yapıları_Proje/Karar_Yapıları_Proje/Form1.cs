using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapıları_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;
        private void BtnB_Click(object sender, EventArgs e)
        {
            label5.Text = BtnB.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

                
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            label5.Text = BtnC.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;

               
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label5.Text = BtnD.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label5.Text = BtnA.Text;
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            if(label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            LblSoruno.Text = soruno.ToString();
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if(soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";

                label4.Text = "1923";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Hangi ilimiz Karadeniz Bölgesinde değildir?";
                BtnA.Text = "Rize";
                BtnB.Text = "Trabzon";
                BtnC.Text = "Ankara";
                BtnD.Text = "Ordu";

                label4.Text = "Ankara";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Aşağıdaki futbolculardan hangisi Fenerbahçe'de oynamamıştır?";
                BtnA.Text = "Alex De Souza";
                BtnB.Text = "Roberto Carlos";
                BtnC.Text = "Ronaldinho";
                BtnD.Text = "Servet Çetin";

                label4.Text = "Ronaldinho";
            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = true;

                LblSoruno.Text = "3";
                BtnSonraki.Text = "Sonuç";
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
                this.Close();
            }

        }
    }
}
