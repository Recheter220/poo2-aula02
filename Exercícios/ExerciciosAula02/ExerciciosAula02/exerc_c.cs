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
    public partial class exerc_c : Form
    {
        public exerc_c()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked && checkBox3.Checked)
            {
                if (checkBox4.Checked || checkBox6.Checked )
                {
                  if (checkBox4.Checked && checkBox8.Checked)
                    {
                        MessageBox.Show("Você foi Selecionado para a Vaga na área de TI");
                    }  
                }
              }
            else 
                 {

                MessageBox.Show("Você não passou, mas continue tentando");
            }
        }
    }
}
