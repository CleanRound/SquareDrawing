internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a symbol to draw the square: ");
        char symbol = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the length of the side of the square: ");
        int sideLength = Convert.ToInt32(Console.ReadLine());

        DrawSquare(sideLength, symbol);
    }

    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                if (i == 0 || i == sideLength - 1 || j == 0 || j == sideLength - 1)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}