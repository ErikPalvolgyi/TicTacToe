namespace TicTacToe
{
    class Conditions
    {
        public bool quit = false;

        public void decideIfConditionIsTrue(Table obj,string value)
        {
            if(obj.tableElems[0, 0] == value && obj.tableElems[1, 0] == value && obj.tableElems[2, 0] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[0, 1] == value && obj.tableElems[1, 1] == value && obj.tableElems[2, 1] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[0, 2] == value && obj.tableElems[1, 2] == value && obj.tableElems[2, 2] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[0, 0] == value && obj.tableElems[0, 1] == value && obj.tableElems[0, 2] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[1, 0] == value && obj.tableElems[1, 1] == value && obj.tableElems[1, 2] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[2, 0] == value && obj.tableElems[2, 1] == value && obj.tableElems[2, 2] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[0, 0] == value && obj.tableElems[1, 1] == value && obj.tableElems[2, 2] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else if(obj.tableElems[0, 2] == value && obj.tableElems[1, 1] == value && obj.tableElems[2, 0] == value)
            {
                Console.WriteLine($"{value} nyert");
                quit = true;
            }
            else
            {
                quit = false;
            }
        }
    }
}
