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
    public class Functions
    {
        public static void GenerateSquare(DataGridView Grid,int [,]squareMatrix) //creating square
        {
            Grid.Columns.Add("C1", "C1");
            Grid.Columns.Add("C2", "C2");
            Grid.Columns.Add("C3", "C3");
            Grid.Columns.Add("C4", "C4");

            squareMatrix[0, 1] = 2;
            squareMatrix[0, 2] = 3;
            squareMatrix[1, 3] = 8;
            squareMatrix[2, 0] = 9;
            squareMatrix[2, 2] = 6;
            squareMatrix[2, 3] = 12;



            for (int index = 0; index < 4; index++)
            {
                Grid.Rows.Add( squareMatrix[index, 0], squareMatrix[index, 1], squareMatrix[index, 2], squareMatrix[index, 3] );
            }

           

        }

        public static int[,] GetResult(DataGridView Grid, int [,] matrix) //extracting player result
        { 

            for (int index = 0; index < 4; index++)
                for (int ndindex = 0; ndindex < 4; ndindex++)
                {
                    string cell = Grid.Rows[index].Cells[ndindex].Value.ToString();
                    matrix[index, ndindex] = Convert.ToInt32(cell);
                    
                }
            return matrix;
        }

        public static void GridEdit(DataGridView Grid) //design for magic square
        {
            Grid.Rows[0].Height = 150;
            Grid.Rows[1].Height = 150;
            Grid.Rows[2].Height = 150;
            Grid.Rows[3].Height = 150;

            Grid.DefaultCellStyle.BackColor = Color.LightBlue;
            Grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Grid.DefaultCellStyle.Font= new Font("Comic Sans MS",25);

            Grid[1, 0].Style.BackColor = Color.IndianRed;
            Grid[2, 0].Style.BackColor = Color.IndianRed;
            Grid[3, 1].Style.BackColor = Color.IndianRed;
            Grid[0, 2].Style.BackColor = Color.IndianRed;
            Grid[2, 2].Style.BackColor = Color.IndianRed;
            Grid[3, 2].Style.BackColor = Color.IndianRed;

        }

        public static void MagicSquareCheck(int [,]matrix) //function checking if the answer is correct and the solution is a magic square, which means sums of all rows,columns and diagonals must be equal
        {
            int sumrow1 = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3];
            int sumrow2 = matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[1, 3];
            int sumrow3 = matrix[2, 0] + matrix[2, 1] + matrix[2, 2] + matrix[2, 3];
            int sumrow4 = matrix[3, 0] + matrix[3, 1] + matrix[3, 2] + matrix[3, 3];

            int sumcolumn1 = matrix[0, 0] + matrix[1, 0] + matrix[2, 0] + matrix[3, 0];
            int sumcolumn2 = matrix[0, 1] + matrix[1, 1] + matrix[2, 1] + matrix[3, 1];
            int sumcolumn3 = matrix[0, 2] + matrix[1, 2] + matrix[2, 2] + matrix[3, 2];
            int sumcolumn4 = matrix[0, 3] + matrix[1, 3] + matrix[2, 3] + matrix[3, 3];

            int sumdiagonal1 = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
            int sumdiagonal2 = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];

            if(sumrow1==sumrow2 && sumrow2 == sumrow3 && sumrow3 == sumrow4 && 
                sumrow4==sumcolumn1 &&
                sumcolumn1==sumcolumn2 && sumcolumn2 == sumcolumn3 && sumcolumn3 == sumcolumn4 &&
                sumcolumn4==sumdiagonal1 &&
                sumdiagonal1==sumdiagonal2)
            {
                MessageBox.Show("Correct! You won!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Wrong!");                
            }
        }
        public static void ShowAnswer(DataGridView Grid) // answer
        {
            Grid[0, 0].Value = 16;
            Grid[3, 0].Value = 13;
           
            Grid[0, 1].Value = 5;
            Grid[1, 1].Value = 11;
            Grid[2, 1].Value = 10;

            Grid[1, 2].Value = 7;

            Grid[0, 3].Value = 4;
            Grid[1, 3].Value = 14;
            Grid[2, 3].Value = 15;
            Grid[3, 3].Value = 1;
        }
    }
}
