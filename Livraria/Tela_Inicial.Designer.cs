namespace Livraria
{
    partial class FormTelaInicial
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnExecutarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 12);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(344, 43);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.Location = new System.Drawing.Point(12, 61);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(344, 43);
            this.btnLivros.TabIndex = 1;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = true;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // btnExecutarVenda
            // 
            this.btnExecutarVenda.Location = new System.Drawing.Point(12, 110);
            this.btnExecutarVenda.Name = "btnExecutarVenda";
            this.btnExecutarVenda.Size = new System.Drawing.Size(344, 43);
            this.btnExecutarVenda.TabIndex = 2;
            this.btnExecutarVenda.Text = "Executar Venda";
            this.btnExecutarVenda.UseVisualStyleBackColor = true;
            this.btnExecutarVenda.Click += new System.EventHandler(this.btnExecutarVenda_Click);
            // 
            // FormTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 165);
            this.Controls.Add(this.btnExecutarVenda);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.btnCliente);
            this.Name = "FormTelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnExecutarVenda;
    }
}

