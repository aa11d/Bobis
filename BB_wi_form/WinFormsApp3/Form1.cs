namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        static int number = 0;
        static Random random = new Random();
        PictureBox[,] kepek = new PictureBox[6, 8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Gomba_click(object sender, EventArgs e)
        {
            number++;
            gomba.Text = number.ToString();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gomba.Location = new Point(random.Next(0, Width - 10), random.Next(0, Height - 5));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < kepek.GetLength(0); x++)
            {
                for (int y = 0; y < kepek.GetLength(1); y++)
                {
                    kepek[x,y] = new PictureBox();
                    kepek[x,y].Location = new Point(50+100*x,50+100*y);
                    kepek[x,y].Size = new Size(100,100);
                    kepek[x, y].Image = Image.FromFile(@"D:\BB_wi_form\WinFormsApp3\enber.png");
                    kepek[x,y].Name = "kep" + x.ToString() +"," + y.ToString();
                    Controls.Add(kepek[x,y]);
                }
            }
        }
    }
}
