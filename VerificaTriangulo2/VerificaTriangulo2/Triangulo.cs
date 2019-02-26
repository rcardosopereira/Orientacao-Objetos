using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaTriangulo2
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        //void: não devolve valor algum.
        public void VerificaTriangulo()
        {
            if((ladoA < ladoB + ladoC)&&(ladoB < ladoA + ladoC)&&(ladoC < ladoB + ladoA))
            {
                Console.WriteLine("Forma um triângulo");
            }
            else
            {
                Console.WriteLine("Não forma um triângulo");
            }
        }
    }
}

/*
 * if(ladoA==ladoB && ladoA==ladoC && ladoB==ladoC) //é equilatero
 * else if((ladoA == ladoB & ladoA != ladoC) || (ladoA==ladoC && ladoA != ladoB) || (ladoB == ladoC & ladoA != ladoC)) //é isosceles
 * else //no caso todas as tentativas de comparação entre os lados ja foram esgotadas, 
 * os 3 lados são diferentes em tamanho é escaleno.
 */
