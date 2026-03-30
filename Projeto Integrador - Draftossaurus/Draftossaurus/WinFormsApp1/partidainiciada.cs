using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class partidainiciada : Form
    {
        private Jogador jogador;
        public partidainiciada()
        {
            InitializeComponent(); 
        }

        private void dados_Click(object sender, EventArgs e)
        {
            Jogo.Iniciar(this.jogador.id, this.jogador.senha );
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Jogo.VerificarTurno(0);
        }

        private void maoatual_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jogo.ExibirMao(this.jogador.id, this.jogador.senha);
        }
    }
}
