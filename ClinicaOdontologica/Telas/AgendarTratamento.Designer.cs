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
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cb_data = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_tratameto
            // 
            this.cb_tratameto.Enabled = false;
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
            this.cb_tratameto.Location = new System.Drawing.Point(242, 366);
            this.cb_tratameto.Name = "cb_tratameto";
            this.cb_tratameto.Size = new System.Drawing.Size(200, 21);
            this.cb_tratameto.TabIndex = 5;
            this.cb_tratameto.SelectedIndexChanged += new System.EventHandler(this.cb_tratameto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de tratamento:";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(351, 416);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "Ok!";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // cb_data
            // 
            this.cb_data.Enabled = false;
            this.cb_data.FormattingEnabled = true;
            this.cb_data.Location = new System.Drawing.Point(242, 326);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(200, 21);
            this.cb_data.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Horario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(160, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(282, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(254, 416);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(75, 23);
            this.bt_novo.TabIndex = 11;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(160, 416);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_excluir.TabIndex = 12;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Selecione um horário disponível:";
            // 
            // cb_clientes
            // 
            this.cb_clientes.Enabled = false;
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Location = new System.Drawing.Point(321, 30);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(121, 21);
            this.cb_clientes.TabIndex = 15;
            this.cb_clientes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // mask_data
            // 
            this.mask_data.Enabled = false;
            this.mask_data.Location = new System.Drawing.Point(242, 289);
            this.mask_data.Mask = "(99) 00000-0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(200, 20);
            this.mask_data.TabIndex = 16;
            // 
            // AgendarTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 457);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.cb_clientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_data);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cb_tratameto);
            this.Controls.Add(this.label1);
            this.Name = "AgendarTratamento";
            this.Text = "Tratamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tratameto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox cb_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_clientes;
        private System.Windows.Forms.MaskedTextBox mask_data;
    }
}