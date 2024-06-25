using System;
namespace ProjetoFinalLivraria
{
    internal partial class FormPessoa : Form
    {
        public List<Funcionario> funcionarios;
        public List<Leitor> leitores;
        public List<Exemplar> exemplares;
        public Funcionario funcionario;
        public Leitor leitor;

        public FormPessoa(List<Funcionario> funcionarios, List<Leitor> leitores, List<Exemplar> exemplares)
        {
            InitializeComponent();

            CargaEnum();

            this.funcionarios = funcionarios;
            this.leitores = leitores;
            this.exemplares = exemplares;

            listBoxExemplares.DataSource = exemplares;
            listBoxExemplares.DisplayMember = "Titulo";
        }

        public FormPessoa(List<Funcionario> funcionarios, Funcionario funcionario)
        {
            InitializeComponent();

            CargaEnum();

            this.funcionario = funcionario;
            this.funcionarios = funcionarios;

            listBoxExemplares.DataSource = exemplares;
            listBoxExemplares.DisplayMember = "Titulo";

            textBoxNome.Text = funcionario.Nome;
            dateTimePickerNascimento.Value = funcionario.Nascimento;
            maskedTextBoxCPF.Text = funcionario.Cpf;
            maskedTextBoxEmail.Text = funcionario.Email;
            maskedTextBoxTelefone.Text = funcionario.Telefone;
            comboBoxCargo.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
            numericUpDownSalario.Value = funcionario.Salario;
            numericUpDownCargaHoraria.Value = funcionario.CargaHoraria;
            textBoxFuncao.Text = funcionario.Funcao;

            tabControlPessoa.SelectedIndex = 1;
            tabControlPessoa.TabPages[0].Enabled = false;
            buttonSalvar.Enabled = false;
        }

        public FormPessoa(List<Leitor> leitores, Leitor leitor, List<Exemplar> exemplares)
        {
            InitializeComponent();

            CargaEnum();

            this.leitor = leitor;
            this.leitores = leitores;
            this.exemplares = exemplares;

            listBoxExemplares.DataSource = exemplares;
            listBoxExemplares.DisplayMember = "Titulo";
            listBoxExemplaresLeitor.DataSource = leitor.ExemplaresLeitor;
            listBoxExemplaresLeitor.DisplayMember = "Titulo";

            textBoxNome.Text = leitor.Nome;
            dateTimePickerNascimento.Value = leitor.Nascimento;
            maskedTextBoxCPF.Text = leitor.Cpf;
            maskedTextBoxEmail.Text = leitor.Email;
            maskedTextBoxTelefone.Text = leitor.Telefone;
            listBoxTipoLeitor.SelectedIndex = leitor.Tipo;

            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.TabPages[1].Enabled = false;
            labelExemplares.Enabled = true;
            listBoxExemplares.Enabled = true;
            buttonAdicionaExemplarLeitor.Enabled = true;
            buttonSalvar.Enabled = false;
        }

        public void CargaEnum()
        {
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;

            listBoxTipoLeitor.DataSource = Enum.GetValues(typeof(EnumTipoLeitor));
            listBoxTipoLeitor.SelectedIndex = 0;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                leitores.Add(new Leitor(textBoxNome.Text, dateTimePickerNascimento.Value, maskedTextBoxCPF.Text, maskedTextBoxEmail.Text, maskedTextBoxTelefone.Text, listBoxTipoLeitor.SelectedIndex, new List<Exemplar>()));
            }
            else
            {
                funcionarios.Add(new Funcionario(textBoxNome.Text, dateTimePickerNascimento.Value, maskedTextBoxCPF.Text, maskedTextBoxEmail.Text, maskedTextBoxTelefone.Text, (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text), Convert.ToDecimal(numericUpDownSalario.Text), Convert.ToInt32(numericUpDownCargaHoraria.Text), textBoxFuncao.Text));
            }

            MessageBox.Show("Pessoa cadastrada com sucesso!");
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (tabControlPessoa.SelectedIndex == 0)
            {
                leitor.Nome = textBoxNome.Text;
                leitor.Nascimento = dateTimePickerNascimento.Value;
                leitor.Cpf = maskedTextBoxCPF.Text;
                leitor.Email = maskedTextBoxEmail.Text;
                leitor.Telefone = maskedTextBoxTelefone.Text;
                leitor.Tipo = Convert.ToInt32(listBoxTipoLeitor.SelectedIndex);
                leitor.ExemplaresLeitor = listBoxExemplaresLeitor.Items.Cast<Exemplar>().ToList();
            }
            else
            {
                funcionario.Nome = textBoxNome.Text;
                funcionario.Nascimento = dateTimePickerNascimento.Value;
                funcionario.Cpf = maskedTextBoxCPF.Text;
                funcionario.Email = maskedTextBoxEmail.Text;
                funcionario.Telefone = maskedTextBoxTelefone.Text;
                funcionario.Cargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text);
                funcionario.Salario = numericUpDownSalario.Value;
                funcionario.CargaHoraria = Convert.ToInt32(numericUpDownCargaHoraria.Value);
                funcionario.Funcao = textBoxFuncao.Text;
            }

            MessageBox.Show("Pessoa editada com sucesso!");
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                leitores.Remove(leitor);
                MessageBox.Show("Leitor excluído com sucesso!");
            }
            else if (tabControlPessoa.SelectedIndex == 1)
            {
                funcionarios.Remove(funcionario);
                MessageBox.Show("Funcionário excluído com sucesso!");
            }
            else if (tabControlPessoa.SelectedIndex == 2)
            {
                MessageBox.Show("Exemplar excluída com sucesso!");
            }
            Close();
        }

        private void buttonAdicionaExemplarLeitor_Click(object sender, EventArgs e)
        {
            leitor.AdicionaExemplarLeitor((Exemplar)listBoxExemplares.SelectedItem, leitor);

            listBoxExemplaresLeitor.DataSource = null;
            listBoxExemplaresLeitor.DataSource = leitor.ExemplaresLeitor;
            listBoxExemplaresLeitor.DisplayMember = "Titulo";

            MessageBox.Show("Exemplar adicionado com sucesso!");
        }

        private void listBoxExemplaresLeitor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxExemplaresLeitor.IndexFromPoint(e.Location);

                if (index != ListBox.NoMatches)
                {
                    listBoxExemplaresLeitor.SelectedIndex = index;
                    contextMenuStripExcluirExemplarLeitor.Show(listBoxExemplaresLeitor, e.Location);
                }
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxExemplaresLeitor.SelectedItem != null)
            {
                Exemplar exemplarSelecionado = (Exemplar)listBoxExemplaresLeitor.SelectedItem;
                leitor.ExemplaresLeitor.Remove(exemplarSelecionado);

                listBoxExemplaresLeitor.DataSource = null;
                listBoxExemplaresLeitor.DataSource = leitor.ExemplaresLeitor;
                listBoxExemplaresLeitor.DisplayMember = "Titulo";

                MessageBox.Show("Exemplar excluído com sucesso!");
            }
        }
    }
}
