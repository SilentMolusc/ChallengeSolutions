using System;
using System.Collections.Generic;
public class FastSolution {
	static public void Main() {
		string caseCount = Console.ReadLine();
		for (int c = 0; c < int.Parse(caseCount); c++) {
			string input = Console.ReadLine();
			Stack<int> open = new Stack<int>();
			Stack<int> close = new Stack<int>();
			Stack<int> results = new Stack<int>();
			for (int i = 0; i < input.Length; i++) {
				if (input[i] == '(') {
					open.Push(i);
				}
				else {
					if (open.Count == 0) {
						int result = 0;
						while (close.Count != 0) {
							int end = close.Pop();
							int start = close.Pop();
							result += end - start + 1;
						}
						results.Push(result);
						continue;
					}
					int s = open.Pop();
					while (close.Count != 0) {
						int prevEnd = close.Pop();
						if (prevEnd > s) {
							close.Pop();
						}
						else {
							close.Push(prevEnd);
							break;
						}
					}
					close.Push(s);
					close.Push(i);
				}
			}
			if (close.Count != 0) {
				int result = 0;
				int unclosed = open.Count != 0 ? open.Pop() : -1;
				while (close.Count != 0) {
					int end = close.Pop();
					int start = close.Pop();
					while (unclosed > end) {
						if (result == 0) {
							unclosed = open.Count != 0 ? open.Pop() : -1;
						}
						else {
							unclosed = open.Count != 0 ? open.Pop() : -1;
							results.Push(result);
							result = 0;
						}
					}
					result += end - start + 1;
				}
				results.Push(result);
			}
			int finalR = 0;
			while (results.Count != 0) {
				int r = results.Pop();
				if (r > finalR) {
					finalR = r;
				}
			}
			Console.WriteLine(finalR);
		}
	}
}