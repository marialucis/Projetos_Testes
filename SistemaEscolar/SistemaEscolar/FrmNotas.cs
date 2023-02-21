using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaEscolar
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }
        //variaveis
        public double media {get;set;}
        public double nota1 {get;set;}
        public double nota2 {get;set;} 
        public double nota3 {get; set;}
        public double nota4 {get; set;}
        public string nomeA { get;set;}
        //metodo que obtem as notas do aluno
        public void ObterNotas()
        {
            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            nota4 = Convert.ToDouble(txtnota4.Text);           
        }

        //metodo que calcula a media do aluno
        public void CalculaMedia()
        {
            ObterNotas();
            media = (nota1 + nota2 + nota3 + nota4) / 4;
        }
        
        //metodo que limpa os dados após o calculo da media
        public void LimpaDados()
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtNomeA.Clear();
        }

        //metodo que vai verificar a situação 'Aprovado', 'Recuperação', 'Reprovado'
        public void VerificaSituacaoAluno()
        {
            if (media >= 7) 
            {
                MessageBox.Show("Aprovado");
            }

            else if ( media >= 6 )
            {
                MessageBox.Show("Recuperação");
            }
            else
            {
                MessageBox.Show("Reprovado");
            }

        }
        
        public void ObtemAluno() 
        {
            nomeA = txtNomeA.Text;
            FrmAlunos frmAlunos = new FrmAlunos();
            frmAlunos.nomeAluno = nomeA;
              
                }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            ObtemAluno();
            CalculaMedia();
            MessageBox.Show($"Olá {nomeA}a sua media é:{media}");
            VerificaSituacaoAluno();
            LimpaDados();

        }
        //Validacao com regex
        Regex regex = new Regex(@"^\d*[0-9]+$");
        private void txtnota1_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtnota1.Text))
            {

                nota1 =Convert.ToDouble(txtnota1.Text);
                
            }
            else
            {
                MessageBox.Show("numero invalido");
                txtnota1.Clear();
                
            }
        }

        private void txtnota2_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtnota2.Text))
            {
                nota2 = Convert.ToDouble(txtnota2.Text);
            }
            else
            {
                txtnota2.Clear();
                MessageBox.Show("numero invalido");
            }
        }

        private void txtnota3_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtnota3.Text))
            {
                nota3 = Convert.ToDouble(txtnota3.Text);
            }
            else
            {
                txtnota3.Clear();
                MessageBox.Show("numero invalido");
            }
        }

        private void txtnota4_TextChanged(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtnota4.Text))
            {
                nota4 = Convert.ToDouble(txtnota4.Text);
            }
            else
            {
                txtnota4.Clear();
                MessageBox.Show("numero invalido");
                
            }
        }
    }
}
