using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.MODEL
{
    public class Clientes
    {
        private int ID_Cli;
        private String Nome_Cli;
        private String CPF_Cli;
        private String Ender_Cli;
        private String Tel_Cli;

        public int ID_Cli1 { get => ID_Cli; set => ID_Cli = value; }
        public string Nome_Cli1 { get => Nome_Cli; set => Nome_Cli = value; }
        public string CPF_Cli1 { get => CPF_Cli; set => CPF_Cli = value; }
        public string Ender_Cli1 { get => Ender_Cli; set => Ender_Cli = value; }
        public string Tel_Cli1 { get => Tel_Cli; set => Tel_Cli = value; }
    }
}
