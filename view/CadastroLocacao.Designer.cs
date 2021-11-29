﻿
namespace LoucaLiza.view
{
    partial class CadastroLocacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLocacao));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNascimento = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocalizaCliente = new System.Windows.Forms.Button();
            this.btnLocalizaVeiculo = new System.Windows.Forms.Button();
            this.btnSalvarLocacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Editar / Novo Cliente";
            // 
            // textBoxNascimento
            // 
            this.textBoxNascimento.Location = new System.Drawing.Point(16, 70);
            this.textBoxNascimento.Multiline = true;
            this.textBoxNascimento.Name = "textBoxNascimento";
            this.textBoxNascimento.Size = new System.Drawing.Size(120, 32);
            this.textBoxNascimento.TabIndex = 0;
            this.textBoxNascimento.Text = "Data de Locação";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(16, 123);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(459, 32);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 176);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Veículo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 229);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 32);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Dias Locação";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 229);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 32);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Dias Locação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "R$ valor";
            // 
            // btnLocalizaCliente
            // 
            this.btnLocalizaCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLocalizaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaCliente.Image")));
            this.btnLocalizaCliente.Location = new System.Drawing.Point(472, 123);
            this.btnLocalizaCliente.Name = "btnLocalizaCliente";
            this.btnLocalizaCliente.Size = new System.Drawing.Size(32, 32);
            this.btnLocalizaCliente.TabIndex = 1;
            this.btnLocalizaCliente.TabStop = false;
            this.btnLocalizaCliente.UseVisualStyleBackColor = false;
            this.btnLocalizaCliente.Click += new System.EventHandler(this.btnLocalizaCliente_Click);
            // 
            // btnLocalizaVeiculo
            // 
            this.btnLocalizaVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizaVeiculo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLocalizaVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizaVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaVeiculo.Image")));
            this.btnLocalizaVeiculo.Location = new System.Drawing.Point(472, 176);
            this.btnLocalizaVeiculo.Name = "btnLocalizaVeiculo";
            this.btnLocalizaVeiculo.Size = new System.Drawing.Size(32, 32);
            this.btnLocalizaVeiculo.TabIndex = 2;
            this.btnLocalizaVeiculo.TabStop = false;
            this.btnLocalizaVeiculo.UseVisualStyleBackColor = false;
            this.btnLocalizaVeiculo.Click += new System.EventHandler(this.btnLocalizaVeiculo_Click);
            // 
            // btnSalvarLocacao
            // 
            this.btnSalvarLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnSalvarLocacao.FlatAppearance.BorderSize = 0;
            this.btnSalvarLocacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLocacao.Location = new System.Drawing.Point(404, 349);
            this.btnSalvarLocacao.Name = "btnSalvarLocacao";
            this.btnSalvarLocacao.Size = new System.Drawing.Size(100, 32);
            this.btnSalvarLocacao.TabIndex = 5;
            this.btnSalvarLocacao.Text = "Alugar Veículo";
            this.btnSalvarLocacao.UseVisualStyleBackColor = false;
            // 
            // CadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 402);
            this.Controls.Add(this.btnSalvarLocacao);
            this.Controls.Add(this.btnLocalizaVeiculo);
            this.Controls.Add(this.btnLocalizaCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNascimento);
            this.Controls.Add(this.label1);
            this.Name = "CadastroLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoucaLiza - Cadastro Locação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNascimento;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocalizaCliente;
        private System.Windows.Forms.Button btnLocalizaVeiculo;
        private System.Windows.Forms.Button btnSalvarLocacao;
    }
}