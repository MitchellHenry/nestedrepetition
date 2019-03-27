/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 27/03/2019
 * Time: 4:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Excercise1._
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter your name!");
				string name = Console.ReadLine();
				Console.WriteLine("Enter the number of times you what your name printed(It must be a number or program wont work!)");
				int times = int.Parse(Console.ReadLine());
				
			 int count = 0;
			while(count < 10){
			 	string name2 = "";
			 	int count2 = 0;
			 	while(count2 < times){
			 		name2 = name2 + " " + name;
			 		count2++;
			 	}
			 		
				count++;
				Console.WriteLine(name2);}
			
			Console.ReadKey(true);
		}
	}
}
