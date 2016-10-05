using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
	interface IStockRepository
	{
		int NextId();
		void SaveStock(Stock a);
		Stock LoadStock(long id);
		List<Asset> FindAllStocks();
		void Clear();
	}
}
