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

            desativa();
        }

        public string nome { get; set; }
        public double saldo { get; set; }
        public double numConta { get; set; }

        public void desativa() 
        {
            txtSaldoResul.Enabled= false;
            txtSaque.Enabled=false;
            txtDeposito.Enabled=false;  

        }
        public void abilita() 
        {
            txtSaldoResul.Enabled = true;
            txtSaque.Enabled = true;
            txtDeposito.Enabled = true;
        }


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
                if (ValorConta < 0)
                {
                    MessageBox.Show("DIGITA O SEU NUMERO DA CONTA VALIDO ", "ERRO");
                    return;
                }
                else 
                {
                    this.txtNumConta.Text = ValorConta.ToString();
                }
            } else 
              {
                MessageBox.Show("O NUMERO DA CONTA ESTA INCORRETA, POR FAVOR DIGITA O NUMERO DA CONTA NOVAMENTE ","ERRO");
              }

           
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

            var msg = $"NOME:{this.nome}\nSaldo:{this.saldo:C2}\nNUMERO CONTA:{this.numConta}";
            var ContaBancaria = new ContaBancaria(this.nome, this.numConta, this.saldo);
            lblResultado.Text = msg;

            abilita();
            salque();
        }

        private void checkBoxDeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeposito.Checked)
            {               
                checkBoxSaque.Checked = false;            
            }           
        }        
        private void checkBoxSaque_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaque.Checked)
            {              
                checkBoxDeposito.Checked = false;
            }           
        }      

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Valor;

            if (checkBoxDeposito.Checked)
            {

                if (Double.TryParse(txtDeposito.Text, out Valor) && Valor > 0)
                {
                    txtSaldoResul.Text = (this.saldo + Valor).ToString();
                    txtDeposito.Text ="";
                }
                else
                {
                    MessageBox.Show("VALOR ESTA INVALIDO!");
                }
            }
            else 
            {
                if(Double.TryParse(txtSaque.Text, out Valor) && Valor > 0)
                {
                    txtSaldoResul.Text = (this.saldo - Valor).ToString();
                    txtDeposito.Text = "";
                }
                else
                {
                    MessageBox.Show("VALOR ESTA INVALIDO!");
                }
            }           
        }  

        private void salque() 
        {
            double Valor;
            if (Double.TryParse(txtSaldo.Text, out Valor) && Valor > 0)
            {
                txtSaldoResul.Text = (Valor).ToString();
            }
            else
            {
                MessageBox.Show("VALOR ESTA INVALIDO!");
            }
        }

        private void Deposito() 
        {
            double Valor;
            if (Double.TryParse(txtDeposito.Text, out Valor) && Valor > 0)
            {
                txtSaldoResul.Text = (Valor).ToString();
            }
            else
            {
                MessageBox.Show("VALOR ESTA INVALIDO!");
            }
        }
    }
}
