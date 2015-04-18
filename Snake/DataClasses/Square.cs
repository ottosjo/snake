using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.DataClasses
{

    public enum SquareItem { Food };
    
    public class Square : IEquatable<Square>
    {
        public int X { get; private set;}
        public int Y { get; private set; }
        public SquareItem SquareItem { get; set; }

        public Square(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        public bool Equals(Square square) {
            if (square == null) {
                return false;
            }
            return this.X == square.X && this.Y == square.Y;
        } 
    }
}
