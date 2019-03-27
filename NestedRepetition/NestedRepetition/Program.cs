/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 21/03/2019
 * Time: 3:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NestedRepetition
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter your name!");
				string name = Console.ReadLine();
				
			 int count = 0;
			while(count < 10){
			 	string name2 = name;
			 	int count2 = 0;
			 	while(count2 < 9){
			 		name2 = name2 + " " + name;
			 		count2++;
			 	}
			 		
				count++;
				Console.WriteLine(name2);}
			
			Console.ReadKey(true);
		}
	}
}