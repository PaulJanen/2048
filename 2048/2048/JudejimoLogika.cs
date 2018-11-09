using System;

namespace _2048
{
    class JudejimoLogika
    {

        Form1 form1;
        LabelUtility labelUtility;
        
        public JudejimoLogika(Form1 form1,LabelUtility labelUtility)
        {
            this.form1 = form1;
            this.labelUtility = labelUtility;
        }

        public void JudejimasApacion(int x, int xx)
        {
            form1.label2.Text = Convert.ToString(form1.ejimuSkaicius);
            for (; x != xx; x--)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = x;
                    int vieta = 0;
                    for (; l != 3; l++)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (x == 0 && form1.pozicijosSavybe[l][k] == true && form1.pozicija[x][k] != form1.pozicija[l][k])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }
                        if (form1.pozicijosSavybe[l + 1][k] == true && form1.pozicija[x][k] == form1.pozicija[l + 1][k])
                        {
                            vieta = l + 1;
                            form1.pozicija[vieta][k] += form1.pozicija[x][k];
                            form1.pozicija[x][k] = 0;
                            form1.pozicijosSavybe[x][k] = false;
                            break;
                        }
                        if (x != 0)
                        {
                            if (form1.pozicijosSavybe[l + 1][k] == true && form1.pozicija[x][k] != form1.pozicija[l + 1][k] && form1.pozicijosSavybe[l][k] != false)
                            {
                                vieta = -1;
                                l = 2;

                            }
                        }

                        if (form1.pozicijosSavybe[l + 1][k] == false)
                        {
                            vieta = l + 1;
                        }

                    }
                    if (vieta != -1)
                    {

                        if (form1.pozicijosSavybe[vieta][k] == true && form1.pozicija[x][k] != form1.pozicija[vieta][k])
                        {

                        }
                        if (form1.pozicijosSavybe[vieta][k] == false)
                        {
                            form1.pozicija[vieta][k] = form1.pozicija[x][k];
                            form1.pozicija[x][k] = 0;
                            form1.pozicijosSavybe[x][k] = false;
                        }
                    }
                }

                labelUtility.LabelSurasymas();

            }

        }
        public void JudejimasVirsun(int x, int xx)
        {
            form1.label2.Text = Convert.ToString(form1.ejimuSkaicius);
            for (; x != xx; x++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = x;
                    int vieta = 0;
                    for (; l != 0; l--)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (x == 3 && form1.pozicijosSavybe[l][k] == true && form1.pozicija[x][k] != form1.pozicija[l][k])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }
                        if (form1.pozicijosSavybe[l - 1][k] == true && form1.pozicija[x][k] == form1.pozicija[l - 1][k])
                        {
                            vieta = l - 1;
                            form1.pozicija[vieta][k] += form1.pozicija[x][k];
                            form1.pozicija[x][k] = 0;
                            form1.pozicijosSavybe[x][k] = false;
                            break;
                        }
                        if (x != 3)
                        {
                            if (form1.pozicijosSavybe[l - 1][k] == true && form1.pozicija[x][k] != form1.pozicija[l - 1][k] && form1.pozicijosSavybe[l][k] != false)
                            {
                                vieta = -1;
                                break;

                            }
                        }
                        if (form1.pozicijosSavybe[l - 1][k] == false)
                        {
                            vieta = l - 1;

                        }

                    }
                    if (vieta != -1)
                    {

                        if (form1.pozicijosSavybe[vieta][k] == true && form1.pozicija[x][k] != form1.pozicija[vieta][k])
                        {

                        }
                        if (form1.pozicijosSavybe[vieta][k] == false)
                        {
                            form1.pozicija[vieta][k] = form1.pozicija[x][k];
                            form1.pozicija[x][k] = 0;
                            form1.pozicijosSavybe[x][k] = false;
                        }
                    }
                }

                labelUtility.LabelSurasymas();
            }

        }
        public void JudejimasDesinen(int y, int yy)
        {
            form1.label2.Text = Convert.ToString(form1.ejimuSkaicius);
            for (; y != yy; y--)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = y;
                    int vieta = 0;
                    for (; l != 3; l++)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (y == 0 && form1.pozicijosSavybe[k][l] == true && form1.pozicija[k][y] != form1.pozicija[k][l])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }
                        if (form1.pozicijosSavybe[k][l + 1] == true && form1.pozicija[k][y] == form1.pozicija[k][l + 1])
                        {
                            vieta = l + 1;
                            form1.pozicija[k][vieta] += form1.pozicija[k][y];
                            form1.pozicija[k][y] = 0;
                            form1.pozicijosSavybe[k][y] = false;
                            break;
                        }
                        if (y != 0)
                        {
                            if (form1.pozicijosSavybe[k][l + 1] == true && form1.pozicija[k][y] != form1.pozicija[k][l + 1] && form1.pozicijosSavybe[k][l] != false)
                            {
                                vieta = -1;
                                break;

                            }
                        }
                        if (form1.pozicijosSavybe[k][l + 1] == false)
                        {
                            vieta = l + 1;

                        }

                    }
                    if (vieta != -1)
                    {


                        if (form1.pozicijosSavybe[k][vieta] == false)
                        {
                            form1.pozicija[k][vieta] = form1.pozicija[k][y];
                            form1.pozicija[k][y] = 0;
                            form1.pozicijosSavybe[k][y] = false;
                        }
                    }
                }

                labelUtility.LabelSurasymas();

            }

        }

        public void JudejimasKairen(int y, int yy)
        {
            form1.label2.Text = Convert.ToString(form1.ejimuSkaicius);

            for (; y != yy; y++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = y;
                    int vieta = 0;
                    for (; l != 0; l--)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (y == 3 && form1.pozicijosSavybe[k][l] == true && form1.pozicija[k][y] != form1.pozicija[k][l])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }

                        if (form1.pozicijosSavybe[k][l - 1] == true && form1.pozicija[k][y] == form1.pozicija[k][l - 1])
                        {
                            vieta = l - 1;
                            form1.pozicija[k][vieta] += form1.pozicija[k][y];
                            form1.pozicija[k][y] = 0;
                            form1.pozicijosSavybe[k][y] = false;
                            break;
                        }
                        if (y != 3)
                        {
                            if (form1.pozicijosSavybe[k][l - 1] == true && form1.pozicija[k][y] != form1.pozicija[k][l - 1] && form1.pozicijosSavybe[k][l] != false)
                            {
                                vieta = -1;
                                break;
                            }
                        }
                        if (form1.pozicijosSavybe[k][l - 1] == false)
                        {
                            vieta = l - 1;

                        }

                    }
                    if (vieta != -1)
                    {


                        if (form1.pozicijosSavybe[k][vieta] == false)
                        {
                            form1.pozicija[k][vieta] = form1.pozicija[k][y];
                            form1.pozicija[k][y] = 0;
                            form1.pozicijosSavybe[k][y] = false;
                        }
                    }
                }

                labelUtility.LabelSurasymas();

            }

        }
    
    }
}
