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

Dictionary<string, (string, string)>
{
    { "Br", ("Braquiossauro", "Roxo") };
    { "Ep", ("Espinossauro", "Laranja") };
    { "Et", ("Estegossauro", "Azul") };
    { "Pa", ("Parasaurolófo", "Verde") };
    { "Ti", ("Tiranossauro", "Vermelho") };
    { "Tr", ("Triceratops", "Amarelo") };
}

namespace PI_Dinos_saurus
{
    public partial class Partidainiciada : Form
    {
        public Partidainiciada()
        {
            InitializeComponent();
        }

        private void partidainiciada_Load(object sender, EventArgs e)
        {

        }

        private void dinossauros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
