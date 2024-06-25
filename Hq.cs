using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalLivraria
{
    internal class Hq : Exemplar
    {
        //Mateus Zancheta Falcão
        public int Edicao { get; set; }
        public string Ilustrador { get; set; }

        public Hq(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int edicao, string ilustrador) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
        {
            Edicao = edicao;
            Ilustrador = ilustrador;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
