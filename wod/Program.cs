namespace egg
{
	using System;
	using Npgsql;

	public class Program
	{
		public static int Main(string[] args)
		{
			using(var conn = new NpgsqlConnection("Host=localhost;Username=drusellers;Password=;Database=egg;"))
			{
				conn.Open();

				using(var cmd = new NpgsqlCommand())
				{
					cmd.Connection = conn;

					cmd.CommandText = "SELECT fib(2)";
					var i = cmd.ExecuteScalar();
					Console.WriteLine(i);
				}
			}
			Console.WriteLine("hi");
			return 0;
		}
	}
}
