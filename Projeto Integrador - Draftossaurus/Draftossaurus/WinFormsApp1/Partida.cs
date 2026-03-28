using System;
using System.Collections.Generic;
using System.Text;
using Draft;

namespace WinFormsApp1
{
    internal class Partida
    {
        public int id { get; set; }

        public string nome { get; set; }

        public DateTime data { get; set; }

        public char status { get; set; }

        public static List<Partida> ListarPartidas()
        {

            string listapartidas = Jogo.ListarPartidas("T");
            listapartidas = listapartidas.Replace("\r", "");
            listapartidas = listapartidas.Substring(0, listapartidas.Length - 1);
            string[] partidas = listapartidas.Split("\n");


            List<Partida> lpartidas = new List<Partida>();


            foreach (var item in partidas)
            {
                string[] dados = item.Split(",");
                string[] partida = dados;

                Partida p = new Partida();

                p.id = int.Parse(dados[0]);
                p.nome = dados[1];
                p.data = DateTime.Parse(dados[2]);
                p.status = char.Parse(dados[3]);

                lpartidas.Add(p);
            }
            return lpartidas;
        }
    }
}
