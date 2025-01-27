class HUU
{
    static int n = 50;
    static int m = 30;
    static Random rnd = new Random();
    static char[,] palya = new char[n, m];

    static void Ki_iras()
    {
        for (int i = 0; i < palya.GetLength(0); i++)
        {
            Console.SetCursorPosition(0, i);
            for (int j = 0; j < palya.GetLength(1); j++)
            {
                System.Console.Write(palya[i, j]);
            }
            System.Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.SetWindowSize(n, m);
        bool exit = false;
        int timer = 100;
        while (!exit)
        {
            timer--;
            Console.SetCursorPosition(0,0);
            System.Console.WriteLine(timer);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
                else
                {
                    Console.SetCursorPosition(n/2,m/2);
                    System.Console.WriteLine(pressed.KeyChar);
                }
            }
        }
    }
}