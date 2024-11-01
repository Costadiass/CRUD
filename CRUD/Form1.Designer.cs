namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbSerie2 = new System.Windows.Forms.RadioButton();
            this.rdbSerie1 = new System.Windows.Forms.RadioButton();
            this.rdbSerie3 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgAluno = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(71, 337);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(152, 337);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(233, 337);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(314, 337);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(395, 337);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(435, 67);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(106, 20);
            this.txtIdade.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Idade:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(435, 108);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(106, 21);
            this.cmbTurma.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Turma:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFloresta);
            this.panel1.Controls.Add(this.rdbBarroca);
            this.panel1.Location = new System.Drawing.Point(15, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 38);
            this.panel1.TabIndex = 13;
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(100, 12);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(62, 17);
            this.rdbFloresta.TabIndex = 15;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(13, 12);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(62, 17);
            this.rdbBarroca.TabIndex = 14;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbSerie2);
            this.panel2.Controls.Add(this.rdbSerie1);
            this.panel2.Controls.Add(this.rdbSerie3);
            this.panel2.Location = new System.Drawing.Point(219, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 38);
            this.panel2.TabIndex = 16;
            // 
            // rdbSerie2
            // 
            this.rdbSerie2.AutoSize = true;
            this.rdbSerie2.Location = new System.Drawing.Point(55, 11);
            this.rdbSerie2.Name = "rdbSerie2";
            this.rdbSerie2.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie2.TabIndex = 16;
            this.rdbSerie2.TabStop = true;
            this.rdbSerie2.Text = "2ª";
            this.rdbSerie2.UseVisualStyleBackColor = true;
            // 
            // rdbSerie1
            // 
            this.rdbSerie1.AutoSize = true;
            this.rdbSerie1.Location = new System.Drawing.Point(14, 11);
            this.rdbSerie1.Name = "rdbSerie1";
            this.rdbSerie1.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie1.TabIndex = 14;
            this.rdbSerie1.TabStop = true;
            this.rdbSerie1.Text = "1ª";
            this.rdbSerie1.UseVisualStyleBackColor = true;
            // 
            // rdbSerie3
            // 
            this.rdbSerie3.AutoSize = true;
            this.rdbSerie3.Location = new System.Drawing.Point(95, 11);
            this.rdbSerie3.Name = "rdbSerie3";
            this.rdbSerie3.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie3.TabIndex = 15;
            this.rdbSerie3.TabStop = true;
            this.rdbSerie3.Text = "3ª";
            this.rdbSerie3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Série:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Unidade:";
            // 
            // dtgAluno
            // 
            this.dtgAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAluno.Location = new System.Drawing.Point(20, 162);
            this.dtgAluno.Name = "dtgAluno";
            this.dtgAluno.Size = new System.Drawing.Size(511, 141);
            this.dtgAluno.TabIndex = 19;
            this.dtgAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAluno_CellClick);
            this.dtgAluno.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dtgAluno_CellToolTipTextNeeded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 372);
            this.Controls.Add(this.dtgAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbSerie2;
        private System.Windows.Forms.RadioButton rdbSerie1;
        private System.Windows.Forms.RadioButton rdbSerie3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgAluno;
    }
}

