using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.MODEL
{
    public class Aluguel
    {
        private int ID_Aluguel;
        private String Data_Compra;
        private String Data_Prazo;
        private int ID_Cli;
        private int ID_Filme;

        public int ID_Aluguel1 { get => ID_Aluguel; set => ID_Aluguel = value; }
        public string Data_Compra1 { get => Data_Compra; set => Data_Compra = value; }
        public string Data_Prazo1 { get => Data_Prazo; set => Data_Prazo = value; }
        public int ID_Cli1 { get => ID_Cli; set => ID_Cli = value; }
        public int ID_Filme1 { get => ID_Filme; set => ID_Filme = value; }
    }
}
 