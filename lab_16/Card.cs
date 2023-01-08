namespace lab_16;

public class Card
{
	private delegate void WarningInConsole();
	private event WarningInConsole LimitReached;
	private event WarningInConsole LimitRedemption;
	
	private double _balance;
	private readonly double _limit;
	private readonly string _cardholder;
	
	public Card(string cardholder, double balance, double limit)
	{
		_cardholder = cardholder;
		_balance = balance;
		_limit = limit;
		LimitReached += ShowMessageLimitReached;
		LimitRedemption += ShowMessageRedemption;
	}

	private static void ShowMessageLimitReached()
	{
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.WriteLine("Limit has been reached!");
		Console.ResetColor();
	}

	private static void ShowMessageRedemption()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Good! Limit has been repaid!");
		Console.ResetColor();
	}

	public void Show()
	{
		Console.WriteLine("--- Card Info ---\n" +
		                  $"Balance: {_balance}\n" +
		                  $"Limit: {_limit}\n" +
		                  $"Cardholder: {_cardholder}");
	}

	public void Put(double count)
	{
		if ((_balance <= _limit) && (_balance + count) > _limit)
			LimitRedemption?.Invoke();
		_balance += count;
		Console.WriteLine($"Account successfully replenished. Balance: {_balance}");
		
	}

	public void Pay(double count)
	{
		if (_balance - count < 0)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("The operation has been cancelled. There are not enough funds on the card.");
			Console.ResetColor();
			return;
		}
		if (_balance - count <= _limit)
			LimitReached?.Invoke();
		_balance -= count;
		Console.WriteLine($"Successfully withdrawn from account. Balance: {_balance}");
	}
}