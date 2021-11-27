
namespace LoucaLiza.view
{
    partial class ListaCliente
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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxCNH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dataGridCliente.Location = new System.Drawing.Point(13, 124);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.Size = new System.Drawing.Size(759, 353);
            this.dataGridCliente.TabIndex = 32;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(672, 82);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(100, 32);
            this.btnBuscarCliente.TabIndex = 29;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(13, 82);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(362, 32);
            this.textBoxNome.TabIndex = 27;
            this.textBoxNome.Text = "Nome";
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.btnExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Location = new System.Drawing.Point(460, 30);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(100, 32);
            this.btnExcluirCliente.TabIndex = 26;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Location = new System.Drawing.Point(566, 30);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(100, 32);
            this.btnEditarCliente.TabIndex = 25;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(137)))));
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Location = new System.Drawing.Point(672, 30);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(100, 32);
            this.btnAddCliente.TabIndex = 24;
            this.btnAddCliente.Text = "+ Novo Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(13, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 24);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Clientes";
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(381, 82);
            this.textBoxCPF.Multiline = true;
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(140, 32);
            this.textBoxCPF.TabIndex = 28;
            this.textBoxCPF.Text = "CPF";
            // 
            // textBoxCNH
            // 
            this.textBoxCNH.Location = new System.Drawing.Point(527, 82);
            this.textBoxCNH.Multiline = true;
            this.textBoxCNH.Name = "textBoxCNH";
            this.textBoxCNH.Size = new System.Drawing.Size(140, 32);
            this.textBoxCNH.TabIndex = 33;
            this.textBoxCNH.Text = "CNH";
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBoxCNH);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.labelTitle);
            this.Name = "ListaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoucaLiza - Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.TextBox textBoxCNH;
    }
}