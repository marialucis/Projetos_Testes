using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaEscolar
{
    public partial class FrmAlunos : Form
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }

        //variaveis/propridad
       public String nomeAlterado { get; set; }
       public String nomeAluno { get; set; }
       public String DtaNas { get; set; }

        //validacao com 
        Regex regexValidaAluno = new Regex(@"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i;");

        //criando metodo para obter os dados do aluno
        public void DadosAlunos()
        {
            nomeAluno = txtnomeAluno.Text;
            DtaNas = txtdtaN.Text;

            if (regexValidaAluno.IsMatch(nomeAluno)) 
            {
                nomeAluno = txtnomeAluno.Text;
            
            }
            else 
            {
                MessageBox.Show("Nome Invalido!");
            }



        }


        //metodo para alterar dados do aluno
        public void AlteraDadosAluno()
        {
            nomeAlterado = txtnomeAluno.Text;

        }

        //criando metodo para apgar dados do aluno
        public void LimpadadoAluno()
        {
            txtnomeAluno.Clear();
            txtdtaN.Clear();
        }

        private void btnsalvaAluno_Click(object sender, EventArgs e)
        {
            DadosAlunos();
            MessageBox.Show("Aluno(a) salvo com sucesso.");
            LimpadadoAluno();
        }

        private void btnalteraAluno_Click(object sender, EventArgs e)
        {
            AlteraDadosAluno();
            MessageBox.Show("Aluno(a) alterado com sucesso.");
            LimpadadoAluno();
        }

        private void btnexcluirAluno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluno(a) excluido.");
            LimpadadoAluno();
        }
    }
}
