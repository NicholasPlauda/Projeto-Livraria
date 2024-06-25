using System.Numerics;

namespace ProjetoFinalLivraria
{
    internal partial class FormExemplar : Form
    {
        public List<Exemplar> exemplares;
        public Exemplar exemplar;

        public FormExemplar(List<Exemplar> exemplares)
        {
            InitializeComponent();

            CargaEnum();

            this.exemplares = exemplares;
        }

        public FormExemplar(List<Exemplar> exemplares, Exemplar exemplar)
        {
            InitializeComponent();

            CargaEnum();

            this.exemplares = exemplares;
            this.exemplar = exemplar;

            textBoxTitulo.Text = exemplar.Titulo;
            textBoxSubTitulo.Text = exemplar.SubTitulo;
            textBoxEscritor.Text = exemplar.Escritor;
            textBoxEditora.Text = exemplar.Editora;
            numericUpDownAnoPublicacao.Value = exemplar.AnoPublicacao;
            comboBoxGenero.Text = "" + (EnumGenero)Enum.Parse(typeof(EnumGenero), exemplar.Genero.ToString());
            comboBoxStatus.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());

            if (exemplar is Livro || exemplar is Ebook)
            {
                numericUpDownPaginasLivro.Value = ((Livro)exemplar).Paginas;
                comboBoxTipoCapa.Text = ((Livro)exemplar).TipoCapa;
                textBoxIsbn.Text = ((Livro)exemplar).Isbn;
                checkBoxEBook.Checked = false;

                tabControlExemplar.SelectedIndex = 0;
                tabControlExemplar.TabPages[1].Enabled = false;
                tabControlExemplar.TabPages[2].Enabled = false;
                tabControlExemplar.TabPages[3].Enabled = false;
                buttonSalvar.Enabled = false;

                if (exemplar is Ebook)
                {
                    checkBoxEBook.Checked = true;
                    comboBoxFormato.Text = ((Ebook)exemplar).Formato;
                    numericUpDownTamanho.Value = ((Ebook)exemplar).Tamanho;
                    textBoxURL.Text = ((Ebook)exemplar).Url;
                }
            }
            else if (exemplar is Revista revista)
            {
                numericUpDownEdicaoRevista.Value = revista.Edicao;
                numericUpDownPaginasRevista.Value = revista.Paginas;

                tabControlExemplar.SelectedIndex = 1;
                tabControlExemplar.TabPages[0].Enabled = false;
                tabControlExemplar.TabPages[2].Enabled = false;
                tabControlExemplar.TabPages[3].Enabled = false;
                buttonSalvar.Enabled = false;
            }
            else if (exemplar is Hq hq)
            {
                numericUpDownEdicaoHQ.Value = hq.Edicao;
                textBoxIlustrador.Text = hq.Ilustrador;

                tabControlExemplar.SelectedIndex = 2;
                tabControlExemplar.TabPages[0].Enabled = false;
                tabControlExemplar.TabPages[1].Enabled = false;
                tabControlExemplar.TabPages[3].Enabled = false;
                buttonSalvar.Enabled = false;
            }
            else if (exemplar is Generico)
            {
                listBoxTipo.SelectedIndex = ((Generico)exemplar).Tipo;

                tabControlExemplar.SelectedIndex = 3;
                tabControlExemplar.TabPages[0].Enabled = false;
                tabControlExemplar.TabPages[1].Enabled = false;
                tabControlExemplar.TabPages[2].Enabled = false;
                buttonSalvar.Enabled = false;
            }
        }

        public void CargaEnum()
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;

            comboBoxTipoCapa.DataSource = Enum.GetValues(typeof(EnumTipoCapa));
            comboBoxTipoCapa.SelectedIndex = 0;

            comboBoxFormato.DataSource = Enum.GetValues(typeof(EnumFormato));
            comboBoxFormato.SelectedIndex = 0;

