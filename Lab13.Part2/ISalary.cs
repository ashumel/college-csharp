namespace Lab13.Part2;

public interface ISalary
{
	string FirstName { get; }
	string LastName { get; }
	double Salary { get; }
	double Get();
}

public class Handyman : ISalary
{
	public Handyman(string firstName, string lastName, double salary)
	{
		FirstName = firstName;
		LastName = lastName;
		Salary = salary;
	}

	public string FirstName { get; }
	public string LastName { get; }
	public double Salary { get; }
	public double Get() => Salary + Salary * 0.1;
}

public class Engineer : ISalary
{
	public Engineer(string firstName, string lastName, double salary)
	{
		FirstName = firstName;
		LastName = lastName;
		Salary = salary;
	}

	public string FirstName { get; }
	public string LastName { get; }
	public double Salary { get; }
	public double Get() => Salary + Salary * 0.5;
}