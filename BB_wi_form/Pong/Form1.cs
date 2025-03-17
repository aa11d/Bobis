namespace Pong
{
    public partial class Form1 : Form
    {
        int vx, vy;
        int pontj = 0;
        int pontb = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            vx = random.Next(5, 11);
            if (random.NextDouble() < 0.5)
            {
                vx *= -1;
            }
            vy = random.Next(-5, 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int balfel = pictureBox1.Top + vy;
            int balbal = pictureBox1.Left + vx;
            int jobblen = balfel + pictureBox1.Height;
            int jobbjobb = balbal + pictureBox1.Width;

            if (balbal < 0 || jobbjobb > ClientRectangle.Width)
            {
                vx *= -1;
            }
            else
            {
                pictureBox1.Left = balbal;
            }
            if (balfel < 0 || jobblen > ClientRectangle.Height)
            {
                vy *= -1;
            }
            else
            {
                pictureBox1.Top = balfel;
            }
            if (pictureBox1.Left + pictureBox1.Width >= pictureBox3.Left && pictureBox1.Top >= pictureBox3.Top && pictureBox1.Top + pictureBox1.Height <= pictureBox3.Top + pictureBox3.Height)
            {
                vx *= -1;
            }
        }
        private void Form1_PreviewKeyDone(object sender, KeyEventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (pictureBox3.Top > 10)
                {
                    pictureBox3.Top -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (pictureBox3.Top + pictureBox3.Height + 10 < ClientRectangle.Height)
                {
                    pictureBox3.Top += 10;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
