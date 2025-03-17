namespace Valami2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BalSzamokKatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (Ballszovegdoboz.Text == "0")
            {
                Ballszovegdoboz.Text = szam.ToString();
            }
            else
            {
                Ballszovegdoboz.Text += szam.ToString();
            }
        }

        private void balDelGomb_Click(object sender, EventArgs e)
        {
            Ballszovegdoboz.Text = Ballszovegdoboz.Text.Substring(0, Ballszovegdoboz.Text.Length - 1);
            if (Ballszovegdoboz.Text == "")
            {
                Ballszovegdoboz.Text = "0";
            }
        }

        private void JobbSzamKatt(object sender, EventArgs e)
        {
            char szam = (sender as Button).Text[0];
            if (Jobbszovegboboz.Text == "0")
            {
                Jobbszovegboboz.Text = szam.ToString();
            }
            else
            {
                Jobbszovegboboz.Text += szam.ToString();
            }
        }

        private void jobbDelGOmb_Click(object sender, EventArgs e)
        {
            Jobbszovegboboz.Text = Jobbszovegboboz.Text.Substring(0, Jobbszovegboboz.Text.Length - 1);
            if (Jobbszovegboboz.Text == "")
            {
                Jobbszovegboboz.Text = "0";
            }
        }

        private void Muvelet_katt(object sender, EventArgs e)
        {
            int bal = int.Parse(Ballszovegdoboz.Text);
            int jobb = int.Parse(Jobbszovegboboz.Text);
            bool hiba = false;
            int ered = 0;
            char muv = (sender as Button).Text[0];
            switch(muv)
            {
                case '+':
                    ered = bal + jobb;
                    break;

                case '-':
                    ered = bal - jobb;
                    break;

                case '*':
                    ered = bal * jobb;
                    break;

                case '/':
                    if (jobb != 0)
                    {
                        ered = bal / jobb;
                    }
                    else 
                    {
                        hiba = true;
                    }
                    break;
            }
            if (!hiba)
            {
                Ballszovegdoboz.Text = ered.ToString();
                Jobbszovegboboz.Text = "0";
            }
            else
            {
                MessageBox.Show("Ne ossz nullával!");
            }
        }
    }
}
