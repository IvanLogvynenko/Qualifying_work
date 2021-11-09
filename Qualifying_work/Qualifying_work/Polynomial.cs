﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class Monomial
	{
		readonly private double Multiplier;
		readonly private double Power;
		readonly CountingFunction Function;
		readonly private Polynomial InnerPolynomial;
		readonly private bool IsEnd;
		public string Text { get; }
		public double YCounter(double x)
		{
			if (!IsEnd)
			{
				if (this.Multiplier == 1)
				{
					return Math.Pow(this.Function.Counter(this.InnerPolynomial.YCounter(x)), this.Power);
				}
				else
				{
					return Math.Pow(this.InnerPolynomial.YCounter(x), this.Power) * this.Multiplier;
				}
			}
			else
			{
				if (IsNumber(this.Text))
				{
					return Math.Pow(this.Multiplier, this.Power);
				}
				else
				{
					if (Multiplier == 1)
					{
						return Math.Pow(this.Function.Counter(x), this.Power);
					}
					else
					{
						return Math.Pow(this.Multiplier * x, this.Power);
					}
				}
			}
		}
		public Monomial(string input)
		{
			input = input.Replace(" ", "");
			input = input.Replace(".", ",");
			this.Function = new CountingFunction();
			string Multiplier = "", Function = "", Power = "";
			foreach (char item in input)
			{
				if (item == '*' || item == '(')
				{
					break;
				}
				Multiplier += item;
			}
			bool b = false;
			int breckets = 0;
			foreach (char item in input)
			{
				if (item == '(')
				{
					breckets++;
				}
				if (item == ')')
				{
					breckets--;
				}
				if (b)
				{
					Power += item;
				}
				if (item.Equals('^') && breckets == 0)
				{
					b = true;
					Power = "";
				}
			}
			if (IsFunction(Multiplier))
			{
				Function = Multiplier;
				Multiplier = "1";
			}
			if (!IsNumber(Multiplier) || Multiplier.Length == 0)
			{
				Multiplier = "1";
			}
			if (!IsNumber(Power) || Power.Length == 0)
			{
				Power = "1";
			}
			this.Function = GetFunction(BreacketsCleaner(Function));
			this.Multiplier = Convert.ToDouble(BreacketsCleaner(Multiplier));
			this.Power = Convert.ToDouble(BreacketsCleaner(Power));
			this.Text = input;
			//now we have thing that will go to next level
			if (InnerText(input) == "x" || IsNumber(input))
			{
				this.IsEnd = true;
			}
			else
			{
				this.IsEnd = false;
				this.InnerPolynomial = new Polynomial(InnerText(input));
			}
		}
		private string InnerText(string input)
		{
			return BreacketsCleaner(BeforePower(AfterMultiplier(input)));
		}
		private string AfterMultiplier(string input)
		{
			string answer = "";
			int breckets = 0;
			bool b = false;
			foreach (char item in input)
			{
				if (item == '(')
				{
					breckets++;
				}
				if (item == ')')
				{
					breckets--;
				}
				if (item == '(' && !b && breckets == 1)
				{
					b = true;
				}
				if (b)
				{
					answer += item;
				}
				if (item == '*' && !b && breckets == 0)
				{
					b = true;
				}
				if (item == 'x' && breckets == 0)
				{
					answer = input;
					break;
				}
			}
			if (answer == "")
			{
				answer = input;
			}
			return answer;
		}
		private string BeforePower(string input)
		{
			string answer = "";
			int breckets = 0;
			if (input.Contains('^'))
			{
				string temp = "";
				foreach (char item in input)
				{
					if (item == '(')
					{
						breckets++;
					}
					if (item == ')')
					{
						breckets--;
					}
					if (item == '^' && breckets == 0)
					{
						answer = temp;
						temp += item;
					}
					else
					{
						temp += item;
					}
				}
			}
			else
			{
				answer = input;
			}
			return answer;
		}
		private static bool IsFunction(string input)
		{
			return input.ToLower().Contains("sin") ||
				input.ToLower().Contains("cos") ||
				input.ToLower().Contains("tg") ||
				input.ToLower().Contains("ctg") ||
				input.ToLower().Contains("arcsin") ||
				input.ToLower().Contains("arccos") ||
				input.ToLower().Contains("arctg") ||
				input.ToLower().Contains("arcctg");
		}
		private static CountingFunction GetFunction(string input)
		{
			if (input.ToLower().Contains("sin"))
			{
				return new Sinus();
			}
			else
			{
				if (input.ToLower().Contains("cos"))
				{
					return new Cosinus();
				}
				else
				{
					if (input.ToLower().Contains("tg"))
					{
						return new Tangens();
					}
					else
					{
						if (input.ToLower().Contains("ctg"))
						{
							return new Cotangens();
						}
						else
						{
							if (input.ToLower().Contains("arcsin"))
							{
								return new Arcsinus();
							}
							else
							{
								if (input.ToLower().Contains("arccos"))
								{
									return new Arccosinus();
								}
								else
								{
									if (input.ToLower().Contains("arctg"))
									{
										return new Arctangens();
									}
									else
									{
										if (input.ToLower().Contains("arcctg"))
										{
											return new Arccotangens();
										}
										else
										{
											return new CountingFunction();
										}
									}
								}
							}
						}
					}
				}
			}
		}
		public static bool IsNumber(string input)
		{
			foreach (char item in input)
			{
				if (!char.IsDigit(item) && item != '-' && item != ',' && item != '(' && item != ')')
				{
					return false;
				}
			}
			return true;
		}
		private string BreacketsCleaner(string input)
		{
			if (input.Length > 2)
			{
				string newInput = "", prevInput = input;
				while (prevInput.StartsWith("(") && prevInput.EndsWith(")"))
				{
					for (int i = 1; i < prevInput.Length - 1; i++)
					{
						newInput += prevInput[i];
					}
					prevInput = newInput;
					newInput = "";
				}
				return prevInput;
			}
			else
			{
				return input;
			}
		}
	}
	public class Polynomial
	{
		Monomial[] Monomials { get; }
		public string PolynomialText { get; }
		public Polynomial(string input)
		{
			input = input.Replace(" ", "");
			input = input.Replace(".", ",");
			this.PolynomialText = input;
			this.Monomials = this.Separator(input);
		}
		public double YCounter(double x)
		{
			double answer = 0;
			foreach (Monomial item in this.Monomials)
			{
				answer += item.YCounter(x);
			}
			return answer;
		}
		private Monomial[] Separator(string input)
		{
			List<Monomial> sep = new List<Monomial>();
			string temp = "";
			int brackets = 0;
			foreach (char item in input)
			{
				if (item == '(')
				{
					brackets++;
				}
				if (item == ')')
				{
					brackets--;
				}
				if ((item == '+' || item == '-') && brackets == 0)
				{
					sep.Add(new Monomial(temp));
					if (item == '+')
					{
						temp = "";
					}
					else
					{
						temp = "-";
					}
				}
				else
				{
					temp += item;
				}
			}
			sep.Add(new Monomial(temp));
			return sep.ToArray();
		}
	}
}
