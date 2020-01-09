using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class TicTacToe
    {
        private string[,] fields = {
            { "1", "2", "3"},
            { "4", "5", "6"},
            { "7", "8", "9"}
        };
        private int gameWonBy = 0;
        private int playerTurn = 1;

        public void StartGame()
        {
            while (gameWonBy == 0)
            {
                Console.Clear();

                Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[0, 0], fields[0, 1], fields[0, 2]);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
                Console.WriteLine("-----------------");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[1, 0], fields[1, 1], fields[1, 2]);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
                Console.WriteLine("-----------------");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[2, 0], fields[2, 1], fields[2, 2]);
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
                Console.WriteLine("");
                Console.WriteLine("Player {0}, please choose a number between 1-9 to make a move", playerTurn);
                Console.WriteLine("");


                try
                {
                    int move = int.Parse(Console.ReadLine());

                    MakeMove(move);

                    gameWonBy = CheckWinner();

                }
                catch
                {
                    Console.WriteLine("input needs to be a valid number between 1-9, that hasn't been chosen yet. Please try again");
                    Console.ReadKey();
                }




            }

            Console.Clear();

            Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[0, 0], fields[0, 1], fields[0, 2]);
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[1, 0], fields[1, 1], fields[1, 2]);
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", fields[2, 0], fields[2, 1], fields[2, 2]);
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", " ", " ", " ");
            Console.WriteLine("");
            Console.WriteLine("Player {0} has won the game!", playerTurn);
            Console.WriteLine("");

            Console.ReadLine();
        }

        private void MakeMove(int move)
        {
            move--;

            if (fields[move / 3, move % 3] == "X" || fields[move / 3, move % 3] == "O")
                throw new Exception();

            if (playerTurn == 1)
                fields[move / 3, move % 3] = "X";
            else
                fields[move / 3, move % 3] = "O";
        }

        private int CheckWinner()
        {
            int gameWonBy = 0; //0 means nobody won

            gameWonBy += CheckLine(fields[0, 0], fields[0, 1], fields[0, 2]);
            gameWonBy += CheckLine(fields[1, 0], fields[1, 1], fields[1, 2]);
            gameWonBy += CheckLine(fields[2, 0], fields[2, 1], fields[2, 2]);
            gameWonBy += CheckLine(fields[0, 0], fields[1, 0], fields[2, 0]);
            gameWonBy += CheckLine(fields[0, 1], fields[1, 1], fields[2, 1]);
            gameWonBy += CheckLine(fields[0, 2], fields[1, 2], fields[2, 2]);
            gameWonBy += CheckLine(fields[0, 0], fields[1, 1], fields[2, 2]);
            gameWonBy += CheckLine(fields[0, 2], fields[1, 1], fields[2, 0]);


            if (gameWonBy == 0)
            {
                if (playerTurn == 1)
                    playerTurn = 2;
                else
                    playerTurn = 1;
            }

            return gameWonBy;
        }

        private int CheckLine(string a, string b, string c)
        {
            if (a == "X" && b == "X" && c == "X")
            {
                return 1;
            }
            else if (a == "O" && b == "O" && c == "O")
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

    }
}
