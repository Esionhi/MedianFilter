using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedianFilter
{
	public static class Median
	{
		public static int[,] Filter(int[,] bytes, long radius)
		{
			int[,] newBytes = new int[bytes.GetLength(0), bytes.GetLength(1)];
			long w = newBytes.GetLongLength(0);
			long h = newBytes.GetLongLength(1);

			Parallel.For(0, w, new Action<long>((x) =>
			{
				Parallel.For(0, h, new Action<long>((y) =>
				{
					if (radius > 0)
					{
						var neighbours = new List<int>();
						Parallel.For(x - radius, x + radius + 1, new Action<long>((i) =>
						{
							Parallel.For(y - radius, y + radius + 1, new Action<long>((j) =>
							{
								if (i >= 0 & i < w && j >= 0 && j < h)
									neighbours.Add(bytes[i, j]);
							}));
						}));
						neighbours.Sort();
						if (neighbours.Count > 1)
							newBytes[x, y] = neighbours[neighbours.Count / 2];
					}
					else
					{
						newBytes[x, y] = bytes[x, y];
					}
				}));
			}));
			return newBytes;
		}
	}
}