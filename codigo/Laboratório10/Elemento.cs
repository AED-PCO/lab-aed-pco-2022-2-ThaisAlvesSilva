using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Elemento
    {
        public Aluno aluno;
        public Elemento proximo;

        public Elemento(){
            this.aluno = new Aluno();
            this.proximo = null;
        }
    }
}
