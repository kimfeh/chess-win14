using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProject
{
    class Pawn : ChessPiece
    {
        public Pawn(int xPos, int yPos)
        {            
            this._xPos = xPos;
            this._yPos = yPos;
            this._symbol = '█';
        }

        public override void MovePiece(PieceColor color)
        {
            if (_yPos == 7 || _yPos == 0)
            {
                // går inte utanför spelet.

                // ska läggas in att man får välja en ny pjäs om man kommer hit med bonden.
            }
            else if (color == PieceColor.Black)
            {
                this._yPos++;
           
           }
            else if (color == PieceColor.White)
            {
                this._yPos--;
            }
        }
      
    }
}
