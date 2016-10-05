using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
	class MemoryStockRepository : IStockRepository
	{
		private int id;
		private List<Asset> Assets = new List<Asset>();
		public int NextId()
		{
			id++;
			return id;
		}
		public void SaveStock(Stock a)
		{
			Assets.Add(a);
		}
		public Stock LoadStock(long ID)
		{
			foreach(Stock a in Assets)
			{
				if(a.Id == ID)
				{
					return a;
				}
			}
			return null;
		}

		public List<Asset> FindAllStocks()
		{
			return Assets;
		}

		public void Clear()
		{
			Assets.Clear();
		}
	}
}
