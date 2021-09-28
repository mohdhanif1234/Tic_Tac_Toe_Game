using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
        // Declaring and creating an empty array named board of size 10 characters
        char[] board = new char[10];

        public char inpComputer;
        public void InputLetterMethod()
        {
            Console.Write("Enter either X or O: ");
            char inputLetter = Convert.ToChar(Console.ReadLine());
            Console.Write("The user has entered " + inputLetter + "\n");
            Random random = new Random();
            int inpComp = random.Next(0, 2);

            if (inpComp == 1)
            {
               inpComputer = 'X';
            }
            else
            {
               inpComputer = 'O';
            }

            Console.Write("The computer has entered " + inpComputer);
            Console.ReadLine();

        }
    }
}
