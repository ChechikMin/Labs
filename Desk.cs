using System;

namespace TicTac
{
    public class Desk
    {
        const string emptySymbol = "-";
        string currSymbol = "-";
        Tuple<int, int> currTuple = new Tuple<int, int>(0, 0);
        int deskSize = 0;
        string[,] desk = new string[0, 0];
        public Desk()
        {
            Console.WriteLine("Input size of Desk");
            deskSize = Convert.ToInt32(Console.ReadLine());
            desk = new string[deskSize, deskSize];
            Console.WriteLine("Desk Created");
        }
        public int getDeskSize()
        {
            return deskSize;
        }
        public void setDesk(int i, int j, string str)
        {
            desk[i, j] = str;
        }
        public void showDesk()
        {
            for (int i = 0; i < deskSize; i++)
            {
                for (int j = 0; j < deskSize; j++)
                {
                    Console.Write(desk[i, j]);
                }
                Console.Write("\n");

            }
        }
        public string getSymbol(int i, int j)
        {
            return desk[i, j];
        }
        public void setCurrentMove(Tuple<int, int> curTuple, string curSymbol) {
            currTuple = curTuple;
            currSymbol = curSymbol;
            for (int i = 0; i < deskSize; i++)
            {
                for (int j = 0; j < deskSize; j++)
                {
                    if (currTuple.Item1 == j && currTuple.Item2 == i)
                        if(desk[i, j] == "-")
                            desk[i, j] = currSymbol;
                        else
                        {
                            Console.Write("Wrong Input!You passed move xD\n");
                        }
                }
            }
        }
        public bool isEmptySpaces()
        {
        for (int i = 0; i < deskSize; i++)
        {
                for (int j = 0; j < deskSize; j++)
                {
                    if (desk[i, j] == emptySymbol)
                        return true;
                }
        }
        return false;
        }
}
    }
