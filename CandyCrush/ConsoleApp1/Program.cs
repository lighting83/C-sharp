
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{ 
		
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			char[,] mat = new char[n, n];

			for (int i = 0; i < n; i++)
			{
				string[] unos = Console.ReadLine().Split();
				for (int j = 0; j < unos.Length; j++)
				{
					mat[i, j] = char.Parse(unos[j]);
				}

			}

			char uljez = char.Parse(Console.ReadLine());
			for (int  i = 0;  i < n;  i++)
			{
				for (int j = 0; j < n; j++)
				{
					if(mat[j,i] == uljez)
					{
						//padanje
						for (int x = j; x > 0; x--) {
							mat[x, i] = mat[x-1, i]; 
						}
						mat[0, i] = 'x';
					}
				}
			}
			ispisiMatricu(mat);
		}
		
		static void ispisiMatricu(char[,] mat)
		{
			for (int i = 0; i < mat.GetLength(0); i++)
			{
				for (int j = 0; j < mat.GetLength(1); j++)
				{
					Console.Write(mat[i,j]+" ");
				}
				Console.WriteLine();
			}
		}
		


	}
}
