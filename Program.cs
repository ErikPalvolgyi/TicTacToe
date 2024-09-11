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
                Quit = conds.quit;
                if(Quit == false)
                {
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
                table.tableElems[input.rowFinal - 1, input.columnFinal - 1] = state;
                table.MakeTable();
                conds.decideIfConditionIsTrue(table, state);
                nextPlayer++;
                }
                else
                {
                    continue;
                }
            }while(Quit == false);
        }
    }
}
