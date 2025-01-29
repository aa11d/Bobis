class Robot
{
    static int n = 50;
    static int m = 30;
    static Random rnd = new Random();
    static char[,] palya = new char[n, m];

    static int aka = 70;
    static int robx = rnd.Next(1, n - 1);
    static int roby = rnd.Next(1, m - 1);
    static void Ki_iras()
    {
        for (int i = 0; i < palya.GetLength(1); i++)
        {

            for (int j = 0; j < palya.GetLength(0); j++)
            {
                if (palya[j, i] != 0)
                {
                    Console.SetCursorPosition(j, i);
                    System.Console.Write(palya[j, i]);
                }
            }
            System.Console.WriteLine();
        }
    }

    static void Gen(int a)
    {

        int akax = rnd.Next(1, n - 1);
        int akay = rnd.Next(1, m - 1);


        for (int i = 0; i < palya.GetLength(0); i++)
        {
            for (int j = 0; j < palya.GetLength(1); j++)
            {
                if (i == 0)
                {
                    palya[i, j] = 'X';
                }
                if (i == palya.GetLength(0) - 1)
                {
                    palya[i, j] = 'X';
                }
                if (j == 0)
                {
                    palya[i, j] = 'X';
                }
                if (j == palya.GetLength(1) - 1)
                {
                    palya[i, j] = 'X';
                }
            }
        }
        for (int i = 0; i < a; i++)
        {
            akax = rnd.Next(1, n - 1);
            akay = rnd.Next(1, m - 1);
            palya[akax, akay] = 'X';
        }

        palya[robx, roby] = '@';
        palya[rnd.Next(1, n - 1), rnd.Next(1, m - 1)] = 'O';

        Ki_iras();

    }

    static void Mozgas()
    {
        bool exit = false;
        while (!exit)
        {
            int i = robx;
            int j = roby;
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
                else if (pressed.Key == ConsoleKey.UpArrow)
                {
                    if (palya[i, j - 1] == 'O')
                    {
                        exit = true;
                    }
                    else
                    {
                        while (palya[i, j - 1] != 'X')
                        {
                            palya[i, j] = ' ';
                            j--;
                            palya[i, j] = '@';
                            robx = i;
                            roby = j;
                        }
                    }

                }
                else if (pressed.Key == ConsoleKey.RightArrow)
                {
                    if (palya[i + 1, j] == 'O')
                    {
                        exit = true;
                    }
                    else
                    {
                        while (palya[i + 1, j] != 'X')
                        {
                            palya[i, j] = ' ';
                            i++;
                            palya[i, j] = '@';
                            robx = i;
                            roby = j;
                        }
                    }

                }
                else if (pressed.Key == ConsoleKey.DownArrow)
                {
                    if (palya[i, j + 1] == 'O')
                    {
                        exit = true;
                    }
                    else
                    {
                        while (palya[i, j + 1] != 'X')
                        {
                            palya[i, j] = ' ';
                            j++;
                            palya[i, j] = '@';
                            robx = i;
                            roby = j;
                        }
                    }
                }
                else if (pressed.Key == ConsoleKey.LeftArrow)
                {
                    if (palya[i - 1, j] == 'O')
                    {
                        exit = true;
                    }
                    else
                    {
                        while (palya[i - 1, j] != 'X')
                        {
                            palya[i, j] = ' ';
                            i--;
                            palya[i, j] = '@';
                            robx = i;
                            roby = j;
                        }
                    }
                }
            }
            Ki_iras();
        }

    }

    static void Main()
    {
        Console.SetWindowSize(n + 1, m + 1);
        Gen(aka);
        Mozgas();
    }
}