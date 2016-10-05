using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Files
{
	public class Portfolio
	{
		public List<Asset> Stocks = new List<Asset>();

		public Portfolio()
		{

		}
		public Portfolio(List<Asset> stocks)
		{
			Stocks = stocks;
		}
		public double GetTotalValue()
		{
			double total = 0;
			foreach(Asset stock in Stocks)
			{
				total += stock.GetValue();
			}
			return total;
		}

		public void AddAsset(Asset asset)
		{
			Stocks.Add(asset);
		}
		public IList<Asset> GetAssets()
		{
			IReadOnlyList<Asset> assets = new ReadOnlyCollection<Asset>(Stocks);
			return (IList<Asset>)assets;
		}

		public Asset GetAssetByName(string name)
		{
			foreach (Asset item in Stocks)
			{
				if (item.GetName() == name)
				{
					return item;
				}
			}
			return null;
		}

		public IList<Asset> GetAssetsSortedByName()
		{ 
			Dictionary<string, Asset> assets = new Dictionary<string, Asset>();
			foreach (Asset a in Stocks)
			{
				assets.Add(a.GetName(), a);
			}
			List<string> sorter = new List<string>(assets.Keys);
			sorter.Sort();
			List<Asset> newList = new List<Asset>();
			foreach (var item in sorter)
			{
				newList.Add(assets[item]);
			}
			
			return newList;
		}

		public IList<Asset> GetAssetsSortedByValue()
		{
			Dictionary<double, Asset> assets = new Dictionary<double, Asset>();
			foreach (Asset a in Stocks)
			{
				assets.Add(a.GetValue(), a);
			}
			List<double> sorter = new List<double>(assets.Keys);
			sorter.Sort();
			sorter.Reverse();
			List<Asset> newList = new List<Asset>();
			foreach (var item in sorter)
			{
				newList.Add(assets[item]);
			}

			return newList;
		}
		
	}
}
