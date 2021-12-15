using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTac;

namespace TicTac
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Desk desk = new Desk();
            Game game = new Game();

            game.initDesk(desk);

            desk.showDesk();

            while (desk.isEmptySpaces())
            {
                player1.makeMove(desk);
                if (game.isOver(desk, player1, player2))
                {
                    desk.showDesk();
                    break;
                }
                desk.showDesk();
                player2.makeMove(desk);
                if (game.isOver(desk, player1, player2))
                {
                    desk.showDesk();
                    break;
                }
                desk.showDesk();
            }
        }
    }
}
