using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Board text function is used to display some rules and text in console page
            BoardText();
            int[,] Board = new int[6, 7] { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 } };
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write("\t" + "\t" + Board[i, j] + "   ");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

            
            
            #region Play_Game
            int GameRound=1;
            int assign;
                while (GameRound <= 42)
                {
                    Console.WriteLine("Enter the column 1 or 2 or 3 or 4 or 5 or 6 or 7 :");
                    int c = Convert.ToInt32(Console.ReadLine());
                    #region colum 1 fill
                    if (c == 1)
                    {
                        if (Board[5, 0] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 0] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 0] = 1);
                            }
                        }
                        else if (Board[4, 0] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 0] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 0] = 1);

                            }
                        }
                        else if (Board[3, 0] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 0] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 0] = 1);
                            }
                        }
                        else if (Board[2, 0] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 0] = 2;
                            }
                            else
                            {
                                assign = Board[2, 0] = 1;
                            }
                        }
                        else if (Board[1, 0] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 0] = 2;
                            }
                            else
                            {
                                assign = Board[1, 0] = 1;
                            }
                        }
                        else if (Board[0, 0] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 0] = 2;
                            }
                            else
                            {
                                assign = Board[0, 0] = 1;
                            }
                        }

                    }
                    #endregion
                    #region column 2 fill
                    if (c == 2)
                    {
                        if (Board[5, 1] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 1] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 1] = 1);
                            }
                        }
                        else if (Board[4, 1] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 1] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 1] = 1);

                            }
                        }
                        else if (Board[3, 1] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 1] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 1] = 1);
                            }
                        }
                        else if (Board[2, 1] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 1] = 2;
                            }
                            else
                            {
                                assign = Board[2, 1] = 1;
                            }
                        }
                        else if (Board[1, 1] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 1] = 2;
                            }
                            else
                            {
                                assign = Board[1, 1] = 1;
                            }
                        }
                        else if (Board[0, 1] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 1] = 2;
                            }
                            else
                            {
                                assign = Board[0, 1] = 1;
                            }
                        }

                    }

                    #endregion
                    #region column 3 fill
                    if (c == 3)
                    {
                        if (Board[5, 2] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 2] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 2] = 1);
                            }
                        }
                        else if (Board[4, 2] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 2] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 2] = 1);

                            }
                        }
                        else if (Board[3, 2] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 2] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 2] = 1);
                            }
                        }
                        else if (Board[2, 2] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 2] = 2;
                            }
                            else
                            {
                                assign = Board[2, 2] = 1;
                            }
                        }
                        else if (Board[1, 2] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 2] = 2;
                            }
                            else
                            {
                                assign = Board[1, 2] = 1;
                            }
                        }
                        else if (Board[0, 2] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 2] = 2;
                            }
                            else
                            {
                                assign = Board[0, 2] = 1;
                            }
                        }

                    }
                    #endregion
                    #region column 4 fill
                    if (c == 4)
                    {
                        if (Board[5, 3] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 3] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 3] = 1);
                            }
                        }
                        else if (Board[4, 3] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 3] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 3] = 1);

                            }
                        }
                        else if (Board[3, 3] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 3] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 3] = 1);
                            }
                        }
                        else if (Board[2, 3] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 3] = 2;
                            }
                            else
                            {
                                assign = Board[2, 3] = 1;
                            }
                        }
                        else if (Board[1, 3] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 3] = 2;
                            }
                            else
                            {
                                assign = Board[1, 3] = 1;
                            }
                        }
                        else if (Board[0, 3] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 3] = 2;
                            }
                            else
                            {
                                assign = Board[0, 3] = 1;
                            }
                        }

                    }
                    #endregion
                    #region  column 5 fill
                    if (c == 5)
                    {
                        if (Board[5, 4] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 4] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 4] = 1);
                            }
                        }
                        else if (Board[4, 4] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 4] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 4] = 1);

                            }
                        }
                        else if (Board[3, 4] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 4] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 4] = 1);
                            }
                        }
                        else if (Board[2, 4] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 4] = 2;
                            }
                            else
                            {
                                assign = Board[2, 4] = 1;
                            }
                        }
                        else if (Board[1, 4] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 4] = 2;
                            }
                            else
                            {
                                assign = Board[1, 4] = 1;
                            }
                        }
                        else if (Board[0, 4] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 4] = 2;
                            }
                            else
                            {
                                assign = Board[0, 4] = 1;
                            }
                        }

                    }
                    #endregion
                    #region column 6fill
                    if (c == 6)
                    {
                        if (Board[5, 5] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 5] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 5] = 1);
                            }
                        }
                        else if (Board[4, 5] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 5] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 5] = 1);

                            }
                        }
                        else if (Board[3, 5] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 5] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 5] = 1);
                            }
                        }
                        else if (Board[2, 5] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 5] = 2;
                            }
                            else
                            {
                                assign = Board[2, 5] = 1;
                            }
                        }
                        else if (Board[1, 5] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 5] = 2;
                            }
                            else
                            {
                                assign = Board[1, 5] = 1;
                            }
                        }
                        else if (Board[0, 5] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 5] = 2;
                            }
                            else
                            {
                                assign = Board[0, 5] = 1;
                            }
                        }

                    }
                    #endregion
                    #region column 7 fill
                    if (c == 7)
                    {
                        if (Board[5, 6] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[5, 6] = 2);
                            }
                            else
                            {
                                assign = (Board[5, 6] = 1);
                            }
                        }
                        else if (Board[4, 6] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[4, 6] = 2);
                            }
                            else
                            {
                                assign = (Board[4, 6] = 1);

                            }
                        }
                        else if (Board[3, 6] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = (Board[3, 6] = 2);
                            }
                            else
                            {
                                assign = (Board[3, 6] = 1);
                            }
                        }
                        else if (Board[2, 6] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[2, 6] = 2;
                            }
                            else
                            {
                                assign = Board[2, 6] = 1;
                            }
                        }
                        else if (Board[1, 6] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[1, 6] = 2;
                            }
                            else
                            {
                                assign = Board[1, 6] = 1;
                            }
                        }
                        else if (Board[0, 6] == 0)
                        {
                            if (GameRound % 2 == 0)
                            {
                                assign = Board[0, 6] = 2;
                            }
                            else
                            {
                                assign = Board[0, 6] = 1;
                            }
                        }

                    }
                    #endregion
                    for (int i = 0; i < Board.GetLength(0); i++)
                    {
                        for (int j = 0; j < Board.GetLength(1); j++)
                        {
                            Console.Write("\t" + "\t" + Board[i, j] + "   ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    GameRound += 1;
                    #region column 1 win
                    if (Board[5, 0] == 1 && Board[4, 0] == 1 && Board[3, 0] == 1 && Board[2, 0] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 0] == 1 && Board[2, 0] == 1 && Board[1, 0] == 1 && Board[0, 0] == 1)
                    {
                        Console.WriteLine("Player 1 win the game");
                        break;
                    }
                    else if (Board[4, 0] == 1 && Board[3, 0] == 1 && Board[2, 0] == 1 && Board[1, 0] == 1)
                    {
                        Console.WriteLine("Player 1 win the game");
                        break;
                    }
                    else if (Board[5, 0] == 2 && Board[4, 0] == 2 && Board[3, 0] == 2 && Board[2, 0] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 0] == 2 && Board[2, 0] == 2 && Board[1, 0] == 2 && Board[0, 0] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                    }
                    else if (Board[4, 0] == 2 && Board[3, 0] == 2 && Board[2, 0] == 2 && Board[1, 0] == 2)
                    {
                        Console.WriteLine("Player 2 win the game");
                        break;
                    }
                    #endregion
                    #region column 2 win
                    else if (Board[5, 1] == 1 && Board[4, 1] == 1 && Board[3, 1] == 1 && Board[2, 1] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 1] == 1 && Board[2, 1] == 1 && Board[1, 1] == 1 && Board[0, 1] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 1] == 1 && Board[3, 1] == 1 && Board[2, 1] == 1 && Board[1, 1] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 1] == 2 && Board[4, 1] == 2 && Board[3, 1] == 2 && Board[2, 1] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 1] == 2 && Board[2, 1] == 2 && Board[1, 1] == 2 && Board[0, 1] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 1] == 2 && Board[3, 1] == 2 && Board[2, 1] == 2 && Board[1, 1] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region column 3 win
                    else if (Board[5, 2] == 1 && Board[4, 2] == 1 && Board[3, 2] == 1 && Board[2, 2] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 2] == 1 && Board[2, 2] == 1 && Board[1, 2] == 1 && Board[0, 2] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 2] == 1 && Board[3, 2] == 1 && Board[2, 2] == 1 && Board[10, 2] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 2] == 2 && Board[4, 2] == 2 && Board[3, 2] == 2 && Board[2, 2] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 2] == 2 && Board[2, 2] == 2 && Board[1, 2] == 2 && Board[0, 2] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 2] == 2 && Board[3, 2] == 2 && Board[2, 2] == 2 && Board[10, 2] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region column 4 win
                    else if (Board[5, 3] == 1 && Board[4, 3] == 1 && Board[3, 3] == 1 && Board[2, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 3] == 1 && Board[2, 3] == 1 && Board[1, 3] == 1 && Board[0, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 3] == 1 && Board[3, 3] == 1 && Board[2, 3] == 1 && Board[1, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 3] == 2 && Board[4, 3] == 2 && Board[3, 3] == 2 && Board[2, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 3] == 2 && Board[2, 3] == 2 && Board[1, 3] == 2 && Board[0, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 3] == 2 && Board[3, 3] == 2 && Board[2, 3] == 2 && Board[1, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region column 5 win
                    else if (Board[5, 4] == 1 && Board[4, 4] == 1 && Board[3, 4] == 1 && Board[2, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 4] == 1 && Board[2, 4] == 1 && Board[1, 4] == 1 && Board[0, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 4] == 1 && Board[3, 4] == 1 && Board[2, 4] == 1 && Board[1, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 4] == 2 && Board[4, 4] == 2 && Board[3, 4] == 2 && Board[2, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 4] == 2 && Board[2, 4] == 2 && Board[1, 4] == 2 && Board[0, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 4] == 2 && Board[3, 4] == 2 && Board[2, 4] == 2 && Board[1, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region column 6 win
                    else if (Board[5, 5] == 1 && Board[4, 5] == 1 && Board[3, 5] == 1 && Board[2, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 5] == 1 && Board[2, 5] == 1 && Board[1, 5] == 1 && Board[0, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 5] == 1 && Board[3, 5] == 1 && Board[2, 5] == 1 && Board[1, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 5] == 2 && Board[4, 5] == 2 && Board[3, 5] == 2 && Board[2, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 5] == 2 && Board[2, 5] == 2 && Board[1, 5] == 2 && Board[0, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 5] == 2 && Board[3, 5] == 2 && Board[2, 5] == 2 && Board[1, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region column 7 win
                    else if (Board[5, 6] == 1 && Board[4, 6] == 1 && Board[3, 6] == 1 && Board[2, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 6] == 1 && Board[2, 6] == 1 && Board[1, 6] == 1 && Board[0, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 6] == 1 && Board[3, 6] == 1 && Board[2, 6] == 1 && Board[1, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 6] == 2 && Board[4, 6] == 2 && Board[3, 6] == 2 && Board[2, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 6] == 2 && Board[2, 6] == 2 && Board[1, 6] == 2 && Board[0, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 6] == 2 && Board[3, 6] == 2 && Board[2, 6] == 2 && Board[1, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region ROW 1 WIN
                    if (Board[0, 0] == 1 && Board[0, 1] == 1 && Board[0, 2] == 1 && Board[0, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[0, 1] == 1 && Board[0, 2] == 1 && Board[0, 3] == 1 && Board[0, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[0, 2] == 1 && Board[0, 3] == 1 && Board[0, 4] == 1 && Board[0, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[0, 3] == 1 && Board[0, 4] == 1 && Board[0, 5] == 1 && Board[0, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[0, 0] == 2 && Board[0, 1] == 2 && Board[0, 2] == 2 && Board[0, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[0, 1] == 2 && Board[0, 2] == 2 && Board[0, 3] == 2 && Board[0, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[0, 2] == 2 && Board[0, 3] == 2 && Board[0, 4] == 2 && Board[0, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[0, 3] == 2 && Board[0, 4] == 2 && Board[0, 5] == 2 && Board[0, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }

                    #endregion
                    #region  ROW 2 WIN
                    else if (Board[1, 0] == 1 && Board[1, 1] == 1 && Board[1, 2] == 1 && Board[1, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[1, 1] == 1 && Board[1, 2] == 1 && Board[1, 3] == 1 && Board[1, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[1, 2] == 1 && Board[1, 3] == 1 && Board[1, 4] == 1 && Board[1, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[1, 3] == 1 && Board[1, 4] == 1 && Board[1, 5] == 1 && Board[1, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[1, 0] == 2 && Board[1, 1] == 2 && Board[1, 2] == 2 && Board[1, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[1, 1] == 2 && Board[1, 2] == 2 && Board[1, 3] == 2 && Board[1, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[1, 2] == 2 && Board[1, 3] == 2 && Board[1, 4] == 2 && Board[1, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[1, 3] == 2 && Board[1, 4] == 2 && Board[1, 5] == 2 && Board[1, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region ROW 3 WIN
                    else if (Board[2, 0] == 1 && Board[2, 1] == 1 && Board[2, 2] == 1 && Board[2, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[2, 1] == 1 && Board[2, 2] == 1 && Board[2, 3] == 1 && Board[2, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[2, 2] == 1 && Board[2, 3] == 1 && Board[2, 4] == 1 && Board[2, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[2, 3] == 1 && Board[2, 3] == 1 && Board[2, 5] == 1 && Board[2, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[2, 0] == 2 && Board[2, 1] == 2 && Board[2, 2] == 2 && Board[2, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[2, 1] == 2 && Board[2, 2] == 2 && Board[2, 3] == 2 && Board[2, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[2, 2] == 2 && Board[2, 3] == 2 && Board[2, 4] == 2 && Board[2, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[2, 3] == 2 && Board[2, 3] == 2 && Board[2, 5] == 2 && Board[2, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region ROW 4 WIN
                    else if (Board[3, 0] == 1 && Board[3, 1] == 1 && Board[3, 2] == 1 && Board[3, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 1] == 1 && Board[3, 2] == 1 && Board[3, 3] == 1 && Board[3, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 2] == 1 && Board[3, 3] == 1 && Board[3, 4] == 1 && Board[3, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 3] == 1 && Board[3, 4] == 1 && Board[3, 5] == 1 && Board[3, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[3, 0] == 2 && Board[3, 1] == 2 && Board[3, 2] == 2 && Board[3, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 1] == 2 && Board[3, 2] == 2 && Board[3, 3] == 2 && Board[3, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 2] == 2 && Board[3, 3] == 2 && Board[3, 4] == 2 && Board[3, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[3, 3] == 2 && Board[3, 4] == 2 && Board[3, 5] == 2 && Board[3, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region ROW 5 WIN
                    else if (Board[4, 0] == 1 && Board[4, 1] == 1 && Board[4, 2] == 1 && Board[4, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 1] == 1 && Board[4, 2] == 1 && Board[4, 3] == 1 && Board[4, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 2] == 1 && Board[4, 3] == 1 && Board[4, 4] == 1 && Board[4, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 3] == 1 && Board[4, 4] == 1 && Board[4, 5] == 1 && Board[4, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[4, 0] == 2 && Board[4, 1] == 2 && Board[4, 2] == 2 && Board[4, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 1] == 2 && Board[4, 2] == 2 && Board[4, 3] == 2 && Board[4, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 2] == 2 && Board[4, 3] == 2 && Board[4, 4] == 2 && Board[4, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[4, 3] == 2 && Board[4, 4] == 2 && Board[4, 5] == 2 && Board[4, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    #endregion
                    #region ROW 6 WIN
                    else if (Board[5, 0] == 1 && Board[5, 1] == 1 && Board[5, 2] == 1 && Board[5, 3] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 1] == 1 && Board[5, 2] == 1 && Board[5, 3] == 1 && Board[5, 4] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 2] == 1 && Board[5, 3] == 1 && Board[5, 4] == 1 && Board[5, 5] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 3] == 1 && Board[5, 4] == 1 && Board[5, 5] == 1 && Board[5, 6] == 1)
                    {
                        Console.WriteLine("player 1 win the game");
                        break;
                    }
                    else if (Board[5, 0] == 2 && Board[5, 1] == 2 && Board[5, 2] == 2 && Board[5, 3] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[5, 1] == 2 && Board[5, 2] == 2 && Board[5, 3] == 2 && Board[5, 4] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[5, 2] == 2 && Board[5, 3] == 2 && Board[5, 4] == 2 && Board[5, 5] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }
                    else if (Board[5, 3] == 2 && Board[5, 4] == 2 && Board[5, 5] == 2 && Board[5, 6] == 2)
                    {
                        Console.WriteLine("player 2 win the game");
                        break;
                    }

                    #endregion
                    #region diagonal win 1
                    if (Board[3, 0] == 1 && Board[2, 1] == 1 && Board[1, 2] == 1 && Board[0, 3] == 1)
                    {
                        Console.WriteLine("User 1 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[3, 0] == 2 && Board[2, 1] == 2 && Board[1, 2] == 2 && Board[0, 3] == 2)
                    {
                        Console.WriteLine("User 2 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    #endregion
                    #region diagional 2 win
                    else if (Board[4, 0] == 1 && Board[3, 1] == 1 && Board[2, 2] == 1 && Board[1, 3] == 1)
                    {
                        Console.WriteLine("User 1 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[3, 1] == 1 && Board[2, 2] == 1 && Board[1, 3] == 1 && Board[0, 4] == 1)
                    {
                        Console.WriteLine("User 1 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[4, 0] == 2 && Board[3, 1] == 2 && Board[2, 2] == 2 && Board[1, 3] == 2)
                    {
                        Console.WriteLine("User 2 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[3, 1] == 2 && Board[2, 2] == 2 && Board[1, 3] == 2 && Board[0, 4] == 2)
                    {
                        Console.WriteLine("User 2 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    #endregion
                    #region diaginal win 3
                    else if (Board[5, 0] == 1 && Board[4, 1] == 1 && Board[3, 2] == 1 && Board[2, 3] == 1)
                    {
                        Console.WriteLine("User 1 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[4, 1] == 1 && Board[3, 2] == 1 && Board[2, 3] == 1 && Board[1, 4] == 1)
                    {
                        Console.WriteLine("User 1 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[3, 2] == 1 && Board[2, 3] == 1 && Board[1, 4] == 1 && Board[0, 5] == 1)
                    {
                        Console.WriteLine("User 1 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[5, 0] == 2 && Board[4, 1] == 2 && Board[3, 2] == 2 && Board[2, 3] == 2)
                    {
                        Console.WriteLine("User 2 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[4, 1] == 2 && Board[3, 2] == 2 && Board[2, 3] == 2 && Board[1, 4] == 2)
                    {
                        Console.WriteLine("User 2 connected 4 diagonaly....WIN .....");
                        break;
                    }
                    else if (Board[3, 2] == 2 && Board[2, 3] == 2 && Board[1, 4] == 2 && Board[0, 5] == 2)
                    {
                        Console.WriteLine("User 2 connected 4 diagonaly....WIN .....");
                        break;
                    }

                    #endregion
                    #region diagional 4 win
                    else if (Board[5, 1] == 1 && Board[4, 2] == 1 && Board[3, 3] == 1 && Board[2, 4] == 1)
                    {
                        Console.WriteLine("Player 1 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[4, 2] == 1 && Board[3, 3] == 1 && Board[2, 4] == 1 && Board[1, 5] == 1)
                    {
                        Console.WriteLine("Player 1 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[3, 3] == 1 && Board[2, 4] == 1 && Board[1, 5] == 1 && Board[0, 6] == 1)
                    {
                        Console.WriteLine("Player 1 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[5, 1] == 2 && Board[4, 2] == 2 && Board[3, 3] == 2 && Board[2, 4] == 2)
                    {
                        Console.WriteLine("Player 2 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[4, 2] == 2 && Board[3, 3] == 2 && Board[2, 4] == 2 && Board[1, 5] == 2)
                    {
                        Console.WriteLine("Player 2 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[3, 3] == 2 && Board[2, 4] == 2 && Board[1, 5] == 2 && Board[0, 6] == 2)
                    {
                        Console.WriteLine("Player 2 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    #endregion
                    #region diagional 5 win
                    else if (Board[5, 2] == 1 && Board[4, 3] == 1 && Board[3, 4] == 1 && Board[2, 5] == 1)
                    {
                        Console.WriteLine("Player 1 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[4, 3] == 1 && Board[3, 4] == 1 && Board[2, 5] == 1 && Board[1, 6] == 1)
                    {
                        Console.WriteLine("Player 1 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[5, 2] == 2 && Board[4, 3] == 2 && Board[3, 4] == 2 && Board[2, 5] == 2)
                    {
                        Console.WriteLine("Player 2 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[4, 3] == 2 && Board[3, 4] == 2 && Board[2, 5] == 2 && Board[1, 6] == 2)
                    {
                        Console.WriteLine("Player 2 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }

                    #endregion
                    #region diagional 6 win
                    else if (Board[5, 3] == 1 && Board[4, 4] == 1 && Board[3, 5] == 1 && Board[2, 5] == 1)
                    {
                        Console.WriteLine("Player 1 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }
                    else if (Board[5, 3] == 2 && Board[4, 4] == 2 && Board[3, 5] == 2 && Board[2, 5] == 2)
                    {
                        Console.WriteLine("Player 2 connected 4 diagionally ....WIN THE GAME....");
                        break;
                    }

                    #endregion
                }
                Console.WriteLine("Won the game by ..." + GameRound + "....attempts");
           
            #endregion
                
          
            
        }
        public static void BoardText()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("                                                         ****************************************************");
            Console.WriteLine("                                                         *           Welcome to  Two player Connect-4 game    *  ");
            Console.WriteLine("                                                         ****************************************************");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "The game ruleses and hints:");
            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + " 1. The board will be filled with zero. You can fill that boxes.");
            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + " 2. Player must fill the boxes from bottom only prohipted to fill from top or center");
            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "\t" + "\t" + " 3. Players have two option 1 is RED 2 is Yellow");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
