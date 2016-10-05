using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _11_Files
{
	class StockIO
	{
		public void WriteStock(StringWriter sw, Stock hp)
		{
			string NL = Environment.NewLine;
			sw.Write(hp.Symbol + NL + hp.PricePerShare + NL + hp.NumShares + NL);
			sw.Close();
		}

		public Stock ReadStock(StringReader data)
		{
			string line = data.ReadLine();
			double line2 = Convert.ToDouble(data.ReadLine());
			double line3 = Convert.ToDouble(data.ReadLine());
			data.Close();
			return new Stock(line, line2, line3);
		}

		public void WriteStock(FileInfo file, Stock hp)
		{
			string NL = Environment.NewLine;
			StreamWriter sw = file.CreateText();
			sw.Write(hp.Symbol + NL + hp.PricePerShare + NL + hp.NumShares + NL);
			sw.Close();

		}

		public Stock ReadStock(FileInfo data)
		{
			StreamReader sr = data.OpenText();
			string line = sr.ReadLine();
			double line2 = Convert.ToDouble(sr.ReadLine());
			double line3 = Convert.ToDouble(sr.ReadLine());
			sr.Close();
			return new Stock(line, line2, line3);
		}
	}
}