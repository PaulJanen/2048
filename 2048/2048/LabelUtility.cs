using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    class LabelUtility
    {
        Form1 form1;
        int xJudinimas = 120;
        int yJudinimas = 100;
        int xDydis = 80;
        int yDydis = 60;
        int xAtstumas;
        int yAtstumas;

        public LabelUtility(Form1 form1)
        {
            xAtstumas = xDydis + 10;
            yAtstumas = yDydis + 10;
            this.form1 = form1;
            LabelInicijavimas();
        }

        public void LabelInicijavimas()
        {
            
            // pirmoji eile leibeliu(surasymas matricos principu)
            form1.label1.Location = new Point(xJudinimas, yJudinimas);
            form1.label1.Size = new Size(xDydis, yDydis);
            form1.label1.Font = new Font("Arial", 18);
            form1.label1.Text = null;
            form1.label12.Size = new Size(xDydis, yDydis);
            form1.label12.Location = new Point(xJudinimas + xAtstumas, yJudinimas);
            form1.label12.Font = new Font("Arial", 18);
            form1.label12.Text = null;
            form1.label13.Size = new Size(xDydis, yDydis);
            form1.label13.Location = new Point(xJudinimas + xAtstumas * 2, yJudinimas);
            form1.label13.Font = new Font("Arial", 18);
            form1.label13.Text = null;
            form1.label14.Size = new Size(xDydis, yDydis);
            form1.label14.Location = new Point(xJudinimas + xAtstumas * 3, yJudinimas);
            form1.label14.Font = new Font("Arial", 18);
            form1.label14.Text = null;
            // antroji eile leibeliu
            form1.label21.Size = new Size(xDydis, yDydis);
            form1.label21.Location = new Point(xJudinimas, yJudinimas + yAtstumas);
            form1.label21.Font = new Font("Arial", 18);
            form1.label21.Text = ("  ");
            form1.label22.Size = new Size(xDydis, yDydis);
            form1.label22.Location = new Point(xJudinimas + xAtstumas, yJudinimas + yAtstumas);
            form1.label22.Font = new Font("Arial", 18);
            form1.label22.Text = ("  ");
            form1.label23.Size = new Size(xDydis, yDydis);
            form1.label23.Location = new Point(xJudinimas + xAtstumas * 2, yJudinimas + yAtstumas);
            form1.label23.Font = new Font("Arial", 18);
            form1.label23.Text = ("  ");
            form1.label24.Size = new Size(xDydis, yDydis);
            form1.label24.Location = new Point(xJudinimas + xAtstumas * 3, yJudinimas + yAtstumas);
            form1.label24.Font = new Font("Arial", 18);
            form1.label24.Text = ("  ");
            // trecioji eile leibeliu
            form1.label31.Size = new Size(xDydis, yDydis);
            form1.label31.Location = new Point(xJudinimas, yJudinimas + yAtstumas * 2);
            form1.label31.Font = new Font("Arial", 18);
            form1.label31.Text = ("  ");
            form1.label32.Size = new Size(xDydis, yDydis);
            form1.label32.Location = new Point(xJudinimas + xAtstumas, yJudinimas + yAtstumas * 2);
            form1.label32.Font = new Font("Arial", 18);
            form1.label32.Text = ("  ");
            form1.label33.Size = new Size(xDydis, yDydis);
            form1.label33.Location = new Point(xJudinimas + xAtstumas * 2, yJudinimas + yAtstumas * 2);
            form1.label33.Font = new Font("Arial", 18);
            form1.label33.Text = ("  ");
            form1.label34.Size = new Size(xDydis, yDydis);
            form1.label34.Location = new Point(xJudinimas + xAtstumas * 3, yJudinimas + yAtstumas * 2);
            form1.label34.Font = new Font("Arial", 18);
            form1.label34.Text = ("  ");
            // ketvirtoji eile leibeliu
            form1.label41.Size = new Size(xDydis, yDydis);
            form1.label41.Location = new Point(xJudinimas, yJudinimas + yAtstumas * 3);
            form1.label41.Font = new Font("Arial", 18);
            form1.label41.Text = ("  ");
            form1.label42.Size = new Size(xDydis, yDydis);
            form1.label42.Location = new Point(xJudinimas + xAtstumas, yJudinimas + yAtstumas * 3);
            form1.label42.Font = new Font("Arial", 18);
            form1.label42.Text = ("  ");
            form1.label43.Size = new Size(xDydis, yDydis);
            form1.label43.Location = new Point(xJudinimas + xAtstumas * 2, yJudinimas + yAtstumas * 3);
            form1.label43.Font = new Font("Arial", 18);
            form1.label43.Text = ("  ");
            form1.label44.Size = new Size(xDydis, yDydis);
            form1.label44.Location = new Point(xJudinimas + xAtstumas * 3, yJudinimas + yAtstumas * 3);
            form1.label44.Font = new Font("Arial", 18);
            form1.label44.Text = ("  ");


        }

        public void DuotiLeibeliuRef(out Label[] leibeliai)
        {
            leibeliai = new Label[16];

            leibeliai[0] = form1.label1;
            leibeliai[1] = form1.label12;
            leibeliai[2] = form1.label13;
            leibeliai[3] = form1.label14;
            leibeliai[4] = form1.label21;
            leibeliai[5] = form1.label22;
            leibeliai[6] = form1.label23;
            leibeliai[7] = form1.label24;
            leibeliai[8] = form1.label31;
            leibeliai[9] = form1.label32;
            leibeliai[10] = form1.label33;
            leibeliai[11] = form1.label34;
            leibeliai[12] = form1.label41;
            leibeliai[13] = form1.label42;
            leibeliai[14] = form1.label43;
            leibeliai[15] = form1.label44;

            for (int i = 0; i < leibeliai.Length; i++)
            {
                leibeliai[i].Image = Image.FromFile("1.png");
            }
        }

        public void LabelSurasymas()
        {
            form1.label1.Text  = Convert.ToString(form1.pozicija[0][0]);
            form1.label12.Text = Convert.ToString(form1.pozicija[0][1]);
            form1.label13.Text = Convert.ToString(form1.pozicija[0][2]);
            form1.label14.Text = Convert.ToString(form1.pozicija[0][3]);
                                                 
            form1.label21.Text = Convert.ToString(form1.pozicija[1][0]);
            form1.label22.Text = Convert.ToString(form1.pozicija[1][1]);
            form1.label23.Text = Convert.ToString(form1.pozicija[1][2]);
            form1.label24.Text = Convert.ToString(form1.pozicija[1][3]);
                                                  
            form1.label31.Text = Convert.ToString(form1.pozicija[2][0]);
            form1.label32.Text = Convert.ToString(form1.pozicija[2][1]);
            form1.label33.Text = Convert.ToString(form1.pozicija[2][2]);
            form1.label34.Text = Convert.ToString(form1.pozicija[2][3]);
                                                  
            form1.label41.Text = Convert.ToString(form1.pozicija[3][0]);
            form1.label42.Text = Convert.ToString(form1.pozicija[3][1]);
            form1.label43.Text = Convert.ToString(form1.pozicija[3][2]);
            form1.label44.Text = Convert.ToString(form1.pozicija[3][3]);

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (form1.pozicija[i][k] == 0)
                    {
                        form1.pozicijosSavybe[i][k] = false;
                    }
                    else
                    {
                        form1.pozicijosSavybe[i][k] = true;
                    }
                }
            }
        }

    }

    

}
