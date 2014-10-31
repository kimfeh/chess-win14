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

        public override void MovePiece(PieceColor color, List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)
        {
            if (_yPos == 7 || _yPos == 0) // stopping pawns from leaving the gameboard.
            {
                 // ska läggas in att man får välja en ny pjäs om man kommer hit med bonden.
            }
            
            else if (color == PieceColor.Black)
            {
                if (AnalyzeWhite(_blackPiecesList, _whitePiecesList))
                {
                    this._yPos++;
                }
                else if(PawnKillBlack(_blackPiecesList, _whitePiecesList))
                {
                        
                }
                
            }
            
            else if (color == PieceColor.White)
            {
                if (AnalyzeBlack(_blackPiecesList, _whitePiecesList))
                {
                    this._yPos--;
                }
                else if (PawnKillWhite(_blackPiecesList, _whitePiecesList)) 
                { 
                
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
                
                if (item._yPos == this._yPos - 1 && item._xPos == this._xPos + 1)
                {
                    
                    item._yPos = this._yPos;
                    item._xPos = this._xPos;
                    _blackPiecesList.Remove(item);

                    return true;
                }
                if (item._yPos == this._yPos - 1 && item._xPos == this._xPos - 1) 
                {
                   
                    item._yPos = this._yPos;
                    item._xPos = this._xPos;
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

                if (item._yPos == this._yPos - 1 && item._xPos == this._xPos + 1)
                {
                    
                    item._yPos = this._yPos;
                    item._xPos = this._xPos;
                    _whitePiecesList.Remove(item);

                    return true;
                }
                if (item._yPos == this._yPos - 1 && item._xPos == this._xPos - 1)
                {
                    
                    item._yPos = this._yPos;
                    item._xPos = this._xPos;
                    _whitePiecesList.Remove(item);
                    return true;
                }

            }
            return false;
          
        }
    
    }
}
