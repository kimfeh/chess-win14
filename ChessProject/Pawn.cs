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
            this._symbol = 'P';
        }

        public override void MovePiece(PieceColor color, List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)
        {
            if (_yPos == 7 || _yPos == 0) // stopping pawns from leaving the gameboard.
            {
                return;
                
               // ska läggas in att man får välja en ny pjäs om man kommer hit med bonden.
            }
            
            else if (color == PieceColor.Black)
            {
                
                if(PawnKillWhite(_blackPiecesList, _whitePiecesList))
                {
                    
                }
                else if (AnalyzeWhite(_blackPiecesList, _whitePiecesList))
                {
                    this._yPos++;
                }
                
                
            }
            
            else if (color == PieceColor.White)
            {
                if (PawnKillBlack(_blackPiecesList, _whitePiecesList)) 
                {
                    
                    
                }
                
                else if (AnalyzeBlack(_blackPiecesList, _whitePiecesList))
                {
                    this._yPos--;
                }
                
                 
            }
        }

        private bool AnalyzeWhite(List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)
        {
            foreach (var item in _whitePiecesList)
            {
                if (item._yPos == this._yPos +1)
                {
                    return false;
                }

            }
            return true;
        }

        private bool AnalyzeBlack(List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)
        {
            foreach (var item in _blackPiecesList)
            {
                if (item._yPos == this._yPos-1)
                {
                    return false;
                }

            }
            return true;
        }

        private bool PawnKillBlack(List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList) 
        {
            foreach (var item in _blackPiecesList)
            {

                if ((item._yPos == this._yPos - 1 && item._xPos == this._xPos - 1) || (item._yPos == this._yPos - 1 && item._xPos == this._xPos + 1))
                {

                    this._yPos = item._yPos;
                    this._xPos = item._xPos;
                    _blackPiecesList.Remove(item);

                    return true;
                }
                

            }
            return false;
            
        }

        private bool PawnKillWhite(List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)
        {
            foreach (var item in _whitePiecesList)
            {

                if ((item._yPos == this._yPos + 1 && item._xPos == this._xPos + 1) || (item._yPos == this._yPos + 1 && item._xPos == this._xPos - 1))
                {

                    this._yPos = item._yPos;
                    this._xPos = item._xPos;
                    _whitePiecesList.Remove(item);
                    return true;
                }

            }
            return false;
          
        }
    
    }
}
