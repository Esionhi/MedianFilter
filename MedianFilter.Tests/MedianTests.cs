using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MedianFilter.Tests
{
	[TestClass]
	public class MedianTests
	{
		[TestMethod]
		public void FilterZeroRadius()
		{
			var model = new int[,] { { 1, 2 }, { 3, 4 } };
			var result = Median.Filter(model, 0);
			var expected = new int[,] { { 1, 2 }, { 3, 4 } };
			result.ShouldBeEquivalentTo(expected);
		}

		[TestMethod]
		public void FilterWithRadius()
		{
			var model = new int[,] { { 1, 2, 3 }, { 7, 8, 9 }, { 4, 5, 6 } };
			var result = Median.Filter(model, 1);
			var expected = new int[,] { { 7, 7, 8 }, { 5, 5, 6 }, { 7, 7, 8 } };
			result.ShouldBeEquivalentTo(expected);
		}
	}
}