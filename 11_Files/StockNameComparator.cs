using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
	class StockNameComparator
	{
		
		public int Compare(Stock a, Stock b)
		{
			return string.Compare(a.Symbol, b.Symbol);
		}

	}
}
