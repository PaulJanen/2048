using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Drawing;

namespace TestsFor2048
{
    [TestClass]
    public class Test2048
    {
        [TestMethod]
        public void TestNewSquareAnimation()
        {
            //Arrange
            _2048.BoxAnimations fieldAnimations = new _2048.BoxAnimations();
            bool[][] newFieldAnimation = new bool[4][];
            Label[] labels = new Label[16];
            int x = 0;
            int y = 0;
            int expectedLabelIndex = 0;

            for (int i = 0; i < newFieldAnimation.Length; i++)
            {
                newFieldAnimation[i] = new bool[4];
            }
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Image = Image.FromFile(@"1.png");
                labels[i].Image.Tag = "";
            }
            newFieldAnimation[x][y] = true;

            Image expectedObj = Image.FromFile("18.png");
            expectedObj.Tag = "NewField";

            //Act
            fieldAnimations.NewBox(newFieldAnimation, labels);

            //Assert
            Assert.AreEqual(expectedObj.Tag, labels[expectedLabelIndex].Image.Tag);
        }
        [TestMethod]

        public void TestTurnOffPreviousNewSquare()
        {
            //Arrange
            _2048.BoxAnimations fieldAnimations = new _2048.BoxAnimations();
            bool[][] newFieldAnimation = new bool[4][];
            Label[] labels = new Label[16];
            int x = 0;
            int y = 1;
            int expectedLabelIndex = 4 * x + y;

            for (int i = 0; i < newFieldAnimation.Length; i++)
            {
                newFieldAnimation[i] = new bool[4];
            }
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Image = Image.FromFile("18.png");
                labels[i].Image.Tag = "";
            }
            newFieldAnimation[x][y] = true;

            Image expectedObj = Image.FromFile(@"1.png");
            expectedObj.Tag = "PreviousNewField";

            //Act
            fieldAnimations.TurnOffPreviousNewSquare(newFieldAnimation, labels);

            //Assert
            Assert.AreEqual(expectedObj.Tag, labels[expectedLabelIndex].Image.Tag);
        }
    }
}
