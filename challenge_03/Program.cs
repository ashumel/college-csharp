namespace challenge_03;

public static class Program
{
	public static void Main()
	{
		Console.WriteLine("-- Sign in -- ");
		Console.Write("Login: ");
		var login = Console.ReadLine();
		Console.Write("Password: ");
		var password = Console.ReadLine();
		var users = GetUsers();
		User? userObj = null;
		foreach (var user in users)
		{
			if (user.Login != login) continue;
			if (user.Password != password)
			{
				Console.WriteLine("Wrong password!");
				break;
			}
			Console.WriteLine("Complete!");
			userObj = user;
			break;
		}
		if (userObj is null) Console.WriteLine("Not exist");
	}

	private static IEnumerable<User> GetUsers() => 
		File.ReadAllLines("C:\\folder\\users.txt")
			.Select(User.GetUser);
}