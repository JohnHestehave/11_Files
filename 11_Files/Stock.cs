using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _11_Files
{
	public class Stock : Asset
	{
		public int Id;
		public string Symbol;
		public double PricePerShare;
		public double NumShares;

		public Stock()
		{

		}
		public Stock(string symbol, double price, double shares)
		{
			Symbol = symbol;
			PricePerShare = price;
			NumShares = shares;
		}
		

		public double GetValue()
		{
			return NumShares * PricePerShare;
		}
		public static double TotalValue(Stock[] stocks)
		{
			double total = 0;
			foreach (Stock stock in stocks)
			{
				total += stock.PricePerShare * stock.NumShares;
			}
			return total;
		}
		public static double TotalValue(Asset[] stocks)
		{
			double total = 0;
			foreach(Asset item in stocks)
			{
				total = total + item.GetValue();
			}
			
			return total;
		}

		public override string ToString()
		{
			return "Stock[symbol="+this.Symbol+",pricePerShare="+this.PricePerShare.ToString(CultureInfo.CreateSpecificCulture("en-GB"))+",numShares="+this.NumShares+"]";
		}
		public bool Equals(Stock obj)
		{
			if (this.Symbol == obj.Symbol && this.PricePerShare == obj.PricePerShare && this.NumShares == obj.NumShares)
			{
				return true;
			}
			return false;
		}

		public string GetName()
		{
			return Symbol;
		}
	}
}
