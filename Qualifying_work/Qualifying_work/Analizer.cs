using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class Analizer
	{
		public Function Function { get; }
		public string DomainFunction { get { return domainFunction; } }
		readonly private string domainFunction;
		public string FunctionRange { get { return functionRange; } }
		readonly private string functionRange;
		public string IsOdd { get { return isOdd; } }
		readonly private string isOdd;
		public string IntersectionAxes { get { return intersectionAxes; } }
		readonly private string intersectionAxes;
		public string InflctionPoints { get { return inflectionPoints; } }
		readonly private string inflectionPoints;
		public Analizer(Function Function)
		{
			this.Function = Function;
		}
	}
}