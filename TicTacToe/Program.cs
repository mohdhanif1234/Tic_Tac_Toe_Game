using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //TicTacToeGame game = new TicTacToeGame(); // Creating an object 'game' of class 'TicTacToeGame'
            //game.TicTacToeGameMethod(); // Calling a method 'TicTacToeGameMethod'

            TicTacToeGame input = new TicTacToeGame();
            input.InputLetterMethod();
        }
    }
}
