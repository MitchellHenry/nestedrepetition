/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 27/03/2019
 * Time: 4:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Excercise_2._
{
	class Program
	{
		public static void Main(string[] args)
		{
			 int count = 0;
			 int Value = 0;
			 Console.WriteLine("Type an Integer how many X's you want to start with");
			 int number = int.Parse(Console.ReadLine());
			 while(count < number){
			 	string x = "";
			 	int count2 = number;
			 	while(count2 > Value){
			 		x = x + "x";
			 		count2 = count2 -1;
			 	}
			 	Console.WriteLine(x);
			 	Value = Value + 1;
				count++;}
			
			Console.ReadKey(true);
		}
	}
}