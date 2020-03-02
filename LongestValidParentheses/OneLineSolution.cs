using System;
using System.Linq;
using System.Text.RegularExpressions;
public class OneLineSolution {
	static public void Main() {
		int caseCount = 0;
		for (int c = 0 ; c < (caseCount = caseCount == 0 ? Int32.Parse(Console.ReadLine()) : caseCount); c++) { Console.WriteLine(Regex.Matches(Console.ReadLine(), "((?'Open'\\()+(?'Close-Open'\\))+)*(?(Open)(?!))", RegexOptions.Compiled).Cast<Match>().Max(m => m.Length)); }
	}
}