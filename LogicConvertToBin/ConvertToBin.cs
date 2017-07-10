using System;
using System.Text;
using System.Collections;
namespace LogicConvertToBin
{
	public static class ConvertToBin
	{
		/// <summary>
		/// Converts number to bin.
		/// </summary>
		/// <returns>The number in bin.</returns>
		/// <param name="number">Number.</param>
		public static string NumberInBin(double number)
		{
			BitArray bits = new BitArray(BitConverter.GetBytes(number));
			return ToString(bits);
		}
		/// <summary>
		/// Converts to string
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="arr">Array of bits.</param>
		private static string ToString(BitArray arr)
		{
			StringBuilder str = new StringBuilder(arr.Length);
			for (int i = arr.Length - 1; i >= 0; i--)
				str.Append(arr[i] ? '1' : '0');
			return str.ToString();
		} 
	}
}
