﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach
{
	public class Program
	{
		static void Main(string[] args)
		{

			int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            
			Console.Write("***** Foreach *****");
			string[] arabalar = { "BMV", "Ford", "Toyota", "Nissan" };
			foreach (var araba in arabalar)
			{
				Console.WriteLine(araba);
			}
			
		}
	}
}