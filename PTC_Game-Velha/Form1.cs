using System;
using System.Windows.Forms;

namespace PTC_Game_Velha
{
    public partial class Form1 : Form
    {

        public string jogadorAtual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        public void zerar()
        {
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            jogadorAtual = "X";

        }
        public void ganhar()
        {
            MessageBox.Show("!!! O CANALHA -> " + jogadorAtual + " <- GANHOU!!!!");
            zerar();
        }

        public string InverteJogador()
        {
            if (jogadorAtual == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public bool Verificar(string jogador)
        {
            if (bt1.Text == jogador && bt2.Text == jogador && bt3.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt1.Text == jogador && bt4.Text == jogador && bt7.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt1.Text == jogador && bt5.Text == jogador && bt9.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt3.Text == jogador && bt5.Text == jogador && bt7.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt3.Text == jogador && bt6.Text == jogador && bt9.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt4.Text == jogador && bt5.Text == jogador && bt6.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt7.Text == jogador && bt8.Text == jogador && bt9.Text == jogador)
            {
                ganhar();
                return true;
            }
            if (bt2.Text == jogador && bt5.Text == jogador && bt8.Text == jogador)
            {
                ganhar();
                return true;
            }

            label1.Text = "JOGADOR ATUAL: " + jogadorAtual; 
            jogadorAtual = InverteJogador();

            return false;

        }

        private void btRef_Click(object sender, EventArgs e)
        {
            zerar();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (bt1.Text == "")
            {
                bt1.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (bt2.Text == "")
            {
                bt2.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (bt3.Text == "")
            {
                bt3.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (bt4.Text == "")
            {
                bt4.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (bt5.Text == "")
            {
                bt5.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (bt6.Text == "")
            {
                bt6.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (bt7.Text == "")
            {
                bt7.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (bt8.Text == "")
            {
                bt8.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (bt9.Text == "")
            {
                bt9.Text = jogadorAtual;
                Verificar(jogadorAtual);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
