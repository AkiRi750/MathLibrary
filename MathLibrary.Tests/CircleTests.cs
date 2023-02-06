namespace MathLibrary.Tests
{
	public class CircleTests
	{
		[Theory]
		[InlineData(0)]
		[InlineData(-100)]
		public void FailToCreateInvalidCircle(double radius)
		{
			Exception? exception = null;
			try
			{
				var circle = new Circle(radius);
			}
			catch(Exception ex) 
			{ 
				exception = ex; 
			}

			Assert.True(exception != null);
		}

		[Theory]
		[InlineData(1)]
		[InlineData(20)]
		public void GetCircleArea(double radius)
		{
			var circle = new Circle(radius);
			var result = circle.GetArea();

			Assert.True(result > 0);
		}
	}
}