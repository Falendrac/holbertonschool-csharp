using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
        var myFormat = new System.Globalization.CultureInfo("en-US");
		Console.WriteLine(string.Format(myFormat,"Percent: {0:0.00%}\nCurrency: {1:C}", percent, currency));
	}
}
