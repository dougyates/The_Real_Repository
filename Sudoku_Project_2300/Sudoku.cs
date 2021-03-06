﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Project_2300
{
    class Sudoku
    {
        // variables
        // private List<String> board = new List<String>();

        private string[] board = new string[] {"","","","","","","","",""};
        
        // Member Methods

        // The CheckRow method
        // Purpose: Check that the current row is valid
        public bool CheckRow(int row)
        {
            return false;
        }

        // The CheckCol method
        // Purpose: Check that the current column is valid
        public bool CheckCol(int col)
        {
            return false;
        }

        // The CheckSquare method
        // Purpose: Check that the 9x9 square is valid
        public bool CheckSquare(int row, int col)
        {
            int r = 0, c = 0;

            //count how many numbers are in the square
            for (int i = '0'; i < '9'; i++)
                checkAgainst[i] = 0;

            for (r = row; r < row + 3; r++)
            {
                for (c = col; c < col + 3; c++)
                {
                    //check for existing numbers in the square
                    if (board[r].ElementAt(c) != '*')
                    {
                        //return false if there is a duplicate number
                        if ((checkAgainst[board[r].ElementAt(c)]) >= 1)
                            return false;
                        //add that the number exists in the square
                        checkAgainst[board[r].ElementAt(c)] = 1;
                    }
                }
            }
            return false;
        }

        // The AddLine method
        // Purpose: Insert rows into the board
        public void AddLine(string line, int row)
        {
            board[row] = line;
        }

        // The GetBoard method
        // Purpose: Return the board as an array of strings
        public string[] GetBoard()
        {
            return board;
        }

        // The SolveRecursively method
        // Purpose: Solve the puzzle recursively.  
        public bool SolveRecursively (int row, int col)
        {
            // Advance through columns and rows until a blank spot is found
            //while(row < 9 and the current spot is not a blank)
            while (row < 9 && board.ElementAt(row).ElementAt(col) != '*')
            {

                // go to the next column
                col++;

                // if in column 9, move to the next row
                if (col == 9)
                {
                    // move to the next row
                    row++;
                    // start in the first column
                    col = 0;
                }

            }

            // If row = 9, we have processed all rows (0-8) and the solve is complete.  
            if (row == 9)
            {
                return true;
            }

            // otherwise
            // try values 1-9 and check row, column, and square
            for (int i = 1; i <= 9; i++)
            {
                //board.ElementAt(row)[col] = (char)i;
                
            }

            return false;
        }
    }
}
