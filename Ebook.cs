using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalLivraria
{
    internal class Ebook : Livro
    {
        //Mateus Zancheta Falcão
        public string Formato { get; set; }
        public decimal Tamanho { get; set; }
        public string Url { get; set; }

        public Ebook(string titulo, string subTitulo, string escritor, string editora, int anoPublicacao, string genero, int status, int paginas, string tipoCapa, string lbsn, string formato, decimal tamanho, string url) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status, paginas, tipoCapa, lbsn)
        {
            Formato = formato;
            Tamanho = tamanho;
            Url = url;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
