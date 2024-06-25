using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalLivraria
{
    internal class Livro : Exemplar
    {
        //Mateus Zancheta Falcão
        public int Paginas { get; set; }
        public string TipoCapa { get; set; }
        public string Isbn { get; set; }

        public Livro(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int paginas, string tipoCapa, string isbn) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)
        {
            Paginas = paginas;
            TipoCapa = tipoCapa;
            Isbn = isbn;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
