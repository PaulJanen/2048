using System;
using System.Drawing;
using System.Windows.Forms;
using CommandPattern;

namespace _2048
{
    enum Directions
    {
        Left, Right, Top, Bottom, Non
    }

    public partial class Form1 : Form
    {
        private Directions direction;
        LabelUtility labelUtility;
        BoxAnimations boxAnimations;
        public Label[] boxes;
        public int xPos;
        public int yPos;
        public int[][] pos;
        public bool[][] posFeature;
        public bool[][] newBoxAnimation;
        public int movementCount;
        public int galimiejimai;
        private Command upButton;
        private Command downButton;
        private Command leftButton;
        private Command rightButton;


        public Form1()
        {
            InitializeComponent();
        }
            
        public void Form1_Load(object sender, EventArgs e)
        {
            InitializeVariables();

            GameBeginning();
        }

       private void InitializeVariables()
        {
            direction = Directions.Non;
            boxes = new Label[16];
            xPos = 0;
            yPos = 0;
            pos = new int[4][];
            posFeature = new bool[4][];
            newBoxAnimation = new bool[4][];
            movementCount = 0;
            galimiejimai = 1;

            labelUtility = new LabelUtility(this);
            labelUtility.GiveLabelReferences(out boxes,this);
            CreateButtonLayout();
            boxAnimations = new BoxAnimations();
        }

        void CreateButtonLayout()
        {
            upButton = new GoUp();
            downButton = new GoDown();
            leftButton = new GoLeft();
            rightButton = new GoRight();
        }


        public void GameBeginning()
        {
            gameEnd.Visible = false;
            for (int i = 0; i < pos.Length; i++)
            {
                pos[i] = new int[4];
            }
            for (int i = 0; i < posFeature.Length; i++)
            {
                posFeature[i] = new bool[4];
                newBoxAnimation[i] = new bool[4];
            }
            for (int i = 0; i<4;i++)
            {
                for (int k = 0; k<4;k++)
                {
                    newBoxAnimation[i][k] = false;
                }
            }
            
            labelUtility.GiveLabelText(this);
            NewBox();
            NewBox();
        
            
            labelUtility.GiveLabelText(this);

        }

        private void AnimateAndCreateNewBox()
        {
            boxAnimations.AnimateTakenBox(posFeature, boxes);
            labelUtility.GiveLabelText(this);
            NewBox();
            direction = Directions.Non;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(direction!=Directions.Non)
            {
                movementCount++;
                boxAnimations.TurnOffPreviousNewSquare(newBoxAnimation, boxes);
                labelUtility.GiveLabelText(this);
            }
            if (direction == Directions.Bottom)
            {
                downButton.Execute(2, -1, this, labelUtility);
                AnimateAndCreateNewBox();
            }
            if (direction == Directions.Top)
            {
                upButton.Execute(1, 4, this, labelUtility);
                AnimateAndCreateNewBox();
            }
            if (direction == Directions.Right)
            {
                rightButton.Execute(2, -1, this, labelUtility);
                AnimateAndCreateNewBox();
            }
            if (direction == Directions.Left)
            {
                leftButton.Execute(1, 4, this, labelUtility);
                AnimateAndCreateNewBox();
            }           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                direction = Directions.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                direction = Directions.Right;
            }
            if (e.KeyCode == Keys.Down)
            {
                direction = Directions.Bottom;
            }
            if (e.KeyCode == Keys.Up)
            {
                direction = Directions.Top;
            }
        }
        
        private void NewBox()
        {
            int checkIfThereIsFreePosition;
            if (movementCount == 0)
            {
                checkIfThereIsFreePosition = 1;
            }
            else
            {
                checkIfThereIsFreePosition = 0;
            }
            for (int i = 0;i<4 && movementCount !=0;i++)
            {
                for(int k = 0;k<4;k++)
                {
                    if(posFeature[i][k]==false)
                    {
                        checkIfThereIsFreePosition = 1;
                        k = 3;
                        i = 3;
                    }
                }
            }
            Random numberPos = new Random();
            if (checkIfThereIsFreePosition == 1)
            {
                for (int i = 0; i < 1; )
                {
                    i++;
                    xPos = numberPos.Next(0, 4);
                    yPos = numberPos.Next(0, 4);

                    if (posFeature[xPos][yPos] == false)      
                    {
                        pos[xPos][yPos] = 2;
                        posFeature[xPos][yPos] = true;
                        newBoxAnimation[xPos][yPos] = true;
                    }
                    else
                    {
                        i--;
                    }
                }
            }
     
            boxAnimations.NewBox(newBoxAnimation, boxes);
            labelUtility.GiveLabelText(this);
        }  

        private void EndGame()
        {
            gameEnd.Size = new Size(450, 500);
            gameEnd.Image = Image.FromFile("6.png");
            gameEnd.Visible = true;
            gameEnd.Location = new Point(50,50);
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
            EndGame();
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
   
        
    

