// Juego de Piedra, Papel, Tijera!

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Elije una opción: 1 - Piedra, 2 - Papel, 3 - Tijera, 4 - Salir");
            int opcionUsuario = Convert.ToInt32(Console.ReadLine());

            if (opcionUsuario == 4)
            {
                Console.WriteLine("¡Gracias por jugar!");
                break;
            }

            Random random = new Random();
            int opcionComputadora = random.Next(1, 4);

            Console.WriteLine("La computadora elige: " + GetOpcion(opcionComputadora));
            Console.WriteLine("Tú eliges: " + GetOpcion(opcionUsuario));

            int resultado = DeterminarGanador(opcionUsuario, opcionComputadora);

            if (resultado == 0)
            {
                Console.WriteLine("Empate.");
            }
            else if (resultado == 1)
            {
                Console.WriteLine("¡Ganaste!");
            }
            else
            {
                Console.WriteLine("La computadora gana.");
            }
        }
    }

    static string GetOpcion(int opcion)
    {
        switch (opcion)
        {
            case 1:
                return "Piedra";
            case 2:
                return "Papel";
            case 3:
                return "Tijera";
            default:
                return "Opción inválida";
        }
    }

    static int DeterminarGanador(int usuario, int computadora)
    {
        if (usuario == computadora)
        {
            return 0; // Empate
        }
        else if ((usuario == 1 && computadora == 3) || (usuario == 2 && computadora == 1) || (usuario == 3 && computadora == 2))
        {
            return 1; // Usuario gana
        }
        else
        {
            return -1; // Computadora gana
        }
    }
}

