using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Models
{
	public class Circle : Figure
	{
		public readonly double Radius;

		public Circle(double radius)
		{
			if (radius <= 0)
				throw new ArgumentException("Radius should be positive");
			Radius = radius;
		}

		public override double GetArea()
		{
			return Radius * Radius * Math.PI;
		}
	}
}
