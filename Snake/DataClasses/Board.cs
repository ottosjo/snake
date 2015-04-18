using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.DataClasses
{
    class Board
    {
        public Square[,] Matrix {get; set;}

        public Board(int x, int y) { 
            this.Matrix = new Square[x, y];
            for (int i = 0; i < x; i++) { 
                for (int j = 0; j < y; j++) {
                    this.Matrix[i, j] = new Square(i,j);
                }
            }
        }

        public Square Get(Square square) {
            return this.Get(square.X, square.Y);
        }

        public Square Get(int x, int y) {
            return this.Matrix[x, y];
        }

        public void Set(Square square) {
            this.Matrix[square.X, square.Y] = square;
        }
    }
}
