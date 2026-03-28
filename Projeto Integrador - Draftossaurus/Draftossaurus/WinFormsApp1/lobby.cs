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

    public partial class lobby : Form
    {
        public required string senhajogador;
        Jogador player = new Jogador();
        public lobby(Jogador player1)
        {
            InitializeComponent();
            datagridpartidas.DataSource = Partida.ListarPartidas();

            datagridpartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridpartidas.EditMode = DataGridViewEditMode.EditProgrammatically;
            datagridpartidas.AllowUserToResizeRows = false;
            datagridpartidas.AllowUserToResizeColumns = false;
            datagridpartidas.RowHeadersVisible = false;

        }

        public lobby()
        {
        }

        private void criarpartida_Click(object sender, EventArgs e)
        {
            Form partidanova = new partidanova();
            partidanova.ShowDialog();
        }

        private void senhapartida_TextChanged(object sender, EventArgs e)
        {
            this.senhajogador = senhapartida.Text;
        }

        private void nomedapartida_TextChanged(object sender, EventArgs e)
        {
            Partida partida = new Partida();
            partida.nome = nomedapartida.Text;
        }

        private void senhapartida_TextChanged_1(object sender, EventArgs e)
        { 
            player.senha = senhapartida.Text;
            player.id = Convert.ToString(nomedapartida.Text);
            player.grupo = grupo.Text;
        }

        private void grupo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
