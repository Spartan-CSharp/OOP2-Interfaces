namespace ConsoleUI
{
	internal class Person : IRun
	{
		internal string FirstName
		{
			get; set;
		}
		internal string LastName
		{
			get; set;
		}
		internal string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public string StartRunning()
		{
			return $"{FullName} starts running.";
		}

		public string StopRunning()
		{
			return $"{FullName} stops running.";
		}
	}
}
