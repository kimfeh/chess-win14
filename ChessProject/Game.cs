using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChessProject
{
    class Game
    {
        
        PlayerBlack _playerBlack;
        PlayerWhite _playerWhite;
        
        public Game()
        {
            
            _playerWhite = new PlayerWhite();   //Create an WhitePlayer
            _playerBlack = new PlayerBlack();  // Create an BlackPlayer
        }

        public void StartGame()
        {
            
        }

        public void NextTurn()   // One round of the game.
        {
            while (true)
            {
                Random rnd = new Random();
                int whiteIndex = rnd.Next(_playerWhite._whitePiecesList.Count);
                _playerWhite._whitePiecesList[whiteIndex].MovePiece(PieceColor.White, _playerBlack._blackPiecesList, _playerWhite._whitePiecesList);
                ChessBoard.PrintBoard(_playerWhite._whitePiecesList, _playerBlack._blackPiecesList);
                 // randomise an white move onto the print board 

                int blackIndex = rnd.Next(_playerBlack._blackPiecesList.Count);
                _playerBlack._blackPiecesList[blackIndex].MovePiece(PieceColor.Black, _playerBlack._blackPiecesList, _playerWhite._whitePiecesList); 
                ChessBoard.PrintBoard(_playerWhite._whitePiecesList, _playerBlack._blackPiecesList);
                // randomise an black move onto the print board 
                                          
            } 
        }
    }   
}
