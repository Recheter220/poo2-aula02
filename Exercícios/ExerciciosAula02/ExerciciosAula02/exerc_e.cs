using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosAula02
{
    public partial class exerc_e : Form
    {
        List<Produto> listaProdutos;
        List<Cliente> listaClientes;

        public exerc_e()
        {
            InitializeComponent();
        }

        private void exerc_e_Load(object sender, EventArgs e)
        {
            listaProdutos = new List<Produto>();
            listaClientes = new List<Cliente>();

            CalcularTotal();
        }

        /// <summary>
        /// Percorre as linhas do dgvCarrinho uma a uma e faz a soma do valor total da compra
        /// </summary>
        public void CalcularTotal()
        {
            double soma = 0;
            /* Percorre todas as linhas do carrinho e soma os valores totais */
            foreach (DataGridViewRow rw in dgvCarrinho.Rows)
            {
                soma += Convert.ToDouble(rw.Cells[dgvCarrinho_colValorTotal.Index].Value);
            }

            /* Atualiza o valor total da compra e alinha a label no canto direito */
            lblValorTotal.Text = "Valor Total: " + string.Format("{0:C}", soma);
            lblValorTotal.Location = new Point(panelCarrinhoTotal.Width - 15 - lblValorTotal.Width, lblValorTotal.Location.Y);
        }

        private void txtProdutoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Verifica se o caractere digitado no txtProdutoValor é um número de 0 a 9 ou vírgula */
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar.Equals(',')))
            {
                /* Em caso afirmativo, cancela a escrita do caractere */
                e.Handled = true;
            }
            else
            {
                /* Em caso negativo, permite a escrita normalmente */
                e.Handled = false;
            }
        }

        private void txtProdutoQuantidadeEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Verifica se o caractere digitado no txtProdutoValor é um número de 0 a 9 ou vírgula */
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar.Equals(',')))
            {
                /* Em caso afirmativo, cancela a escrita do caractere */
                e.Handled = true;
            }
            else
            {
                /* Em caso negativo, permite a escrita normalmente */
                e.Handled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* Recupera os dados do produto selecionado */
            int linha = dgvProduto.SelectedCells[0].RowIndex;
            string nomeProd = dgvProduto[dgvProduto_colNome.Index, linha].Value.ToString();
            var valorProd = Convert.ToDouble(dgvProduto[dgvProduto_colValor.Index, linha].Value.ToString());
            double estoqueAnterior = Convert.ToDouble(dgvProduto[dgvProduto_colQtdEstoque.Index, linha].Value.ToString());
            double quantidade = Convert.ToDouble(txtQuantidade.Text);
            /* Em caso da quantidade a ser comprada ser maior que o estoque, confirmar com o usuário */
            if (estoqueAnterior < quantidade)
            {
                DialogResult resposta = MessageBox.Show("A quantidade que está sendo vendida é maior do que a disponível em estoque. Deseja continuar?",
                                                        "Estoque insuficiente",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question);
                if (resposta == DialogResult.Cancel)
                {
                    return;
                }
            }
            estoqueAnterior -= quantidade;
            double total = valorProd * quantidade;


            /* Adiciona ao carrinho e atualiza o valor total da compra */
            dgvCarrinho.Rows.Add(linha+1, nomeProd, valorProd.ToString(), txtQuantidade.Text, string.Format("{0:C}", total), total, "Excluir");
            dgvProduto.Rows[linha].Cells[dgvProduto_colQtdEstoque.Index].Value = estoqueAnterior > 0 ? estoqueAnterior : 0;
            CalcularTotal();
        }

        private void btnProdutoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                /* Atribuições de variáveis */
                int id = Convert.ToInt32(txtProdutoId.Text);
                string nome = txtProdutoNome.Text;
                double valor = 0;
                double.TryParse(txtProdutoValor.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentUICulture, out valor);
                double estoque = 0;
                double.TryParse(txtProdutoValor.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentUICulture, out estoque);

                /* Procura no DGV se já existe um produto com o ID que está tentando ser inserido */
                foreach (DataGridViewRow rw in dgvProduto.Rows)
                {
                    if (Convert.ToInt32(rw.Cells[dgvProduto_colId.Index].Value) == id)
                    {
                        /* Caso exista, exibe uma mensagem e devolve o foco ao txtProdutoId */
                        MessageBox.Show("Já existe um produto com o ID informado. Escolha outro ID e tente novamente.", "ID em duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtProdutoId.Focus();
                        return;
                    }
                }
                /* Caso contrário, adiciona a linha ao DGV */
                dgvProduto.Rows.Add(id, nome, string.Format("{0:C}", valor), valor, estoque, "Excluir");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalhes:\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClienteAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                /* Atribuições de variáveis */
                int id = Convert.ToInt32(txtClienteId.Text);
                string nome = txtClienteNome.Text;

                /* Procura no DGV se já existe um cliente com o ID que está tentando ser inserido */
                foreach (DataGridViewRow rw in dgvCliente.Rows)
                {
                    if (Convert.ToInt32(rw.Cells[dgvCliente_colId.Index].Value) == id)
                    {
                        /* Caso exista, exibe uma mensagem e devolve o foco ao txtClienteId */
                        MessageBox.Show("Já existe um cliente com o ID informado. Escolha outro ID e tente novamente.", "ID em duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClienteId.Focus();
                        return;
                    }
                }
                /* Caso contrário, adiciona a linha ao DGV */
                dgvCliente.Rows.Add(id, nome, "Excluir");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detalhes:\n" + ex.Message, "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Aqui temos um clássico exemplo de utilidade do evento CellContentClick. 
             * Quando se trata da captura de um clique em um controle do tipo DataGridViewButtonColumn, 
             * o campo todo clicável possui conteúdo. Nesse caso, ao implementar esse método nós reduzimos
             * parcialmente a ocorrência do evento, uma vez que ele não será acionado quando o usuário 
             * clicar em uma célula solta do DGV. Dessa forma, economiza-se memória e processamento.
             */
            
            /* Caso o índice da coluna clicada seja o mesmo que do botão de exclusão
             * E o índice da linha seja não negativo (o cabeçalho é uma linha, porém seu índice é negativo) */
            if (e.ColumnIndex == dgvProduto_btnExcluir.Index && e.RowIndex >= 0)
            {
                /*  Remove a linha */
                dgvProduto.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Caso o índice da coluna clicada seja diferente do botão de exclusão
             * E o índice da linha seja não negativo (o cabeçalho é uma linha, porém seu índice é negativo) */
            if (e.ColumnIndex != dgvCliente_btnExcluir.Index && e.RowIndex >= 0)
            {
                /* Altera o texto da labelCliente para o nome selecionado no dgvCliente */
                lblCliente.Text = "Cliente selecionado: " + dgvCliente.Rows[e.RowIndex].Cells[dgvCliente_colNome.Index].Value;
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Caso o índice da coluna clicada seja o mesmo que do botão de exclusão
             * E o índice da linha seja não negativo (o cabeçalho é uma linha, porém seu índice é negativo) */
            if (e.ColumnIndex == dgvCliente_btnExcluir.Index && e.RowIndex >= 0)
            {
                /*  Remove a linha */
                dgvCliente.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* Caso o índice da coluna clicada seja o mesmo que do botão de exclusão
             * E o índice da linha seja não negativo (o cabeçalho é uma linha, porém seu índice é negativo) */
            if (e.ColumnIndex == dgvCarrinho_btnExcluir.Index && e.RowIndex >= 0)
            {
                /*  Remove a linha e atualiza o valor total da compra */
                dgvCarrinho.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            /* Verifica se nenhum produto foi colocado no carrinho e exibe mensagem */
            if (dgvCarrinho.Rows.Count < 1)
            {
                MessageBox.Show("É necessário adicionar ao menos um produto ao carrinho", "Carrinho vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /* Verifica se nenhum cliente foi selecionado e exibe mensagem */
            if (dgvCliente.SelectedCells.Count < 1)
            {
                MessageBox.Show("É necessário selecionar um cliente para finalizar as compras", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* Exibe mensagem, limpa o carrinho, cliente e valor */
            MessageBox.Show("Venda finalizada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvCarrinho.Rows.Clear();
            lblCliente.Text = "Cliente selecionado: --";
            CalcularTotal();
        }
    }

    class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }

    class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
