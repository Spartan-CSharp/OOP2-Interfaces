using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			List<IRun> runs = new List<IRun>();

			Person tim = new Person { FirstName = "Tim", LastName = "Corey" };
			Person sue = new Person { FirstName = "Sue", LastName = "Storm" };
			Animal meatball = new Animal { Name = "Meatball" };
			Animal lizzy = new Animal { Name = "Lizzy" };

			runs.Add(tim);
			runs.Add(sue);
			runs.Add(meatball);
			runs.Add(lizzy);

			foreach ( IRun run in runs )
			{
				Console.WriteLine(run.StartRunning());
			}

			Console.WriteLine();

			foreach ( IRun run in runs )
			{
				Console.WriteLine(run.StopRunning());
			}

			_ = Console.ReadLine();
		}
	}
}
