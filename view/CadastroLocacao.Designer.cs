
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxDataLocacao = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxCliente = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxVeiculo = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxDias = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.textBoxDevolucao = new LoucaLiza.View.Components.PlaceHolderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLocalizaCliente = new System.Windows.Forms.Button();
            this.btnLocalizaVeiculo = new System.Windows.Forms.Button();
            this.btnSalvarLocacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(131, 24);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Nova Locação";
            // 
            // textBoxDataLocacao
            // 
            this.textBoxDataLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDataLocacao.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDataLocacao.Location = new System.Drawing.Point(16, 73);
            this.textBoxDataLocacao.Multiline = true;
            this.textBoxDataLocacao.Name = "textBoxDataLocacao";
            this.textBoxDataLocacao.PlaceHolderText = "dd/mm/yyyy HH:mm";
            this.textBoxDataLocacao.Size = new System.Drawing.Size(120, 32);
            this.textBoxDataLocacao.TabIndex = 0;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxCliente.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCliente.Location = new System.Drawing.Point(16, 128);
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.PlaceHolderText = "Cliente";
            this.textBoxCliente.Size = new System.Drawing.Size(459, 32);
            this.textBoxCliente.TabIndex = 1;
            this.textBoxCliente.TabStop = false;
            // 
            // textBoxVeiculo
            // 
            this.textBoxVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxVeiculo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxVeiculo.Location = new System.Drawing.Point(16, 183);
            this.textBoxVeiculo.Multiline = true;
            this.textBoxVeiculo.Name = "textBoxVeiculo";
            this.textBoxVeiculo.PlaceHolderText = "Veículo";
            this.textBoxVeiculo.Size = new System.Drawing.Size(459, 32);
            this.textBoxVeiculo.TabIndex = 2;
            this.textBoxVeiculo.TabStop = false;
            // 
            // textBoxDias
            // 
            this.textBoxDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDias.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDias.Location = new System.Drawing.Point(16, 240);
            this.textBoxDias.Multiline = true;
            this.textBoxDias.Name = "textBoxDias";
            this.textBoxDias.PlaceHolderText = "Dias Locação";
            this.textBoxDias.Size = new System.Drawing.Size(120, 32);
            this.textBoxDias.TabIndex = 3;
            // 
            // textBoxDevolucao
            // 
            this.textBoxDevolucao.Enabled = false;
            this.textBoxDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.textBoxDevolucao.ForeColor = System.Drawing.Color.Gray;
            this.textBoxDevolucao.Location = new System.Drawing.Point(157, 240);
            this.textBoxDevolucao.Multiline = true;
            this.textBoxDevolucao.Name = "textBoxDevolucao";
            this.textBoxDevolucao.PlaceHolderText = "dd/mm/yyyy HH:mm";
            this.textBoxDevolucao.Size = new System.Drawing.Size(120, 32);
            this.textBoxDevolucao.TabIndex = 4;
            this.textBoxDevolucao.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "R$ 0.00";
            // 
            // btnLocalizaCliente
            // 
            this.btnLocalizaCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLocalizaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizaCliente.Image")));
            this.btnLocalizaCliente.Location = new System.Drawing.Point(472, 128);
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
            this.btnLocalizaVeiculo.Location = new System.Drawing.Point(472, 183);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Devolução Estimada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Dias Locação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Data Locação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Veículo";
            // 
            // CadastroLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarLocacao);
            this.Controls.Add(this.btnLocalizaVeiculo);
            this.Controls.Add(this.btnLocalizaCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDevolucao);
            this.Controls.Add(this.textBoxDias);
            this.Controls.Add(this.textBoxVeiculo);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.textBoxDataLocacao);
            this.Controls.Add(this.labelTitle);
            this.Name = "CadastroLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoucaLiza - Cadastro Locação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDataLocacao;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxCliente;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxVeiculo;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDias;
        private LoucaLiza.View.Components.PlaceHolderTextBox textBoxDevolucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLocalizaCliente;
        private System.Windows.Forms.Button btnLocalizaVeiculo;
        private System.Windows.Forms.Button btnSalvarLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}