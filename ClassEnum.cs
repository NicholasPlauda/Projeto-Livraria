using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalLivraria
{
    public enum EnumTipoLeitor
    {
        [Description("Leitor Casual")]
        LeitorCasual = 1,

        [Description("Leitor Ávido")]
        LeitorAvido = 2,

        [Description("Leitor de Ficção")]
        LeitorDeFiccao = 3,

        [Description("Leitor de Não Ficção")]
        LeitorDeNaoFiccao = 4,

        [Description("Leitor Crítico")]
        LeitorCritico = 5,

        [Description("Leitor de Best-sellers")]
        LeitorDeBestSellers = 6,

        [Description("Leitor de Clássicos")]
        LeitorDeClassicos = 7,

        [Description("Leitor de Gênero Específico")]
        LeitorDeGeneroEspecifico = 8,

        [Description("Leitor Acadêmico")]
        LeitorAcademico = 9,

        [Description("Leitor Digital")]
        LeitorDigital = 10,

        [Description("Leitor Tradicional")]
        LeitorTradicional = 11,

        [Description("Leitor de Livros de Bolso")]
        LeitorDeLivrosDeBolso = 12,

        [Description("Leitor Multitarefa")]
        LeitorMultitarefa = 13,

        [Description("Leitor Seletivo")]
        LeitorSeletivo = 14,

        [Description("Leitor Visual")]
        LeitorVisual = 15,

        [Description("Outros")]
        Outros = 16,
    }

    public enum EnumFuncionarioCargo
    {
        [Description("Gerente")]
        Gerente = 1,
        [Description("Atendente")]
        Atendente = 2,
        [Description("Caixa")]
        Caixa = 3,
        [Description("Estagiário")]
        Estagiário = 4
    }

    public enum EnumGenericoTipo
    {
        [Description("Jornais")]
        Jornais = 1,
        [Description("Calendários e Agendas")]
        CalendariosAgendas = 2,
        [Description("Mapas e Atlas")]
        MapasAtlas = 3,
        [Description("Postais e Cartões de Saudação")]
        PostaisCartoesSaudacao = 4,
        [Description("Papéis de Presente e Material de Embalagem")]
        PapeisPresenteMaterialEmbalagem = 5,
        [Description("DVDs e Blu-rays")]
        DVDsBlurays = 6,
        [Description("CDs e Vinis")]
        CDsVinis = 7,
        [Description("K7")]
        K7 = 8,
        [Description("Jogos de Tabuleiro e Quebra-Cabeças")]
        JogosTabuleiroQuebraCabecas = 9,
        [Description("Material de Papelaria e Escritório")]
        MaterialPapelariaEscritorio = 10,
        [Description("Produtos Relacionados à Cultura Pop")]
        ProdutosRelacionadosCulturaPop = 11,
        [Description("Audiolivros")]
        Audiolivros = 12,
        [Description("Outros")]
        Outros = 13
    }

    public enum EnumExemplarStatus
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Lido")]
        Lido = 2,
        [Description("Emprestado")]
        Emprestado = 3,
        [Description("Devolvido")]
        Devolvido = 4,
        [Description("Perdido")]
        Perdido = 5
    }

    public enum EnumGenero
    {
        [Description("Romance")]
        Romance = 1,
        [Description("Novela")]
        Novela = 2,
        [Description("Conto")]
        Conto = 3,
        [Description("Crônica")]
        Crônica = 4,
        [Description("Poema")]
        Poema = 5,
        [Description("Canção")]
        Canção = 6,
        [Description("Drama histórico")]
        DramaHistórico = 7,
        [Description("Teatro de vanguarda")]
        TeatroDeVanguarda = 8
    }

    public enum EnumTipoCapa
    {
        [Description("Capa Dura")]
        CapaDura = 1,
        [Description("Capa Flexível ou Brochura")]
        CapaFlexívelOuBrochura = 2,
        [Description("Capa de Papel Cartão")]
        CapaDePapelCartão = 3,
        [Description("Capa com Sobrecapa (Jacket)")]
        CapaComSobrecapa = 4,
        [Description("Capa com Relevo")]
        CapaComRelevo = 5,
        [Description("Capa com Verniz UV")]
        CapaComVernizUV = 6,
        [Description("Capa Metalizada")]
        CapaMetalizada = 7,
        [Description("Capa de Tecido")]
        CapaDeTecido = 8,
        [Description("Capa com Janela")]
        CapaComJanela = 9,
        [Description("Capa Transparente")]
        CapaTransparente = 10,
        [Description("Capa Digital")]
        CapaDigital = 11
    }

    public enum EnumFormato
    {
        [Description("Portable Document Format (PDF)")]
        PDF = 1,
        [Description("Electronic Publication (ePUB)")]
        EPUB = 2,
        [Description("Mobipocket (MOBI)")]
        MOBI = 3,
        [Description("Kindle Package Format (KPF)")]
        KPF = 4,
        [Description("Outros")]
        Outros = 5
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
    }
}
