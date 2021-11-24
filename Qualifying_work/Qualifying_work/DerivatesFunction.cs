using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualifying_work
{
	public class DerivatesFunction
	{
		public double Counter(double x)
        {
			try { return x; } catch (OverflowException) { throw; }
		}
	}
	 
}
