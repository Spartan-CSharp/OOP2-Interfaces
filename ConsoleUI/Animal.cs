namespace ConsoleUI
{
	internal class Animal : IRun
	{
		internal string Name
		{
			get; set;
		}

		public string StartRunning()
		{
			return $"{Name} starts running.";
		}

		public string StopRunning()
		{
			return $"{Name} stops running.";
		}
	}
}
