namespace SistemaEscolar
{
    partial class FrmAlunos
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
            this.txtnomeAluno = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnsalvaAluno = new System.Windows.Forms.Button();
            this.btnalteraAluno = new System.Windows.Forms.Button();
            this.btnexcluirAluno = new System.Windows.Forms.Button();
            this.lbldtaNasc = new System.Windows.Forms.Label();
            this.txtdtaN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnomeAluno
            // 
            this.txtnomeAluno.Location = new System.Drawing.Point(117, 54);
            this.txtnomeAluno.Name = "txtnomeAluno";
            this.txtnomeAluno.Size = new System.Drawing.Size(283, 20);
            this.txtnomeAluno.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Completo:";
            // 
            // btnsalvaAluno
            // 
            this.btnsalvaAluno.Location = new System.Drawing.Point(15, 318);
            this.btnsalvaAluno.Name = "btnsalvaAluno";
            this.btnsalvaAluno.Size = new System.Drawing.Size(75, 23);
            this.btnsalvaAluno.TabIndex = 2;
            this.btnsalvaAluno.Text = "Salvar";
            this.btnsalvaAluno.UseVisualStyleBackColor = true;
            this.btnsalvaAluno.Click += new System.EventHandler(this.btnsalvaAluno_Click);
            // 
            // btnalteraAluno
            // 
            this.btnalteraAluno.Location = new System.Drawing.Point(108, 318);
            this.btnalteraAluno.Name = "btnalteraAluno";
            this.btnalteraAluno.Size = new System.Drawing.Size(75, 23);
            this.btnalteraAluno.TabIndex = 3;
            this.btnalteraAluno.Text = "Alterar";
            this.btnalteraAluno.UseVisualStyleBackColor = true;
            this.btnalteraAluno.Click += new System.EventHandler(this.btnalteraAluno_Click);
            // 
            // btnexcluirAluno
            // 
            this.btnexcluirAluno.Location = new System.Drawing.Point(202, 318);
            this.btnexcluirAluno.Name = "btnexcluirAluno";
            this.btnexcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnexcluirAluno.TabIndex = 4;
            this.btnexcluirAluno.Text = "Excluir";
            this.btnexcluirAluno.UseVisualStyleBackColor = true;
            this.btnexcluirAluno.Click += new System.EventHandler(this.btnexcluirAluno_Click);
            // 
            // lbldtaNasc
            // 
            this.lbldtaNasc.AutoSize = true;
            this.lbldtaNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtaNasc.Location = new System.Drawing.Point(419, 58);
            this.lbldtaNasc.Name = "lbldtaNasc";
            this.lbldtaNasc.Size = new System.Drawing.Size(112, 13);
            this.lbldtaNasc.TabIndex = 5;
            this.lbldtaNasc.Text = "Data Nascimento: ";
            // 
            // txtdtaN
            // 
            this.txtdtaN.Location = new System.Drawing.Point(537, 54);
            this.txtdtaN.Name = "txtdtaN";
            this.txtdtaN.Size = new System.Drawing.Size(123, 20);
            this.txtdtaN.TabIndex = 6;
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 411);
            this.Controls.Add(this.txtdtaN);
            this.Controls.Add(this.lbldtaNasc);
            this.Controls.Add(this.btnexcluirAluno);
            this.Controls.Add(this.btnalteraAluno);
            this.Controls.Add(this.btnsalvaAluno);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtnomeAluno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomeAluno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnsalvaAluno;
        private System.Windows.Forms.Button btnalteraAluno;
        private System.Windows.Forms.Button btnexcluirAluno;
        private System.Windows.Forms.Label lbldtaNasc;
        private System.Windows.Forms.TextBox txtdtaN;
    }
}