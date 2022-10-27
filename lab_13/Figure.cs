using System;

namespace lab_13
{
	public abstract class Figure
	{
		public abstract double Square();
	}

	public sealed class Foursquare : Figure
	{
		private readonly double _side;
		public Foursquare(double side)
		{
			_side = side;
		}
		public override double Square() => Math.Pow(_side, 2);
	}

	public sealed class Circle : Figure
	{
		private readonly double _radius;
		public Circle(double radius)
		{
			_radius = radius;
		}
		public override double Square() => Math.PI * Math.Pow(_radius, 2);
	}
}