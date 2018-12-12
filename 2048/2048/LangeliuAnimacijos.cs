using System.Drawing;
using System.Windows.Forms;
namespace _2048
{
    public class BoxAnimations
    {
        public void NewBox(bool[][] whichBoxToAnimate, Label[] boxes)
        {
            for (int i = 0; i < whichBoxToAnimate.Length; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    boxes[i * 4 + k].Image.Tag = "";
                    if (whichBoxToAnimate[i][k] == true)
                    {
                        boxes[i * 4 + k].Image = Image.FromFile("18.png");
                        boxes[i * 4 + k].Image.Tag = "NewField";
                    }
                }
            }
        }

        public void TurnOffPreviousNewSquare(bool[][] whichBoxToAnimate, Label[] boxes)
        {
            for (int i = 0; i < whichBoxToAnimate.Length; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (whichBoxToAnimate[i][k] == true)
                    {
                        whichBoxToAnimate[i][k] = false;
                        boxes[i * 4 + k].Image = Image.FromFile(@"1.png");
                        boxes[i * 4 + k].Image.Tag = "PreviousNewField";
                    }
                }
            }
        }
        public void AnimateTakenBox(bool[][] whichBoxToAnimate, Label[] boxes)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (whichBoxToAnimate[i][k] == true)
                    {
                        boxes[i * 4 + k].Image = Image.FromFile("8.png");
                    }
                    if (whichBoxToAnimate[i][k] == false)
                    {
                        boxes[i * 4 + k].Image = Image.FromFile("1.png");
                    }

                }
            }
        }


    }
}
