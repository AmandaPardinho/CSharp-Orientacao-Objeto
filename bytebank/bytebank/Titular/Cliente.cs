using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        //Método construtor => é invocado quando se cria um novo objeto (assim q se coloca a palavra "new")
        public Cliente() 
        {
            
        }
    }
}
