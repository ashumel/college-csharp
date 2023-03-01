namespace Lab12;

public static class Replace
{
	public static string CharInString(string str, int index, char symbol) => 
		str.Remove(index).Insert(index, symbol.ToString());

	public static string CharInString(string str, char oldChar, char newChar) => 
		str.Replace(oldChar, newChar);
		
	public static string CharInString(string str, int index) =>
		str.Remove(index).Insert(index, " ");

	public static string CharInString(string str, char symbol) =>
		str.Replace(symbol.ToString(), " ");
}