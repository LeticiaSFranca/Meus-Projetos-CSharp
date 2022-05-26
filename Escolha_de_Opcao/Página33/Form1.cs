using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Página33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (optionA.Checked) 
            {
                lblEscreverONumero.Text = "Opção 'A' selecionada.";
            }

            else if (optionB.Checked)
            {
                lblEscreverONumero.Text = "Opção 'B' selecionada.";
            }

            else
            {
                lblEscreverONumero.Text = "Opção 'C' selecionada.";
            }

        }

        private void optionA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
