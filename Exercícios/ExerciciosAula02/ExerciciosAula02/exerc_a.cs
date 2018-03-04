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
    public partial class exerc_a : Form
    {
        public exerc_a()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exerc_a_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try // tratamento de erro 
            {
                double aulas = 0.0, faltas = 0.0, presencabr = 0.0, presencapr = 0.0;
                //declara variáveis
                //substitui caracter . por ,
                textBox2.Text = textBox2.Text.Replace(".", ",");
                //converte texto contido em textBox1 para double
                aulas = Convert.ToDouble(textBox2.Text);
                //converte texto contido em textBox2 para double
                faltas = Convert.ToDouble(textBox3.Text);
                //cálculos de frequência
                presencabr = aulas - faltas; 
                presencapr = (presencabr * 100) / aulas;
                MessageBox.Show("Frequência do aulo é de " + presencapr);
            }
            catch (FormatException erro)
            {
                //captura e mostra o erro de conversão de formato
                MessageBox.Show("ERRO: " + erro.Message);
            }
        }
    }
}
