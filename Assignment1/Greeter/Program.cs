// See https://aka.ms/new-console-template for more information
using System;

class Program 
{
	static void Main(string[] args)
	{
		Console.Write("Enter your full name: ");
		string fullName = Console.ReadLine();
		string cFullName = fullName.ToUpper();


		Console.Write("Enter your DOB (yyyy/MM/DD): ");
		string dobString = Console.ReadLine();
		DateTime dob = DateTime.Parse(dobString);

		Console.WriteLine($"Hello {fullName}!");
		Console.WriteLine($"Your DOB is :{dob.ToString("dddd, dd MMMM yyyy")}");
		
		 TimeSpan age = DateTime.Now - dob;
            int years = (int)(age.Days / 365.25);
            int months = (int)((age.Days % 365.25) / 30.44);
            int weeks = (int)((age.Days % 365.25) % 30.44 / 7);
            int days = (int)((age.Days % 365.25) % 30.44 % 7);

        Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
	}
}



