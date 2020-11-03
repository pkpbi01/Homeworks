using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
	static public class TDArrays
	{
		static public int GetMinimalElement(int[,] array)
		{
			int minIdi = 0;
			int minIdj = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] < array[minIdi, minIdj])
					{
						minIdj = j;
						minIdi = i;
					}
				}
			}
			return array[minIdi, minIdj];
		}

		static public int GetMaximalElement(int[,] array)
		{
			int maxIdi = 0;
			int maxIdj = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] > array[maxIdi, maxIdj])
					{
						maxIdj = j;
						maxIdi = i;
					}
				}
			}
			return array[maxIdi, maxIdj];
		}

		static public int[] GetIndexOfMinimalElement(int[,] array)
		{
			int minIdi = 0;
			int minIdj = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] < array[minIdi, minIdj])
					{
						minIdj = j;
						minIdi = i;
					}
				}
			}
			int[] a = new int[2] { minIdi, minIdj };
			return a;
		}

		static public int[] GetIndexOfMaximalElement(int[,] array)
		{
			int maxIdi = 0;
			int maxIdj = 0;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					if (array[i, j] > array[maxIdi, maxIdj])
					{
						maxIdj = j;
						maxIdi = i;
					}
				}
			}
			int[] a = new int[2] { maxIdi, maxIdj };
			return a;
		}

		static public int GetNumberOfElementsThatBiggerTheirNeighbors(int[,] a)
		{
			int counter = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (((i - 1 < 0) || (a[i, j] > a[i - 1, j])) && ((j - 1 < 0) || (a[i, j] > a[i, j - 1])) && ((i + 2 > a.GetLength(0)) || (a[i, j] > a[i + 1, j])) && ((j + 2 > a.GetLength(1)) || (a[i, j] > a[i, j + 1])))
					{
						counter++;
					}
				}
			}
			return counter;
		}

		static public int[,] TransposeTheMatrix(int[,] array)
		{
			int[,] a = new int[array.GetLength(1), array.GetLength(0)];
			for (int i = 0; i < a.GetLength(0); i++)
				for (int j = 0; j < a.GetLength(1); j++)
					a[i, j] = array[j, i];
			return a;
		}

		static public int[,] CopyArray(int[,] array)
		{
			int[,] a = new int[array.GetLength(0), array.GetLength(1)];
			for (int i = 0; i < array.GetLength(0); i++)
				for (int j = 0; j < array.GetLength(1); j++)
					a[i, j] = array[i, j];
			return a;
		}
	}
}