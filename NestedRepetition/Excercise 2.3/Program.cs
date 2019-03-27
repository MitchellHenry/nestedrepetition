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
			 while(count < 1){
			 	string x = "";
			 	int count2 = 0;
			 	while(count2 < 5){
			 		x = x + "x";
			 		count2++;
			 		Console.WriteLine(x);
			 	}
			 		
				count++;}
			
			Console.ReadKey(true);
		}
	}
}