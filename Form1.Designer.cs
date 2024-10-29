namespace AplicativoComMultiplasJanelas
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionarProduto = new Button();
            buttonDeletarProduto = new Button();
            dataGridView1 = new DataGridView();
            buttonVerProdutos = new Button();
            buttonVerClientes = new Button();
            buttonVerFornecedores = new Button();
            buttonVerCompras = new Button();
            buttonVerVendas = new Button();
            buttonAdicionarFornecedor = new Button();
            buttonDeletarFornecedor = new Button();
            buttonAdicionarCliente = new Button();
            buttonDeletarCliente = new Button();
            buttonAdicionarCompra = new Button();
            buttonDeletarCompra = new Button();
            buttonAdicionarVenda = new Button();
            buttonDeletarVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarProduto
            // 
            buttonAdicionarProduto.BackColor = SystemColors.ScrollBar;
            buttonAdicionarProduto.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProduto.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdicionarProduto.Location = new Point(12, 53);
            buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            buttonAdicionarProduto.Size = new Size(150, 23);
            buttonAdicionarProduto.TabIndex = 0;
            buttonAdicionarProduto.Text = "Novo Produto";
            buttonAdicionarProduto.UseVisualStyleBackColor = false;
            buttonAdicionarProduto.Click += buttonAdicionarProduto_Click;
            // 
            // buttonDeletarProduto
            // 
            buttonDeletarProduto.BackColor = SystemColors.ScrollBar;
            buttonDeletarProduto.FlatStyle = FlatStyle.Flat;
            buttonDeletarProduto.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeletarProduto.Location = new Point(12, 76);
            buttonDeletarProduto.Name = "buttonDeletarProduto";
            buttonDeletarProduto.Size = new Size(150, 23);
            buttonDeletarProduto.TabIndex = 1;
            buttonDeletarProduto.Text = "Deletar Produto";
            buttonDeletarProduto.UseVisualStyleBackColor = false;
            buttonDeletarProduto.Click += buttonDeletarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(750, 420);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            // 
            // buttonVerProdutos
            // 
            buttonVerProdutos.BackColor = SystemColors.ScrollBar;
            buttonVerProdutos.FlatStyle = FlatStyle.Flat;
            buttonVerProdutos.ForeColor = SystemColors.ActiveCaptionText;
            buttonVerProdutos.Location = new Point(12, 12);
            buttonVerProdutos.Name = "buttonVerProdutos";
            buttonVerProdutos.Size = new Size(150, 41);
            buttonVerProdutos.TabIndex = 3;
            buttonVerProdutos.Text = "Produtos";
            buttonVerProdutos.UseVisualStyleBackColor = false;
            buttonVerProdutos.Click += buttonVerProdutos_Click;
            // 
            // buttonVerClientes
            // 
            buttonVerClientes.BackColor = SystemColors.ScrollBar;
            buttonVerClientes.FlatStyle = FlatStyle.Flat;
            buttonVerClientes.ForeColor = SystemColors.ActiveCaptionText;
            buttonVerClientes.Location = new Point(312, 12);
            buttonVerClientes.Name = "buttonVerClientes";
            buttonVerClientes.Size = new Size(150, 41);
            buttonVerClientes.TabIndex = 4;
            buttonVerClientes.Text = "Clientes";
            buttonVerClientes.UseVisualStyleBackColor = false;
            buttonVerClientes.Click += buttonVerClientes_Click;
            // 
            // buttonVerFornecedores
            // 
            buttonVerFornecedores.BackColor = SystemColors.ScrollBar;
            buttonVerFornecedores.FlatStyle = FlatStyle.Flat;
            buttonVerFornecedores.ForeColor = SystemColors.ActiveCaptionText;
            buttonVerFornecedores.Location = new Point(162, 12);
            buttonVerFornecedores.Name = "buttonVerFornecedores";
            buttonVerFornecedores.Size = new Size(150, 41);
            buttonVerFornecedores.TabIndex = 4;
            buttonVerFornecedores.Text = "Fornecedores";
            buttonVerFornecedores.UseVisualStyleBackColor = false;
            buttonVerFornecedores.Click += buttonVerFornecedores_Click;
            // 
            // buttonVerCompras
            // 
            buttonVerCompras.BackColor = SystemColors.ScrollBar;
            buttonVerCompras.FlatStyle = FlatStyle.Flat;
            buttonVerCompras.ForeColor = SystemColors.ActiveCaptionText;
            buttonVerCompras.Location = new Point(462, 12);
            buttonVerCompras.Name = "buttonVerCompras";
            buttonVerCompras.Size = new Size(150, 41);
            buttonVerCompras.TabIndex = 4;
            buttonVerCompras.Text = "Compras";
            buttonVerCompras.UseVisualStyleBackColor = false;
            buttonVerCompras.Click += buttonVerCompras_Click;
            // 
            // buttonVerVendas
            // 
            buttonVerVendas.BackColor = SystemColors.ScrollBar;
            buttonVerVendas.FlatStyle = FlatStyle.Flat;
            buttonVerVendas.ForeColor = SystemColors.ActiveCaptionText;
            buttonVerVendas.Location = new Point(612, 12);
            buttonVerVendas.Name = "buttonVerVendas";
            buttonVerVendas.Size = new Size(150, 41);
            buttonVerVendas.TabIndex = 4;
            buttonVerVendas.Text = "Vendas";
            buttonVerVendas.UseVisualStyleBackColor = false;
            buttonVerVendas.Click += buttonVerVendas_Click;
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.BackColor = SystemColors.ScrollBar;
            buttonAdicionarFornecedor.FlatStyle = FlatStyle.Flat;
            buttonAdicionarFornecedor.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdicionarFornecedor.Location = new Point(162, 53);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(150, 23);
            buttonAdicionarFornecedor.TabIndex = 0;
            buttonAdicionarFornecedor.Text = "Novo Fornecedor";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.BackColor = SystemColors.ScrollBar;
            buttonDeletarFornecedor.FlatStyle = FlatStyle.Flat;
            buttonDeletarFornecedor.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeletarFornecedor.Location = new Point(162, 76);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(150, 23);
            buttonDeletarFornecedor.TabIndex = 1;
            buttonDeletarFornecedor.Text = "Deletar Fornecedor";
            buttonDeletarFornecedor.UseVisualStyleBackColor = false;
            buttonDeletarFornecedor.Click += buttonDeletarFornecedor_Click;
            // 
            // buttonAdicionarCliente
            // 
            buttonAdicionarCliente.BackColor = SystemColors.ScrollBar;
            buttonAdicionarCliente.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCliente.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdicionarCliente.ImageAlign = ContentAlignment.MiddleRight;
            buttonAdicionarCliente.Location = new Point(312, 53);
            buttonAdicionarCliente.Name = "buttonAdicionarCliente";
            buttonAdicionarCliente.Size = new Size(150, 23);
            buttonAdicionarCliente.TabIndex = 0;
            buttonAdicionarCliente.Text = "Novo Cliente";
            buttonAdicionarCliente.UseVisualStyleBackColor = false;
            buttonAdicionarCliente.Click += buttonAdicionarCliente_Click;
            // 
            // buttonDeletarCliente
            // 
            buttonDeletarCliente.BackColor = SystemColors.ScrollBar;
            buttonDeletarCliente.FlatStyle = FlatStyle.Flat;
            buttonDeletarCliente.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeletarCliente.ImageAlign = ContentAlignment.MiddleRight;
            buttonDeletarCliente.Location = new Point(312, 76);
            buttonDeletarCliente.Name = "buttonDeletarCliente";
            buttonDeletarCliente.Size = new Size(150, 23);
            buttonDeletarCliente.TabIndex = 1;
            buttonDeletarCliente.Text = "Deletar Cliente";
            buttonDeletarCliente.UseVisualStyleBackColor = false;
            buttonDeletarCliente.Click += buttonDeletarCliente_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = SystemColors.ScrollBar;
            buttonAdicionarCompra.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCompra.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdicionarCompra.Location = new Point(462, 53);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(150, 23);
            buttonAdicionarCompra.TabIndex = 0;
            buttonAdicionarCompra.Text = "Nova Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // buttonDeletarCompra
            // 
            buttonDeletarCompra.BackColor = SystemColors.ScrollBar;
            buttonDeletarCompra.FlatStyle = FlatStyle.Flat;
            buttonDeletarCompra.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeletarCompra.Location = new Point(462, 76);
            buttonDeletarCompra.Name = "buttonDeletarCompra";
            buttonDeletarCompra.Size = new Size(150, 23);
            buttonDeletarCompra.TabIndex = 1;
            buttonDeletarCompra.Text = "Deletar Compra";
            buttonDeletarCompra.UseVisualStyleBackColor = false;
            buttonDeletarCompra.Click += buttonDeletarCompra_Click;
            // 
            // buttonAdicionarVenda
            // 
            buttonAdicionarVenda.BackColor = SystemColors.ScrollBar;
            buttonAdicionarVenda.FlatStyle = FlatStyle.Flat;
            buttonAdicionarVenda.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdicionarVenda.Location = new Point(612, 53);
            buttonAdicionarVenda.Name = "buttonAdicionarVenda";
            buttonAdicionarVenda.Size = new Size(150, 23);
            buttonAdicionarVenda.TabIndex = 0;
            buttonAdicionarVenda.Text = "Nova Venda";
            buttonAdicionarVenda.UseVisualStyleBackColor = false;
            buttonAdicionarVenda.Click += buttonAdicionarVenda_Click;
            // 
            // buttonDeletarVenda
            // 
            buttonDeletarVenda.BackColor = SystemColors.ScrollBar;
            buttonDeletarVenda.FlatStyle = FlatStyle.Flat;
            buttonDeletarVenda.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeletarVenda.Location = new Point(612, 76);
            buttonDeletarVenda.Name = "buttonDeletarVenda";
            buttonDeletarVenda.Size = new Size(150, 23);
            buttonDeletarVenda.TabIndex = 1;
            buttonDeletarVenda.Text = "Deletar Venda";
            buttonDeletarVenda.UseVisualStyleBackColor = false;
            buttonDeletarVenda.Click += buttonDeletarVenda_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 537);
            Controls.Add(buttonVerVendas);
            Controls.Add(buttonVerCompras);
            Controls.Add(buttonVerFornecedores);
            Controls.Add(buttonVerClientes);
            Controls.Add(buttonVerProdutos);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeletarVenda);
            Controls.Add(buttonDeletarCompra);
            Controls.Add(buttonDeletarCliente);
            Controls.Add(buttonDeletarFornecedor);
            Controls.Add(buttonDeletarProduto);
            Controls.Add(buttonAdicionarVenda);
            Controls.Add(buttonAdicionarCompra);
            Controls.Add(buttonAdicionarCliente);
            Controls.Add(buttonAdicionarFornecedor);
            Controls.Add(buttonAdicionarProduto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProduto;
		private Button buttonDeletarProduto;
		private DataGridView dataGridView1;
		private Button buttonVerProdutos;
		private Button buttonVerClientes;
		private Button buttonVerFornecedores;
		private Button buttonVerCompras;
		private Button buttonVerVendas;
		private Button buttonAdicionarFornecedor;
		private Button buttonDeletarFornecedor;
		private Button buttonAdicionarCliente;
		private Button buttonDeletarCliente;
		private Button buttonAdicionarCompra;
		private Button buttonDeletarCompra;
		private Button buttonAdicionarVenda;
		private Button buttonDeletarVenda;
	}
}
