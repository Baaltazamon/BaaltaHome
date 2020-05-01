using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    class Calculats
    {
		public double A { get; set; }
		public double B { get; set; }
		public string Operation { get; set; }

		public double Add() => A + B;
		public double Sub() => A - B;
		public double Mul() => A * B;
		public double Del() => A / B;
		public double Pow() => Math.Pow(A, B);
		public double Qrt() => Math.Pow(A, 1/B);
		public double Log() => Math.Log(A, B);
		public double Culc()
		{
			if (Operation == "+")
				return Add();
			else if (Operation == "-")
				return Sub();
			else if (Operation == "*")
				return Mul();
			else if (Operation == "/")
				return Del();
			else if (Operation == "^")
				return Pow();
			else if (Operation == "Log")
				return Log();
			else
				return Qrt();
		}
	}
}
