﻿namespace SistemaEscolar
{
    partial class FrmNotas
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
            this.lblnota1 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtNomeA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.Location = new System.Drawing.Point(13, 137);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(53, 13);
            this.lblnota1.TabIndex = 0;
            this.lblnota1.Text = "Nota 1: ";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(83, 134);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 1;
            this.txtnota1.TextChanged += new System.EventHandler(this.txtnota1_TextChanged);
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.Location = new System.Drawing.Point(13, 178);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(53, 13);
            this.lblnota2.TabIndex = 2;
            this.lblnota2.Text = "Nota 2: ";
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(83, 175);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 3;
            this.txtnota2.TextChanged += new System.EventHandler(this.txtnota2_TextChanged);
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(372, 130);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 4;
            this.txtnota3.TextChanged += new System.EventHandler(this.txtnota3_TextChanged);
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(372, 176);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(100, 20);
            this.txtnota4.TabIndex = 5;
            this.txtnota4.TextChanged += new System.EventHandler(this.txtnota4_TextChanged);
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.Location = new System.Drawing.Point(302, 133);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(53, 13);
            this.lblnota3.TabIndex = 6;
            this.lblnota3.Text = "Nota 3: ";
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota4.Location = new System.Drawing.Point(302, 179);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(53, 13);
            this.lblnota4.TabIndex = 7;
            this.lblnota4.Text = "Nota 4: ";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(65, 269);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 9;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(13, 269);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 10;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtNomeA
            // 
            this.txtNomeA.Location = new System.Drawing.Point(112, 47);
            this.txtNomeA.Name = "txtNomeA";
            this.txtNomeA.Size = new System.Drawing.Size(363, 20);
            this.txtNomeA.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome Aluno: ";
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(554, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeA);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.lblnota1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotas";
            this.ShowIcon = false;
            this.Text = "Cadastro de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtNomeA;
        private System.Windows.Forms.Label label1;
    }
}