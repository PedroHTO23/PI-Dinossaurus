using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Draft;


namespace PI_Dinos_saurus
{
    public partial class Lobby : Form
    {
        private string senhajogador;

        public Lobby()
        {
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void NomePartida_TextChanged(object sender, EventArgs e)
        {

            string textousuario = NomePartida.Text;
            string nomePartida = textousuario;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            string textousuario3 = textBox3.Text;
            string senha = textousuario3;
            this.senhajogador = senha;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            Partidas.Text = retorno;
            retorno = retorno.Replace("\r", "");

            retorno = retorno.Substring(0, retorno.Length - 1);

            string[] partidas = retorno.Split('\n');

            for (int i = 0; i < partidas.Length - 1; i++)
            {
                Partidas.Items.Add(partidas[i]);
            }

            Assembly dll = Assembly.GetAssembly(typeof(Jogo));
            string versaodll = dll.GetName().Version.ToString();

            label5.Text = versaodll;

        }

        private void Partidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partidaSelecionada = Partidas.SelectedItem.ToString();
            string[] infopartida = partidaSelecionada.Split(',');

            int idPartida = int.Parse(infopartida[0]);
            string nomePartida = infopartida[1];
            string dataPartida = infopartida[2];

            label1.Text = idPartida.ToString();
            label2.Text = nomePartida;
            label3.Text = dataPartida;

            string retorno = Jogo.ListarJogadores(idPartida);

            if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro:\n" + retorno.Substring(5));
                return;
            }

            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            Players.Items.Clear();

            for (int i = 0; i < jogadores.Length - 1; i++)
            {
                Players.Items.Add(jogadores[i]);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            partidanova frm = new partidanova();
            frm.Senha = senhajogador;
            frm.NomeGrupo = NomePartida.Text.Trim();
            frm.ShowDialog();
        }

    }
}
}
