using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAluno
{
    public class Aluno
    {
        private int _matricula;
        public int Matricula
        {
            get { return _matricula; }
            set
            {
                if(value > 0)
                {
                    _matricula = value;
                }
            }
        }

        public string Nome { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public int TipoCurso { get; set; }
    }
}
