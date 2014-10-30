using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    class PlayerBlack : Player
    {
        internal List<ChessPiece> _blackPiecesList = new List<ChessPiece>();

        public PlayerBlack()
        {
            ChessPiece pawn1 = new Pawn(0, 1);
            ChessPiece pawn2 = new Pawn(1, 1);
            ChessPiece pawn3 = new Pawn(2, 1);
            ChessPiece pawn4 = new Pawn(3, 1);
            ChessPiece pawn5 = new Pawn(4, 1);
            ChessPiece pawn6 = new Pawn(5, 1);
            ChessPiece pawn7 = new Pawn(6, 1);
            ChessPiece pawn8 = new Pawn(7, 1);
            _blackPiecesList.Add(pawn1);
            _blackPiecesList.Add(pawn2);
            _blackPiecesList.Add(pawn3);
            _blackPiecesList.Add(pawn4);
            _blackPiecesList.Add(pawn5);
            _blackPiecesList.Add(pawn6);
            _blackPiecesList.Add(pawn7);
            _blackPiecesList.Add(pawn8);
        }

        
    }
}
