/*
 * Created by SharpDevelop.
 * User: Mitchell
 * Date: 27/03/2019
 * Time: 4:21 PM
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
			 int Value = 0;
			 while(count < 5){
			 	string x = "";
			 	int count2 = 5;
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