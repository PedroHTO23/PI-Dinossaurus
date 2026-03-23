using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace PI_Dinos_saurus
{
    public partial class Form1 : Form
    {
        private string nomegrupo;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nomegrupo = textBox1.Text.Trim();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Lobby lobby = new Lobby();
            lobby.ShowDialog();


        }
    }
}
