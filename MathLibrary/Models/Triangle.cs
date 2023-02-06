using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Models
{
	public class Triangle : Figure
	{
		public readonly double A;
		public readonly double B;
		public readonly double C;

		/// <summary>
		/// Создание треугольника по трём сторонам
		/// </summary>
		public Triangle(double a, double b, double c) 
		{
			if (a <= 0 || b <= 0 || c <= 0)
				throw new ArgumentException("Sides should be positive");
			if (!IsTriangleExists(a, b, c))
				throw new Exception("Triangle does not exist");
			A = a;
			B = b;
			C = c;
		}

		/// <summary>
		/// Проверка существования треугольника по трём сторонам
		/// </summary>
		private bool IsTriangleExists(double a, double b, double c)
		{
			return a < b + c && b < a + c && c < a + b;
		}

		public bool IsTriangleRightAngled()
		{
			var sides = new double[] { A, B, C };
			sides = sides.Select(x => x * x)
				.OrderBy(x => x)
				.ToArray();
			return Math.Abs(sides[2] - sides[1] - sides[0]) < 1e-8;
		}

		public override double GetArea()
		{
			double p = (A + B + C) / 2;
			return Math.Sqrt((p - A) * (p - B) * (p - C) * p);
		}
	}
}
