namespace ClinicaOdontologica
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
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_telefone = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_cidade
            // 
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Items.AddRange(new object[] {
            "Porto Velho",
            "Vilhena",
            "Ji-paraná",
            "Ouro Preto do Oeste",
            "Presidente Médici",
            "Jaru",
            "Ariquemes",
            "Cacoal",
            "Rolim de Moura",
            "Machadinho do Oeste"});
            this.cb_cidade.Location = new System.Drawing.Point(365, 214);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(135, 21);
            this.cb_cidade.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cidade:";
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(365, 181);
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(136, 20);
            this.tx_telefone.TabIndex = 20;
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(365, 144);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(136, 20);
            this.tx_email.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(365, 107);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(136, 20);
            this.tx_nome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cadastrar!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_telefone;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

