namespace Valami2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool elsoszam;
        int bal, jobb;
        char muvelet;

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

        private void Muvelet_katt(object sender, EventArgs e)
        {
            bool hiba = false;
            int ered = 0;
            char muv = (sender as Button).Text[0];

            if (elsoszam)
            {
                switch (muv)
                {
                    case '=':
                        listBox1.Items.Add(Ballszovegdoboz.Text + "=" + Ballszovegdoboz);
                        Ballszovegdoboz.Text = "0";
                        muvelet = '=';
                        elsoszam = true;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        bal = int.Parse(Ballszovegdoboz.Text);
                        muvelet = muv;
                        listBox1.Items.Add(Ballszovegdoboz.Text + " " + muvelet.ToString() + " ");
                        elsoszam = false;
                        Ballszovegdoboz.Text = "0";
                        break;
                }
            }
            else
            {
                if (muv == '=')
                {
                    jobb = int.Parse(Ballszovegdoboz.Text);
                    switch (muvelet)
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
                        listBox1.Items[listBox1.Items.Count - 1] += " " + Ballszovegdoboz.Text + " = " + ered.ToString();
                        if (muv == '=')
                        {
                            muvelet = '=';
                            elsoszam = true;
                            Ballszovegdoboz.Text = "0";
                        }
                        else
                        {
                            muvelet = muv;
                            bal = ered;
                            Ballszovegdoboz.Text = "0";
                            elsoszam = false;
                            listBox1.Items.Add(bal.ToString() + " " + muvelet.ToString());
                        }
                    }
                    else 
                    {
                        listBox1.Items[listBox1.Items.Count - 1] += " " + Ballszovegdoboz.Text + " = " + "HIBA!";
                        Ballszovegdoboz.Text = "0";
                        elsoszam = true;
                    }


                    if (muv == )
                    {
                        
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
        






            /*switch (muv)
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
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            elsoszam = true;
            bal = 0;
            jobb = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
