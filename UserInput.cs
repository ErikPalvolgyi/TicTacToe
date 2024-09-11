namespace TicTacToe
{
    class UserInput
    {
        public int rowFinal = 0;
        public int columnFinal = 0;
        public void TakeInput(string inputChar)
        {
            Console.WriteLine($"Melyik oszlopba tegyem az {inputChar}-t (1-3)?");
            string column = Console.ReadLine();
            Console.WriteLine($"Melyik sorba tegyem az {inputChar}-t (1-3)?");
            string row = Console.ReadLine();
            rowFinal = int.Parse(row);
            columnFinal = int.Parse(column);
        }
    }
}
