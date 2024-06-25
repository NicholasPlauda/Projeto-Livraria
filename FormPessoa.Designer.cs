namespace ProjetoFinalLivraria
{
    partial class FormPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelNome = new Label();
            labelDataNascimento = new Label();
            labelCPF = new Label();
            labelEmail = new Label();
            labelTelefone = new Label();
            textBoxNome = new TextBox();
            dateTimePickerNascimento = new DateTimePicker();
            maskedTextBoxCPF = new MaskedTextBox();
            maskedTextBoxEmail = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            labelTipo = new Label();
            labelCargaHoraria = new Label();
            labelSalario = new Label();
            labelCargo = new Label();
            textBoxFuncao = new TextBox();
            labelFuncao = new Label();
            buttonSalvar = new Button();
            comboBoxCargo = new ComboBox();
            tabControlPessoa = new TabControl();
            tabPageLeitor = new TabPage();
            labelExemplaresLeitor = new Label();
            listBoxExemplaresLeitor = new ListBox();
            listBoxTipoLeitor = new ListBox();
            tabPageFuncionario = new TabPage();
            numericUpDownCargaHoraria = new NumericUpDown();
            numericUpDownSalario = new NumericUpDown();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            listBoxExemplares = new ListBox();
            buttonAdicionaExemplarLeitor = new Button();
            labelExemplares = new Label();
            contextMenuStripExcluirExemplarLeitor = new ContextMenuStrip(components);
            excluirToolStripMenuItem = new ToolStripMenuItem();
            tabControlPessoa.SuspendLayout();
            tabPageLeitor.SuspendLayout();
            tabPageFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaHoraria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).BeginInit();
            contextMenuStripExcluirExemplarLeitor.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(22, 18);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(22, 73);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(117, 15);
            labelDataNascimento.TabIndex = 1;
            labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(22, 128);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(28, 15);
            labelCPF.TabIndex = 2;
            labelCPF.Text = "CPF";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(22, 181);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "E-mail";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(22, 232);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 4;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(22, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(263, 23);
            textBoxNome.TabIndex = 5;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.Location = new Point(22, 91);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(263, 23);
            dateTimePickerNascimento.TabIndex = 6;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(22, 146);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(263, 23);
            maskedTextBoxCPF.TabIndex = 7;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.Location = new Point(22, 199);
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(263, 23);
            maskedTextBoxEmail.TabIndex = 8;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(22, 250);
            maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(263, 23);
            maskedTextBoxTelefone.TabIndex = 9;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(6, 13);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 14;
            labelTipo.Text = "Tipo";
            // 
            // labelCargaHoraria
            // 
            labelCargaHoraria.AutoSize = true;
            labelCargaHoraria.Location = new Point(6, 141);
            labelCargaHoraria.Name = "labelCargaHoraria";
            labelCargaHoraria.Size = new Size(80, 15);
            labelCargaHoraria.TabIndex = 20;
            labelCargaHoraria.Text = "Carga Horária";
            // 
            // labelSalario
            // 
            labelSalario.AutoSize = true;
            labelSalario.Location = new Point(6, 76);
            labelSalario.Name = "labelSalario";
            labelSalario.Size = new Size(42, 15);
            labelSalario.TabIndex = 19;
            labelSalario.Text = "Salário";
            // 
            // labelCargo
            // 
            labelCargo.AutoSize = true;
            labelCargo.Location = new Point(6, 19);
            labelCargo.Name = "labelCargo";
            labelCargo.Size = new Size(39, 15);
            labelCargo.TabIndex = 18;
            labelCargo.Text = "Cargo";
            // 
            // textBoxFuncao
            // 
            textBoxFuncao.Location = new Point(6, 213);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(218, 23);
            textBoxFuncao.TabIndex = 27;
            // 
            // labelFuncao
            // 
            labelFuncao.AutoSize = true;
            labelFuncao.Location = new Point(6, 195);
            labelFuncao.Name = "labelFuncao";
            labelFuncao.Size = new Size(46, 15);
            labelFuncao.TabIndex = 26;
            labelFuncao.Text = "Função";
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ActiveCaption;
            buttonSalvar.Location = new Point(22, 478);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(263, 52);
            buttonSalvar.TabIndex = 28;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Location = new Point(6, 37);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(218, 23);
            comboBoxCargo.TabIndex = 29;
            // 
            // tabControlPessoa
            // 
            tabControlPessoa.Controls.Add(tabPageLeitor);
            tabControlPessoa.Controls.Add(tabPageFuncionario);
            tabControlPessoa.Location = new Point(332, 18);
            tabControlPessoa.Name = "tabControlPessoa";
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.Size = new Size(450, 335);
            tabControlPessoa.TabIndex = 31;
            // 
            // tabPageLeitor
            // 
            tabPageLeitor.Controls.Add(labelExemplaresLeitor);
            tabPageLeitor.Controls.Add(listBoxExemplaresLeitor);
            tabPageLeitor.Controls.Add(listBoxTipoLeitor);
            tabPageLeitor.Controls.Add(labelTipo);
            tabPageLeitor.Location = new Point(4, 24);
            tabPageLeitor.Name = "tabPageLeitor";
            tabPageLeitor.Padding = new Padding(3);
            tabPageLeitor.Size = new Size(442, 307);
            tabPageLeitor.TabIndex = 0;
            tabPageLeitor.Text = "Leitor";
            tabPageLeitor.UseVisualStyleBackColor = true;
            // 
            // labelExemplaresLeitor
            // 
            labelExemplaresLeitor.AutoSize = true;
            labelExemplaresLeitor.Location = new Point(293, 13);
            labelExemplaresLeitor.Name = "labelExemplaresLeitor";
            labelExemplaresLeitor.Size = new Size(117, 15);
            labelExemplaresLeitor.TabIndex = 33;
            labelExemplaresLeitor.Text = "Exemplares do Leitor";
            // 
            // listBoxExemplaresLeitor
            // 
            listBoxExemplaresLeitor.FormattingEnabled = true;
            listBoxExemplaresLeitor.ItemHeight = 15;
            listBoxExemplaresLeitor.Location = new Point(293, 31);
            listBoxExemplaresLeitor.Name = "listBoxExemplaresLeitor";
            listBoxExemplaresLeitor.Size = new Size(138, 259);
            listBoxExemplaresLeitor.TabIndex = 32;
            listBoxExemplaresLeitor.MouseDown += listBoxExemplaresLeitor_MouseDown;
            // 
            // listBoxTipoLeitor
            // 
            listBoxTipoLeitor.FormattingEnabled = true;
            listBoxTipoLeitor.ItemHeight = 15;
            listBoxTipoLeitor.Location = new Point(6, 31);
            listBoxTipoLeitor.Name = "listBoxTipoLeitor";
            listBoxTipoLeitor.Size = new Size(270, 259);
            listBoxTipoLeitor.TabIndex = 31;
            // 
            // tabPageFuncionario
            // 
            tabPageFuncionario.Controls.Add(numericUpDownCargaHoraria);
            tabPageFuncionario.Controls.Add(numericUpDownSalario);
            tabPageFuncionario.Controls.Add(labelCargo);
            tabPageFuncionario.Controls.Add(labelSalario);
            tabPageFuncionario.Controls.Add(textBoxFuncao);
            tabPageFuncionario.Controls.Add(labelFuncao);
            tabPageFuncionario.Controls.Add(comboBoxCargo);
            tabPageFuncionario.Controls.Add(labelCargaHoraria);
            tabPageFuncionario.Location = new Point(4, 24);
            tabPageFuncionario.Name = "tabPageFuncionario";
            tabPageFuncionario.Padding = new Padding(3);
            tabPageFuncionario.Size = new Size(442, 307);
            tabPageFuncionario.TabIndex = 1;
            tabPageFuncionario.Text = "Funcionário";
            tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCargaHoraria
            // 
            numericUpDownCargaHoraria.Location = new Point(6, 159);
            numericUpDownCargaHoraria.Name = "numericUpDownCargaHoraria";
            numericUpDownCargaHoraria.Size = new Size(218, 23);
            numericUpDownCargaHoraria.TabIndex = 31;
            // 
            // numericUpDownSalario
            // 
            numericUpDownSalario.Location = new Point(6, 94);
            numericUpDownSalario.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownSalario.Name = "numericUpDownSalario";
            numericUpDownSalario.Size = new Size(218, 23);
            numericUpDownSalario.TabIndex = 30;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.LimeGreen;
            buttonEditar.Location = new Point(332, 478);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(128, 52);
            buttonEditar.TabIndex = 32;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Location = new Point(500, 478);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(122, 52);
            buttonExcluir.TabIndex = 33;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // listBoxExemplares
            // 
            listBoxExemplares.Enabled = false;
            listBoxExemplares.FormattingEnabled = true;
            listBoxExemplares.ItemHeight = 15;
            listBoxExemplares.Location = new Point(22, 309);
            listBoxExemplares.Name = "listBoxExemplares";
            listBoxExemplares.Size = new Size(263, 79);
            listBoxExemplares.TabIndex = 34;
            // 
            // buttonAdicionaExemplarLeitor
            // 
            buttonAdicionaExemplarLeitor.Enabled = false;
            buttonAdicionaExemplarLeitor.Location = new Point(22, 410);
            buttonAdicionaExemplarLeitor.Name = "buttonAdicionaExemplarLeitor";
            buttonAdicionaExemplarLeitor.Size = new Size(117, 35);
            buttonAdicionaExemplarLeitor.TabIndex = 35;
            buttonAdicionaExemplarLeitor.Text = "Adiciona Exemplar";
            buttonAdicionaExemplarLeitor.UseVisualStyleBackColor = true;
            buttonAdicionaExemplarLeitor.Click += buttonAdicionaExemplarLeitor_Click;
            // 
            // labelExemplares
            // 
            labelExemplares.AutoSize = true;
            labelExemplares.Enabled = false;
            labelExemplares.Location = new Point(25, 289);
            labelExemplares.Name = "labelExemplares";
            labelExemplares.Size = new Size(67, 15);
            labelExemplares.TabIndex = 36;
            labelExemplares.Text = "Exemplares";
            // 
            // contextMenuStripExcluirExemplarLeitor
            // 
            contextMenuStripExcluirExemplarLeitor.Items.AddRange(new ToolStripItem[] { excluirToolStripMenuItem });
            contextMenuStripExcluirExemplarLeitor.Name = "contextMenuStrip1";
            contextMenuStripExcluirExemplarLeitor.Size = new Size(181, 48);
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(180, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // FormPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(993, 542);
            Controls.Add(labelExemplares);
            Controls.Add(buttonAdicionaExemplarLeitor);
            Controls.Add(listBoxExemplares);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(tabControlPessoa);
            Controls.Add(buttonSalvar);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxEmail);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(dateTimePickerNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(labelTelefone);
            Controls.Add(labelEmail);
            Controls.Add(labelCPF);
            Controls.Add(labelDataNascimento);
            Controls.Add(labelNome);
            Name = "FormPessoa";
            Text = "Cadastro Pessoa";
            tabControlPessoa.ResumeLayout(false);
            tabPageLeitor.ResumeLayout(false);
            tabPageLeitor.PerformLayout();
            tabPageFuncionario.ResumeLayout(false);
            tabPageFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaHoraria).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).EndInit();
            contextMenuStripExcluirExemplarLeitor.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelDataNascimento;
        private Label labelCPF;
        private Label labelEmail;
        private Label labelTelefone;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerNascimento;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxEmail;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label labelTipo;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label labelCargaHoraria;
        private Label labelSalario;
        private Label labelCargo;
        private TextBox textBoxFuncao;
        private Label labelFuncao;
        private Button buttonSalvar;
        private ComboBox comboBoxCargo;
        private TabControl tabControlPessoa;
        private TabPage tabPageLeitor;
        private TabPage tabPageFuncionario;
        private ListBox listBoxTipoLeitor;
        private NumericUpDown numericUpDownSalario;
        private NumericUpDown numericUpDownCargaHoraria;
        private Button buttonEditar;
        private Button buttonExcluir;
        private ListBox listBoxExemplaresLeitor;
        private ListBox listBoxExemplares;
        private Button buttonAdicionaExemplarLeitor;
        private Label labelExemplares;
        private Label labelExemplaresLeitor;
        private ContextMenuStrip contextMenuStripExcluirExemplarLeitor;
        private ToolStripMenuItem excluirToolStripMenuItem;
    }
}