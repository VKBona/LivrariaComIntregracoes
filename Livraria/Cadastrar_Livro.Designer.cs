namespace Livraria
{
    partial class FormLivro
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
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAnoLancamento = new System.Windows.Forms.TextBox();
            this.txtNumEdicao = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNumExemplares = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAnoLancamento = new System.Windows.Forms.Label();
            this.lblNumEdicao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNumExemplares = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(118, 12);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(161, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(118, 38);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(161, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(118, 64);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(161, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // txtAnoLancamento
            // 
            this.txtAnoLancamento.Location = new System.Drawing.Point(118, 90);
            this.txtAnoLancamento.Name = "txtAnoLancamento";
            this.txtAnoLancamento.Size = new System.Drawing.Size(161, 20);
            this.txtAnoLancamento.TabIndex = 3;
            // 
            // txtNumEdicao
            // 
            this.txtNumEdicao.Location = new System.Drawing.Point(431, 12);
            this.txtNumEdicao.Name = "txtNumEdicao";
            this.txtNumEdicao.Size = new System.Drawing.Size(161, 20);
            this.txtNumEdicao.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(431, 38);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(161, 20);
            this.txtPreco.TabIndex = 5;
            // 
            // txtNumExemplares
            // 
            this.txtNumExemplares.Location = new System.Drawing.Point(431, 64);
            this.txtNumExemplares.Name = "txtNumExemplares";
            this.txtNumExemplares.Size = new System.Drawing.Size(161, 20);
            this.txtNumExemplares.TabIndex = 6;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 15);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 7;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 67);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor:";
            // 
            // lblAnoLancamento
            // 
            this.lblAnoLancamento.AutoSize = true;
            this.lblAnoLancamento.Location = new System.Drawing.Point(12, 93);
            this.lblAnoLancamento.Name = "lblAnoLancamento";
            this.lblAnoLancamento.Size = new System.Drawing.Size(102, 13);
            this.lblAnoLancamento.TabIndex = 10;
            this.lblAnoLancamento.Text = "Ano de lançamento:";
            // 
            // lblNumEdicao
            // 
            this.lblNumEdicao.AutoSize = true;
            this.lblNumEdicao.Location = new System.Drawing.Point(307, 15);
            this.lblNumEdicao.Name = "lblNumEdicao";
            this.lblNumEdicao.Size = new System.Drawing.Size(97, 13);
            this.lblNumEdicao.TabIndex = 11;
            this.lblNumEdicao.Text = "Número de edição:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(307, 41);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNumExemplares
            // 
            this.lblNumExemplares.AutoSize = true;
            this.lblNumExemplares.Location = new System.Drawing.Point(307, 67);
            this.lblNumExemplares.Name = "lblNumExemplares";
            this.lblNumExemplares.Size = new System.Drawing.Size(118, 13);
            this.lblNumExemplares.TabIndex = 13;
            this.lblNumExemplares.Text = "Número de exemplares:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(514, 87);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 301);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(517, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(431, 423);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 456);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblNumExemplares);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNumEdicao);
            this.Controls.Add(this.lblAnoLancamento);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtNumExemplares);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNumEdicao);
            this.Controls.Add(this.txtAnoLancamento);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtISBN);
            this.Name = "FormLivro";
            this.Text = "Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAnoLancamento;
        private System.Windows.Forms.TextBox txtNumEdicao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNumExemplares;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAnoLancamento;
        private System.Windows.Forms.Label lblNumEdicao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNumExemplares;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
    }
}