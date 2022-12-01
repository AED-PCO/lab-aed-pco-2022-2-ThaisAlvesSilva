using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDuplamenteEncad
{
    public class Elemento
    {
        public Aluno aluno;
        public Elemento proximo;
        public Elemento anterior;

        public Elemento()
        {
            this.aluno = new Aluno();
            this.proximo = null;
            this.anterior = null;
        }
    }
}
