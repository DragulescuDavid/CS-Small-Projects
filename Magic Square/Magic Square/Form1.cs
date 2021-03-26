using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Square
{
    public partial class Form1 : Form
    {
        public int[,] magicSquareMatrix = new int[4, 4];
        public int chances = 3;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //loading the magic square
        {
            Functions.GenerateSquare(Square,magicSquareMatrix);
            Functions.GridEdit(Square);
            LivesLabel.Text = chances.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e) // checking player answer
        {
            magicSquareMatrix = Functions.GetResult(Square, magicSquareMatrix);
            Functions.MagicSquareCheck(magicSquareMatrix);
            chances--;
            LivesLabel.Text = chances.ToString();
            
            if (chances == 0)
            {
                MessageBox.Show("You lost!");
                Application.Exit();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e) // solution show
        {
            Functions.ShowAnswer(Square);
        }
    }
}
