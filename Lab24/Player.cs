namespace Lab24;

public class Player
{
	private int _health;
	public bool IsAlive { get; private set; }

	public Player(int health)
	{
		_health = health;
		IsAlive = true;
	}
	
	public int Health
	{
		get => _health;
		set
		{
			_health = value;
			if (_health > 0) return;
			_health = 0;
			IsAlive = false;
		}
	}
	
	
}