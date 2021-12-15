using System;

namespace TicTac
{
    public class Game
    {
        public Game()
        {
        }
        public void initDesk(Desk desk)
        {
            for (int i = 0; i < desk.getDeskSize(); i++)
            {
                for (int j = 0; j < desk.getDeskSize(); j++)
                {
                    desk.setDesk(i, j, "-");
                }
            }
        }
        public bool isOver(Desk desk, Player player1, Player player2)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < desk.getDeskSize(); i++)
            {
                for (int j = 0; j < desk.getDeskSize(); j++)
                {
                    if (player1.getSymbol() == desk.getSymbol(i, j))
                        count1++;
                    if (player2.getSymbol() == desk.getSymbol(i, j))
                        count2++;
                }
                if (checkWinner(desk, player1, player2, count1, count2))
                    return true;
                count1 = 0;
                count2 = 0;
            }
            for (int i = 0; i < desk.getDeskSize(); i++)
            {
                for (int j = 0; j < desk.getDeskSize(); j++)
                {
                    if (player1.getSymbol() == desk.getSymbol(j, i))
                        count1++;
                    if (player2.getSymbol() == desk.getSymbol(j, i))
                        count2++;
                }
                if (checkWinner(desk, player1, player2, count1, count2))
                    return true;
                count1 = 0;
                count2 = 0;
            }

            for (int i = 0; i < desk.getDeskSize(); i++)
            {
                if (player1.getSymbol() == desk.getSymbol(i, i))
                    count1++;
                if (player2.getSymbol() == desk.getSymbol(i, i))
                    count2++;
                if (checkWinner(desk, player1, player2, count1, count2))
                    return true;
            }
            count1 = 0;
            count2 = 0;
            for (int i = 0; i < desk.getDeskSize(); i++)
            {
                if (player1.getSymbol() == desk.getSymbol( i, desk.getDeskSize() - i - 1 ))
                    count1++;
                if (player2.getSymbol() == desk.getSymbol( i, desk.getDeskSize() - i - 1))
                    count2++;
                if (checkWinner(desk, player1, player2, count1, count2))
                    return true;
            }
            return false;
        }
        private bool checkWinner(Desk desk, Player player1, Player player2, int count1, int count2)
        {
            if (count1 == desk.getDeskSize())
            {
                Console.Write("Player " + Convert.ToString(player1.getSymbol()) + " Win\n");
                return true;
            }
            if (count2 == desk.getDeskSize())
            {
                Console.Write("Player " + Convert.ToString(player2.getSymbol()) + " Win\n");
                return true;
            }
            return false;
        }
    }
}