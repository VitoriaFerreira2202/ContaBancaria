namespace ContaBancaria
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumConta = new System.Windows.Forms.Label();
            this.lblNomeTitula = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNumConta = new System.Windows.Forms.TextBox();
            this.txtNomeTitula = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSaldoResul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.checkBoxDeposito = new System.Windows.Forms.CheckBox();
            this.checkBoxSaque = new System.Windows.Forms.CheckBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTA BANCARIA";
            // 
            // lblNumConta
            // 
            this.lblNumConta.AutoSize = true;
            this.lblNumConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConta.Location = new System.Drawing.Point(12, 58);
            this.lblNumConta.Name = "lblNumConta";
            this.lblNumConta.Size = new System.Drawing.Size(225, 25);
            this.lblNumConta.TabIndex = 1;
            this.lblNumConta.Text = "NUMERO DA CONTA:";
            // 
            // lblNomeTitula
            // 
            this.lblNomeTitula.AutoSize = true;
            this.lblNomeTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTitula.Location = new System.Drawing.Point(12, 93);
            this.lblNomeTitula.Name = "lblNomeTitula";
            this.lblNomeTitula.Size = new System.Drawing.Size(194, 25);
            this.lblNomeTitula.TabIndex = 2;
            this.lblNomeTitula.Text = "NOME DA TITULA:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(12, 124);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(89, 25);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "SALDO:";
            // 
            // txtNumConta
            // 
            this.txtNumConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumConta.Location = new System.Drawing.Point(233, 54);
            this.txtNumConta.Name = "txtNumConta";
            this.txtNumConta.Size = new System.Drawing.Size(195, 31);
            this.txtNumConta.TabIndex = 4;
            // 
            // txtNomeTitula
            // 
            this.txtNomeTitula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTitula.Location = new System.Drawing.Point(203, 91);
            this.txtNomeTitula.Name = "txtNomeTitula";
            this.txtNomeTitula.Size = new System.Drawing.Size(225, 31);
            this.txtNomeTitula.TabIndex = 5;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(116, 124);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(195, 31);
            this.txtSaldo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Para continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSaldoResul
            // 
            this.txtSaldoResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoResul.Location = new System.Drawing.Point(159, 237);
            this.txtSaldoResul.Name = "txtSaldoResul";
            this.txtSaldoResul.Size = new System.Drawing.Size(195, 31);
            this.txtSaldoResul.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "SALDO:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(214, 274);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(195, 31);
            this.txtDeposito.TabIndex = 11;
            // 
            // txtSaque
            // 
            this.txtSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaque.Location = new System.Drawing.Point(188, 311);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(195, 31);
            this.txtSaque.TabIndex = 13;
            // 
            // checkBoxDeposito
            // 
            this.checkBoxDeposito.AutoSize = true;
            this.checkBoxDeposito.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeposito.Location = new System.Drawing.Point(71, 275);
            this.checkBoxDeposito.Name = "checkBoxDeposito";
            this.checkBoxDeposito.Size = new System.Drawing.Size(144, 29);
            this.checkBoxDeposito.TabIndex = 14;
            this.checkBoxDeposito.Text = "DEPOSITO:";
            this.checkBoxDeposito.UseVisualStyleBackColor = false;
            this.checkBoxDeposito.CheckedChanged += new System.EventHandler(this.checkBoxDeposito_CheckedChanged);
            // 
            // checkBoxSaque
            // 
            this.checkBoxSaque.AutoSize = true;
            this.checkBoxSaque.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkBoxSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSaque.Location = new System.Drawing.Point(76, 313);
            this.checkBoxSaque.Name = "checkBoxSaque";
            this.checkBoxSaque.Size = new System.Drawing.Size(110, 29);
            this.checkBoxSaque.TabIndex = 15;
            this.checkBoxSaque.Text = "SAQUE:";
            this.checkBoxSaque.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 149);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 25);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(-2, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 176);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 361);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.checkBoxSaque);
            this.Controls.Add(this.checkBoxDeposito);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.txtSaldoResul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNomeTitula);
            this.Controls.Add(this.txtNumConta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNomeTitula);
            this.Controls.Add(this.lblNumConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumConta;
        private System.Windows.Forms.Label lblNomeTitula;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNumConta;
        private System.Windows.Forms.TextBox txtNomeTitula;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSaldoResul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.CheckBox checkBoxDeposito;
        private System.Windows.Forms.CheckBox checkBoxSaque;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

