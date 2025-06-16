using EjerciciosPrueba;

int opcion = 0;
TableroDamas tablero = new TableroDamas();

do
{
    Console.WriteLine("*************Menu de Ejercicios**************\n");
    Console.WriteLine("1. Tablero de Damas.\n");
    Console.WriteLine("2. Elementos de un arreglo que sumados dan 10.\n");
    Console.WriteLine("3. Movimientos en una matriz de 4x4.\n");
    Console.WriteLine("4. Salir.\n");

    Console.Write("Por favor, selecciona un ejercicio: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("*********************************************\n");

    switch (opcion)
    {
        case 1:
            // Ejercicio 1: Tablero de Damas
            tablero.ImprimirTableroDamas();
            break;
        case 2:
            // Ejercicio 2: Elementos de un arreglo que sumados dan 10
            Console.WriteLine("");
            break;
        case 3:
            // Ejercicio 3: Movimientos en una matriz de 4x4
            Console.WriteLine("");
            break;
        case 4:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, selecciona una opción del menú.");
            break;
    }

}
while (opcion != 4);