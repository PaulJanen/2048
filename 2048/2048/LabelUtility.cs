using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048
{
    public class LabelUtility
    {
        int xMovement = 120;
        int yMovement = 100;
        int xSize = 80;
        int ySize = 60;
        int xLength;
        int yLength;

        public LabelUtility(Form1 form1)
        {
            xLength = xSize + 10;
            yLength = ySize + 10;
            LabelIniniating(form1);
        }

        public void LabelIniniating(Form1 form)
        {
            
            // pirmoji eile leibeliu(surasymas matricos principu)
            form.label1.Location = new Point(xMovement, yMovement);
            form.label1.Size = new Size(xSize, ySize);
            form.label1.Font = new Font("Arial", 18);
            form.label1.Text = null;
            form.label12.Size = new Size(xSize, ySize);
            form.label12.Location = new Point(xMovement + xLength, yMovement);
            form.label12.Font = new Font("Arial", 18);
            form.label12.Text = null;
            form.label13.Size = new Size(xSize, ySize);
            form.label13.Location = new Point(xMovement + xLength * 2, yMovement);
            form.label13.Font = new Font("Arial", 18);
            form.label13.Text = null;
            form.label14.Size = new Size(xSize, ySize);
            form.label14.Location = new Point(xMovement + xLength * 3, yMovement);
            form.label14.Font = new Font("Arial", 18);
            form.label14.Text = null;
            // antroji eile leibeliu
            form.label21.Size = new Size(xSize, ySize);
            form.label21.Location = new Point(xMovement, yMovement + yLength);
            form.label21.Font = new Font("Arial", 18);
            form.label21.Text = ("  ");
            form.label22.Size = new Size(xSize, ySize);
            form.label22.Location = new Point(xMovement + xLength, yMovement + yLength);
            form.label22.Font = new Font("Arial", 18);
            form.label22.Text = ("  ");
            form.label23.Size = new Size(xSize, ySize);
            form.label23.Location = new Point(xMovement + xLength * 2, yMovement + yLength);
            form.label23.Font = new Font("Arial", 18);
            form.label23.Text = ("  ");
            form.label24.Size = new Size(xSize, ySize);
            form.label24.Location = new Point(xMovement + xLength * 3, yMovement + yLength);
            form.label24.Font = new Font("Arial", 18);
            form.label24.Text = ("  ");
            // trecioji eile leibeliu
            form.label31.Size = new Size(xSize, ySize);
            form.label31.Location = new Point(xMovement, yMovement + yLength * 2);
            form.label31.Font = new Font("Arial", 18);
            form.label31.Text = ("  ");
            form.label32.Size = new Size(xSize, ySize);
            form.label32.Location = new Point(xMovement + xLength, yMovement + yLength * 2);
            form.label32.Font = new Font("Arial", 18);
            form.label32.Text = ("  ");
            form.label33.Size = new Size(xSize, ySize);
            form.label33.Location = new Point(xMovement + xLength * 2, yMovement + yLength * 2);
            form.label33.Font = new Font("Arial", 18);
            form.label33.Text = ("  ");
            form.label34.Size = new Size(xSize, ySize);
            form.label34.Location = new Point(xMovement + xLength * 3, yMovement + yLength * 2);
            form.label34.Font = new Font("Arial", 18);
            form.label34.Text = ("  ");
            // ketvirtoji eile leibeliu
            form.label41.Size = new Size(xSize, ySize);
            form.label41.Location = new Point(xMovement, yMovement + yLength * 3);
            form.label41.Font = new Font("Arial", 18);
            form.label41.Text = ("  ");
            form.label42.Size = new Size(xSize, ySize);
            form.label42.Location = new Point(xMovement + xLength, yMovement + yLength * 3);
            form.label42.Font = new Font("Arial", 18);
            form.label42.Text = ("  ");
            form.label43.Size = new Size(xSize, ySize);
            form.label43.Location = new Point(xMovement + xLength * 2, yMovement + yLength * 3);
            form.label43.Font = new Font("Arial", 18);
            form.label43.Text = ("  ");
            form.label44.Size = new Size(xSize, ySize);
            form.label44.Location = new Point(xMovement + xLength * 3, yMovement + yLength * 3);
            form.label44.Font = new Font("Arial", 18);
            form.label44.Text = ("  ");
        }

        public void GiveLabelReferences(out Label[] leibels, Form1 form)
        {
            leibels = new Label[16];

            leibels[0] = form.label1;
            leibels[1] = form.label12;
            leibels[2] = form.label13;
            leibels[3] = form.label14;
            leibels[4] = form.label21;
            leibels[5] = form.label22;
            leibels[6] = form.label23;
            leibels[7] = form.label24;
            leibels[8] = form.label31;
            leibels[9] = form.label32;
            leibels[10] = form.label33;
            leibels[11] = form.label34;
            leibels[12] = form.label41;
            leibels[13] = form.label42;
            leibels[14] = form.label43;
            leibels[15] = form.label44;

            for (int i = 0; i < leibels.Length; i++)
            {
                leibels[i].Image = Image.FromFile("1.png");
            }
        }

        public void GiveLabelText(Form1 form)
        {
            form.label1.Text  = Convert.ToString(form.pos[0][0]);
            form.label12.Text = Convert.ToString(form.pos[0][1]);
            form.label13.Text = Convert.ToString(form.pos[0][2]);
            form.label14.Text = Convert.ToString(form.pos[0][3]);
                                                 
            form.label21.Text = Convert.ToString(form.pos[1][0]);
            form.label22.Text = Convert.ToString(form.pos[1][1]);
            form.label23.Text = Convert.ToString(form.pos[1][2]);
            form.label24.Text = Convert.ToString(form.pos[1][3]);
                                                  
            form.label31.Text = Convert.ToString(form.pos[2][0]);
            form.label32.Text = Convert.ToString(form.pos[2][1]);
            form.label33.Text = Convert.ToString(form.pos[2][2]);
            form.label34.Text = Convert.ToString(form.pos[2][3]);
                                                  
            form.label41.Text = Convert.ToString(form.pos[3][0]);
            form.label42.Text = Convert.ToString(form.pos[3][1]);
            form.label43.Text = Convert.ToString(form.pos[3][2]);
            form.label44.Text = Convert.ToString(form.pos[3][3]);

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (form.pos[i][k] == 0)
                    {
                        form.posFeature[i][k] = false;
                    }
                    else
                    {
                        form.posFeature[i][k] = true;
                    }
                }
            }
        }

    }

    

}
