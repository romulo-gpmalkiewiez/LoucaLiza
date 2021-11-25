
namespace LoucaLiza
{
    partial class ListaLocacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAddLocacao = new System.Windows.Forms.Button();
            this.btnExcluirLocacao = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.btnBuscaLocacao = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.dataGridLocacao = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacao)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 64);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(66)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(167, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locadora de Veículos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoucaLiza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Locações";
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnVeiculos.FlatAppearance.BorderSize = 0;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculos.Location = new System.Drawing.Point(672, 81);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(100, 32);
            this.btnVeiculos.TabIndex = 2;
            this.btnVeiculos.Text = "Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(566, 81);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 32);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnAddLocacao
            // 
            this.btnAddLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAddLocacao.FlatAppearance.BorderSize = 0;
            this.btnAddLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocacao.Location = new System.Drawing.Point(460, 81);
            this.btnAddLocacao.Name = "btnAddLocacao";
            this.btnAddLocacao.Size = new System.Drawing.Size(100, 32);
            this.btnAddLocacao.TabIndex = 4;
            this.btnAddLocacao.Text = "+ Nova Locação";
            this.btnAddLocacao.UseVisualStyleBackColor = false;
            // 
            // btnExcluirLocacao
            // 
            this.btnExcluirLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnExcluirLocacao.FlatAppearance.BorderSize = 0;
            this.btnExcluirLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirLocacao.Location = new System.Drawing.Point(354, 81);
            this.btnExcluirLocacao.Name = "btnExcluirLocacao";
            this.btnExcluirLocacao.Size = new System.Drawing.Size(100, 32);
            this.btnExcluirLocacao.TabIndex = 5;
            this.btnExcluirLocacao.Text = "Excluir";
            this.btnExcluirLocacao.UseVisualStyleBackColor = false;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(14, 136);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(335, 32);
            this.textBoxCliente.TabIndex = 6;
            this.textBoxCliente.Text = "Cliente";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(354, 135);
            this.textBoxDocumento.Multiline = true;
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(166, 32);
            this.textBoxDocumento.TabIndex = 7;
            this.textBoxDocumento.Text = "Documento";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(526, 135);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 32);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "De";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(652, 135);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 32);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Até";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(13, 180);
            this.textBoxModelo.Multiline = true;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(177, 32);
            this.textBoxModelo.TabIndex = 10;
            this.textBoxModelo.Text = "Modelo";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(396, 180);
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(124, 32);
            this.textBoxPlaca.TabIndex = 11;
            this.textBoxPlaca.Text = "Placa";
            // 
            // btnBuscaLocacao
            // 
            this.btnBuscaLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnBuscaLocacao.FlatAppearance.BorderSize = 0;
            this.btnBuscaLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaLocacao.Location = new System.Drawing.Point(672, 180);
            this.btnBuscaLocacao.Name = "btnBuscaLocacao";
            this.btnBuscaLocacao.Size = new System.Drawing.Size(100, 32);
            this.btnBuscaLocacao.TabIndex = 12;
            this.btnBuscaLocacao.Text = "Buscar";
            this.btnBuscaLocacao.UseVisualStyleBackColor = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.ItemHeight = 26;
            this.comboBoxStatus.Location = new System.Drawing.Point(526, 180);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(140, 32);
            this.comboBoxStatus.TabIndex = 13;
            this.comboBoxStatus.Text = "Disponível";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.ItemHeight = 26;
            this.comboBoxMarca.Location = new System.Drawing.Point(196, 180);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(194, 32);
            this.comboBoxMarca.Sorted = true;
            this.comboBoxMarca.TabIndex = 14;
            this.comboBoxMarca.Text = "Marca";
            // 
            // dataGridLocacao
            // 
            this.dataGridLocacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridLocacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocacao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridLocacao.Location = new System.Drawing.Point(13, 222);
            this.dataGridLocacao.Name = "dataGridLocacao";
            this.dataGridLocacao.Size = new System.Drawing.Size(759, 292);
            this.dataGridLocacao.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 536);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 24);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "LoucaLiza - Mais louca que você imagina";
            // 
            // ListaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridLocacao);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnBuscaLocacao);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.btnExcluirLocacao);
            this.Controls.Add(this.btnAddLocacao);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ListaLocacao";
            this.Text = "LoucaLiza - Locadora de Veículos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAddLocacao;
        private System.Windows.Forms.Button btnExcluirLocacao;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Button btnBuscaLocacao;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.DataGridView dataGridLocacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}

