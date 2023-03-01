namespace Challenge3;

public class User
{
	public string? Login { get; private init; }
	public string? Password { get; private init; }
	
	public override string ToString() => $"{Login};{Password}";
	
	public static User GetUser(string user)
	{
		var info = user.Split(";").ToArray();
		return new User
		{
			Login = info[0],
			Password = info[1]
		};
	}

	
}