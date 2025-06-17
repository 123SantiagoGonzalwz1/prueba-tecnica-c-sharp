using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrueba
{
    internal class MovimientoDeUnElemento
    {
        string[] matriz = { "O", "O", "O", "O",
                            "O", "O", "O", "O",
                            "O", "O", "O", "O",
                            "O", "O", "O", "O" };
        int[] movimientos = { 1,2,-1,1,0,1,2,-1,-1,-2};
        int posicionX = 0;
        int posicionY = 0;
        int posicionActual = 0;

        private void MoverElemento()
        {
            for (int i = 0; i < movimientos.Length; i += 2)
            {
                // Movimiento horizontal X
                posicionX += movimientos[i];
                // Movimiento vertical Y
                posicionY += movimientos[i + 1];

                // Verificando que la posición no se salga de los límites de la matriz 4x4
                if (posicionX < 0 || posicionX >= 4 || posicionY < 0 || posicionY >= 4)
                {
                    if (posicionX < 0)
                    {
                        posicionX = 0;
                    }
                    else if (posicionX >= 4)
                    {
                        posicionX = 3;
                    }

                    if (posicionY < 0)
                    {
                        posicionY = 0;
                    }
                    else if (posicionY >= 4)
                    {
                        posicionY = 3;
                    }
                }

                // Actualizando la posición actual en la matriz
                posicionActual = posicionY * 4 + posicionX;

                // Limpiando la matriz
                for (int j = 0; j < matriz.Length; j++)
                {
                    matriz[j] = "O";
                }

                // Colocando el elemento en la nueva posición
                matriz[posicionActual] = "X";
            }
        }

        public void ImprimirMatriz()
        {
            MoverElemento();

            Console.WriteLine("*************Matriz 4x4***************");

            for (int i = 0; i < 4; i++) // Imprimir filas
            {
                for (int j = 0; j < 4; j++) // Imprimir columnas
                {
                    // Calcular el índice de la matriz
                    int indice = i * 4 + j;
                    Console.Write(matriz[indice]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
