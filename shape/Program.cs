namespace shape
{
	internal class Program
	{
		static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle(false, "Red", 50, 120);
            Square square = new Square(false, "Blue", 40, 40);
            Circle circle = new Circle("Green", 30, false);

            Shape[] shapes = { rectangle, square, circle };

            
           foreach(var item in shapes)
           {
                Console.WriteLine(item);
           }
            
            
            square.MakeHoley();
            Console.WriteLine("\nAfter making Square holey:");
            Console.WriteLine(square);

            Console.WriteLine("------------------------------------------------------------");

            Shape largestShape = FindLargestArea(shapes);
            Console.WriteLine("\nThe shape with the largest area:");
            Console.WriteLine(largestShape);

            Console.WriteLine("------------------------------------------------------------");

            Shape newShape = CreateShape(false, "Yellow", 100, 50);
            Console.WriteLine("\nCreated Shape:");
            Console.WriteLine(newShape);
            
        }
        static Shape FindLargestArea(Shape[] shapes)
        {
            return shapes.OrderByDescending(s => s.Area()).FirstOrDefault();
        }

        static Shape CreateShape(bool isHoley, string color, double height, double width)
        {
            if (height == width)
            {
                return new Square(isHoley, color, height, width);
            }
            return new Rectangle(isHoley, color, height, width);
        }
    }
}
