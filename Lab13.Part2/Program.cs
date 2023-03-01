namespace Lab13.Part2;

internal static class Program
{
	private static void ShowList(ISalary subject) => Console.Write(
		$"\n{subject.FirstName} {subject.LastName}, к выдаче {subject.Get()} руб.");
	public static void Main(string[] args)
	{
		var workers = new ISalary[]
		{
			new Engineer(
				firstName: "Александр",
				lastName: "Смирнов",
				salary: 1400.2),
			new Engineer(
				firstName: "Никита",
				lastName: "Симонов",
				salary: 1200.2),
			new Handyman(
				firstName: "Дмитрий",
				lastName: "Петров",
				salary: 700.4)
		};
		foreach (var subject in workers)
			ShowList(subject);
	}
}