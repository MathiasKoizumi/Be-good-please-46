using System;

namespace WindowsFormsApplication1
{
	public static class MSSystemExtenstions
	{
		private static Random rng = new Random();

		public static void Shuffle<T>(this T[] array)
		{
			rng = new Random();
			int num = array.Length;
			while (num > 1)
			{
				int num2 = rng.Next(num);
				num--;
				T val = array[num];
				array[num] = array[num2];
				array[num2] = val;
			}
		}
	}
}
