using System;		
using CompanyManagement.Models;	
public class Program
{
	public static void Main()
	{
                Client chad = new Client("Chad ", "Gigachad@google.com");
                Console.WriteLine(chad.GetSummary());

                Client stacy = new Client("Stacy", "BakerStacy@yahoo.com");
                Console.WriteLine(stacy.GetSummary());

                stacy.Deactivate();
                Console.WriteLine("After deactivation:");
                Console.WriteLine(stacy.GetSummary());

	}
}