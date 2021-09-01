using System;

namespace Geometri {
    public class Square {
        private int side;
        public int Side {
            get { return side; }
        }

        public Square(int side) {
            this.side = side;
        }

        public int Perimiter() {
            return side * 4;
        }

        public int Area() {
            return side * side;
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.Write("Length of side: ");
            int input = int.Parse(Console.ReadLine());
            Square s = new Square(input);
	    
            Console.WriteLine($"Perimeter: {s.Perimiter()}");
            Console.WriteLine($"\nArea: {s.Area()}");
        }
    }
}
