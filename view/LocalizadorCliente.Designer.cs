
namespace LoucaLiza.view
{
    partial class LocalizadorCliente
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
            this.textBoxCNH = new System.Windows.Forms.TextBox();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCNH
            // 
            this.textBoxCNH.Location = new System.Drawing.Point(527, 79);
            this.textBoxCNH.Multiline = true;
            this.textBoxCNH.Name = "textBoxCNH";
            this.textBoxCNH.Size = new System.Drawing.Size(140, 32);
            this.textBoxCNH.TabIndex = 42;
            this.textBoxCNH.Text = "CNH";
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridCliente.Location = new System.Drawing.Point(13, 121);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.Size = new System.Drawing.Size(759, 353);
            this.dataGridCliente.TabIndex = 41;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(672, 79);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(100, 32);
            this.btnBuscarCliente.TabIndex = 40;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(381, 79);
            this.textBoxCPF.Multiline = true;
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(140, 32);
            this.textBoxCPF.TabIndex = 39;
            this.textBoxCPF.Text = "CPF";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 79);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(362, 32);
            this.textBoxNome.TabIndex = 38;
            this.textBoxNome.Text = "Nome";
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Location = new System.Drawing.Point(460, 27);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(100, 32);
            this.btnExcluirCliente.TabIndex = 37;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Location = new System.Drawing.Point(566, 27);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(100, 32);
            this.btnEditarCliente.TabIndex = 36;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Location = new System.Drawing.Point(672, 27);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(100, 32);
            this.btnAddCliente.TabIndex = 35;
            this.btnAddCliente.Text = "+ Novo Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Clientes";
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnSelecionarCliente.FlatAppearance.BorderSize = 0;
            this.btnSelecionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarCliente.Location = new System.Drawing.Point(672, 498);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(100, 32);
            this.btnSelecionarCliente.TabIndex = 43;
            this.btnSelecionarCliente.Text = "Selecionar";
            this.btnSelecionarCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // LocalizadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSelecionarCliente);
            this.Controls.Add(this.textBoxCNH);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.label1);
            this.Name = "LocalizadorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoucaLiza - Localizar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCNH;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionarCliente;
    }
}