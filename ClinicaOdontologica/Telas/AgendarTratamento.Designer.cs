namespace ClinicaOdontologica.Telas
{
    partial class AgendarTratamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_tratameto = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cb_tratameto
            // 
            this.cb_tratameto.Enabled = false;
            this.cb_tratameto.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tratameto.FormattingEnabled = true;
            this.cb_tratameto.Items.AddRange(new object[] {
            "Limpeza Dental",
            "Obturações",
            "Tratamento de Canal",
            "Extração Dentária",
            "Implantes Dentários",
            "Coroas Dentárias",
            "Ponte Dentária",
            "Aparelhos Ortodônticos"});
            this.cb_tratameto.Location = new System.Drawing.Point(64, 151);
            this.cb_tratameto.Name = "cb_tratameto";
            this.cb_tratameto.Size = new System.Drawing.Size(235, 21);
            this.cb_tratameto.TabIndex = 5;
            this.cb_tratameto.Text = "Tipo Tratamento";
            this.cb_tratameto.SelectedIndexChanged += new System.EventHandler(this.cb_tratameto_SelectedIndexChanged);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.CadetBlue;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.Location = new System.Drawing.Point(224, 208);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "Cadastrar";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cb_horario
            // 
            this.cb_horario.Enabled = false;
            this.cb_horario.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cb_horario.Location = new System.Drawing.Point(64, 124);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(135, 21);
            this.cb_horario.TabIndex = 7;
            this.cb_horario.Text = "Horario";
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_novo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.ForeColor = System.Drawing.Color.White;
            this.bt_novo.Location = new System.Drawing.Point(143, 208);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 11;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = false;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excluir.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.ForeColor = System.Drawing.Color.White;
            this.bt_excluir.Location = new System.Drawing.Point(64, 208);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 12;
            this.bt_excluir.Text = "Cancelar";
            this.bt_excluir.UseVisualStyleBackColor = false;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cadastre Horario e tratamento do cliente";
            // 
            // cb_clientes
            // 
            this.cb_clientes.Enabled = false;
            this.cb_clientes.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Location = new System.Drawing.Point(64, 97);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(135, 21);
            this.cb_clientes.TabIndex = 15;
            this.cb_clientes.Text = "Cliente";
            this.cb_clientes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // mask_data
            // 
            this.mask_data.Enabled = false;
            this.mask_data.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data.Location = new System.Drawing.Point(205, 123);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(94, 22);
            this.mask_data.TabIndex = 16;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // AgendarTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaOdontologica.Properties.Resources.papel_de_parede_azul_degrade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 325);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.cb_clientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cb_tratameto);
            this.Name = "AgendarTratamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamento";
            this.Load += new System.EventHandler(this.AgendarTratamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tratameto;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_clientes;
        private System.Windows.Forms.MaskedTextBox mask_data;
    }
}