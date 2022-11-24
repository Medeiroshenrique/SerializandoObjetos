using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializando
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, string sobrenome, int idade) {
            if (nome!=""||sobrenome!=""||idade!=0) {
                this.Nome = nome;
                this.Sobrenome = sobrenome;
                this.Idade = idade;
            }
            
        }
    }
}
