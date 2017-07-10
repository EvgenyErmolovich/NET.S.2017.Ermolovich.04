using System;
namespace LogicNOD
{
	public static class NOD
	{
		/// <summary>
		/// Euclid algorithm to find NOD.
		/// </summary>
		/// <returns>The NOD.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static long Euclid(long a, long b)
		{
			Check(a, b);
			return EuclidLogic(a, b);
		}
		public static long Euclid(long a, long b, long c)
		{
			Check(a, b, c);
			return EuclidLogic(EuclidLogic(a, b), c);
		}
		public static long Euclid(params long[] numbers)
		{
			Check(numbers);
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				numbers[i + 1] = EuclidLogic(numbers[i], numbers[i + 1]);
			}
			return numbers[numbers.Length - 1];
		}
		/// <summary>
		/// Stein algorithm to find NOD.
		/// </summary>
		/// <returns>The NOD.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		public static long Stein(long a, long b)
		{
			Check(a, b);
			return SteinLogic(a, b);
		}
		public static long Stein(long a, long b, long c)
		{
			Check(a, b, c);
			return SteinLogic(SteinLogic(a, b), c);
		}
		public static long Stein(params long[] numbers)
		{
			Check(numbers);
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				numbers[i + 1] = SteinLogic(numbers[i], numbers[i + 1]);
			}
			return numbers[numbers.Length - 1];
		}
		/// <summary>
		/// Check the specified numbers.
		/// </summary>
		/// <returns>The check.</returns>
		/// <param name="numbers">Numbers.</param>
		private static void Check(params long[] numbers)
		{
			if (numbers.Length < 2)
				throw new ArgumentException("Should be >= 2 parameters");
			for (int i = 0; i < numbers.Length; i++)
				if (numbers[i] < 0) throw new ArgumentOutOfRangeException("Cannot be negative!");
		}
		/// <summary>
		/// Euclids logic.
		/// </summary>
		/// <returns>The NOD.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		private static long EuclidLogic(long a, long b)
		{
			while (a > 0 && b > 0)
				if (a >= b)
					a %= b;
				else
					b %= a;
			return a | b;
		}
		/// <summary>
		/// Steins logic.
		/// </summary>
		/// <returns>The NOD.</returns>
		/// <param name="a">The alpha component.</param>
		/// <param name="b">The blue component.</param>
		private static long SteinLogic(long a, long b)
		{
			if (a == 0) return b;
			if (b == 0) return a;
			if (a == b) return a;

			bool val1IsEven = (a & 1u) == 0;
			bool val2IsEven = (b & 1u) == 0;

			if (val1IsEven && val2IsEven)
				return Stein(a >> 1, b >> 1) << 1;
			else if (val1IsEven)
				return Stein(a >> 1, b);
			else if (val2IsEven)
				return Stein(a, b >> 1);
			else if (a > b)
				return Stein((a - b) >> 1, b);
			else
				return Stein(a, (b - a) >> 1);
		}
    }
}
