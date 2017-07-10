using NUnit.Framework;
using System;
namespace LogicNOD.NUnit.Tests
{
	[TestFixture()]
	public class NODTests
	{
		[TestCase(1200, 60, ExpectedResult = 60)]
		[TestCase(116150, 232704, ExpectedResult = 202)]
		[TestCase(15, 4, ExpectedResult = 1)]
		public long Euclid_2Args(long a, long b)
		{
			return NOD.Euclid(a, b);
		}

		[TestCase(5, -10)]
		[TestCase(-5, 10)]
		public void Euclid_2Args_ThrowsArgumentOutOfRangeException(long a, long b)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => NOD.Euclid(a, b));
		}

		[TestCase(1200, 60, 120, ExpectedResult = 60)]
		[TestCase(116150, 232704, 404, ExpectedResult = 202)]
		[TestCase(15, 4, 315, ExpectedResult = 1)]
		public long Euclid_3Args(long a, long b, long c)
		{
			return NOD.Euclid(a, b);
		}

		[TestCase(8, -15, 888)]
		[TestCase(-8, 15, 888)]
		[TestCase(8, 15, -888)]
		public void Euclid_3Args_ThrowsArgumentOutOfRangeException(long a, long b, long c)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => NOD.Euclid(a, b, c));
		}

		[TestCase(2, 4, 8, 16, 32, ExpectedResult = 2)]
		[TestCase(116150, 232704, 404, 8080, 202, ExpectedResult = 202)]
		[TestCase(15, 4, 315, 78, 56565, ExpectedResult = 1)]
		public long Euclid_ManyArgs(long a, long b, long c, long d, long e)
		{
			return NOD.Euclid(a, b, c, d, e);
		}

		[TestCase(8, -15, 888, 12, 23)]
		[TestCase(-8, 15, 888, 12, 23)]
		[TestCase(8, 15, -888, 12, 23)]
		[TestCase(8, 15, 888, -12, 23)]
		[TestCase(8, 15, 888, 12, -23)]
		public void Euclid_ManyArgs_ThrowsArgumentOutOfRangeException(long a, long b, long c, long d, long e)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => NOD.Euclid(a, b, c, d, e));
		}

		[TestCase(1200, 60, ExpectedResult = 60)]
		[TestCase(116150, 232704, ExpectedResult = 202)]
		[TestCase(15, 4, ExpectedResult = 1)]
		public long Stein_2Args(long a, long b)
		{

			return NOD.Stein(a, b);
		}
		[TestCase(8, -15)]
		[TestCase(-8, 15)]
		public void Stein_2Args_ThrowsArgumentOutOfRangeException(long a, long b)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => NOD.Stein(a, b));
		}

		[TestCase(1200, 60, 120, ExpectedResult = 60)]
		[TestCase(116150, 232704, 404, ExpectedResult = 202)]
		[TestCase(15, 4, 315, ExpectedResult = 1)]
		public long Stein_3Args(long a, long b, long c)
		{
			return NOD.Stein(a, b);
		}
		[TestCase(8, -15, 888)]
		[TestCase(-8, 15, 888)]
		[TestCase(8, 15, -888)]
		public void Stein_3Args_ThrowsArgumentOutOfRangeException(long a, long b, long c)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => NOD.Stein(a, b, c));
		}

		[TestCase(2, 4, 8, 16, 32, ExpectedResult = 2)]
		[TestCase(116150, 232704, 404, 8080, 202, ExpectedResult = 202)]
		[TestCase(15, 4, 315, 78, 56565, ExpectedResult = 1)]
		public long Stein_ManyArgs(long a, long b, long c, long d, long e)
		{
			return NOD.Stein(a, b, c, d, e);
		}

		[TestCase(8, -15, 888, 12, 23)]
		[TestCase(-8, 15, 888, 12, 23)]
		[TestCase(8, 15, -888, 12, 23)]
		[TestCase(8, 15, 888, -12, 23)]
		[TestCase(8, 15, 888, 12, -23)]
		public void Stein_ManyArgs_ThrowsArgumentOutOfRangeException(long a, long b, long c, long d, long e)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => NOD.Stein(a, b, c, d, e));
		}
	}
}
