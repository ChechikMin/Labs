using System;
 
namespace TicTac
{
    public class Player
    {
        string symbol = "";
        public Player()
        {
            Console.WriteLine("Input Your typeSymbol");
            symbol = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Player Created");
        }
        public void makeMove(Desk desk) {
            Console.WriteLine("Input Your Cell in format: i j");
            Tuple<int, int> t = new Tuple<int, int>(Convert.ToUInt16(Console.ReadLine()), Convert.ToUInt16(Console.ReadLine()));
            desk.setCurrentMove(t, symbol);
        }
        public string getSymbol() 
        {
            return symbol;
        }
    }
}
