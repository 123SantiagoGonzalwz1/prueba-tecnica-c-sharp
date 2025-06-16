using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrueba
{
    internal class SumaDeDosElementos
    {
        int[] elementos = { 1, 2, 3, 2, 7, 0 };
        int objetivo = 10;

        public void BuscarDosElementosQueSumen10()
        {
            Console.WriteLine("*************Dos números que al sumarlos den 10**************\n");

            bool encontrado = false;

            // Recorriendo el indice desde el primer elemento hasta el penúltimo
            for (int i = 0; i < elementos.Length; i++)
            {
                // Recorriendo el indice desde el siguiente elemento al actual hasta el último
                for (int j = i + 1; j < elementos.Length; j++)
                {
                    // Verificando la suma de los dos elementos
                    if (elementos[i] + elementos[j] == objetivo)
                    {
                        // Convertir arreglo a string para mostrarlo
                        Console.WriteLine($"Dado un array [{string.Join(", ", elementos)}], estos dos elementos suman 10\n");
                        Console.WriteLine($"{elementos[i]} {elementos[j]}\n");

                        encontrado = true;
                        return;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"El array [{string.Join(", ", elementos)}], no contiene ninguna pareja que sume {objetivo}");
            }
        }

    }
}
