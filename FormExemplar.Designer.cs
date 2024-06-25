namespace ProjetoFinalLivraria
{
    partial class FormExemplar
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
            buttonSalvar = new Button();
            textBoxTitulo = new TextBox();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelEscritor = new Label();
            labelSubTitulo = new Label();
            labelTitulo = new Label();
            textBoxSubTitulo = new TextBox();
            textBoxEscritor = new TextBox();
            numericUpDownAnoPublicacao = new NumericUpDown();
            comboBoxGenero = new ComboBox();
            comboBoxStatus = new ComboBox();
            labelGenero = new Label();
            labelStatus = new Label();
            numericUpDownPaginasLivro = new NumericUpDown();
            labelPaginas = new Label();
            labelTIpoCapa = new Label();
            comboBoxTipoCapa = new ComboBox();
            labelIsbn = new Label();
            textBoxEditora = new TextBox();
            textBoxIsbn = new TextBox();
            checkBoxEBook = new CheckBox();
            comboBoxFormato = new ComboBox();
            labelFormato = new Label();
            numericUpDownTamanho = new NumericUpDown();
            labelTamanho = new Label();
            textBoxURL = new TextBox();
            labelURL = new Label();
            numericUpDownEdicaoRevista = new NumericUpDown();
            labelEdicaoRevista = new Label();
            numericUpDownPaginasRevista = new NumericUpDown();
            labelPaginasRevista = new Label();
            textBoxIlustrador = new TextBox();
            labelIlustrador = new Label();
            labelTipo = new Label();
            tabControlExemplar = new TabControl();
            tabPageLivro = new TabPage();
            tabPageRevista = new TabPage();
            tabPageHQ = new TabPage();
            numericUpDownEdicaoHQ = new NumericUpDown();
            labelEdicaoHQ = new Label();
            tabPageGenerico = new TabPage();
            listBoxTipo = new ListBox();
            buttonExcluir = new Button();
            buttonEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPublicacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasLivro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasRevista).BeginInit();
            tabControlExemplar.SuspendLayout();
            tabPageLivro.SuspendLayout();
            tabPageRevista.SuspendLayout();
            tabPageHQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoHQ).BeginInit();
            tabPageGenerico.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ActiveCaption;
            buttonSalvar.Location = new Point(25, 413);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(263, 52);
            buttonSalvar.TabIndex = 55;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(25, 35);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(263, 23);
            textBoxTitulo.TabIndex = 36;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(25, 241);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(90, 15);
            labelTelefone.TabIndex = 35;
            labelTelefone.Text = "Ano Publicação";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(25, 180);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 34;
            labelEmail.Text = "Editora";
            // 
            // labelEscritor
            // 
            labelEscritor.AutoSize = true;
            labelEscritor.Location = new Point(25, 127);
            labelEscritor.Name = "labelEscritor";
            labelEscritor.Size = new Size(46, 15);
            labelEscritor.TabIndex = 33;
            labelEscritor.Text = "Escritor";
            // 
            // labelSubTitulo
            // 
            labelSubTitulo.AutoSize = true;
            labelSubTitulo.Location = new Point(25, 72);
            labelSubTitulo.Name = "labelSubTitulo";
            labelSubTitulo.Size = new Size(57, 15);
            labelSubTitulo.TabIndex = 32;
            labelSubTitulo.Text = "SubTitulo";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(25, 17);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(37, 15);
            labelTitulo.TabIndex = 31;
            labelTitulo.Text = "Titulo";
            // 
            // textBoxSubTitulo
            // 
            textBoxSubTitulo.Location = new Point(25, 90);
            textBoxSubTitulo.Name = "textBoxSubTitulo";
            textBoxSubTitulo.Size = new Size(263, 23);
            textBoxSubTitulo.TabIndex = 56;
            // 
            // textBoxEscritor
            // 
            textBoxEscritor.Location = new Point(25, 145);
            textBoxEscritor.Name = "textBoxEscritor";
            textBoxEscritor.Size = new Size(263, 23);
            textBoxEscritor.TabIndex = 57;
            // 
            // numericUpDownAnoPublicacao
            // 
            numericUpDownAnoPublicacao.Location = new Point(25, 259);
            numericUpDownAnoPublicacao.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownAnoPublicacao.Name = "numericUpDownAnoPublicacao";
            numericUpDownAnoPublicacao.Size = new Size(90, 23);
            numericUpDownAnoPublicacao.TabIndex = 58;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(25, 316);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(263, 23);
            comboBoxGenero.TabIndex = 59;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(25, 369);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(263, 23);
            comboBoxStatus.TabIndex = 60;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(25, 298);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 61;
            labelGenero.Text = "Gênero";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(25, 351);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 62;
            labelStatus.Text = "Status";
            // 
            // numericUpDownPaginasLivro
            // 
            numericUpDownPaginasLivro.Location = new Point(10, 30);
            numericUpDownPaginasLivro.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numericUpDownPaginasLivro.Name = "numericUpDownPaginasLivro";
            numericUpDownPaginasLivro.Size = new Size(90, 23);
            numericUpDownPaginasLivro.TabIndex = 66;
            // 
            // labelPaginas
            // 
            labelPaginas.AutoSize = true;
            labelPaginas.Location = new Point(10, 12);
            labelPaginas.Name = "labelPaginas";
            labelPaginas.Size = new Size(48, 15);
            labelPaginas.TabIndex = 65;
            labelPaginas.Text = "Páginas";
            // 
            // labelTIpoCapa
            // 
            labelTIpoCapa.AutoSize = true;
            labelTIpoCapa.Location = new Point(10, 66);
            labelTIpoCapa.Name = "labelTIpoCapa";
            labelTIpoCapa.Size = new Size(76, 15);
            labelTIpoCapa.TabIndex = 68;
            labelTIpoCapa.Text = "Tipo de Capa";
            // 
            // comboBoxTipoCapa
            // 
            comboBoxTipoCapa.FormattingEnabled = true;
            comboBoxTipoCapa.Location = new Point(10, 84);
            comboBoxTipoCapa.Name = "comboBoxTipoCapa";
            comboBoxTipoCapa.Size = new Size(263, 23);
            comboBoxTipoCapa.TabIndex = 67;
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Location = new Point(10, 112);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(32, 15);
            labelIsbn.TabIndex = 69;
            labelIsbn.Text = "ISBN";
            // 
            // textBoxEditora
            // 
            textBoxEditora.Location = new Point(25, 205);
            textBoxEditora.Name = "textBoxEditora";
            textBoxEditora.Size = new Size(263, 23);
            textBoxEditora.TabIndex = 70;
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Location = new Point(10, 137);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(263, 23);
            textBoxIsbn.TabIndex = 71;
            // 
            // checkBoxEBook
            // 
            checkBoxEBook.AutoSize = true;
            checkBoxEBook.Location = new Point(10, 180);
            checkBoxEBook.Name = "checkBoxEBook";
            checkBoxEBook.Size = new Size(59, 19);
            checkBoxEBook.TabIndex = 72;
            checkBoxEBook.Text = "EBook";
            checkBoxEBook.UseVisualStyleBackColor = true;
            checkBoxEBook.CheckedChanged += checkBoxEBook_CheckedChanged;
            // 
            // comboBoxFormato
            // 
            comboBoxFormato.Enabled = false;
            comboBoxFormato.FormattingEnabled = true;
            comboBoxFormato.Location = new Point(10, 226);
            comboBoxFormato.Name = "comboBoxFormato";
            comboBoxFormato.Size = new Size(263, 23);
            comboBoxFormato.TabIndex = 73;
            // 
            // labelFormato
            // 
            labelFormato.AutoSize = true;
            labelFormato.Enabled = false;
            labelFormato.Location = new Point(10, 208);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(52, 15);
            labelFormato.TabIndex = 74;
            labelFormato.Text = "Formato";
            // 
            // numericUpDownTamanho
            // 
            numericUpDownTamanho.Enabled = false;
            numericUpDownTamanho.Location = new Point(10, 279);
            numericUpDownTamanho.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            numericUpDownTamanho.Name = "numericUpDownTamanho";
            numericUpDownTamanho.Size = new Size(90, 23);
            numericUpDownTamanho.TabIndex = 76;
            // 
            // labelTamanho
            // 
            labelTamanho.AutoSize = true;
            labelTamanho.Enabled = false;
            labelTamanho.Location = new Point(10, 261);
            labelTamanho.Name = "labelTamanho";
            labelTamanho.Size = new Size(56, 15);
            labelTamanho.TabIndex = 75;
            labelTamanho.Text = "Tamanho";
            // 
            // textBoxURL
            // 
            textBoxURL.Enabled = false;
            textBoxURL.Location = new Point(10, 336);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(263, 23);
            textBoxURL.TabIndex = 78;
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Enabled = false;
            labelURL.Location = new Point(10, 318);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(28, 15);
            labelURL.TabIndex = 77;
            labelURL.Text = "URL";
            // 
            // numericUpDownEdicaoRevista
            // 
            numericUpDownEdicaoRevista.Location = new Point(10, 30);
            numericUpDownEdicaoRevista.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numericUpDownEdicaoRevista.Name = "numericUpDownEdicaoRevista";
            numericUpDownEdicaoRevista.Size = new Size(90, 23);
            numericUpDownEdicaoRevista.TabIndex = 80;
            // 
            // labelEdicaoRevista
            // 
            labelEdicaoRevista.AutoSize = true;
            labelEdicaoRevista.Location = new Point(10, 11);
            labelEdicaoRevista.Name = "labelEdicaoRevista";
            labelEdicaoRevista.Size = new Size(42, 15);
            labelEdicaoRevista.TabIndex = 79;
            labelEdicaoRevista.Text = "Edição";
            // 
            // numericUpDownPaginasRevista
            // 
            numericUpDownPaginasRevista.Location = new Point(10, 84);
            numericUpDownPaginasRevista.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numericUpDownPaginasRevista.Name = "numericUpDownPaginasRevista";
            numericUpDownPaginasRevista.Size = new Size(90, 23);
            numericUpDownPaginasRevista.TabIndex = 82;
            // 
            // labelPaginasRevista
            // 
            labelPaginasRevista.AutoSize = true;
            labelPaginasRevista.Location = new Point(10, 66);
            labelPaginasRevista.Name = "labelPaginasRevista";
            labelPaginasRevista.Size = new Size(48, 15);
            labelPaginasRevista.TabIndex = 81;
            labelPaginasRevista.Text = "Páginas";
            // 
            // textBoxIlustrador
            // 
            textBoxIlustrador.Location = new Point(10, 84);
            textBoxIlustrador.Name = "textBoxIlustrador";
            textBoxIlustrador.Size = new Size(263, 23);
            textBoxIlustrador.TabIndex = 84;
            // 
            // labelIlustrador
            // 
            labelIlustrador.AutoSize = true;
            labelIlustrador.Location = new Point(10, 66);
            labelIlustrador.Name = "labelIlustrador";
            labelIlustrador.Size = new Size(57, 15);
            labelIlustrador.TabIndex = 83;
            labelIlustrador.Text = "Ilustrador";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(10, 12);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 86;
            labelTipo.Text = "Tipo";
            // 
            // tabControlExemplar
            // 
            tabControlExemplar.Controls.Add(tabPageLivro);
            tabControlExemplar.Controls.Add(tabPageRevista);
            tabControlExemplar.Controls.Add(tabPageHQ);
            tabControlExemplar.Controls.Add(tabPageGenerico);
            tabControlExemplar.Location = new Point(346, 35);
            tabControlExemplar.Name = "tabControlExemplar";
            tabControlExemplar.SelectedIndex = 0;
            tabControlExemplar.Size = new Size(317, 430);
            tabControlExemplar.TabIndex = 87;
            // 
            // tabPageLivro
            // 
            tabPageLivro.Controls.Add(numericUpDownPaginasLivro);
            tabPageLivro.Controls.Add(labelPaginas);
            tabPageLivro.Controls.Add(comboBoxTipoCapa);
            tabPageLivro.Controls.Add(labelTIpoCapa);
            tabPageLivro.Controls.Add(textBoxIsbn);
            tabPageLivro.Controls.Add(textBoxURL);
            tabPageLivro.Controls.Add(labelIsbn);
            tabPageLivro.Controls.Add(labelURL);
            tabPageLivro.Controls.Add(comboBoxFormato);
            tabPageLivro.Controls.Add(numericUpDownTamanho);
            tabPageLivro.Controls.Add(checkBoxEBook);
            tabPageLivro.Controls.Add(labelTamanho);
            tabPageLivro.Controls.Add(labelFormato);
            tabPageLivro.Location = new Point(4, 24);
            tabPageLivro.Name = "tabPageLivro";
            tabPageLivro.Padding = new Padding(3);
            tabPageLivro.Size = new Size(309, 402);
            tabPageLivro.TabIndex = 0;
            tabPageLivro.Text = "Livro";
            tabPageLivro.UseVisualStyleBackColor = true;
            // 
            // tabPageRevista
            // 
            tabPageRevista.Controls.Add(numericUpDownEdicaoRevista);
            tabPageRevista.Controls.Add(labelEdicaoRevista);
            tabPageRevista.Controls.Add(numericUpDownPaginasRevista);
            tabPageRevista.Controls.Add(labelPaginasRevista);
            tabPageRevista.Location = new Point(4, 24);
            tabPageRevista.Name = "tabPageRevista";
            tabPageRevista.Padding = new Padding(3);
            tabPageRevista.Size = new Size(309, 402);
            tabPageRevista.TabIndex = 1;
            tabPageRevista.Text = "Revista";
            tabPageRevista.UseVisualStyleBackColor = true;
            // 
            // tabPageHQ
            // 
            tabPageHQ.Controls.Add(numericUpDownEdicaoHQ);
            tabPageHQ.Controls.Add(labelEdicaoHQ);
            tabPageHQ.Controls.Add(textBoxIlustrador);
            tabPageHQ.Controls.Add(labelIlustrador);
            tabPageHQ.Location = new Point(4, 24);
            tabPageHQ.Name = "tabPageHQ";
            tabPageHQ.Padding = new Padding(3);
            tabPageHQ.Size = new Size(309, 402);
            tabPageHQ.TabIndex = 2;
            tabPageHQ.Text = "HQ";
            tabPageHQ.UseVisualStyleBackColor = true;
            // 
            // numericUpDownEdicaoHQ
            // 
            numericUpDownEdicaoHQ.Location = new Point(10, 30);
            numericUpDownEdicaoHQ.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            numericUpDownEdicaoHQ.Name = "numericUpDownEdicaoHQ";
            numericUpDownEdicaoHQ.Size = new Size(90, 23);
            numericUpDownEdicaoHQ.TabIndex = 86;
            // 
            // labelEdicaoHQ
            // 
            labelEdicaoHQ.AutoSize = true;
            labelEdicaoHQ.Location = new Point(10, 11);
            labelEdicaoHQ.Name = "labelEdicaoHQ";
            labelEdicaoHQ.Size = new Size(42, 15);
            labelEdicaoHQ.TabIndex = 85;
            labelEdicaoHQ.Text = "Edição";
            // 
            // tabPageGenerico
            // 
            tabPageGenerico.Controls.Add(listBoxTipo);
            tabPageGenerico.Controls.Add(labelTipo);
            tabPageGenerico.Location = new Point(4, 24);
            tabPageGenerico.Name = "tabPageGenerico";
            tabPageGenerico.Padding = new Padding(3);
            tabPageGenerico.Size = new Size(309, 402);
            tabPageGenerico.TabIndex = 3;
            tabPageGenerico.Text = "Genérico";
            tabPageGenerico.UseVisualStyleBackColor = true;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Location = new Point(10, 30);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(281, 319);
            listBoxTipo.TabIndex = 87;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.Red;
            buttonExcluir.Location = new Point(541, 485);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(122, 52);
            buttonExcluir.TabIndex = 89;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.LimeGreen;
            buttonEditar.Location = new Point(346, 485);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(128, 52);
            buttonEditar.TabIndex = 88;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // FormExemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(689, 555);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(tabControlExemplar);
            Controls.Add(textBoxEditora);
            Controls.Add(labelStatus);
            Controls.Add(labelGenero);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxGenero);
            Controls.Add(numericUpDownAnoPublicacao);
            Controls.Add(textBoxEscritor);
            Controls.Add(textBoxSubTitulo);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelTelefone);
            Controls.Add(labelEmail);
            Controls.Add(labelEscritor);
            Controls.Add(labelSubTitulo);
            Controls.Add(labelTitulo);
            Name = "FormExemplar";
            Text = "Cadastro Exemplar";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPublicacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasLivro).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanho).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginasRevista).EndInit();
            tabControlExemplar.ResumeLayout(false);
            tabPageLivro.ResumeLayout(false);
            tabPageLivro.PerformLayout();
            tabPageRevista.ResumeLayout(false);
            tabPageRevista.PerformLayout();
            tabPageHQ.ResumeLayout(false);
            tabPageHQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoHQ).EndInit();
            tabPageGenerico.ResumeLayout(false);
            tabPageGenerico.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalvar;
        private TextBox textBoxTitulo;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelEscritor;
        private Label labelSubTitulo;
        private Label labelTitulo;
        private TextBox textBoxSubTitulo;
        private TextBox textBoxEscritor;
        private NumericUpDown numericUpDownAnoPublicacao;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxStatus;
        private Label labelGenero;
        private Label labelStatus;
        private NumericUpDown numericUpDownPaginasLivro;
        private Label labelPaginas;
        private Label labelTIpoCapa;
        private ComboBox comboBoxTipoCapa;
        private Label labelIsbn;
        private TextBox textBoxEditora;
        private TextBox textBoxIsbn;
        private CheckBox checkBoxEBook;
        private ComboBox comboBoxFormato;
        private Label labelFormato;
        private NumericUpDown numericUpDownTamanho;
        private Label labelTamanho;
        private TextBox textBoxURL;
        private Label labelURL;
        private NumericUpDown numericUpDownEdicaoRevista;
        private Label labelEdicaoRevista;
        private NumericUpDown numericUpDownPaginasRevista;
        private Label labelPaginasRevista;
        private TextBox textBoxIlustrador;
        private Label labelIlustrador;
        private Label labelTipo;
        private TabControl tabControlExemplar;
        private TabPage tabPageLivro;
        private TabPage tabPageRevista;
        private TabPage tabPageHQ;
        private TabPage tabPageGenerico;
        private NumericUpDown numericUpDownEdicaoHQ;
        private Label labelEdicaoHQ;
        private ListBox listBoxTipo;
        private Button buttonExcluir;
        private Button buttonEditar;
    }
}