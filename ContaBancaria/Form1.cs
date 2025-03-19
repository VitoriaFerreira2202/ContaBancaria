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

        public string nome { get; set; }
        public double saldo { get; set; }
        public double numConta { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            //ESTA DANDO ERRADO 


            if (txtNomeTitula.Text == "")
            {
                MessageBox.Show("DIGITA O SEU NOME", "ERRO");
                return;
            }
            else 
            {
              
                this.nome = txtNomeTitula.Text;
            }


            if (Double.TryParse(txtNumConta.Text,out double ValorConta))
            {

                MessageBox.Show("DIGITA O SEU NUMERO DA CONTA ", "ERRO");
                return;
            }

            else 
            { 
                this.txtNumConta= txtNumConta.Text;
            }

            // lblResultado.Text = ContaBancaria.Exibir();



            if (Double.TryParse(txtSaldo.Text, out double ValorConv))
            {
                this.saldo = ValorConv;
            }
            else
            { 
                MessageBox.Show("VALOR ESTA INVALIDO", "ERRO");
                return;
            }

            this.nome = (txtNomeTitula.Text).Trim();
            // this.saldo = Convert.ToDouble(txtSaldo.Text);
            this.numConta = Convert.ToDouble(txtNumConta.Text.Trim());

            var msg = "teste";
            var ContaBancaria = new ContaBancaria(this.nome, this.numConta, this.saldo);
            lblResultado.Text = msg;
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