            comboBoxGenero.DataSource = Enum.GetValues(typeof(EnumGenero));
            comboBoxGenero.SelectedIndex = 0;

            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listBoxTipo.SelectedIndex = 0;
        }

        private void checkBoxEBook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEBook.Checked)
            {
                comboBoxFormato.Enabled = true;
                numericUpDownTamanho.Enabled = true;
                textBoxURL.Enabled = true;
                labelFormato.Enabled = true;
                labelTamanho.Enabled = true;
                labelURL.Enabled = true;
            }
            else
            {
                comboBoxFormato.Enabled = false;
                comboBoxFormato.SelectedIndex = 0;
                numericUpDownTamanho.Enabled = false;
                textBoxURL.Enabled = false;
                labelFormato.Enabled = false;
                labelTamanho.Enabled = false;
                labelURL.Enabled = false;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (tabControlExemplar.SelectedIndex == 0)
            {
                if (!checkBoxEBook.Checked)
                {
                    exemplares.Add(new Livro(textBoxTitulo.Text, textBoxSubTitulo.Text, textBoxEscritor.Text, textBoxEditora.Text, Convert.ToInt32(numericUpDownAnoPublicacao.Value), comboBoxGenero.Text, (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text), Convert.ToInt32(numericUpDownPaginasLivro.Value), comboBoxTipoCapa.Text, textBoxIsbn.Text));
                }
                else
                {
                    exemplares.Add(new Ebook(textBoxTitulo.Text, textBoxSubTitulo.Text, textBoxEscritor.Text, textBoxEditora.Text, Convert.ToInt32(numericUpDownAnoPublicacao.Value), comboBoxGenero.Text, (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text), Convert.ToInt32(numericUpDownPaginasLivro.Value), comboBoxTipoCapa.Text, textBoxIsbn.Text, comboBoxFormato.Text, numericUpDownTamanho.Value, textBoxURL.Text));
                }
            }
            else if (tabControlExemplar.SelectedIndex == 1)
            {
                exemplares.Add(new Revista(textBoxTitulo.Text, textBoxSubTitulo.Text, textBoxEscritor.Text, textBoxEditora.Text, Convert.ToInt32(numericUpDownAnoPublicacao.Value), comboBoxGenero.Text, (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text), Convert.ToInt32(numericUpDownEdicaoRevista.Value), Convert.ToInt32(numericUpDownPaginasRevista.Value)));
            }
            else if (tabControlExemplar.SelectedIndex == 2)
            {
                exemplares.Add(new Hq(textBoxTitulo.Text, textBoxSubTitulo.Text, textBoxEscritor.Text, textBoxEditora.Text, Convert.ToInt32(numericUpDownAnoPublicacao.Value), comboBoxGenero.Text, (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text), Convert.ToInt32(numericUpDownEdicaoHQ.Value), textBoxIlustrador.Text));
            }
            else if (tabControlExemplar.SelectedIndex == 3)
            {
                exemplares.Add(new Generico(textBoxTitulo.Text, textBoxSubTitulo.Text, textBoxEscritor.Text, textBoxEditora.Text, Convert.ToInt32(numericUpDownAnoPublicacao.Value), comboBoxGenero.Text, (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text), (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listBoxTipo.SelectedIndex.ToString())));
            }

            MessageBox.Show("Exemplar cadastrado com sucesso!");
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            exemplar.Titulo = textBoxTitulo.Text;
            exemplar.SubTitulo = textBoxSubTitulo.Text;
            exemplar.Escritor = textBoxEscritor.Text;
            exemplar.Editora = textBoxEditora.Text;
            exemplar.AnoPublicacao = Convert.ToInt32(numericUpDownAnoPublicacao.Value);
            exemplar.Genero = comboBoxGenero.SelectedIndex.ToString();
            exemplar.Status = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);

            if (exemplar is Livro livro)
            {
                livro.Paginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                livro.TipoCapa = comboBoxTipoCapa.Text;
                livro.Isbn = textBoxIsbn.Text;
            }
            else if (exemplar is Ebook ebook)
            {
                ebook.Paginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                ebook.TipoCapa = comboBoxTipoCapa.Text;
                ebook.Isbn = textBoxIsbn.Text;
                ebook.Formato = comboBoxFormato.Text;
                ebook.Tamanho = numericUpDownTamanho.Value;
                ebook.Url = textBoxURL.Text;
            }
            else if (exemplar is Revista revista)
            {
                revista.Edicao = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                revista.Paginas = Convert.ToInt32(numericUpDownPaginasRevista.Value);
            }
            else if (exemplar is Hq hq)
            {
                hq.Edicao = Convert.ToInt32(numericUpDownEdicaoHQ.Value);
                hq.Ilustrador = textBoxIlustrador.Text;
            }
            else if (exemplar is Generico generico)
            {
                generico.Tipo = listBoxTipo.SelectedIndex;
            }

            MessageBox.Show("Exemplar editado com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            exemplares.Remove(exemplar);

            MessageBox.Show("Exemplar removido com sucesso!");
            Close();
        }
    }
}
