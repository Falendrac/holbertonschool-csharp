using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Substring(str.IndexOf("object-oriented"), 16).Replace(",", " ") + str.Substring(str.IndexOf("programming"), 12) + str.Substring(str.IndexOf("in "), 3) + str.Substring(str.IndexOf("C#"), 2);
		Console.WriteLine(str);
        }
}
