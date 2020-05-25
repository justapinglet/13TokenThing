using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13TokenThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        PictureBox redToken = new PictureBox();
        PictureBox blueToken = new PictureBox();
        Bitmap blueTokenImage = Properties.Resources.blueCircle;

     /*   private int coordinates(int min, int max)
        {
            min = 0;
            max = 400;
            int[] coords = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < coords.Length; i++)
            {
                coords[i] = randNum.Next(min, max);
                redToken.Top = i;
                redToken.Left = i;
            }
            return redToken.Top;
        } */



        private void Form1_Load(object sender, EventArgs e)
        {

      
            redToken.Image = Image.FromFile("C:/Users/17022/OneDrive - Bayfield High School/2020/Computer Science/Programming/Programs/13TokenGame/redCircle.png");
            blueToken.Image = blueTokenImage;
            //Set the starting points of both tokens
            blueToken.Top = 100;
            blueToken.Left = 100;

           // token[] redTokens = new token[10];

            //Random top = new Random[0, 400];

            int min = 0;
            int max = 400;
            int[] coords = new int[10];

           // redToken.Top = min;
           // redToken.Left = max;

            Random randNum = new Random();
            for (int i = 0; i < coords.Length; i++)
            {
                //redToken.Image
                redToken.Top = randNum.Next(0, 400);
                redToken.Left = randNum.Next(0, 900);
             

               // num = r.Next(0, 1000);
                //intArray[i] = num;
            }
            
            redToken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            blueToken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            Controls.Add(redToken);
            Controls.Add(blueToken);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Variables to determine direction
            int right = 1;
            int left = -1;
            int up = -1;
            int down = 1;
            //Distance variables
            int redDist = 10;

            int blueDist = 15;
            //redToken control keys. W:Up; S:Down; A:Left; D:Right
            if (e.KeyCode == Keys.W)
            {
                moveUpDown(up, redDist, redToken);
            }
            if (e.KeyCode == Keys.S)
            {
                moveUpDown(down, redDist, redToken);
            }
            if (e.KeyCode == Keys.A)
            {
                moveRightLeft(left, redDist, redToken);
            }
            if (e.KeyCode == Keys.D)
            {
                moveRightLeft(right, redDist, redToken);
            }
            //blueToken control keys. I:Up; K:Down; J:Left; L:Right
            if (e.KeyCode == Keys.Up)
            {
                moveUpDown(up, blueDist, blueToken);
            }
            if (e.KeyCode == Keys.Down)
            {
                moveUpDown(down, blueDist, blueToken);
            }
            if (e.KeyCode == Keys.Left)
            {
                moveRightLeft(left, blueDist, blueToken);
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRightLeft(right, blueDist, blueToken);
            }
        }
        //move up and down method. Direction will either be 1 for down or -1 for up
        public void moveUpDown(int direction, int distance, PictureBox token)
        {
            token.Top = token.Top + (direction * distance);
        }
        //move right or left method. Direction will either be 1 for right or -1 for Left
        public void moveRightLeft(int direction, int distance, PictureBox token)
        {
            token.Left = token.Left + (direction * distance);
        }
    }
}
       
