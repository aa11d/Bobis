using System.Reflection.Metadata;

class Dugo
{
    static char[] ball = ['1', '3', '5', '6', '9'];
    static char[] jobb = ['2', '4', '7', '8', '0'];
    static int n = 80;
    static Random rnd = new Random();
    static char[] palya = new char[n];

    static void literal()
    {
        for (int i = 0; i < palya.Length; i++)
        {
            Console.SetCursorPosition(i, 1);
            palya[i] = ' ';
        }
    }
    static void iras()
    {
        for (int i = 0; i < palya.Length; i++)
        {
            Console.SetCursorPosition(i, 1);
            System.Console.Write(palya[i]);
        }
    }

    static void Gen()
    {
        double p = 0.5;
        double s = rnd.NextDouble();
        s = rnd.NextDouble();
        if (s > p && palya[0] == ' ')
        {
            //Console.SetCursorPosition(0, 1);
            palya[0] = (char)ball[rnd.Next(0, ball.Length - 1)];
        }
        s = rnd.NextDouble();
        if (s > p && palya[n - 1] == ' ')
        {
            //Console.SetCursorPosition(n - 1, 1);
            palya[n - 1] = (char)jobb[rnd.Next(0, jobb.Length - 1)];
        }
    }

    static void Sims4()
    {
        bool exit = false;
        int timer = 1;
        System.Console.WriteLine();

        while (!exit)
        {
            Gen();
            timer++;
            Console.SetCursorPosition(0, 0);
            System.Console.WriteLine(timer);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);

                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
            }

            for (int i = palya.Length - 1; i >= 0; i--)
            {
                if (palya[i] == '1' || palya[i] == '3' || palya[i] == '5' || palya[i] == '6' || palya[i] == '9')
                {
                    if (i + 1 < n - 1)
                    {
                        if (timer % ((int)(palya[i]) - 48) == 0)
                        {
                            if (palya[i + 1] == ' ')
                            {
                                Console.SetCursorPosition(i, 1);
                                palya[i + 1] = palya[i];
                                palya[i] = ' ';
                            }
                            else
                            {
                                for (int j = 0; j < (int)palya[i]; j++)
                                {
                                    if (i + j < n - 1)
                                    {
                                        if (palya[i + j] == ' ')
                                        {
                                            Console.SetCursorPosition(i, 1);
                                            palya[i + j] = palya[i];
                                            palya[i] = ' ';
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < palya.Length; i++)
            {
                if (palya[i] == '2' || palya[i] == '4' || palya[i] == '7' || palya[i] == '8' || palya[i] == '0')
                {
                    if (i - 1 > 0)
                    {
                        if ( timer % ((int)(palya[i]) - 48) == 0)
                        {
                            if (palya[i - 1] == ' ')
                            {
                                Console.SetCursorPosition(i, 1);
                                palya[i - 1] = palya[i];
                                palya[i] = ' ';
                            }
                            else
                            {
                                for (int j = 0; j < (int)palya[i]; j++)
                                {
                                    if (i - j > 0)
                                    {
                                        if (palya[i - j] == ' ')
                                        {
                                            Console.SetCursorPosition(i, 1);
                                            palya[i - j] = palya[i];
                                            palya[i] = ' ';
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (palya[1] == '2' || palya[1] == '4' || palya[1] == '7' || palya[1] == '8' || palya[1] == '0')
            {
                palya[1] = ' ';
            }
            if (palya[n - 2] == '1' || palya[n - 2] == '3' || palya[n - 2] == '5' || palya[n - 2] == '6' || palya[n - 2] == '9')
            {
                palya[n - 2] = ' ';
            }
            iras();
            Thread.Sleep(100);
        }


    }

    static void Main()
    {
        literal();
        Sims4();
    }

}

