using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aluno
    {
        public int ra;
        public string nome;
        public double n1;
        public double n2;
        public double n3;
        public double n4;
        public double media;
        public string situacao;
        public void calcMedia()
        {
            media = ((n1 * 2) + (n2 * 3) + (n3 * 2) + (n4 * 3)) / 10;
        }
        public void defSituacao()
        {
            if(media < 4)
            {
                situacao = ("Reprovado!!!");
            }
            else if (media < 6)
            {
                situacao = ("Recuperação!!!");
            }
            else
            {
                situacao = ("Aprovado!!!");
            }
        }
    }
}
