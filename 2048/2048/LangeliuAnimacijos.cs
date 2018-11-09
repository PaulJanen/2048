using System.Drawing;

namespace _2048
{
    class LangeliuAnimacijos
    {
        Form1 form1;

        public LangeliuAnimacijos(Form1 form1)
        {
            this.form1 = form1;
        }


        public void NaujoLangelioAnimacija()
        {

            for (int i = 0; i < form1.naujoLangelioAnimacija.Length; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (form1.naujoLangelioAnimacija[i][k] == true)
                    {
                        form1.leibeliai[i * 4 + k].Image = Image.FromFile("18.png");
                    }
                }
            }
        }

        public void LangelisUzgesta()
        {
            for (int i = 0; i < form1.naujoLangelioAnimacija.Length; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (form1.naujoLangelioAnimacija[i][k] == true)
                    {
                        form1.naujoLangelioAnimacija[i][k] = false;
                        form1.leibeliai[i * 4 + k].Image = Image.FromFile(@"1.png");
                    }
                }
            }
        }
        public void UzimtasLangelis()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (form1.pozicijosSavybe[i][k] == true)
                    {
                        form1.leibeliai[i * 4 + k].Image = Image.FromFile("8.png");
                    }
                    if (form1.pozicijosSavybe[i][k] == false)
                    {
                        form1.leibeliai[i * 4 + k].Image = Image.FromFile("1.png");
                    }

                }
            }
        }


    }
}
