using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class Monomial
	{
		readonly private double multiplier;
		readonly private double power;
		readonly private CountingFunction function;
		readonly private Polynomial innerPolynomial;
		readonly private bool isEnd;
		//readonly private bool IsSegmentated;
		public double Multiplier { get { return multiplier; } }
		public double Power { get { return power; } }
		public Polynomial InnerPolynomial { get { return innerPolynomial; } }
		public string Text { get; }
		public bool IsEnd { get { return isEnd; } }
		public CountingFunction Function { get { return function; } }
		public double YCounter(double x)
		{
			try
			{
				if (!isEnd)
				{
					if (this.multiplier == 1)
					{
						return Math.Pow(this.function.Counter(this.innerPolynomial.YCounter(x)), this.power);
					}
					else
					{
						return Math.Pow(this.innerPolynomial.YCounter(x), this.power) * this.multiplier;
					}
				}
				else
				{
					if (IsNumber(this.Text))
					{
						return Math.Pow(this.multiplier, this.power);
					}
					else
					{
						if (multiplier == 1)
						{
							return Math.Pow(this.function.Counter(x), this.power);
						}
						else
						{
							return Math.Pow(this.multiplier * x, this.power);
						}
					}
				}
			}
			catch (OverflowException) { return 0; }
		}
		public Monomial(string input)
		{
			input = input.Replace(" ", "");
			input = input.Replace(".", ",");
			this.function = new CountingFunction();
			string multiplier = "", function = "", power = "";
			this.isEnd = false;
			bool IsSegmentated = false;
			foreach (char item in input)
			{
				if (item == '*' || item == '(')
				{
					break;
				}
				if (item == '/')
				{
					IsSegmentated = true;
					break;
				}
				multiplier += item;
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
					power += item;
				}
				if (item.Equals('^') && breckets == 0)
				{
					b = true;
					power = "";
				}
			}
			if (Isfunction(multiplier))
			{
				function = multiplier;
				multiplier = "1";
			}
			if (!IsNumber(multiplier) || multiplier.Length == 0)
			{
				multiplier = "1";
			}
			if (!IsNumber(power) || power.Length == 0)
			{
				power = "1";
			}
			if (IsSegmentated)
			{
				this.function = new Segmentator(Convert.ToDouble(multiplier));
				this.multiplier = 1;
			}
			else
			{
				this.function = Getfunction(BreacketsCleaner(function));
				this.multiplier = Convert.ToDouble(BreacketsCleaner(multiplier));
			}
			this.power = Convert.ToDouble(BreacketsCleaner(power));
			this.Text = input;
			string innerText = InnerText(input);
			//now we have thing that will go to next level
			if (innerText.Equals("x") || IsNumber(input))
			{
				this.isEnd = true;
			}
			else
			{
				this.isEnd = false;
				this.innerPolynomial = new Polynomial(innerText);
			}
		}
		private string InnerText(string input)
		{
			if (this.power == 1)
			{
				return BreacketsCleaner(Aftermultiplier(input));
			}
			else
			{
				return BreacketsCleaner(Beforepower(Aftermultiplier(input)));
			}
		}
		private string Aftermultiplier(string input)
		{
			string answer = "";
			int breckets = 0;
			bool b = false;
			if (this.multiplier != 1)
			{
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
			}
			else
			{
				foreach (char item in input)
				{
					if (item == '(' && !b && breckets == 0)
					{
						b = true;
					}
					if (item == '(')
					{
						breckets++;
					}
					if (b)
					{
						answer += item;
					}
					if (item == ')')
					{
						breckets--;
						if (breckets == 0)
						{
							break;
						}
					}

					if (item == 'x' && breckets == 0)
					{
						answer = input;
						break;
					}
				}
			}
			if (answer == "")
			{
				answer = input;
			}
			return answer;
		}
		private string Beforepower(string input)
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
		private static bool Isfunction(string input)
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
		private static CountingFunction Getfunction(string input)
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
}
