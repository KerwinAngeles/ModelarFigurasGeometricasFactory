class Hexagono : IInterface
{
    private static Hexagono hexagono;
    private Hexagono()
    {

    }

    public static Hexagono GetHexagonod()
    {
        if (hexagono == null)
        {
            hexagono = new Hexagono();
            return hexagono;
        }
        else
        {
            return hexagono;
        }
    }
    public void DibujarFiguara()
    {
        Console.WriteLine("Dibujando un hexagono...");
    }
}