using System;
using CommandPattern;

namespace _2048
{
    class GoDown : Command
    {
        public override void Execute(int x, int xx, Form1 form1, LabelUtility labelUtility)
        {
            form1.label2.Text = Convert.ToString(form1.movementCount);
            for (; x != xx; x--)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = x;
                    int place = 0;
                    for (; l != 3; l++)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (x == 0 && form1.posFeature[l][k] == true && form1.pos[x][k] != form1.pos[l][k])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }
                        if (form1.posFeature[l + 1][k] == true && form1.pos[x][k] == form1.pos[l + 1][k])
                        {
                            place = l + 1;
                            form1.pos[place][k] += form1.pos[x][k];
                            form1.pos[x][k] = 0;
                            form1.posFeature[x][k] = false;
                            break;
                        }
                        if (x != 0)
                        {
                            if (form1.posFeature[l + 1][k] == true && form1.pos[x][k] != form1.pos[l + 1][k] && form1.posFeature[l][k] != false)
                            {
                                place = -1;
                                l = 2;

                            }
                        }

                        if (form1.posFeature[l + 1][k] == false)
                        {
                            place = l + 1;
                        }

                    }
                    if (place != -1)
                    {

                        if (form1.posFeature[place][k] == true && form1.pos[x][k] != form1.pos[place][k])
                        {

                        }
                        if (form1.posFeature[place][k] == false)
                        {
                            form1.pos[place][k] = form1.pos[x][k];
                            form1.pos[x][k] = 0;
                            form1.posFeature[x][k] = false;
                        }
                    }
                }

                labelUtility.GiveLabelText(form1);

            }
        }
    }

    class GoUp : Command
    {
        public override void Execute(int x, int xx, Form1 form1, LabelUtility labelUtility)
        {
            form1.label2.Text = Convert.ToString(form1.movementCount);
            for (; x != xx; x++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = x;
                    int place = 0;
                    for (; l != 0; l--)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (x == 3 && form1.posFeature[l][k] == true && form1.pos[x][k] != form1.pos[l][k])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }
                        if (form1.posFeature[l - 1][k] == true && form1.pos[x][k] == form1.pos[l - 1][k])
                        {
                            place = l - 1;
                            form1.pos[place][k] += form1.pos[x][k];
                            form1.pos[x][k] = 0;
                            form1.posFeature[x][k] = false;
                            break;
                        }
                        if (x != 3)
                        {
                            if (form1.posFeature[l - 1][k] == true && form1.pos[x][k] != form1.pos[l - 1][k] && form1.posFeature[l][k] != false)
                            {
                                place = -1;
                                break;

                            }
                        }
                        if (form1.posFeature[l - 1][k] == false)
                        {
                            place = l - 1;

                        }

                    }
                    if (place != -1)
                    {

                        if (form1.posFeature[place][k] == true && form1.pos[x][k] != form1.pos[place][k])
                        {

                        }
                        if (form1.posFeature[place][k] == false)
                        {
                            form1.pos[place][k] = form1.pos[x][k];
                            form1.pos[x][k] = 0;
                            form1.posFeature[x][k] = false;
                        }
                    }
                }

                labelUtility.GiveLabelText(form1);
            }
        }
    }

    class GoLeft : Command
    {
        public override void Execute(int y, int yy, Form1 form1, LabelUtility labelUtility)
        {
            form1.label2.Text = Convert.ToString(form1.movementCount);

            for (; y != yy; y++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = y;
                    int place = 0;
                    for (; l != 0; l--)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (y == 3 && form1.posFeature[k][l] == true && form1.pos[k][y] != form1.pos[k][l])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }

                        if (form1.posFeature[k][l - 1] == true && form1.pos[k][y] == form1.pos[k][l - 1])
                        {
                            place = l - 1;
                            form1.pos[k][place] += form1.pos[k][y];
                            form1.pos[k][y] = 0;
                            form1.posFeature[k][y] = false;
                            break;
                        }
                        if (y != 3)
                        {
                            if (form1.posFeature[k][l - 1] == true && form1.pos[k][y] != form1.pos[k][l - 1] && form1.posFeature[k][l] != false)
                            {
                                place = -1;
                                break;
                            }
                        }
                        if (form1.posFeature[k][l - 1] == false)
                        {
                            place = l - 1;

                        }

                    }
                    if (place != -1)
                    {


                        if (form1.posFeature[k][place] == false)
                        {
                            form1.pos[k][place] = form1.pos[k][y];
                            form1.pos[k][y] = 0;
                            form1.posFeature[k][y] = false;
                        }
                    }
                }

                labelUtility.GiveLabelText(form1);

            }

        }
    }

    class GoRight : Command
    {
        public override void Execute(int y, int yy, Form1 form1, LabelUtility labelUtility)
        {
            form1.label2.Text = Convert.ToString(form1.movementCount);
            for (; y != yy; y--)
            {
                for (int k = 0; k < 4; k++)
                {
                    int l = y;
                    int place = 0;
                    for (; l != 3; l++)    //nustato kuris paskutinis langelis leistinas
                    {
                        if (y == 0 && form1.posFeature[k][l] == true && form1.pos[k][y] != form1.pos[k][l])       //bugo taisymas del 4, 2, 4, 2
                        {
                            break;
                        }
                        if (form1.posFeature[k][l + 1] == true && form1.pos[k][y] == form1.pos[k][l + 1])
                        {
                            place = l + 1;
                            form1.pos[k][place] += form1.pos[k][y];
                            form1.pos[k][y] = 0;
                            form1.posFeature[k][y] = false;
                            break;
                        }
                        if (y != 0)
                        {
                            if (form1.posFeature[k][l + 1] == true && form1.pos[k][y] != form1.pos[k][l + 1] && form1.posFeature[k][l] != false)
                            {
                                place = -1;
                                break;

                            }
                        }
                        if (form1.posFeature[k][l + 1] == false)
                        {
                            place = l + 1;

                        }

                    }
                    if (place != -1)
                    {


                        if (form1.posFeature[k][place] == false)
                        {
                            form1.pos[k][place] = form1.pos[k][y];
                            form1.pos[k][y] = 0;
                            form1.posFeature[k][y] = false;
                        }
                    }
                }

                labelUtility.GiveLabelText(form1);

            }
        }
    }
}
