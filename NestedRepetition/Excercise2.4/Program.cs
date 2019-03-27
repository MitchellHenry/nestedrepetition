/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 27/03/2019
 * Time: 5:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Excercise2._
{
	class Program
	{
		public static void Main(string[] args)
		{
			 int count = 0;
			 Console.WriteLine("Enter the number of lines to be displayed(Must be a Integer, Max equals the number)");
			 int lines = int.Parse(Console.ReadLine());
			 while(count < 1){
			 	string x = "";
			 	int count2 = 0;
			 	while(count2 < lines){
			 		x = x + "x";
			 		count2++;
			 		Console.WriteLine(x);
			 	}
			 		
				count++;}
			
			Console.ReadKey(true);
		}
	}
}