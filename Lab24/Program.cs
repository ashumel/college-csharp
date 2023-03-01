namespace Lab24;

public static class Program
{
	private static Random _random = new Random();
	
	public static void Main()
	{
		Task1();
		Task2();
		Task4();
	}

	public static void Task1()
	{
		var currentThread = Thread.CurrentThread;
		var name = currentThread.Name;
		var priority = currentThread.Priority;
		var state = currentThread.ThreadState;
		
		Console.WriteLine(
			"Current thread:\n" +
			"Name: {0} | Priority: {1} | State: {2}", name, priority, state);
		
		Console.Write("Enter thread name: ");
		var threadName = Console.ReadLine() ?? String.Empty;

		
		var newThread = new Thread(() => Console.WriteLine("Hello, world!"));
		newThread.Name = threadName;
		newThread.Start();
		
		name = newThread.Name;
		priority = newThread.Priority;
		state = newThread.ThreadState;

		Console.WriteLine(
			"Current thread:\n" +
			"Name: {0} | Priority: {1} | State: {2}", name, priority, state);
	}

	public static void Task2()
	{
		static void CountNumbers()
		{
			for (var i = 1; i <= 20; i++)
			{
				Console.WriteLine(i);
				Thread.Sleep(1000);
			}
		}
		
		var thread = new Thread(CountNumbers);
		Console.WriteLine("Thread status: {0}", thread.ThreadState);
		thread.Start();
		Console.WriteLine("Thread status: {0}", thread.ThreadState);

		while (thread.IsAlive)
		{
			Console.WriteLine("Thread status: {0}", thread.ThreadState);
			Thread.Sleep(100);
		}
	}

	public static void Task4()
	{
		
		var player = new Player(100);
		
		var attackThread = new Thread(() => Attack(player));
		var healThread = new Thread(() => Heal(player));
		
		attackThread.Start();
		healThread.Start();
		
		while (player.IsAlive) 
			Thread.Sleep(1000);
		
		attackThread.Join();
		healThread.Join();
		
		Console.WriteLine("Game over!");

	}
	
	private static void Attack(Player player)
	{
		while (player.IsAlive)
		{
			var damage = _random.Next(60, 100);
			player.Health -= damage;
			Console.WriteLine("Вы атакованы. Ущерб {0} Здоровье {1}", damage, player.Health);
			Thread.Sleep(2000);
		}
	}

	private static void Heal(Player player)		
	{
		while (player.IsAlive)
		{
			var heal = _random.Next(0, 21);
			player.Health += heal;
			Console.WriteLine("Восстановлено {0}% здоровья. Здоровье {1}", heal, player.Health);
			Thread.Sleep(3000);
		}
	}
}