
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaLocacao));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelLocadoraDeVeiculos = new System.Windows.Forms.Label();
            this.labelLoucaLiza = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAddLocacao = new System.Windows.Forms.Button();
            this.btnExcluirLocacao = new System.Windows.Forms.Button();
            this.textBoxDataInicial = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxDataFinal = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxDocumento = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxCliente = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxModelo = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxPlaca = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.btnBuscaLocacao = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.dataGridLocacao = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacao)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.panelHeader.Controls.Add(this.labelLocadoraDeVeiculos);
            this.panelHeader.Controls.Add(this.labelLoucaLiza);
            this.panelHeader.Location = new System.Drawing.Point(1, 1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(782, 64);
            this.panelHeader.TabIndex = 0;
            // 
            // labelLocadoraDeVeiculos
            // 
            this.labelLocadoraDeVeiculos.AutoSize = true;
            this.labelLocadoraDeVeiculos.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLocadoraDeVeiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(66)))), ((int)(((byte)(214)))));
            this.labelLocadoraDeVeiculos.Location = new System.Drawing.Point(167, 18);
            this.labelLocadoraDeVeiculos.Name = "labelLocadoraDeVeiculos";
            this.labelLocadoraDeVeiculos.Size = new System.Drawing.Size(247, 34);
            this.labelLocadoraDeVeiculos.TabIndex = 1;
            this.labelLocadoraDeVeiculos.Text = "Locadora de Veículos";
            // 
            // labelLoucaLiza
            // 
            this.labelLoucaLiza.AutoSize = true;
            this.labelLoucaLiza.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLoucaLiza.ForeColor = System.Drawing.Color.White;
            this.labelLoucaLiza.Location = new System.Drawing.Point(4, 10);
            this.labelLoucaLiza.Name = "labelLoucaLiza";
            this.labelLoucaLiza.Size = new System.Drawing.Size(167, 45);
            this.labelLoucaLiza.TabIndex = 0;
            this.labelLoucaLiza.Text = "LoucaLiza";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 81);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(92, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Locações";
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
            this.btnAddLocacao.Click += new System.EventHandler(this.btnAddLocacao_Click);
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
            // textBoxDataInicial
            // 
            this.textBoxDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDataInicial.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDataInicial.Location = new System.Drawing.Point(526, 135);
            this.textBoxDataInicial.Multiline = true;
            this.textBoxDataInicial.Name = "textBoxDataInicial";
            this.textBoxDataInicial.PlaceHolderText = "Data Inicial";
            this.textBoxDataInicial.Size = new System.Drawing.Size(120, 32);
            this.textBoxDataInicial.TabIndex = 8;
            this.textBoxDataInicial.Text = "Data Inicial";
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDataFinal.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDataFinal.Location = new System.Drawing.Point(652, 135);
            this.textBoxDataFinal.Multiline = true;
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.PlaceHolderText = "Data Final";
            this.textBoxDataFinal.Size = new System.Drawing.Size(120, 32);
            this.textBoxDataFinal.TabIndex = 9;
            this.textBoxDataFinal.Text = "Data Final";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDocumento.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDocumento.Location = new System.Drawing.Point(354, 135);
            this.textBoxDocumento.Multiline = true;
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.PlaceHolderText = "Documento";
            this.textBoxDocumento.Size = new System.Drawing.Size(166, 32);
            this.textBoxDocumento.TabIndex = 7;
            this.textBoxDocumento.Text = "Documento";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxCliente.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCliente.Location = new System.Drawing.Point(14, 136);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.PlaceHolderText = "Cliente";
            this.textBoxCliente.Size = new System.Drawing.Size(335, 32);
            this.textBoxCliente.TabIndex = 6;
            this.textBoxCliente.Text = "Cliente";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxModelo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxModelo.Location = new System.Drawing.Point(13, 180);
            this.textBoxModelo.Multiline = true;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.PlaceHolderText = "Modelo";
            this.textBoxModelo.Size = new System.Drawing.Size(177, 32);
            this.textBoxModelo.TabIndex = 10;
            this.textBoxModelo.Text = "Modelo";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxPlaca.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPlaca.Location = new System.Drawing.Point(396, 180);
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.PlaceHolderText = "Placa";
            this.textBoxPlaca.Size = new System.Drawing.Size(124, 32);
            this.textBoxPlaca.TabIndex = 11;
            this.textBoxPlaca.Text = "Placa";
            // 
            // btnBuscaLocacao
            // 
            this.btnBuscaLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnBuscaLocacao.FlatAppearance.BorderSize = 0;
            this.btnBuscaLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaLocacao.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaLocacao.Image")));
            this.btnBuscaLocacao.Location = new System.Drawing.Point(672, 180);
            this.btnBuscaLocacao.Name = "btnBuscaLocacao";
            this.btnBuscaLocacao.Size = new System.Drawing.Size(100, 32);
            this.btnBuscaLocacao.TabIndex = 12;
            this.btnBuscaLocacao.Text = "Buscar";
            this.btnBuscaLocacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscaLocacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.comboBoxStatus.Text = "Status";
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
            this.dataGridLocacao.AllowUserToAddRows = false;
            this.dataGridLocacao.AllowUserToDeleteRows = false;
            this.dataGridLocacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridLocacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocacao.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridLocacao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridLocacao.Location = new System.Drawing.Point(13, 222);
            this.dataGridLocacao.MultiSelect = false;
            this.dataGridLocacao.Name = "dataGridLocacao";
            this.dataGridLocacao.ReadOnly = true;
            this.dataGridLocacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLocacao.Size = new System.Drawing.Size(759, 292);
            this.dataGridLocacao.TabIndex = 15;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Location = new System.Drawing.Point(1, 536);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(782, 24);
            this.panelFooter.TabIndex = 16;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFooter.Location = new System.Drawing.Point(11, 5);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(203, 13);
            this.labelFooter.TabIndex = 17;
            this.labelFooter.Text = "LoucaLiza - Mais louca que você imagina";
            // 
            // ListaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dataGridLocacao);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnBuscaLocacao);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxDataFinal);
            this.Controls.Add(this.textBoxDataInicial);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.btnExcluirLocacao);
            this.Controls.Add(this.btnAddLocacao);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelHeader);
            this.Name = "ListaLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoucaLiza - Locadora de Veículos";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacao)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelLoucaLiza;
        private System.Windows.Forms.Label labelLocadoraDeVeiculos;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAddLocacao;
        private System.Windows.Forms.Button btnExcluirLocacao;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDataInicial;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDataFinal;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxCliente;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDocumento;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxModelo;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxPlaca;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Button btnBuscaLocacao;
        private System.Windows.Forms.DataGridView dataGridLocacao;
    }
}

