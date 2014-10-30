using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    class PlayerWhite : Player
    {
        internal List<ChessPiece> _whitePiecesList = new List<ChessPiece>();

        public PlayerWhite()
        {
            ChessPiece pawn1 = new Pawn(0, 6);
            ChessPiece pawn2 = new Pawn(1, 6);
            ChessPiece pawn3 = new Pawn(2, 6);
            ChessPiece pawn4 = new Pawn(3, 6);
            ChessPiece pawn5 = new Pawn(4, 6);
            ChessPiece pawn6 = new Pawn(5, 6);
            ChessPiece pawn7 = new Pawn(6, 6);
            ChessPiece pawn8 = new Pawn(7, 6);
            _whitePiecesList.Add(pawn1);
            _whitePiecesList.Add(pawn2);
            _whitePiecesList.Add(pawn3);
            _whitePiecesList.Add(pawn4);
            _whitePiecesList.Add(pawn5);
            _whitePiecesList.Add(pawn6);
            _whitePiecesList.Add(pawn7);
            _whitePiecesList.Add(pawn8);
        }

     
    }
}
