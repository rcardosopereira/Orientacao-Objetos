using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    class Pessoa
    {
        private string nome;
        private double altura;

        public void setNome(String valor)
        {
            //nome = valor;
            this.nome = valor;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setAltura(double valor)
        {
            this.altura = valor;
        }

        public double getAltura()
        {
            return this.altura;
        }



        public void FaleSobreVoce()
        {
            Console.WriteLine("=====================(Resultados)====================");
            Console.WriteLine("Meu nome é: " + nome);
            Console.WriteLine("Eu tenho: " + altura + " metros de altura.");
        }
    }
}
