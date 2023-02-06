using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Tests
{
	public class TriangleTests
	{
		[Theory]
		[InlineData(0, 0, 0)]
		[InlineData(5, 10, 0)]
		[InlineData(-10, 5, 20)]
		public void FailToCreateTriangle(double a, double b, double c)
		{
			Exception? exception = null;
			try
			{
				var triangle = new Triangle(a, b, c);
			}
			catch (Exception ex)
			{
				exception = ex;
			}

			Assert.True(exception != null);
		}

		[Theory]
		[InlineData(3, 5, 4)]
		[InlineData(10, 10, 10)]
		public void GetTriangleArea(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			var result = triangle.GetArea();

			Assert.True(result > 0);
		}

		[Theory]
		[InlineData(3, 5, 4)]
		[InlineData(24, 10, 26)]
		public void IsTriangleRightAngled(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			var result = triangle.IsTriangleRightAngled();

			Assert.True(result);
		}

		[Theory]
		[InlineData(3, 5, 5)]
		[InlineData(6, 6, 6)]
		public void IsTriangleNotRightAngled(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			var result = triangle.IsTriangleRightAngled();

			Assert.False(result);
		}
	}
}
