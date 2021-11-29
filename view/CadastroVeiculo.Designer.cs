
namespace LoucaLiza.view
{
    partial class CadastroVeiculo
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.btnSalvarVeiculo = new System.Windows.Forms.Button();
            this.textBoxDiaria = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxAno = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxPlaca = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxKm = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxChassi = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxModelo = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 24);
            this.labelTitle.TabIndex = 50;
            this.labelTitle.Text = "Editar / Novo Veículo";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.ItemHeight = 26;
            this.comboBoxMarca.Location = new System.Drawing.Point(16, 74);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(163, 32);
            this.comboBoxMarca.Sorted = true;
            this.comboBoxMarca.TabIndex = 0;
            this.comboBoxMarca.Text = "Marca";
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.ItemHeight = 26;
            this.comboBoxCor.Location = new System.Drawing.Point(16, 218);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(183, 32);
            this.comboBoxCor.Sorted = true;
            this.comboBoxCor.TabIndex = 4;
            this.comboBoxCor.Text = "Cor";
            // 
            // btnSalvarVeiculo
            // 
            this.btnSalvarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnSalvarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnSalvarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarVeiculo.Location = new System.Drawing.Point(306, 329);
            this.btnSalvarVeiculo.Name = "btnSalvarVeiculo";
            this.btnSalvarVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnSalvarVeiculo.TabIndex = 8;
            this.btnSalvarVeiculo.Text = "Salvar";
            this.btnSalvarVeiculo.UseVisualStyleBackColor = false;
            this.btnSalvarVeiculo.Click += new System.EventHandler(this.btnSalvarVeiculo_Click);
            // 
            // textBoxDiaria
            // 
            this.textBoxDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDiaria.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDiaria.Location = new System.Drawing.Point(16, 266);
            this.textBoxDiaria.MaxLength = 10;
            this.textBoxDiaria.Multiline = true;
            this.textBoxDiaria.Name = "textBoxDiaria";
            this.textBoxDiaria.PlaceHolderText = "Diária (R$)";
            this.textBoxDiaria.Size = new System.Drawing.Size(83, 32);
            this.textBoxDiaria.TabIndex = 7;
            this.textBoxDiaria.Text = "Diária (R$)";
            // 
            // textBoxAno
            // 
            this.textBoxAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxAno.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAno.Location = new System.Drawing.Point(215, 218);
            this.textBoxAno.MaxLength = 4;
            this.textBoxAno.Multiline = true;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.PlaceHolderText = "Ano";
            this.textBoxAno.Size = new System.Drawing.Size(83, 32);
            this.textBoxAno.TabIndex = 5;
            this.textBoxAno.Text = "Ano";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxPlaca.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPlaca.Location = new System.Drawing.Point(267, 170);
            this.textBoxPlaca.MaxLength = 7;
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.PlaceHolderText = "Placa";
            this.textBoxPlaca.Size = new System.Drawing.Size(139, 32);
            this.textBoxPlaca.TabIndex = 3;
            this.textBoxPlaca.Text = "Placa";
            // 
            // textBoxKm
            // 
            this.textBoxKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxKm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxKm.Location = new System.Drawing.Point(314, 218);
            this.textBoxKm.Multiline = true;
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.PlaceHolderText = "Km";
            this.textBoxKm.Size = new System.Drawing.Size(92, 32);
            this.textBoxKm.TabIndex = 6;
            this.textBoxKm.Text = "Km";
            // 
            // textBoxChassi
            // 
            this.textBoxChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxChassi.ForeColor = System.Drawing.Color.Gray;
            this.textBoxChassi.Location = new System.Drawing.Point(16, 170);
            this.textBoxChassi.MaxLength = 17;
            this.textBoxChassi.Multiline = true;
            this.textBoxChassi.Name = "textBoxChassi";
            this.textBoxChassi.PlaceHolderText = "Chassi";
            this.textBoxChassi.Size = new System.Drawing.Size(235, 32);
            this.textBoxChassi.TabIndex = 2;
            this.textBoxChassi.Text = "Chassi";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxModelo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxModelo.Location = new System.Drawing.Point(16, 122);
            this.textBoxModelo.MaxLength = 255;
            this.textBoxModelo.Multiline = true;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.PlaceHolderText = "Modelo";
            this.textBoxModelo.Size = new System.Drawing.Size(390, 32);
            this.textBoxModelo.TabIndex = 1;
            this.textBoxModelo.Text = "Modelo";
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 379);
            this.Controls.Add(this.textBoxDiaria);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.comboBoxCor);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxChassi);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnSalvarVeiculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoucaLiza - Cadastro de Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxModelo;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxChassi;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxPlaca;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxAno;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxKm;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDiaria;
        private System.Windows.Forms.Button btnSalvarVeiculo;
    }
}