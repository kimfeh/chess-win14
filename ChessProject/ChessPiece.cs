﻿using System;
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

        protected int _attractionValue;
        public string Name { get; set; }

             
        public virtual void MovePiece(PieceColor color)
        {

        }

    }
}