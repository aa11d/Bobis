namespace Labi
{
    public partial class Form1 : Form
    {
        List<PictureBox> labdak = new List<PictureBox>();
        List<int> labdavx = new List<int>();
        List<int> labdavy = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            if (random.NextDouble() < 1)
            {
                PictureBox labda = new PictureBox();
                int vx = random.Next(-5, 6);
                int vy = random.Next(2, 6);
                labda.Location = new Point(ClientRectangle.Width / 2, 0);
                labda.Size = new Size(25, 25);
                labda.Image = Image.FromFile("..\\..\\..\\png-clipart-sphere-three-dimensional-space-drawing-grey-3d-computer-graphics-sports-thumbnail.png");
                labda.SizeMode = PictureBoxSizeMode.StretchImage;
                labdak.Add(labda);
                labdavx.Add(vx);
                labdavy.Add(vy);
                Controls.Add(labda);
            }
            for (int i = 0; i < labdak.Count; i++)
            {
                int newleft = labdak[i].Left + labdavx[i];
                int newtop = labdak[i].Top + labdavy[i];
                if (newleft < 0)
                {
                    labdavx[i] *= -1;
                }
                else if (newtop < 0)
                {
                    labdavy[i] *= -1;
                }
                else if (newleft + labdak[i].Width > ClientRectangle.Width)
                {
                    labdavx[i] *= -1;
                }
                else
                {
                    labdak[i].Top = newtop;
                    labdak[i].Left = newleft;
                }
            }

            int j = 0;
            while (j < labdak.Count)
            {
                if (labdak[j].Top > ClientRectangle.Height)
                {
                    Controls.Remove(labdak[j]);
                    labdak.RemoveAt(j);
                    labdavx.RemoveAt(j);
                    labdavy.RemoveAt(j);
                    
                }
                else
                {
                    j++;
                }
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (uto.Left > 10)
                {
                    uto.Left -= 10;
                }
               
            } 
            else if (e.KeyCode == Keys.Right)
            {
                if(uto.Left +uto.Width+10 < ClientRectangle.Width)
                {
                    uto.Left += 10;
                }
            }
        }
    }
}
