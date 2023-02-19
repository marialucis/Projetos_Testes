using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void btnCalcula_Click(object sender, EventArgs e)
        {

            CalculaMedia();
            MessageBox.Show("A sua media é: " + media);
            VerificaSituacaoAluno();
            LimpaDados();

        }


    
    }
}
