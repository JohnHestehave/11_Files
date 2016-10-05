using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
	class StockValueComparator
	{
		public double Compare(Asset a, Asset b)
		{
			return b.GetValue().CompareTo(a.GetValue());
		}
	}
}
