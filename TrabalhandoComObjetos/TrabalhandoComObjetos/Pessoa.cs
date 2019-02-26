using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    class Pessoa
    {
        public string nome;
        public double altura;
        public void FaleSobreVoce()
        {
            Console.WriteLine("=====================(Resultados)====================");
            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("Eu tenho: " + altura + " metros de altura.");
        }
    }
}
