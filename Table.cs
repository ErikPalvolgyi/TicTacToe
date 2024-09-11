using System;

namespace TicTacToe
{
    class Table
    {
        public string[,] tableElems = {
            {" ", " ", " "},
            {" ", " ", " "},
            {" ", " ", " "}
        };

        public void MakeTable()
        {
            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine($" {tableElems[i, 0]} | {tableElems[i, 1]} | {tableElems[i, 2]} ");
                if(i != 2)
                {
                    Console.WriteLine("-- +- -+ --");
                }
            }
        }
    }
}
