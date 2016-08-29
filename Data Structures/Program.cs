/*
 * Created by SharpDevelop.
 * User: JustFaith
 * Date: 8/29/2016
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

//Create a class that implements an integer list class, has an add method and uses an internal integer array to store data

namespace Data_Structures
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] numbers = new int[10];
			
			for(int i=0; i < 10; i++)
			{
				numbers[i] = i + 10;
			}
			
			
			List<int> myList = new List<int>();
			
			for(int i=0; i<10; i++){
				
				myList.Add(i + 10);
			
			}
			
		
//			numbers[0] = 10;
//			numbers[1] = 15;
//			numbers[2] = 20;
//			numbers[3] = 30;
//			numbers[4] = 35;
//			numbers[5] = 40;
//			numbers[6] = 45;
//			numbers[7] = 50;
//			numbers[8] = 60;
//			numbers[9] = 70;
//			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}