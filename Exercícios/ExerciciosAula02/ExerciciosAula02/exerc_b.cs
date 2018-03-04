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
    public partial class exerc_b : Form
    {
        public exerc_b()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // tratamento de erro 
            {
                //declara variáveis
                int valor = 0, table = 0;
                //converte texto contido em textBox1 para Int
                valor = Convert.ToInt32(textBox1.Text);
                //cálculo tabuada
                for (table = 1; table < 11; table++)
                {
                    listBox1.Items.Add(table);
 
               }

            }
            catch (FormatException erro)
            {
                //captura e mostra o erro de formato
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
