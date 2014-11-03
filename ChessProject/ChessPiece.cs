using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    abstract class ChessPiece
    {
        internal int _xPos;

        internal int _yPos;

        internal char _symbol;


        public virtual void MovePiece(PieceColor color, List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)  // An virtual MoveMethod to override in every seperated type of Piece.
        {

        }

    }
}
