/*
 * Nome: Rafael C. Pereira
 * Data: 19/02/2019
 * Obs.: Trabalhando com C# (Classe)
 * 
 * C# - 04 - Outro exemplo de classe
 * https://www.youtube.com/watch?v=JlKssgfCfRI&index=4&list=PLfvOpw8k80WqtWFpNXEFz9zvZHediN2bu
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada;
            Triangulo objeto;
            Console.WriteLine("Verifica se três valores informados formam um triângulo");
            Console.Write("Lado A: ");
            entrada = Console.ReadLine();
            objeto = new Triangulo();
            objeto.ladoA = Convert.ToInt32(entrada);
            Console.Write("Lado B: ");
            entrada = Console.ReadLine();
            objeto.ladoB = Convert.ToInt32(entrada);
            Console.Write("Lado C: ");
            entrada = Console.ReadLine();
            objeto.ladoC = Convert.ToInt32(entrada);
            objeto.VerificaTriangulo();
            Console.ReadKey();
        }
    }
}
