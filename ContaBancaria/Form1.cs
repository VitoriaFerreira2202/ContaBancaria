using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            //ESTA DANDO ERRADO 
            var nome = (txtNomeTitula.Text).Trim();
            var saldo = Convert.ToDouble(txtSaldo.Text.Trim());
            var numConta = Convert.ToDouble(txtNumConta.Text.Trim()); 
            var ContaBancaria = new ContaBancaria(nome, numConta,saldo);
            lblResultado.Text = ContaBancaria.Exibir();
            lblResultado.Text = txtSaldoResul.Text;
        }

        private void checkBoxDeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeposito.Checked)
            {               
                checkBoxSaque.Checked = false;            
            }           
        }
        public void Deposito(double valor) 
        {
           

        }
        private void checkBoxSaque_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaque.Checked)
            {              
                checkBoxDeposito.Checked = false;
            }           
        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
