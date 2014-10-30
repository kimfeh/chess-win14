using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    static class ChessBoard
    {
        static public Random rnd = new Random();
        static public void PrintBoard(List<ChessPiece> white, List<ChessPiece> black)
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

        private static void PrintBlackPos(List<ChessPiece> white, List<ChessPiece> black, int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var blackPiece in black)
            {
                if (blackPiece._xPos == x && blackPiece._yPos == y)
                {                   
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(blackPiece._symbol);
                    Console.ResetColor();
                    return;
                }
                else
                {
                    foreach (var whitePiece in white)
                    {
                        if (whitePiece._xPos == x && whitePiece._yPos == y)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(whitePiece._symbol);
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

        private static void PrintWhitePos(List<ChessPiece> white, List<ChessPiece> black, int x, int y)
        {

            Console.BackgroundColor = ConsoleColor.White;

            foreach (var blackPiece in black)
            {

                if (blackPiece._xPos == x && blackPiece._yPos == y)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Red;             
                    Console.Write(blackPiece._symbol);
                    Console.ResetColor();        
                    return;                        
                }
                else
                {
                    foreach (var whitePiece in white)
                    {
                        if (whitePiece._xPos == x && whitePiece._yPos == y)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.ForegroundColor = ConsoleColor.Green;                  
                            Console.Write(whitePiece._symbol);
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