using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalLivraria
{
    internal class Leitor : Pessoa
    {
        //Mateus Zancheta Falcão
        public List<Exemplar> ExemplaresLeitor { get; set; }
        public List<Emprestimo> EmprestimoLeitor { get; set; }
        public int Tipo { get; set; }

        public Leitor(string nome, DateTime nascimento, string cpf, string email, string telefone, int tipo, List<Exemplar> exemplares) : base(nome, nascimento, cpf, email, telefone)
        {
            Tipo = tipo;
            ExemplaresLeitor = exemplares ?? new List<Exemplar>();
            EmprestimoLeitor = new List<Emprestimo>();
        }

        public bool EmprestaItem(Exemplar exemplar, Leitor destino)
        {
            return true;
        }

        public bool DevolucaoItem(Exemplar exemplar, Leitor destino)
        {
            return true;
        }

        public bool DoaExemplar(Exemplar exemplar, Leitor destino)
        {
            return true;
        }

        public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem)
        {
            return true;
        }

        public override string ToString()
        {
            return "";
        }

        public override void ListaLeitor(Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void EditaLeitor(Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            leitor.ExemplaresLeitor.Add(exemplar);
        }

        public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }

        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor)
        {
            throw new NotImplementedException();
        }
    }
}
