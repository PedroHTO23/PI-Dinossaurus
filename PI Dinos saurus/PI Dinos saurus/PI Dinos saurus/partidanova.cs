using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace PI_Dinos_saurus
{
    public partial class partidanova : Form
    {
        public string NomeGrupo { get; set; }
        public string Senha { get; set; }
        public partidanova()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void partidanova_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(NomeGrupo))
                IdJogadorLabel.Text = NomeGrupo;

            if (!string.IsNullOrEmpty(Senha))
                SenhaJogador.Items.Add(Senha);

        }

        private void JogadoresPartida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form partidainiciada = new partidainiciada();
            partidainiciada.ShowDialog();

        }

        private void SenhaJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            SenhaJogador.Text = Senha;
        }
    }
}
