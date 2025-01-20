using System;

class Szovegek
{

    static Random rnd = new Random();
    static char[,] palya = new char[30, 50];
    static void Ki_iras()
    {

        for (int i = 0; i < palya.GetLength(0); i++)
        {
            for (int j = 0; j < palya.GetLength(1); j++)
            {
                System.Console.Write(palya[i, j]);
            }
            System.Console.WriteLine();
        }
    }
    static void Gen()
    {
        for (int i = 0; i < palya.GetLength(0); i++)
        {
            for (int j = 0; j < palya.GetLength(1); j++)
            {
                if (i == 29)
                {
                    palya[i, j] = '*';
                }
                else
                {
                    palya[i, j] = ' ';
                }
            }
        }

        Ki_iras();
    }
    static void Eses()
    {
        double spawn_rate = 0.1;
        double spawn = rnd.NextDouble();
        int eses = rnd.Next(1, 4);
        for (int i = 0; i < palya.GetLength(1); i++)
        {
            if (spawn < spawn_rate)
            {
                palya[0, i] = '*';
            }
            spawn = rnd.NextDouble();
        }
        Ki_iras();

        for (int i = 0; i < palya.GetLength(0); i++)
        {
            for (int j = 0; j < palya.GetLength(1); j++)
            {
                if (eses == 1 && palya[i-1,j-1] == ' ')
                {
                    palya[i,j] = ' ';
                    palya[i-1,j-1] = '*';
                }
                else if ( )
                {
                    
                }
            }
        }

    }
    static void Main()
    {
        Gen();
        Eses();
    }
}
