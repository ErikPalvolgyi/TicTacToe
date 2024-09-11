using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            Table table = new Table();
            UserInput input = new UserInput();
            Conditions conds = new Conditions();
            bool Quit;
            int nextPlayer = 0;


            do
            {
                Quit = input.quit;
                string state = "";
                if(nextPlayer % 2 == 0)
                {
                    state = "X";
                }
                else
                {
                    state = "O";
                }
                input.TakeInput(state);
                table.tableElems[input.columnFinal - 1, input.rowFinal - 1] = state;
                table.MakeTable();
                nextPlayer++;
            }while(Quit == false);

        void Victory(string winner)
        {
            Console.WriteLine($"{winner} nyert");
            Quit = false;
        }
        }
    }
}
