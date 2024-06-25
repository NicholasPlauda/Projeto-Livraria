namespace ProjetoFinalLivraria
{
    partial class FormMenu
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
            buttonCadPessoa = new Button();
            buttonCadExemplares = new Button();
            tabControlPessoa = new TabControl();
            tabPageFuncionario = new TabPage();
            dataGridViewFuncionarios = new DataGridView();
            tabPageLeitor = new TabPage();
            dataGridViewLeitores = new DataGridView();
            tabControlExemplar = new TabPage();
            dataGridViewExemplares = new DataGridView();
            folderBrowserDialog1 = new FolderBrowserDialog();
            contextMenuStripExemplar = new ContextMenuStrip(components);
            excluirToolStripMenuItem = new ToolStripMenuItem();
            tabControlPessoa.SuspendLayout();
            tabPageFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            tabPageLeitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).BeginInit();
            tabControlExemplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).BeginInit();
            contextMenuStripExemplar.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCadPessoa
            // 
            buttonCadPessoa.BackColor = SystemColors.ActiveCaption;
            buttonCadPessoa.Location = new Point(12, 42);
            buttonCadPessoa.Name = "buttonCadPessoa";
            buttonCadPessoa.Size = new Size(206, 49);
            buttonCadPessoa.TabIndex = 0;
            buttonCadPessoa.Text = "Cadastro Pessoa";
            buttonCadPessoa.UseVisualStyleBackColor = false;
            buttonCadPessoa.Click += buttonCadPessoa_Click;
            // 
            // buttonCadExemplares
            // 
            buttonCadExemplares.BackColor = SystemColors.ActiveCaption;
            buttonCadExemplares.Location = new Point(12, 133);
            buttonCadExemplares.Name = "buttonCadExemplares";
            buttonCadExemplares.Size = new Size(206, 49);
            buttonCadExemplares.TabIndex = 1;
            buttonCadExemplares.Text = "Cadastro Exemplar";
            buttonCadExemplares.UseVisualStyleBackColor = false;
            buttonCadExemplares.Click += buttonCadExemplares_Click;
            // 
            // tabControlPessoa
            // 
            tabControlPessoa.Controls.Add(tabPageFuncionario);
            tabControlPessoa.Controls.Add(tabPageLeitor);
            tabControlPessoa.Controls.Add(tabControlExemplar);
            tabControlPessoa.Location = new Point(276, 42);
            tabControlPessoa.Name = "tabControlPessoa";
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.Size = new Size(726, 560);
            tabControlPessoa.TabIndex = 2;
            // 
            // tabPageFuncionario
            // 
            tabPageFuncionario.Controls.Add(dataGridViewFuncionarios);
            tabPageFuncionario.Location = new Point(4, 24);
            tabPageFuncionario.Name = "tabPageFuncionario";
            tabPageFuncionario.Padding = new Padding(3);
            tabPageFuncionario.Size = new Size(718, 532);
            tabPageFuncionario.TabIndex = 0;
            tabPageFuncionario.Text = "Funcionários";
            tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Dock = DockStyle.Fill;
            dataGridViewFuncionarios.Location = new Point(3, 3);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.RowTemplate.Height = 25;
            dataGridViewFuncionarios.Size = new Size(712, 526);
            dataGridViewFuncionarios.TabIndex = 0;
            dataGridViewFuncionarios.DoubleClick += dataGridViewFuncionarios_DoubleClick;
            // 
            // tabPageLeitor
            // 
            tabPageLeitor.Controls.Add(dataGridViewLeitores);
            tabPageLeitor.Location = new Point(4, 24);
            tabPageLeitor.Name = "tabPageLeitor";
            tabPageLeitor.Padding = new Padding(3);
            tabPageLeitor.Size = new Size(718, 532);
            tabPageLeitor.TabIndex = 1;
            tabPageLeitor.Text = "Leitores";
            tabPageLeitor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLeitores
            // 
            dataGridViewLeitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeitores.Dock = DockStyle.Fill;
            dataGridViewLeitores.Location = new Point(3, 3);
            dataGridViewLeitores.Name = "dataGridViewLeitores";
            dataGridViewLeitores.RowTemplate.Height = 25;
            dataGridViewLeitores.Size = new Size(712, 526);
            dataGridViewLeitores.TabIndex = 0;
            dataGridViewLeitores.DoubleClick += dataGridViewLeitores_DoubleClick;
            // 
            // tabControlExemplar
            // 
            tabControlExemplar.Controls.Add(dataGridViewExemplares);
            tabControlExemplar.Location = new Point(4, 24);
            tabControlExemplar.Name = "tabControlExemplar";
            tabControlExemplar.Padding = new Padding(3);
            tabControlExemplar.Size = new Size(718, 532);
            tabControlExemplar.TabIndex = 2;
            tabControlExemplar.Text = "Exemplares";
            tabControlExemplar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExemplares
            // 
            dataGridViewExemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExemplares.Dock = DockStyle.Fill;
            dataGridViewExemplares.Location = new Point(3, 3);
            dataGridViewExemplares.Name = "dataGridViewExemplares";
            dataGridViewExemplares.RowTemplate.Height = 25;
            dataGridViewExemplares.Size = new Size(712, 526);
            dataGridViewExemplares.TabIndex = 0;
            dataGridViewExemplares.DoubleClick += dataGridViewExemplares_DoubleClick;
            dataGridViewExemplares.MouseDown += dataGridViewExemplares_MouseDown;
            // 
            // contextMenuStripExemplar
            // 
            contextMenuStripExemplar.Items.AddRange(new ToolStripItem[] { excluirToolStripMenuItem });
            contextMenuStripExemplar.Name = "contextMenuStrip2";
            contextMenuStripExemplar.Size = new Size(110, 26);
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(109, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1017, 620);
            Controls.Add(tabControlPessoa);
            Controls.Add(buttonCadExemplares);
            Controls.Add(buttonCadPessoa);
            Name = "FormMenu";
            Text = "Menu Biblioteca";
            tabControlPessoa.ResumeLayout(false);
            tabPageFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            tabPageLeitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).EndInit();
            tabControlExemplar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).EndInit();
            contextMenuStripExemplar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadPessoa;
        private Button buttonCadExemplares;
        private TabControl tabControlPessoa;
        private TabPage tabPageFuncionario;
        private TabPage tabPageLeitor;
        private TabPage tabControlExemplar;
        private DataGridView dataGridViewFuncionarios;
        private DataGridView dataGridViewLeitores;
        private DataGridView dataGridViewExemplares;
        private FolderBrowserDialog folderBrowserDialog1;
        private ContextMenuStrip contextMenuStripExemplar;
        private ToolStripMenuItem excluirToolStripMenuItem;
    }
}