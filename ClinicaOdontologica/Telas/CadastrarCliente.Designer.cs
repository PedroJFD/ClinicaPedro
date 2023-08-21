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
            this.tx_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_segundonome = new System.Windows.Forms.TextBox();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cb_cidade
            // 
            this.cb_cidade.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cb_cidade.Location = new System.Drawing.Point(41, 188);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(268, 21);
            this.cb_cidade.TabIndex = 24;
            this.cb_cidade.Text = "Cidade";
            // 
            // tx_email
            // 
            this.tx_email.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(41, 133);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(268, 22);
            this.tx_email.TabIndex = 19;
            this.tx_email.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Crie o cadastro do cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(210, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 25;
            this.button1.Text = "Criar cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Atender bem para atender sempre!";
            // 
            // tx_nome
            // 
            this.tx_nome.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(41, 105);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(102, 22);
            this.tx_nome.TabIndex = 16;
            this.tx_nome.Text = "Primeiro nome";
            // 
            // tx_segundonome
            // 
            this.tx_segundonome.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_segundonome.Location = new System.Drawing.Point(149, 105);
            this.tx_segundonome.Name = "tx_segundonome";
            this.tx_segundonome.Size = new System.Drawing.Size(160, 22);
            this.tx_segundonome.TabIndex = 28;
            this.tx_segundonome.Text = "Sobrenome";
            // 
            // mask_telefone
            // 
            this.mask_telefone.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone.Location = new System.Drawing.Point(41, 162);
            this.mask_telefone.Mask = "(99) 00000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(268, 22);
            this.mask_telefone.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaOdontologica.Properties.Resources.papel_de_parede_azul_degrade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 353);
            this.Controls.Add(this.mask_telefone);
            this.Controls.Add(this.tx_segundonome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_segundonome;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
    }
}

