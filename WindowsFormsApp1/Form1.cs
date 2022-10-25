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

        public void carregarLista()
        {
            dataGridView1.Rows.Clear();
            foreach (Aluno al in listaAlunos)
            {
                dataGridView1.Rows.Add(
                    al.ra,
                    al.nome,
                    al.n1,
                    al.n2,
                    al.n3,
                    al.n4,
                    al.media,
                    al.situacao
                    );
            }
        }
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
                

            bool existe = false;
            foreach (Aluno al in listaAlunos)
            {
                if (al.ra == a.ra)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                listaAlunos.Add(a);
                carregarLista();
                MessageBox.Show("Aluno adicionado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Aluno já existe!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
