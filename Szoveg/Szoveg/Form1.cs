namespace Szoveg
{
    public partial class Fo_Ablak : Form
    {
        string teljes_szoveg;
        string[] szoveg_soronkent;
        public Fo_Ablak()
        {
            InitializeComponent();
        }

        private void Fo_Ablak_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Szia", "üzenet", MessageBoxButtons.OK);
        }

        private void Beolvas_gomb_Click(object sender, EventArgs e)
        {
            string file_utvolnal = "..\\..\\..\\"+file_nev_text.Text;
            // string file_ut_2 = @"..\..\..\" + file_nev_text.Text;        Igy is lehet

            //Ez egybe beolvassa, str ként
            //teljes_szoveg = File.ReadAllText(file_utvolnal, encoding:System.Text.Encoding.UTF8);
            //szoveg_megjelen.Text = teljes_szoveg;

            //egybe soronként, array ként
            //szoveg_soronkent =  File.ReadAllLines(file_utvolnal );
            //szoveg_megjelen.Lines = szoveg_soronkent;

            // egyesével, soronként, egy listába, utána teszem arryba
            StreamReader sr = new StreamReader(file_utvolnal);
            string sor = sr.ReadLine();
            List<string> sorok = new List<string>();

            while (sor != null)
            {
                if (sor.Trim() != "") 
                {
                    sorok.Add(sor.Trim());
                }
                
                sor = sr.ReadLine();
            }
            sr.Close();

            szoveg_megjelen.Lines = sorok.ToArray();

            string[] nev = new string[sorok.Count];
            string[] datum = new string[sorok.Count];
            string[] varos = new string[sorok.Count];
            int[] pont = new int[sorok.Count];

            for (int i = 0; i < sorok.Count; i++)
            {
                string[] darabolva = sorok[i].Split(';');
                nev[i] = darabolva[0];
                datum[i] = darabolva[1];
                varos[i] = darabolva[2];
                pont[i] = int.Parse(darabolva[3]);
            }

            int max_pont = pont.Max();
            int kivolt = Array.IndexOf(pont, max_pont);

            string sor1 = "\r\nLegnagyobb pontszám: " + max_pont;
            szoveg_megjelen.AppendText(sor1);
            string sor2 = "\r\nA legtöbb pontot adta " + nev[kivolt] + "aki itt lakik: " + varos[kivolt];
            szoveg_megjelen.AppendText(sor2);
        }
    }
}
