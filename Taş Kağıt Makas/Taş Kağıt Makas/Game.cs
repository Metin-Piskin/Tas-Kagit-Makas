using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taş_Kağıt_Makas
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int bilgisayart = 0, oyuncut = 0;
        int x;
        private void tkm()
        {
            x = r.Next(1, 4);
            if (x == 1)
            {
                pictureBoxBilgisayar.ImageLocation = "image\\Taş.png";
            }
            if (x == 2)
            {
                pictureBoxBilgisayar.ImageLocation = "image\\Kağıt.png";
            }
            if (x == 3)
            {
                pictureBoxBilgisayar.ImageLocation = "image\\Makas.png";
            }

        }

        private void skor()
        {
            if (bilgisayart >= Convert.ToInt32(this.TurTextBox.Text))
            {
                label7.Text = "***Bilgisayar Kazandı***";
                label7.Visible = true;
                TaşB.Enabled = false;
                KağıtB.Enabled = false;
                MakasB.Enabled = false;
            }
            if (oyuncut >= Convert.ToInt32(this.TurTextBox.Text))
            {
                label7.Text = "***Oyuncu Kazandı***";
                label7.Visible = true;
                TaşB.Enabled = false;
                KağıtB.Enabled = false;
                MakasB.Enabled = false;
                BaşlatB.Enabled = false;
            }

        }

        private void BaşlatB_Click(object sender, EventArgs e)
        {
            pictureBoxBilgisayar.Visible = true;
            pictureBoxOyuncu.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            TaşB.Visible = true;
            MakasB.Visible = true;
            KağıtB.Visible = true;
            TaşB.Enabled = true;
            MakasB.Enabled = true;
            KağıtB.Enabled = true;
            YBaşlatB.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            BilgisayarSkorL.Visible = true;
            OyuncuSkorL.Visible = true;
            BaşlatB.Enabled = false;
            TurTextBox.Enabled = false;
           
        }

        private void TaşB_Click(object sender, EventArgs e)
        {
            pictureBoxOyuncu.ImageLocation = "image\\Taş.png";
            tkm();
            if (x == 2)
            {
                bilgisayart ++;
                BilgisayarSkorL.Text = bilgisayart.ToString();
            }
            else if (x == 3)
            {
                oyuncut++;
                OyuncuSkorL.Text = oyuncut.ToString();
            }
            skor();
        }

        private void KağıtB_Click(object sender, EventArgs e)
        {
            pictureBoxOyuncu.ImageLocation = "image\\Kağıt.png";
            tkm();
            if (x == 1)
            {
                oyuncut++;
                OyuncuSkorL.Text = oyuncut.ToString();
            }
            else if (x == 3)
            {
                bilgisayart++;
                BilgisayarSkorL.Text = bilgisayart.ToString();
            }
            skor();
        }

        private void MakasB_Click(object sender, EventArgs e)
        {
            pictureBoxOyuncu.ImageLocation = "image\\Makas.png";
            tkm();
            if (x == 1)
            {
                bilgisayart++;
                BilgisayarSkorL.Text = bilgisayart.ToString();
            }
            else if (x == 2)
            {
                oyuncut++;
                OyuncuSkorL.Text = oyuncut.ToString();
            }
            skor();
        }

        private void YBaşlatB_Click(object sender, EventArgs e)
        {
            BaşlatB.Enabled = true;
            pictureBoxBilgisayar.Visible = false;
            pictureBoxOyuncu.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            TaşB.Visible = false;
            MakasB.Visible = false;
            KağıtB.Visible = false;
            YBaşlatB.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            bilgisayart = 0;
            oyuncut = 0;
            BilgisayarSkorL.Text = bilgisayart.ToString();
            OyuncuSkorL.Text = oyuncut.ToString();
            TurTextBox.Clear();
            TurTextBox.Focus();
            label7.Visible = false;
            OyuncuSkorL.Visible = false;
            BilgisayarSkorL.Visible = false;
            TurTextBox.Enabled = true;
        }
    }
}
