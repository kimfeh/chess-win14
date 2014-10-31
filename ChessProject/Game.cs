using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    class Game
    {
        PlayerBlack _playerBlack;
        PlayerWhite _playerWhite;
        public Game()
        {
            _playerWhite = new PlayerWhite();   //skapa spelare
            _playerBlack = new PlayerBlack(); 
        }


        public void StartGame()
        {

        }

        public void NextTurn()
        {
            while (true)
            {
                ChessBoard.PrintBoard(_playerWhite._whitePiecesList, _playerBlack._blackPiecesList);
                _playerWhite._whitePiecesList[ChessBoard.rnd.Next(_playerWhite._whitePiecesList.Count)].MovePiece(PieceColor.White);
                ChessBoard.PrintBoard(_playerWhite._whitePiecesList, _playerBlack._blackPiecesList);
                _playerBlack._blackPiecesList[ChessBoard.rnd.Next(_playerBlack._blackPiecesList.Count)].MovePiece(PieceColor.Black);
                
                
                Console.ReadKey();        
            }
        

        }
    }
}
