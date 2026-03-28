using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Draft;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Jogador player1 = new Jogador();
        public string Versao;
        public Form1()
        {
            InitializeComponent();
            this.Versao = Jogo.versao;
        }
        
        public void entralobby_Click(object sender, EventArgs e)
        {
            lobby Lobby = new lobby();
            Lobby.ShowDialog();
            this.Hide();
        }

        private void versaodll_Click(object sender, EventArgs e)
        {
            versaodll.Text = Jogo.versao;
        }

        private void nomegrupo_TextChanged(object sender, EventArgs e)
        {
            player1.grupo = nomegrupo.Text; 
            this.player1.id = nomegrupo.Text;
        }
    }
}
