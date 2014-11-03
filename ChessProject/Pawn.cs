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

            
            if (color == PieceColor.Black)
            {
                
                if(PawnKillWhite(_blackPiecesList, _whitePiecesList))
                {
                    
                }
                else if (AnalyzeWhite(_blackPiecesList, _whitePiecesList))
                {
                    this._yPos++;
                }
                
                
            }
            
            if (color == PieceColor.White)
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
            for (int i = 0; i < _blackPiecesList.Count; i++)
            
           {

               if ((_blackPiecesList[i]._yPos == this._yPos - 1 && _blackPiecesList[i]._xPos == this._xPos - 1) || (_blackPiecesList[i]._yPos == this._yPos - 1 && _blackPiecesList[i]._xPos == this._xPos + 1))
                {

                    this._yPos = _blackPiecesList[i]._yPos;
                    this._xPos = _blackPiecesList[i]._xPos;
                    _blackPiecesList.Remove(_blackPiecesList[i]);

                    return true;
                }
                

            }
            return false;
            
        }

        private bool PawnKillWhite(List<ChessPiece> _blackPiecesList, List<ChessPiece> _whitePiecesList)
        {
            for (int i = 0; i < _whitePiecesList.Count; i++)
			{


                if ((_whitePiecesList[i]._yPos == this._yPos + 1 && _whitePiecesList[i]._xPos == this._xPos + 1) || (_whitePiecesList[i]._yPos == this._yPos + 1 && _whitePiecesList[i]._xPos == this._xPos - 1))
                {

                    this._yPos = _whitePiecesList[i]._yPos;
                    this._xPos = _whitePiecesList[i]._xPos;
                    _whitePiecesList.Remove(_whitePiecesList[i]);
                    return true;
                }

            }
            return false;
          
        }
    
    }
}
