using System;

namespace ejercicio
{
    class Program
    {
        public static void Main (string [] args)
        {
            IInterface figuras;
            Console.Clear();

            Console.WriteLine("FIGURAS GEOMETRIVAS");
            Console.WriteLine("Cual figura geometrica desea dibujar " +
            "\n 1: Cuadrado " +
            "\n 2: Triangulo " +
            "\n 3: Rectagunlo " +
            "\n 4: Hexagono");
            int opc = int.Parse(Console.ReadLine());

            figuras = Fabrica.GetFiguras(opc);

            figuras.DibujarFiguara();
            Console.ReadKey();
            Main(args);
        }
    }
}