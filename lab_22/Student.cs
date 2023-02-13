namespace lab_22;

public class Student : IComparable<Student>
{
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	public int Age { get; private set; }

	public Student(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}

	public int CompareTo(Student? other) => 
		Age - other!.Age;

	public override string ToString() => 
		$"First name: {FirstName} | Last name: {LastName} | Age: {Age}";
}