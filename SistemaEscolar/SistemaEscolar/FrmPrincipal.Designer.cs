namespace SistemaEscolar
{
    partial class FrmPrincipal
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
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(210, 22);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 23);
            this.btnAlunos.TabIndex = 0;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Location = new System.Drawing.Point(348, 22);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(75, 23);
            this.btnNotas.TabIndex = 1;
            this.btnNotas.Text = "Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnProf
            // 
            this.btnProf.Location = new System.Drawing.Point(484, 22);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(75, 23);
            this.btnProf.TabIndex = 2;
            this.btnProf.Text = "Professor";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnAlunos);
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.Text = "Sistema de Notas Escolar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnProf;
    }
}

