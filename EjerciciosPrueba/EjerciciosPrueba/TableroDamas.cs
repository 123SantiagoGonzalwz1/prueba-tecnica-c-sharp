using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrueba
{
    internal class TableroDamas
    {
        int casillas = 0;
        string colorNegro = "X";
        string colorBlanco = "_";

        public string ImprimirTableroDamas()
        {
            Console.WriteLine("*************Tablero de Damas**************\n");
            
            bool entradaUsuario = false;
            
            while (!entradaUsuario)
            {
                try
                {
                    Console.WriteLine("Ingresa el número de casillas (del 1 al 10)\n");
                    casillas = Convert.ToInt32(Console.ReadLine());

                    // Si el número de casillas no esta en el rango permitido, se deja por defecto a 7
                    if (casillas < 1 || casillas > 10)
                    {
                        Console.WriteLine(":( Que te dije (del 1 al 10)");
                        casillas = 7;
                        entradaUsuario = true;
                    } else
                    {
                        entradaUsuario = true;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }

            }

            // Imprimiendo el tablero
            // filas
            for (int i = 0; i < casillas; i++)
            {
                // columnas
                for (int j = 0; j < casillas; j++)
                {
                    // si la suma de los indicies es par, se imprime una casilla negra
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(colorNegro);
                    } else
                    {
                        Console.Write(colorBlanco);
                    }

                }

                Console.WriteLine();
            }

            return "Tablero de Damas impreso correctamente.";
        }

    }
}
