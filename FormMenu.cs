namespace ProjetoFinalLivraria
{
    public partial class FormMenu : Form
    {
        List<Funcionario> funcionarios;
        List<Leitor> leitores;
        List<Exemplar> exemplares;

        public FormMenu()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();
            leitores = new List<Leitor>();
            exemplares = new List<Exemplar>();

            CargaInicial();
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dataGridViewFuncionarios.DataSource = null;
            dataGridViewFuncionarios.DataSource = funcionarios;

            dataGridViewLeitores.DataSource = null;
            dataGridViewLeitores.DataSource = leitores;

            dataGridViewExemplares.DataSource = null;
            dataGridViewExemplares.DataSource = exemplares;
        }

        private void CargaInicial()
        {
            Leitor leitor1 = new("leitor 1", DateTime.Today, "cpf0", "email0", "tel0", 0, new List<Exemplar>());
            leitor1.ExemplaresLeitor.Add(new Livro("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "1", 1, 100, "1", "isbn1"));
            leitor1.ExemplaresLeitor.Add(new Ebook("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "6", 1, 123, "6", "isbn1", "1", 1, "url1"));
            leitor1.ExemplaresLeitor.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "3", 1, 324, 1));
            leitor1.ExemplaresLeitor.Add(new Hq("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "8", 1, 432, "ilustrador1"));
            leitor1.ExemplaresLeitor.Add(new Generico("genérico 1", "subtitulo1", "escritor1", "editora1", 2021, "5", 1, 0));

            Leitor leitor2 = new("leitor 2", DateTime.Today, "cpf2", "email2", "tel2", 1, new List<Exemplar>());
            leitor2.ExemplaresLeitor.Add(new Livro("livro 2", "subtitulo2", "escritor2", "editora2", 2022, "2", 2, 200, "2", "isbn2"));
            leitor2.ExemplaresLeitor.Add(new Ebook("ebook 2", "subtitulo2", "escritor2", "editora2", 2022, "7", 2, 223, "7", "isbn2", "2", 2, "url2"));
            leitor2.ExemplaresLeitor.Add(new Revista("revista 2", "subtitulo2", "escritor2", "editora2", 2022, "4", 2, 424, 2));
            leitor2.ExemplaresLeitor.Add(new Hq("hq 2", "subtitulo2", "escritor2", "editora2", 2022, "9", 2, 532, "ilustrador2"));
            leitor2.ExemplaresLeitor.Add(new Generico("genérico 2", "subtitulo2", "escritor2", "editora2", 2022, "6", 2, 1));

            Leitor leitor3 = new("leitor 3", DateTime.Today, "cpf3", "email3", "tel3", 2, new List<Exemplar>());
            leitor3.ExemplaresLeitor.Add(new Livro("livro 3", "subtitulo3", "escritor3", "editora3", 2023, "3", 3, 300, "3", "isbn3"));
            leitor3.ExemplaresLeitor.Add(new Ebook("ebook 3", "subtitulo3", "escritor3", "editora3", 2023, "8", 3, 323, "8", "isbn3", "3", 3, "url3"));
            leitor3.ExemplaresLeitor.Add(new Revista("revista 3", "subtitulo3", "escritor3", "editora3", 2023, "5", 3, 524, 3));
            leitor3.ExemplaresLeitor.Add(new Hq("hq 3", "subtitulo3", "escritor3", "editora3", 2023, "10", 3, 632, "ilustrador3"));
            leitor3.ExemplaresLeitor.Add(new Generico("genérico 3", "subtitulo3", "escritor3", "editora3", 2023, "7", 3, 2));

            Leitor leitor4 = new("leitor 4", DateTime.Today, "cpf4", "email4", "tel4", 3, new List<Exemplar>());
            leitor4.ExemplaresLeitor.Add(new Livro("livro 4", "subtitulo4", "escritor4", "editora4", 2024, "4", 4, 400, "4", "isbn4"));
            leitor4.ExemplaresLeitor.Add(new Ebook("ebook 4", "subtitulo4", "escritor4", "editora4", 2024, "9", 4, 423, "9", "isbn4", "4", 4, "url4"));
            leitor4.ExemplaresLeitor.Add(new Revista("revista 4", "subtitulo4", "escritor4", "editora4", 2024, "6", 4, 624, 4));
            leitor4.ExemplaresLeitor.Add(new Hq("hq 4", "subtitulo4", "escritor4", "editora4", 2024, "11", 4, 732, "ilustrador4"));
            leitor4.ExemplaresLeitor.Add(new Generico("genérico 4", "subtitulo4", "escritor4", "editora4", 2024, "8", 4, 3));


            Leitor leitor5 = new("leitor 5", DateTime.Today, "cpf5", "email5", "tel5", 4, new List<Exemplar>());
            leitor5.ExemplaresLeitor.Add(new Livro("livro 5", "subtitulo5", "escritor5", "editora5", 2025, "5", 5, 500, "5", "isbn5"));
            leitor5.ExemplaresLeitor.Add(new Ebook("ebook 5", "subtitulo5", "escritor5", "editora5", 2025, "10", 5, 523, "10", "isbn5", "5", 5, "url5"));
            leitor5.ExemplaresLeitor.Add(new Revista("revista 5", "subtitulo5", "escritor5", "editora5", 2025, "7", 5, 724, 5));
            leitor5.ExemplaresLeitor.Add(new Hq("hq 5", "subtitulo5", "escritor5", "editora5", 2025, "12", 5, 832, "ilustrador5"));
            leitor5.ExemplaresLeitor.Add(new Generico("genérico 5", "subtitulo5", "escritor5", "editora5", 2025, "9", 5, 4));

            leitores.Add(leitor1);
            leitores.Add(leitor2);
            leitores.Add(leitor3);
            leitores.Add(leitor4);
            leitores.Add(leitor5);
            //leitores.Add(new Leitor("leitor 0", DateTime.Today, "cpf0", "email0", "tel0", 0, exemplares));
            //leitores.Add(new Leitor("leitor 1", DateTime.Today, "cpf1", "email1", "tel1", 1, exemplares));
            //leitores.Add(new Leitor("leitor 2", DateTime.Today, "cpf2", "email2", "tel2", 2, exemplares));
            //leitores.Add(new Leitor("leitor 3", DateTime.Today, "cpf3", "email3", "tel3", 3, exemplares));
            //leitores.Add(new Leitor("leitor 4", DateTime.Today, "cpf4", "email4", "tel4", 4, exemplares));
            //leitores.Add(new Leitor("leitor 5", DateTime.Today, "cpf5", "email5", "tel5", 5, exemplares));

            funcionarios.Add(new Funcionario("funcionário 1", DateTime.Today, "cpf1", "email1", "tel1", 1, 3333.33M, 8, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 2", DateTime.Today, "cpf2", "email2", "tel2", 2, 3333.33M, 8, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 3", DateTime.Today, "cpf3", "email3", "tel3", 3, 1024.00M, 6, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 4", DateTime.Today, "cpf4", "email4", "tel4", 2, 2222.22M, 8, "fun1"));
            funcionarios.Add(new Funcionario("funcionário 5", DateTime.Today, "cpf5", "email5", "tel5", 4, 2222.22M, 8, "fun1"));

            exemplares.Add(new Livro("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "1", 1, 100, "1", "isbn1"));
            exemplares.Add(new Livro("livro 2", "subtitulo2", "escritor2", "editora2", 2021, "2", 2, 112, "2", "isbn2"));
            exemplares.Add(new Livro("livro 3", "subtitulo3", "escritor3", "editora3", 2021, "3", 3, 132, "3", "isbn3"));
            exemplares.Add(new Livro("livro 4", "subtitulo4", "escritor4", "editora4", 2021, "4", 4, 234, "4", "isbn4"));
            exemplares.Add(new Livro("livro 5", "subtitulo5", "escritor5", "editora5", 2021, "5", 5, 432, "5", "isbn5"));
            exemplares.Add(new Ebook("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "6", 1, 123, "6", "isbn1", "1", 1, "url1"));
            exemplares.Add(new Ebook("ebook 2", "subtitulo2", "escritor2", "editora2", 2021, "7", 2, 321, "7", "isbn2", "2", 1, "url2"));
            exemplares.Add(new Ebook("ebook 3", "subtitulo3", "escritor3", "editora3", 2021, "8", 3, 987, "8", "isbn3", "3", 1, "url3"));
            exemplares.Add(new Ebook("ebook 4", "subtitulo4", "escritor4", "editora4", 2021, "1", 4, 31, "9", "isbn4", "4", 1, "url4"));
            exemplares.Add(new Ebook("ebook 5", "subtitulo5", "escritor5", "editora5", 2021, "2", 5, 909, "10", "isbn5", "5", 1, "url5"));
            exemplares.Add(new Revista("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "3", 1, 324, 1));
            exemplares.Add(new Revista("revista 2", "subtitulo2", "escritor2", "editora2", 2021, "4", 2, 123, 1));
            exemplares.Add(new Revista("revista 3", "subtitulo3", "escritor3", "editora3", 2021, "5", 3, 654, 1));
            exemplares.Add(new Revista("revista 4", "subtitulo4", "escritor4", "editora4", 2021, "6", 4, 764, 1));
            exemplares.Add(new Revista("revista 5", "subtitulo5", "escritor5", "editora5", 2021, "7", 5, 234, 1));
            exemplares.Add(new Hq("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "8", 1, 432, "ilustrador1"));
            exemplares.Add(new Hq("hq 2", "subtitulo2", "escritor2", "editora2", 2021, "1", 2, 542, "ilustrador2"));
            exemplares.Add(new Hq("hq 3", "subtitulo3", "escritor3", "editora3", 2021, "2", 3, 298, "ilustrador3"));
            exemplares.Add(new Hq("hq 4", "subtitulo4", "escritor4", "editora4", 2021, "3", 4, 342, "ilustrador4"));
            exemplares.Add(new Hq("hq 5", "subtitulo5", "escritor5", "editora5", 2021, "4", 5, 98, "ilustrador5"));
            exemplares.Add(new Generico("genérico 1", "subtitulo1", "escritor1", "editora1", 2021, "5", 1, 0));
            exemplares.Add(new Generico("genérico 2", "subtitulo2", "escritor2", "editora2", 2021, "6", 2, 1));
            exemplares.Add(new Generico("genérico 3", "subtitulo3", "escritor3", "editora3", 2021, "7", 3, 2));
            exemplares.Add(new Generico("genérico 4", "subtitulo4", "escritor4", "editora4", 2021, "8", 4, 3));
            exemplares.Add(new Generico("genérico 5", "subtitulo5", "escritor5", "editora5", 2021, "1", 5, 4));
        }

        private void buttonCadPessoa_Click(object sender, EventArgs e)
        {
            FormPessoa menuPessoa = new(funcionarios, leitores, exemplares);
            menuPessoa.StartPosition = FormStartPosition.CenterParent;
            menuPessoa.ShowDialog();

            AtualizarDataGridView();
        }

        private void buttonCadExemplares_Click(object sender, EventArgs e)
        {
            FormExemplar menuExemplar = new(exemplares);
            menuExemplar.StartPosition = FormStartPosition.CenterParent;
            menuExemplar.ShowDialog();

            AtualizarDataGridView();
        }

        private void dataGridViewLeitores_DoubleClick(object sender, EventArgs e)
        {
            var leitor = dataGridViewLeitores.CurrentRow.DataBoundItem as Leitor;

            var form = new FormPessoa(leitores, leitor, exemplares);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            AtualizarDataGridView();
        }

        private void dataGridViewFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            var funcionario = dataGridViewFuncionarios.CurrentRow.DataBoundItem as Funcionario;

            var form = new FormPessoa(funcionarios, funcionario);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            AtualizarDataGridView();
        }

        private void dataGridViewExemplares_DoubleClick(object sender, EventArgs e)
        {
            var exemplar = dataGridViewExemplares.CurrentRow.DataBoundItem as Exemplar;

            var form = new FormExemplar(exemplares, exemplar);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            AtualizarDataGridView();
        }

        private void dataGridViewExemplares_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridViewExemplares.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridViewExemplares.ClearSelection();
                    dataGridViewExemplares.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStripExemplar.Show(dataGridViewExemplares, e.Location);
                }
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewExemplares.SelectedRows.Count > 0)
            {
                exemplares.Remove(exemplares[dataGridViewExemplares.SelectedRows[0].Index]);
                MessageBox.Show("Exemplar excluído com sucesso!");

                AtualizarDataGridView();
            }
        }
    }
}
