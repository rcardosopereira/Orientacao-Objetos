/*
 * Nome: Rafael C. Pereira
 * Data: 18/02/2019
 * Obs.: Praticando Orientação a Objetos em C# (Visual Studio).
 * 
 * C# - 01 - O que é programação orientada a objetos
 * https://www.youtube.com/watch?v=vhvmZfxZhPw&list=PLfvOpw8k80WqtWFpNXEFz9zvZHediN2bu&index=1
 * 
 * C# - 02 - Criando um projeto orientado a objetos em C# no Visual Studio
 * https://www.youtube.com/watch?v=EHyScjTolMw&list=PLfvOpw8k80WqtWFpNXEFz9zvZHediN2bu&index=2
 * 
 * C# - 03 - Utilizando a classe Pessoa no programa principal
 * https://www.youtube.com/watch?v=E3d35uKPDpM&index=3&list=PLfvOpw8k80WqtWFpNXEFz9zvZHediN2bu
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalha com objetos do tipo pessoa
            String entrada = "";
            Pessoa pessoa1;
            pessoa1 = new Pessoa();
            Console.WriteLine("Efetua a leitura dos dados de três pessoas.");
            Console.WriteLine("Dados da 1º pessoa");
            Console.Write("Informe o seu nome: ");
            entrada = Console.ReadLine();
            pessoa1.nome = entrada;
            Console.Write("Informe a sua altura: ");
            entrada = Console.ReadLine();
            pessoa1.altura = Convert.ToDouble(entrada);
            
            Pessoa2 pessoa2;
            pessoa2 = new Pessoa2();
            Console.WriteLine();
            Console.WriteLine("Dados da 2º pessoa");
            Console.Write("Informe o nome da 2º pessoa: ");
            entrada = Console.ReadLine();
            pessoa2.nome2 = entrada;
            Console.Write("Informe a altura: ");
            entrada = Console.ReadLine();
            pessoa2.altura2 = Convert.ToDouble(entrada);

            Pessoa3 pessoa3;
            Console.WriteLine();
            pessoa3 = new Pessoa3();
            Console.WriteLine("Dados da 3º pessoa");
            Console.Write("Informe o nome da 3º pessoa: ");
            entrada = Console.ReadLine();
            pessoa3.nome3 = entrada;
            Console.Write("Informe a altura: ");
            entrada = Console.ReadLine();
            pessoa3.altura3 = Convert.ToDouble(entrada);

            pessoa1.FaleSobreVoce();
            Console.WriteLine();
            pessoa2.FaleSobreVoce();
            Console.WriteLine();
            pessoa3.FaleSobreVoce();
            Console.ReadKey();
        }
    }
}
