
namespace LoucaLiza.view
{
    partial class LocalizadorVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizadorVeiculo));
            this.dataGridVeiculo = new System.Windows.Forms.DataGridView();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnBuscarVeiculo = new System.Windows.Forms.Button();
            this.textBoxPlaca = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxModelo = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.btnExcluirVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnAddVeiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarVeiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVeiculo
            // 
            this.dataGridVeiculo.AllowUserToAddRows = false;
            this.dataGridVeiculo.AllowUserToDeleteRows = false;
            this.dataGridVeiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridVeiculo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridVeiculo.Location = new System.Drawing.Point(13, 119);
            this.dataGridVeiculo.MultiSelect = false;
            this.dataGridVeiculo.Name = "dataGridVeiculo";
            this.dataGridVeiculo.ReadOnly = true;
            this.dataGridVeiculo.RowHeadersVisible = false;
            this.dataGridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVeiculo.Size = new System.Drawing.Size(759, 353);
            this.dataGridVeiculo.TabIndex = 32;
            this.dataGridVeiculo.DoubleClick += new System.EventHandler(this.dataGridVeiculo_DoubleClick);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.ItemHeight = 26;
            this.comboBoxMarca.Location = new System.Drawing.Point(13, 77);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(177, 32);
            this.comboBoxMarca.Sorted = true;
            this.comboBoxMarca.TabIndex = 31;
            this.comboBoxMarca.Text = "Marca";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.ItemHeight = 26;
            this.comboBoxStatus.Location = new System.Drawing.Point(526, 77);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(140, 32);
            this.comboBoxStatus.TabIndex = 30;
            this.comboBoxStatus.Text = "Disponível";
            // 
            // btnBuscarVeiculo
            // 
            this.btnBuscarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnBuscarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnBuscarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarVeiculo.Image")));
            this.btnBuscarVeiculo.Location = new System.Drawing.Point(672, 77);
            this.btnBuscarVeiculo.Name = "btnBuscarVeiculo";
            this.btnBuscarVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnBuscarVeiculo.TabIndex = 29;
            this.btnBuscarVeiculo.Text = "Buscar";
            this.btnBuscarVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarVeiculo.UseVisualStyleBackColor = false;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxPlaca.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPlaca.Location = new System.Drawing.Point(396, 77);
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.PlaceHolderText = "Placa";
            this.textBoxPlaca.Size = new System.Drawing.Size(124, 32);
            this.textBoxPlaca.TabIndex = 28;
            this.textBoxPlaca.Text = "Placa";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxModelo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxModelo.Location = new System.Drawing.Point(196, 77);
            this.textBoxModelo.Multiline = true;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.PlaceHolderText = "Modelo";
            this.textBoxModelo.Size = new System.Drawing.Size(194, 32);
            this.textBoxModelo.TabIndex = 27;
            this.textBoxModelo.Text = "Modelo";
            // 
            // btnExcluirVeiculo
            // 
            this.btnExcluirVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnExcluirVeiculo.FlatAppearance.BorderSize = 0;
            this.btnExcluirVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirVeiculo.Location = new System.Drawing.Point(460, 25);
            this.btnExcluirVeiculo.Name = "btnExcluirVeiculo";
            this.btnExcluirVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnExcluirVeiculo.TabIndex = 26;
            this.btnExcluirVeiculo.Text = "Excluir";
            this.btnExcluirVeiculo.UseVisualStyleBackColor = false;
            // 
            // btnEditarVeiculo
            // 
            this.btnEditarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnEditarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnEditarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVeiculo.Location = new System.Drawing.Point(566, 25);
            this.btnEditarVeiculo.Name = "btnEditarVeiculo";
            this.btnEditarVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnEditarVeiculo.TabIndex = 25;
            this.btnEditarVeiculo.Text = "Editar";
            this.btnEditarVeiculo.UseVisualStyleBackColor = false;
            // 
            // btnAddVeiculo
            // 
            this.btnAddVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAddVeiculo.FlatAppearance.BorderSize = 0;
            this.btnAddVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVeiculo.Location = new System.Drawing.Point(672, 25);
            this.btnAddVeiculo.Name = "btnAddVeiculo";
            this.btnAddVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnAddVeiculo.TabIndex = 24;
            this.btnAddVeiculo.Text = "+ Novo Veículo";
            this.btnAddVeiculo.UseVisualStyleBackColor = false;
            this.btnAddVeiculo.Click += new System.EventHandler(this.btnAddVeiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Veículos";
            // 
            // btnSelecionarVeiculo
            // 
            this.btnSelecionarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnSelecionarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnSelecionarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarVeiculo.Location = new System.Drawing.Point(672, 497);
            this.btnSelecionarVeiculo.Name = "btnSelecionarVeiculo";
            this.btnSelecionarVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnSelecionarVeiculo.TabIndex = 44;
            this.btnSelecionarVeiculo.Text = "Selecionar";
            this.btnSelecionarVeiculo.UseVisualStyleBackColor = false;
            this.btnSelecionarVeiculo.Click += new System.EventHandler(this.btnSelecionarVeiculo_Click);
            // 
            // LocalizadorVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSelecionarVeiculo);
            this.Controls.Add(this.dataGridVeiculo);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnBuscarVeiculo);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.btnExcluirVeiculo);
            this.Controls.Add(this.btnEditarVeiculo);
            this.Controls.Add(this.btnAddVeiculo);
            this.Controls.Add(this.label1);
            this.Name = "LocalizadorVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoucaLiza - Localizar Veículo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVeiculo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnBuscarVeiculo;
        private System.Windows.Forms.Button btnExcluirVeiculo;
        private System.Windows.Forms.Button btnEditarVeiculo;
        private System.Windows.Forms.Button btnAddVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionarVeiculo;
        private View.Components.PlaceHolderTextBox textBoxPlaca;
        private View.Components.PlaceHolderTextBox textBoxModelo;
    }
}