using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.DataClasses
{
    public enum Direction { Up, Down, Left, Right };

    public class Snake
    {
        private Direction Direction { get; set; }
        private LinkedList<Square> Body { get; set; }

        public Snake() {
            this.Direction = Direction.Up;
            this.Body = new LinkedList<Square>();
        }

        /// <summary>
        /// "Moves the snake" by updating the list of squares which constitute the snake's body
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        public bool Move(Square square) {
            if (this.Body.Contains(square))
            {
                return false;
            }
            else {
                // Add next square to the head of the snake
                this.Body.AddFirst(square);
                
                // If no food was found, remove the last square from the snake
                if (!SquareItem.Food.Equals(square.SquareItem)) {
                    this.Body.RemoveLast();
                }
            }
            return true;
        }
    }
}
