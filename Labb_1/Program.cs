namespace Labb_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Circle c = new Circle(10);
			Console.WriteLine(c.ToString());
		}
	}

	class Circle
	{
		public double Radius { get; set; }
		public Circle(double radius)
		{
			Radius = radius;
		}

		public double GetArea()
		{
			double area = Radius * Radius * Math.PI;
			return area;
		}

		public override string ToString()
		{
			return $"Radius: {Radius}\nArea: {GetArea()}";
		}

	}

}
