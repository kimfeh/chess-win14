using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    static class ChessBoard
    {
                
        static public void PrintBoard(List<ChessPiece> white, List<ChessPiece> black)   // printing pieces and squares to the console
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (x % 2 != 0)
                    {
                        if (y % 2 == 0)
                        {
                            PrintBlackPos(white, black, x, y);
                        }
                        else
                        {
                            PrintWhitePos(white, black, x, y);
                        }
                    }
                    else
                    {
                        if (y % 2 != 0)
                        {
                            PrintBlackPos(white, black, x, y);
                        }
                        else
                        {
                            PrintWhitePos(white, black, x, y);
                        }
                    }
                }
            }
        }

        private static void PrintBlackPos(List<ChessPiece> white, List<ChessPiece> black, int x, int y) // printing pieces and squares to the console
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < black.Count; i++)
            {

                if (black[i]._xPos == x && black[i]._yPos == y)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(black[i]._symbol);
                    Console.ResetColor();
                    return;
                }
                else
                {
                    for (int b = 0; b < white.Count; b++)
                    {
                        if (white[b]._xPos == x && white[b]._yPos == y)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(white[b]._symbol);
                            Console.ResetColor();
                            return;
                        }
                        else
                        {
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ");

                        }
                    }
                }
            }

            Console.ResetColor();
        }

        private static void PrintWhitePos(List<ChessPiece> white, List<ChessPiece> black, int x, int y) // printing pieces and squares to the console
        {

            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i < black.Count; i++)
           
            {

                if (black[i]._xPos == x && black[i]._yPos == y)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(black[i]._symbol);
                    Console.ResetColor();        
                    return;                        
                }
                else
                {
                    for (int b = 0; b < white.Count; b++)
                  
                    {
                        if (white[b]._xPos == x && white[b]._yPos == y)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(white[b]._symbol);
                            Console.ResetColor();
                            return;
                        }
                        else
                        {
                            Console.SetCursorPosition(x, y);
                            Console.Write(" ");
                           
                        }
                    }
                }
            }

            Console.ResetColor();
        }
    }
}