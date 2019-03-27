/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 27/03/2019
 * Time: 4:11 PM
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
			 int count = 0;
			while(count < 10){
			 	string name2 = "";
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