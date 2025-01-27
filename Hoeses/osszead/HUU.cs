class HUU
{
    static int n = 50;
    static int m = 30;
    static Random rnd = new Random();
    static int[,] palya = new int[n, m];

    static void Ki_iras()
    {
        for (int i = 0; i < palya.GetLength(1); i++)
        {
            
            for (int j = 0; j < palya.GetLength(0); j++)
            {
                if (palya[j,i] != 0)
                {
                    Console.SetCursorPosition(j, i);
                    System.Console.Write(palya[j, i]);
                }
            }
            System.Console.WriteLine();
        }
    }

    static void KajaElhelyezes(int db){
        for (int i = 0; i < db; i++)
        {
            int kajax = rnd.Next(0,n);
            int kajay = rnd.Next(0,m);
            int kaja_ertek = rnd.Next(5,10);
            palya[kajax,kajay] = kaja_ertek;
        }
    }

    static void Main()
    {
        Console.SetWindowSize(n+1, m+1);

        bool exit = false;
        int timer = 100;

        int babux = n / 2;
        int babuy = m / 2;
        
        int telehas = 10;

        KajaElhelyezes(30);
        
        Ki_iras();

        while (!exit)
        {
            timer--;
            Console.SetCursorPosition(0, 0);
            System.Console.WriteLine(timer);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
                else if (pressed.Key == ConsoleKey.UpArrow && babuy > 0)
                {
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write(' ');
                    babuy--;
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write('\u263A');
                }
                else if (pressed.Key == ConsoleKey.RightArrow && babux < n)
                {
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write(' ');
                    babux++;
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write('\u263A');
                }
                else if (pressed.Key == ConsoleKey.DownArrow && babuy < m)
                {
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write(' ');
                    babuy++;
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write('\u263A');
                }
                else if (pressed.Key == ConsoleKey.LeftArrow && babux > 0)
                {
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write(' ');
                    babux--;
                    Console.SetCursorPosition(babux,babuy);
                    Console.Write('\u263A');
                }

                if (palya[babux, babuy] > 0)
                {
                    telehas += palya[babux,babuy];                   
                }
            }
        }
    }
}