namespace ExerciciosAula02
{
    partial class exerc_e
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
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.dgvCarrinho_colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrinho_colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrinho_colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrinho_colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrinho_colValorTotalExibir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrinho_colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCarrinho_btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dgvCliente_colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCliente_colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCliente_btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelCarrinho = new System.Windows.Forms.Panel();
            this.panelCarrinhoTotal = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.gbSelecionaProduto = new System.Windows.Forms.GroupBox();
            this.panelProdutoQuantidade = new System.Windows.Forms.Panel();
            this.gbCadastroProduto = new System.Windows.Forms.GroupBox();
            this.btnProdutoAdicionar = new System.Windows.Forms.Button();
            this.txtProdutoValor = new System.Windows.Forms.TextBox();
            this.lblProdutoValor = new System.Windows.Forms.Label();
            this.txtProdutoNome = new System.Windows.Forms.TextBox();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.txtProdutoId = new System.Windows.Forms.TextBox();
            this.lblProdutoId = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.gbSelecionaCliente = new System.Windows.Forms.GroupBox();
            this.gbCadastroCliente = new System.Windows.Forms.GroupBox();
            this.btnClienteAdicionar = new System.Windows.Forms.Button();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.panelDados = new System.Windows.Forms.Panel();
            this.panelExibicao = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtProdutoQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.lblQuantidadeEstoque = new System.Windows.Forms.Label();
            this.dgvProduto_colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto_colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto_colValorExibir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto_colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto_colQtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduto_btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panelCarrinho.SuspendLayout();
            this.panelCarrinhoTotal.SuspendLayout();
            this.panelProduto.SuspendLayout();
            this.gbSelecionaProduto.SuspendLayout();
            this.panelProdutoQuantidade.SuspendLayout();
            this.gbCadastroProduto.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.gbSelecionaCliente.SuspendLayout();
            this.gbCadastroCliente.SuspendLayout();
            this.panelDados.SuspendLayout();
            this.panelExibicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(3, 8);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(68, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(77, 5);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(171, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(254, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCarrinho_colId,
            this.dgvCarrinho_colNome,
            this.dgvCarrinho_colValor,
            this.dgvCarrinho_colQuantidade,
            this.dgvCarrinho_colValorTotalExibir,
            this.dgvCarrinho_colValorTotal,
            this.dgvCarrinho_btnExcluir});
            this.dgvCarrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrinho.Location = new System.Drawing.Point(0, 0);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.Size = new System.Drawing.Size(767, 220);
            this.dgvCarrinho.TabIndex = 7;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellContentClick);
            // 
            // dgvCarrinho_colId
            // 
            this.dgvCarrinho_colId.HeaderText = "idProduto";
            this.dgvCarrinho_colId.Name = "dgvCarrinho_colId";
            this.dgvCarrinho_colId.ReadOnly = true;
            // 
            // dgvCarrinho_colNome
            // 
            this.dgvCarrinho_colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCarrinho_colNome.HeaderText = "Nome do Produto";
            this.dgvCarrinho_colNome.Name = "dgvCarrinho_colNome";
            this.dgvCarrinho_colNome.ReadOnly = true;
            // 
            // dgvCarrinho_colValor
            // 
            this.dgvCarrinho_colValor.HeaderText = "Preço do Produto";
            this.dgvCarrinho_colValor.Name = "dgvCarrinho_colValor";
            this.dgvCarrinho_colValor.ReadOnly = true;
            // 
            // dgvCarrinho_colQuantidade
            // 
            this.dgvCarrinho_colQuantidade.HeaderText = "Quantidade";
            this.dgvCarrinho_colQuantidade.Name = "dgvCarrinho_colQuantidade";
            this.dgvCarrinho_colQuantidade.ReadOnly = true;
            // 
            // dgvCarrinho_colValorTotalExibir
            // 
            this.dgvCarrinho_colValorTotalExibir.HeaderText = "Total";
            this.dgvCarrinho_colValorTotalExibir.Name = "dgvCarrinho_colValorTotalExibir";
            this.dgvCarrinho_colValorTotalExibir.ReadOnly = true;
            // 
            // dgvCarrinho_colValorTotal
            // 
            this.dgvCarrinho_colValorTotal.HeaderText = "Total Double";
            this.dgvCarrinho_colValorTotal.Name = "dgvCarrinho_colValorTotal";
            this.dgvCarrinho_colValorTotal.ReadOnly = true;
            this.dgvCarrinho_colValorTotal.Visible = false;
            // 
            // dgvCarrinho_btnExcluir
            // 
            this.dgvCarrinho_btnExcluir.HeaderText = "Excluir";
            this.dgvCarrinho_btnExcluir.Name = "dgvCarrinho_btnExcluir";
            this.dgvCarrinho_btnExcluir.ReadOnly = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProduto_colId,
            this.dgvProduto_colNome,
            this.dgvProduto_colValorExibir,
            this.dgvProduto_colValor,
            this.dgvProduto_colQtdEstoque,
            this.dgvProduto_btnExcluir});
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProduto.Location = new System.Drawing.Point(3, 16);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(332, 204);
            this.dgvProduto.TabIndex = 8;
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCliente_colId,
            this.dgvCliente_colNome,
            this.dgvCliente_btnExcluir});
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliente.Location = new System.Drawing.Point(3, 16);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(423, 204);
            this.dgvCliente.TabIndex = 9;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // dgvCliente_colId
            // 
            this.dgvCliente_colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvCliente_colId.HeaderText = "ID";
            this.dgvCliente_colId.Name = "dgvCliente_colId";
            this.dgvCliente_colId.ReadOnly = true;
            this.dgvCliente_colId.Width = 43;
            // 
            // dgvCliente_colNome
            // 
            this.dgvCliente_colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCliente_colNome.HeaderText = "Nome";
            this.dgvCliente_colNome.Name = "dgvCliente_colNome";
            this.dgvCliente_colNome.ReadOnly = true;
            // 
            // dgvCliente_btnExcluir
            // 
            this.dgvCliente_btnExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvCliente_btnExcluir.HeaderText = "Excluir";
            this.dgvCliente_btnExcluir.Name = "dgvCliente_btnExcluir";
            this.dgvCliente_btnExcluir.ReadOnly = true;
            this.dgvCliente_btnExcluir.Width = 44;
            // 
            // panelCarrinho
            // 
            this.panelCarrinho.Controls.Add(this.panelCarrinhoTotal);
            this.panelCarrinho.Controls.Add(this.dgvCarrinho);
            this.panelCarrinho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarrinho.Location = new System.Drawing.Point(0, 416);
            this.panelCarrinho.Name = "panelCarrinho";
            this.panelCarrinho.Size = new System.Drawing.Size(767, 220);
            this.panelCarrinho.TabIndex = 10;
            // 
            // panelCarrinhoTotal
            // 
            this.panelCarrinhoTotal.Controls.Add(this.lblValorTotal);
            this.panelCarrinhoTotal.Controls.Add(this.lblCliente);
            this.panelCarrinhoTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCarrinhoTotal.Location = new System.Drawing.Point(0, 187);
            this.panelCarrinhoTotal.Name = "panelCarrinhoTotal";
            this.panelCarrinhoTotal.Size = new System.Drawing.Size(767, 33);
            this.panelCarrinhoTotal.TabIndex = 8;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(683, 7);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 20);
            this.lblValorTotal.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 7);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(188, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente selecionado: --";
            // 
            // panelProduto
            // 
            this.panelProduto.Controls.Add(this.gbSelecionaProduto);
            this.panelProduto.Controls.Add(this.gbCadastroProduto);
            this.panelProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProduto.Location = new System.Drawing.Point(0, 0);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(338, 416);
            this.panelProduto.TabIndex = 11;
            // 
            // gbSelecionaProduto
            // 
            this.gbSelecionaProduto.Controls.Add(this.panelProdutoQuantidade);
            this.gbSelecionaProduto.Controls.Add(this.dgvProduto);
            this.gbSelecionaProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelecionaProduto.Location = new System.Drawing.Point(0, 193);
            this.gbSelecionaProduto.Name = "gbSelecionaProduto";
            this.gbSelecionaProduto.Size = new System.Drawing.Size(338, 223);
            this.gbSelecionaProduto.TabIndex = 9;
            this.gbSelecionaProduto.TabStop = false;
            this.gbSelecionaProduto.Text = "Seleção de produto";
            // 
            // panelProdutoQuantidade
            // 
            this.panelProdutoQuantidade.Controls.Add(this.txtQuantidade);
            this.panelProdutoQuantidade.Controls.Add(this.lblQuantidade);
            this.panelProdutoQuantidade.Controls.Add(this.btnCalcular);
            this.panelProdutoQuantidade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProdutoQuantidade.Location = new System.Drawing.Point(3, 188);
            this.panelProdutoQuantidade.Name = "panelProdutoQuantidade";
            this.panelProdutoQuantidade.Size = new System.Drawing.Size(332, 32);
            this.panelProdutoQuantidade.TabIndex = 9;
            // 
            // gbCadastroProduto
            // 
            this.gbCadastroProduto.Controls.Add(this.txtProdutoQuantidadeEstoque);
            this.gbCadastroProduto.Controls.Add(this.lblQuantidadeEstoque);
            this.gbCadastroProduto.Controls.Add(this.btnProdutoAdicionar);
            this.gbCadastroProduto.Controls.Add(this.txtProdutoValor);
            this.gbCadastroProduto.Controls.Add(this.lblProdutoValor);
            this.gbCadastroProduto.Controls.Add(this.txtProdutoNome);
            this.gbCadastroProduto.Controls.Add(this.lblProdutoNome);
            this.gbCadastroProduto.Controls.Add(this.txtProdutoId);
            this.gbCadastroProduto.Controls.Add(this.lblProdutoId);
            this.gbCadastroProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastroProduto.Location = new System.Drawing.Point(0, 0);
            this.gbCadastroProduto.Name = "gbCadastroProduto";
            this.gbCadastroProduto.Size = new System.Drawing.Size(338, 193);
            this.gbCadastroProduto.TabIndex = 0;
            this.gbCadastroProduto.TabStop = false;
            this.gbCadastroProduto.Text = "Cadastro de Produtos";
            // 
            // btnProdutoAdicionar
            // 
            this.btnProdutoAdicionar.Location = new System.Drawing.Point(12, 119);
            this.btnProdutoAdicionar.Name = "btnProdutoAdicionar";
            this.btnProdutoAdicionar.Size = new System.Drawing.Size(320, 57);
            this.btnProdutoAdicionar.TabIndex = 6;
            this.btnProdutoAdicionar.Text = "Adicionar";
            this.btnProdutoAdicionar.UseVisualStyleBackColor = true;
            this.btnProdutoAdicionar.Click += new System.EventHandler(this.btnProdutoAdicionar_Click);
            // 
            // txtProdutoValor
            // 
            this.txtProdutoValor.Location = new System.Drawing.Point(87, 67);
            this.txtProdutoValor.Name = "txtProdutoValor";
            this.txtProdutoValor.Size = new System.Drawing.Size(245, 20);
            this.txtProdutoValor.TabIndex = 5;
            this.txtProdutoValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdutoValor_KeyPress);
            // 
            // lblProdutoValor
            // 
            this.lblProdutoValor.AutoSize = true;
            this.lblProdutoValor.Location = new System.Drawing.Point(50, 70);
            this.lblProdutoValor.Name = "lblProdutoValor";
            this.lblProdutoValor.Size = new System.Drawing.Size(31, 13);
            this.lblProdutoValor.TabIndex = 4;
            this.lblProdutoValor.Text = "Valor";
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.Location = new System.Drawing.Point(87, 41);
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(245, 20);
            this.txtProdutoNome.TabIndex = 3;
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.Location = new System.Drawing.Point(46, 44);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(35, 13);
            this.lblProdutoNome.TabIndex = 2;
            this.lblProdutoNome.Text = "Nome";
            // 
            // txtProdutoId
            // 
            this.txtProdutoId.Location = new System.Drawing.Point(87, 15);
            this.txtProdutoId.Name = "txtProdutoId";
            this.txtProdutoId.Size = new System.Drawing.Size(245, 20);
            this.txtProdutoId.TabIndex = 1;
            // 
            // lblProdutoId
            // 
            this.lblProdutoId.AutoSize = true;
            this.lblProdutoId.Location = new System.Drawing.Point(63, 18);
            this.lblProdutoId.Name = "lblProdutoId";
            this.lblProdutoId.Size = new System.Drawing.Size(18, 13);
            this.lblProdutoId.TabIndex = 0;
            this.lblProdutoId.Text = "ID";
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.gbSelecionaCliente);
            this.panelCliente.Controls.Add(this.gbCadastroCliente);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCliente.Location = new System.Drawing.Point(338, 0);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(429, 416);
            this.panelCliente.TabIndex = 12;
            // 
            // gbSelecionaCliente
            // 
            this.gbSelecionaCliente.Controls.Add(this.dgvCliente);
            this.gbSelecionaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelecionaCliente.Location = new System.Drawing.Point(0, 193);
            this.gbSelecionaCliente.Name = "gbSelecionaCliente";
            this.gbSelecionaCliente.Size = new System.Drawing.Size(429, 223);
            this.gbSelecionaCliente.TabIndex = 2;
            this.gbSelecionaCliente.TabStop = false;
            this.gbSelecionaCliente.Text = "Seleção de cliente";
            // 
            // gbCadastroCliente
            // 
            this.gbCadastroCliente.Controls.Add(this.btnClienteAdicionar);
            this.gbCadastroCliente.Controls.Add(this.txtClienteNome);
            this.gbCadastroCliente.Controls.Add(this.lblClienteNome);
            this.gbCadastroCliente.Controls.Add(this.txtClienteId);
            this.gbCadastroCliente.Controls.Add(this.lblClienteId);
            this.gbCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.gbCadastroCliente.Name = "gbCadastroCliente";
            this.gbCadastroCliente.Size = new System.Drawing.Size(429, 193);
            this.gbCadastroCliente.TabIndex = 1;
            this.gbCadastroCliente.TabStop = false;
            this.gbCadastroCliente.Text = "Cadastro de Clientes";
            // 
            // btnClienteAdicionar
            // 
            this.btnClienteAdicionar.Location = new System.Drawing.Point(51, 119);
            this.btnClienteAdicionar.Name = "btnClienteAdicionar";
            this.btnClienteAdicionar.Size = new System.Drawing.Size(320, 57);
            this.btnClienteAdicionar.TabIndex = 13;
            this.btnClienteAdicionar.Text = "Adicionar";
            this.btnClienteAdicionar.UseVisualStyleBackColor = true;
            this.btnClienteAdicionar.Click += new System.EventHandler(this.btnClienteAdicionar_Click);
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(88, 63);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(283, 20);
            this.txtClienteNome.TabIndex = 10;
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Location = new System.Drawing.Point(51, 66);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(35, 13);
            this.lblClienteNome.TabIndex = 9;
            this.lblClienteNome.Text = "Nome";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(88, 37);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(283, 20);
            this.txtClienteId.TabIndex = 8;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Location = new System.Drawing.Point(64, 40);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(18, 13);
            this.lblClienteId.TabIndex = 7;
            this.lblClienteId.Text = "ID";
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.panelCliente);
            this.panelDados.Controls.Add(this.panelProduto);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDados.Location = new System.Drawing.Point(0, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(767, 416);
            this.panelDados.TabIndex = 0;
            // 
            // panelExibicao
            // 
            this.panelExibicao.Controls.Add(this.btnFinalizar);
            this.panelExibicao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExibicao.Location = new System.Drawing.Point(0, 636);
            this.panelExibicao.Name = "panelExibicao";
            this.panelExibicao.Size = new System.Drawing.Size(767, 94);
            this.panelExibicao.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(0, 0);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(767, 94);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtProdutoQuantidadeEstoque
            // 
            this.txtProdutoQuantidadeEstoque.Location = new System.Drawing.Point(87, 93);
            this.txtProdutoQuantidadeEstoque.Name = "txtProdutoQuantidadeEstoque";
            this.txtProdutoQuantidadeEstoque.Size = new System.Drawing.Size(245, 20);
            this.txtProdutoQuantidadeEstoque.TabIndex = 8;
            this.txtProdutoQuantidadeEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdutoQuantidadeEstoque_KeyPress);
            // 
            // lblQuantidadeEstoque
            // 
            this.lblQuantidadeEstoque.AutoSize = true;
            this.lblQuantidadeEstoque.Location = new System.Drawing.Point(12, 96);
            this.lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
            this.lblQuantidadeEstoque.Size = new System.Drawing.Size(69, 13);
            this.lblQuantidadeEstoque.TabIndex = 7;
            this.lblQuantidadeEstoque.Text = "Qtd. Estoque";
            // 
            // dgvProduto_colId
            // 
            this.dgvProduto_colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvProduto_colId.HeaderText = "ID";
            this.dgvProduto_colId.Name = "dgvProduto_colId";
            this.dgvProduto_colId.ReadOnly = true;
            this.dgvProduto_colId.Width = 43;
            // 
            // dgvProduto_colNome
            // 
            this.dgvProduto_colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProduto_colNome.HeaderText = "Nome";
            this.dgvProduto_colNome.Name = "dgvProduto_colNome";
            this.dgvProduto_colNome.ReadOnly = true;
            // 
            // dgvProduto_colValorExibir
            // 
            this.dgvProduto_colValorExibir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvProduto_colValorExibir.HeaderText = "Valor";
            this.dgvProduto_colValorExibir.Name = "dgvProduto_colValorExibir";
            this.dgvProduto_colValorExibir.ReadOnly = true;
            this.dgvProduto_colValorExibir.Width = 56;
            // 
            // dgvProduto_colValor
            // 
            this.dgvProduto_colValor.HeaderText = "Valor Double";
            this.dgvProduto_colValor.Name = "dgvProduto_colValor";
            this.dgvProduto_colValor.ReadOnly = true;
            this.dgvProduto_colValor.Visible = false;
            // 
            // dgvProduto_colQtdEstoque
            // 
            this.dgvProduto_colQtdEstoque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvProduto_colQtdEstoque.HeaderText = "Qtd. Estoque";
            this.dgvProduto_colQtdEstoque.Name = "dgvProduto_colQtdEstoque";
            this.dgvProduto_colQtdEstoque.ReadOnly = true;
            this.dgvProduto_colQtdEstoque.Width = 94;
            // 
            // dgvProduto_btnExcluir
            // 
            this.dgvProduto_btnExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvProduto_btnExcluir.HeaderText = "Excluir";
            this.dgvProduto_btnExcluir.Name = "dgvProduto_btnExcluir";
            this.dgvProduto_btnExcluir.ReadOnly = true;
            this.dgvProduto_btnExcluir.Width = 44;
            // 
            // exerc_e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 730);
            this.Controls.Add(this.panelCarrinho);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.panelExibicao);
            this.Name = "exerc_e";
            this.Text = "exerc_e";
            this.Load += new System.EventHandler(this.exerc_e_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panelCarrinho.ResumeLayout(false);
            this.panelCarrinhoTotal.ResumeLayout(false);
            this.panelCarrinhoTotal.PerformLayout();
            this.panelProduto.ResumeLayout(false);
            this.gbSelecionaProduto.ResumeLayout(false);
            this.panelProdutoQuantidade.ResumeLayout(false);
            this.panelProdutoQuantidade.PerformLayout();
            this.gbCadastroProduto.ResumeLayout(false);
            this.gbCadastroProduto.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.gbSelecionaCliente.ResumeLayout(false);
            this.gbCadastroCliente.ResumeLayout(false);
            this.gbCadastroCliente.PerformLayout();
            this.panelDados.ResumeLayout(false);
            this.panelExibicao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panelCarrinho;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.GroupBox gbSelecionaProduto;
        private System.Windows.Forms.Panel panelProdutoQuantidade;
        private System.Windows.Forms.GroupBox gbCadastroProduto;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.GroupBox gbSelecionaCliente;
        private System.Windows.Forms.GroupBox gbCadastroCliente;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Panel panelExibicao;
        private System.Windows.Forms.Button btnProdutoAdicionar;
        private System.Windows.Forms.TextBox txtProdutoValor;
        private System.Windows.Forms.Label lblProdutoValor;
        private System.Windows.Forms.TextBox txtProdutoNome;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.TextBox txtProdutoId;
        private System.Windows.Forms.Label lblProdutoId;
        private System.Windows.Forms.Button btnClienteAdicionar;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrinho_colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrinho_colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrinho_colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrinho_colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrinho_colValorTotalExibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCarrinho_colValorTotal;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCarrinho_btnExcluir;
        private System.Windows.Forms.Panel panelCarrinhoTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente_colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCliente_colNome;
        private System.Windows.Forms.DataGridViewButtonColumn dgvCliente_btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto_colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto_colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto_colValorExibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto_colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduto_colQtdEstoque;
        private System.Windows.Forms.DataGridViewButtonColumn dgvProduto_btnExcluir;
        private System.Windows.Forms.TextBox txtProdutoQuantidadeEstoque;
        private System.Windows.Forms.Label lblQuantidadeEstoque;
    }
}

