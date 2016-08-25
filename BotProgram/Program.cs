/*
 * Created by SharpDevelop.
 * User: HORLAARSMAN
 * Date: 8/25/2016
 * Time: 2:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BotProgram
{
	class Program
	{
		public static void Main(string[] args)
		{
			string name;
			string greet;
			
			Console.WriteLine("Hello, Thanks for chating with me, i am a robot, ");
	Console.WriteLine("I promise you this chat wont be boring");
	Console.WriteLine("__________________________________________");
	Console.WriteLine("Enter Your Name");
	name = Console.ReadLine();
	Console.WriteLine("__________________________________________");
	Console.WriteLine("Hello {0}, can you please tell me what", name);
	Console.WriteLine("part of the day we are right now?");
	Console.WriteLine("Morning, afternoon, Or Night");
	Console.WriteLine("__________________________________________");
	greet = Console.ReadLine();
	
	if (greet.ToLower() == "morning")
	{
		Console.WriteLine("Good Morning {0}, and how was your night?", name);
		Console.WriteLine("you dont even need to tell me, i no it is fine");
	} else if (greet == "afternoon") {
		Console.WriteLine("Good Afternoon {0},", name);
		Console.WriteLine("I hope the sun is not too much today");
	} else if (greet == "night") {
		Console.WriteLine("Good Evening {0}, How has been you day", name);
		Console.WriteLine("Hope it not that stresfull");
		Console.WriteLine("__________________________________________");
	} else	{ Console.WriteLine("Oh!!! {0} How can that be?", name);
	}
	Console.WriteLine("__________________________________________");
	Console.WriteLine("So {0} are you Male or Female?", name);
	string gender = Console.ReadLine();
	if (gender == "male") {
		Console.WriteLine("Whaoo, Do you no i love guyz?");
		Console.WriteLine(" Now tell me how many girl friends do you have");	
	} else {
		Console.WriteLine("Oh My God i cant believe i am chating with a female");	
		Console.WriteLine("Well {0}, Thanks for chating with me");
		Console.WriteLine("I dont have anything on my brain about female");
		Console.WriteLine("I am sorry....Please press QUIT CHAT and press enter to cancel");
	}
	
	
	
	
	
	Console.WriteLine();
		Console.ReadKey(false);
		}
	}
}