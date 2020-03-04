using System;
using System.Linq;
using System.Text.RegularExpressions;
public class OneLineSolution {
	static public void Main() {
		Enumerable.Range(0, int.Parse(Console.ReadLine())).ToList().ForEach(c => Console.WriteLine(Regex.Matches(Console.ReadLine(), "((?'Open'\\()+(?'Close-Open'\\))+)*(?(Open)(?!))", RegexOptions.Compiled).Cast<Match>().Max(m => m.Length)));
	}
}