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
    public partial class exerc_d : Form
    {
        List<Notas> listaNota;

        public exerc_d()
        {
            InitializeComponent();
        }
        private void exerc_e_Load(object sender, EventArgs e)
        {
            listaNota = new List<Notas>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                /* Atribuições de variáveis */
                string aluno = textBox1.Text;
                double nota = 0;
                double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentUICulture, out nota);
            
            /* Procura no DGV se já existe um cliente com o ID que está tentando ser inserido */
                foreach (DataGridViewRow rw in dataGridView1.Rows)
            {
                if ( (rw.Cells[dgvaluno.Index].Value.ToString()) == aluno)
                {
                    /* Caso exista, exibe uma mensagem de erro */
                    MessageBox.Show("Já existe um aluno com esse nome cadastrado, tente novamente.", "Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
            }
            /* Caso contrário, adiciona a linha ao DGV */
            dataGridView1.Rows.Add(aluno, nota, "Excluir");
        }
            catch (Exception trambolho)
            {
                MessageBox.Show("Erro de caracter "+trambolho.Message);
            }
        }
        private void exerc_d_Load(object sender, EventArgs e)
        {

         

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Recupera os dados do produto selecionado */
            int linha = dataGridView1.SelectedCells[0].RowIndex;
            string nomealuno = dataGridView1[dgvaluno.Index, linha].Value.ToString();
            double notaanterior = Convert.ToDouble(dataGridView1[dgvnota.Index, linha].Value.ToString());

            /* Em caso da quantidade a ser comprada ser maior que o estoque, confirmar com o usuário */
            if (notaanterior >6)
            {
                   return;
                }
            }

        
    }
    }

        
    

    internal class Notas
    {
    }

