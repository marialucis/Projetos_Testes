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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunos frmAluno = new FrmAlunos(); //inicializa o objeto do formulario aluno
            frmAluno.ShowDialog();
            
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            FrmNotas frmNotas = new FrmNotas(); //inicializa o objeto do formulario notas
            frmNotas.ShowDialog();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            FrmProf frmProf = new FrmProf();
            frmProf.ShowDialog();
        }
    }
}
