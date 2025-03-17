namespace Lapok
{
    public partial class Form1 : Form
    {
        Button[,] lapok;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lapok = new Button[4, 4] { { button1, button2, button3, button4 }, { button5, button6, button7, button8 }, { button9, button10, button11, button12 }, { button13, button14, button15, button16 } };

        }

        private void Lap_katt(object sender, EventArgs e)
        {
            bool gomb = false;
            int x = 0;
            int y = 0;
            while (!gomb)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (lapok[i, j] == (sender as Button))
                        {
                            gomb = true;
                            x = i;
                            y = j;

                        }
                    }
                }
            }
            if (gomb)
            {
                Szinfordit(x, y);
            }
        }
        private void Szinfordit(int x, int y)
        {
            //felsõ
            if (y - 1 >= 0 && lapok[x, y - 1].BackColor == Color.Green)
            {
                lapok[x, y - 1].BackColor = Color.Yellow;
            }
            else if (y - 1 >= 0 && lapok[x, y - 1].BackColor == Color.Yellow)
            {
                lapok[x, y - 1].BackColor = Color.Green;
            }

            //jobb
            if (x + 1 <= 3 && lapok[x + 1, y].BackColor == Color.Green)
            {
                lapok[x + 1, y].BackColor = Color.Yellow;
            }
            else if (x + 1 <= 3 && lapok[x + 1, y].BackColor == Color.Yellow)
            {
                lapok[x + 1, y].BackColor = Color.Green;
            }

            //alsó
            if (y + 1 <= 3 && lapok[x, y + 1].BackColor == Color.Green)
            {
                lapok[x, y + 1].BackColor = Color.Yellow;
            }
            else if (y + 1 <= 3 && lapok[x, y + 1].BackColor == Color.Yellow)
            {
                lapok[x, y + 1].BackColor = Color.Green;
            }

            //bal
            if (x - 1 >= 0 && lapok[x - 1, y].BackColor == Color.Green)
            {
                lapok[x - 1, y].BackColor = Color.Yellow;
            }
            else if (x - 1 >= 0 && lapok[x - 1, y].BackColor == Color.Yellow)
            {
                lapok[x - 1, y].BackColor = Color.Green;
            }
        }

        private void New_game_katt(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 16; i++)
            {
                int rx = random.Next(0, 4);
                int ry = random.Next(0, 4);
                Szinfordit(rx,ry);
            }
            

        }
    }
}
