using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        List<Aluno> listaAlunos = new List<Aluno>();
         
        private void BtnEnviar_Click(object sender, EventArgs e)
        {

            Aluno a = new Aluno();

            a.ra = Convert.ToInt32(txtRA.Text);
            a.nome = txtNome.Text;
            a.n1 = Convert.ToDouble(txtN1.Text);
            a.n2 = Convert.ToDouble(txtN2.Text);
            a.n3 = Convert.ToDouble(txtN3.Text);
            a.n4 = Convert.ToDouble(txtN4.Text);

            a.calcMedia();
            a.defSituacao();

            
                dataGridView1.Rows.Clear();
                //foreach (Aluno a in listaAlunos)
                {
                    dataGridView1.Rows.Add(
                        a.ra,
                        a.nome,
                        a.n1,
                        a.n2,
                        a.n3,
                        a.n4,
                        a.media,
                        a.situacao
                        );
                }
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
