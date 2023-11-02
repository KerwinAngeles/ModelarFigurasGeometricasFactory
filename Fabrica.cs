using System.Collections;

class Fabrica
{
    public static IInterface GetFiguras(int opc)
    {
        if (opc == 1)
        {
            return new Cuadrado();
        }
        else if (opc == 2)
        {
            return new Rectangulo();
        }
        else if (opc == 3)
        {
            return new Triangulo();
        }
        else
        {
            return Hexagono.GetHexagonod();
        }
    }
}