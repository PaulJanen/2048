using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    enum Kursas
    {
        Kaire, Desine, Virsus, Apacia, Nera
    }

    public partial class Form1 : Form
    {
        private Kursas kryptis;
        LabelUtility labelUtility;
        JudejimoLogika judejimoLogika;
        LangeliuAnimacijos langeliuAnimacijos;
        public Label[] leibeliai;
        public int xPozic;
        public int yPozic;
        public int[][] pozicija;
        public bool[][] pozicijosSavybe;
        public bool[][] naujoLangelioAnimacija;
        public int ejimuSkaicius;
        public int galimiejimai;

        public Form1()
        {
            InitializeComponent();
        }
            
        public void Form1_Load(object sender, EventArgs e)
        {
            KintamuInicializavimas();

            Zaidimopradzia();
        }

       private void KintamuInicializavimas()
        {
            kryptis = Kursas.Nera;
            leibeliai = new Label[16];
            xPozic = 0;
            yPozic = 0;
            pozicija = new int[4][];
            pozicijosSavybe = new bool[4][];
            naujoLangelioAnimacija = new bool[4][];
            ejimuSkaicius = 0;
            galimiejimai = 1;

            labelUtility = new LabelUtility(this);
            labelUtility.DuotiLeibeliuRef(out leibeliai);
            judejimoLogika = new JudejimoLogika(this, labelUtility);
            langeliuAnimacijos = new LangeliuAnimacijos(this);
        }

        public void Zaidimopradzia()
        {
            Pabaiga.Visible = false;
            for (int i = 0; i < pozicija.Length; i++)
            {
                pozicija[i] = new int[4];
            }
            for (int i = 0; i < pozicijosSavybe.Length; i++)
            {
                pozicijosSavybe[i] = new bool[4];
                naujoLangelioAnimacija[i] = new bool[4];
            }
            for (int i = 0; i<4;i++)
            {
                for (int k = 0; k<4;k++)
                {
                    naujoLangelioAnimacija[i][k] = false;
                }
            }
            
            labelUtility.LabelSurasymas();
            Naujaslangelis();
            Naujaslangelis();
        
            
            labelUtility.LabelSurasymas();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                if (kryptis == Kursas.Apacia)
                {
                    ejimuSkaicius++;
                    langeliuAnimacijos.LangelisUzgesta();
                    int x = 2;
                    int xx = -1;
                    labelUtility.LabelSurasymas();
                    judejimoLogika.JudejimasApacion(x, xx);
                    langeliuAnimacijos.UzimtasLangelis();
                    labelUtility.LabelSurasymas();
                    Naujaslangelis();
                    kryptis = Kursas.Nera;
                }
                if (kryptis == Kursas.Virsus)
                {
                    ejimuSkaicius++;
                    int x = 1;
                    int xx = 4;
                    labelUtility.LabelSurasymas();
                    judejimoLogika.JudejimasVirsun(x, xx);
                    langeliuAnimacijos.UzimtasLangelis();
                    labelUtility.LabelSurasymas();
                    Naujaslangelis();
                    kryptis = Kursas.Nera;
                }
                if (kryptis == Kursas.Desine)
                {
                    ejimuSkaicius++;
                    langeliuAnimacijos.LangelisUzgesta();
                    int y = 2;
                    int yy = -1;
                    labelUtility.LabelSurasymas();
                    judejimoLogika.JudejimasDesinen(y, yy);
                    langeliuAnimacijos.UzimtasLangelis();
                    labelUtility.LabelSurasymas();
                    Naujaslangelis();
                    kryptis = Kursas.Nera;
                }
                if (kryptis == Kursas.Kaire)
                {
                    ejimuSkaicius++;
                    langeliuAnimacijos.LangelisUzgesta();
                    int y = 1;
                    int yy = 4;
                    labelUtility.LabelSurasymas();
                    judejimoLogika.JudejimasKairen(y, yy);
                    langeliuAnimacijos.UzimtasLangelis();
                    labelUtility.LabelSurasymas();
                    Naujaslangelis();
                    kryptis = Kursas.Nera;
                }           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                kryptis = Kursas.Kaire;
            }
            if (e.KeyCode == Keys.Right)
            {
                kryptis = Kursas.Desine;
            }
            if (e.KeyCode == Keys.Down)
            {
                kryptis = Kursas.Apacia;
            }
            if (e.KeyCode == Keys.Up)
            {
                kryptis = Kursas.Virsus;
            }
        }
        
        private void Naujaslangelis()
        {
            int tikrinimas;
            if (ejimuSkaicius == 0)
            {
                tikrinimas = 1;
            }
            else
            {
                tikrinimas = 0;
            }
            for (int i = 0;i<4 && ejimuSkaicius !=0;i++)
            {
                for(int k = 0;k<4;k++)
                {
                    if(pozicijosSavybe[i][k]==false)
                    {
                        tikrinimas = 1;
                        k = 3;
                        i = 3;
                    }
                }
            }
            Random skaiciausPozicija = new Random();
            if (tikrinimas == 1)
            {
                for (int i = 0; i < 1; )
                {
                    i++;
                    xPozic = skaiciausPozicija.Next(0, 4);
                    yPozic = skaiciausPozicija.Next(0, 4);

                    if (pozicijosSavybe[xPozic][yPozic] == false)       //Pratestuota, veikia
                    {
                        pozicija[xPozic][yPozic] = 2;
                        pozicijosSavybe[xPozic][yPozic] = true;
                        naujoLangelioAnimacija[xPozic][yPozic] = true;
                    }
                    else
                    {
                        i--;
                    }

                }
            }
     
            langeliuAnimacijos.NaujoLangelioAnimacija();
            labelUtility.LabelSurasymas();
        }  

        private void Zaidimopabaiga()
        {
            Pabaiga.Size = new Size(450, 500);
            Pabaiga.Image = Image.FromFile("6.png");
            Pabaiga.Visible = true;
            Pabaiga.Location = new Point(50,50);
            Label PabaigosTekstas = new Label();

            PabaigosTekstas1.AutoSize = true;
            PabaigosTekstas1.Font = new Font("Arial", 32);
            PabaigosTekstas1.Location = new Point(60,100);
            PabaigosTekstas1.Text = "Zaisti isnaujo";
            PabaigosTekstas1.Visible = true;

            PabaigosTekstas2.AutoSize = true;
            PabaigosTekstas2.Font = new Font("Arial", 32);
            PabaigosTekstas2.Location = new Point(60, 200);
            PabaigosTekstas2.Text = "Iseiti";
            PabaigosTekstas2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Zaidimopabaiga();
        }

        private void PabaigosTekstas2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PabaigosTekstas1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        }

    }
   
        
    

