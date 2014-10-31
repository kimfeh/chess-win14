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
                ChessBoard.PrintBoard(_playerWhite._whitePiecesList, _playerBlack._blackPiecesList);
                _playerWhite._whitePiecesList[ChessBoard.rnd.Next(_playerWhite._whitePiecesList.Count)].MovePiece(PieceColor.White); // randomise an white move onto the print board 
                ChessBoard.PrintBoard(_playerWhite._whitePiecesList, _playerBlack._blackPiecesList);
                _playerBlack._blackPiecesList[ChessBoard.rnd.Next(_playerBlack._blackPiecesList.Count)].MovePiece(PieceColor.Black);  // randomise an black move onto the print board 
                
                
                Console.ReadKey();        
            }
        

        }
    }
}
