﻿
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
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.textBoxChassi = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarVeiculo = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDiaria = new System.Windows.Forms.ComboBox();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(267, 170);
            this.textBoxPlaca.Multiline = true;
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(139, 32);
            this.textBoxPlaca.TabIndex = 3;
            this.textBoxPlaca.Text = "Placa";
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(314, 218);
            this.textBoxKm.Multiline = true;
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(92, 32);
            this.textBoxKm.TabIndex = 6;
            this.textBoxKm.Text = "Km";
            // 
            // textBoxChassi
            // 
            this.textBoxChassi.Location = new System.Drawing.Point(16, 170);
            this.textBoxChassi.Multiline = true;
            this.textBoxChassi.Name = "textBoxChassi";
            this.textBoxChassi.Size = new System.Drawing.Size(235, 32);
            this.textBoxChassi.TabIndex = 2;
            this.textBoxChassi.Text = "Chassi";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(16, 122);
            this.textBoxModelo.Multiline = true;
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(390, 32);
            this.textBoxModelo.TabIndex = 1;
            this.textBoxModelo.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Editar / Novo Veículo";
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
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 26;
            this.comboBox2.Location = new System.Drawing.Point(16, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 32);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Marca";
            // 
            // comboBoxDiaria
            // 
            this.comboBoxDiaria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxDiaria.FormattingEnabled = true;
            this.comboBoxDiaria.ItemHeight = 26;
            this.comboBoxDiaria.Location = new System.Drawing.Point(16, 266);
            this.comboBoxDiaria.Name = "comboBoxDiaria";
            this.comboBoxDiaria.Size = new System.Drawing.Size(116, 32);
            this.comboBoxDiaria.TabIndex = 7;
            this.comboBoxDiaria.Text = "Diária R$";
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
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(215, 218);
            this.textBoxAno.Multiline = true;
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(83, 32);
            this.textBoxAno.TabIndex = 5;
            this.textBoxAno.Text = "Ano";
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 379);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.comboBoxCor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxDiaria);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxChassi);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.TextBox textBoxChassi;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarVeiculo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxDiaria;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.TextBox textBoxAno;
    }
}