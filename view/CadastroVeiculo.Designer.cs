
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
            this.textBoxDiaria = new System.Windows.Forms.TextBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.textBoxChassi = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRenavam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 22);
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
            this.comboBoxMarca.Location = new System.Drawing.Point(16, 73);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(160, 32);
            this.comboBoxMarca.Sorted = true;
            this.comboBoxMarca.TabIndex = 0;
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.ItemHeight = 26;
            this.comboBoxCor.Location = new System.Drawing.Point(16, 240);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(220, 32);
            this.comboBoxCor.Sorted = true;
            this.comboBoxCor.TabIndex = 4;
            // 
            // btnSalvarVeiculo
            // 
            this.btnSalvarVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnSalvarVeiculo.FlatAppearance.BorderSize = 0;
            this.btnSalvarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarVeiculo.Location = new System.Drawing.Point(368, 352);
            this.btnSalvarVeiculo.Name = "btnSalvarVeiculo";
            this.btnSalvarVeiculo.Size = new System.Drawing.Size(100, 32);
            this.btnSalvarVeiculo.TabIndex = 8;
            this.btnSalvarVeiculo.Text = "Salvar";
            this.btnSalvarVeiculo.UseVisualStyleBackColor = false;
            this.btnSalvarVeiculo.Click += new System.EventHandler(this.btnSalvarVeiculo_Click);
            // 
            // textBoxDiaria
            // 
            this.textBoxDiaria.Location = new System.Drawing.Point(16, 296);
            this.textBoxDiaria.MaxLength = 10;
            this.textBoxDiaria.Multiline = true;
            this.textBoxDiaria.Name = "textBoxDiaria";
            this.textBoxDiaria.Size = new System.Drawing.Size(111, 32);
            this.textBoxDiaria.TabIndex = 7;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(242, 240);
            this.textBoxAno.MaxLength = 4;
            this.textBoxAno.Multiline = true;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(111, 32);
            this.textBoxAno.TabIndex = 5;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(329, 184);
            this.textBoxPlaca.MaxLength = 7;
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(139, 32);
            this.textBoxPlaca.TabIndex = 3;
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(359, 240);
            this.textBoxKm.Multiline = true;
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(109, 32);
            this.textBoxKm.TabIndex = 6;
            // 
            // textBoxChassi
            // 
            this.textBoxChassi.Location = new System.Drawing.Point(16, 184);
            this.textBoxChassi.MaxLength = 20;
            this.textBoxChassi.Multiline = true;
            this.textBoxChassi.Name = "textBoxChassi";
            this.textBoxChassi.Size = new System.Drawing.Size(307, 32);
            this.textBoxChassi.TabIndex = 2;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(16, 128);
            this.textBoxModelo.MaxLength = 255;
            this.textBoxModelo.Multiline = true;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(307, 32);
            this.textBoxModelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Chassi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Cor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Km";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Diária (R$)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Renavam";
            // 
            // textBoxRenavam
            // 
            this.textBoxRenavam.Location = new System.Drawing.Point(329, 128);
            this.textBoxRenavam.MaxLength = 11;
            this.textBoxRenavam.Multiline = true;
            this.textBoxRenavam.Name = "textBoxRenavam";
            this.textBoxRenavam.Size = new System.Drawing.Size(139, 32);
            this.textBoxRenavam.TabIndex = 59;
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 399);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxRenavam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxChassi;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.TextBox textBoxDiaria;
        private System.Windows.Forms.Button btnSalvarVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRenavam;
    }
}