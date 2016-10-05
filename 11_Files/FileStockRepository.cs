using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace _11_Files
{
	public class FileStockRepository : IStockRepository, IFileRepository
	{
		private int id = 0;
		private DirectoryInfo repositoryDir;
		public FileStockRepository(DirectoryInfo repositoryDir)
		{
			this.repositoryDir = repositoryDir;
		}
		public int NextId()
		{
			id++;
			return id;
		}

		public void SaveStock(Stock a)
		{
			a.Id = NextId();
			StreamWriter writer = new StreamWriter(repositoryDir+"\\stock"+a.Id+".txt");
			writer.WriteLine(a.ToString());
			writer.Close();
		}

		public Stock LoadStock(long id)
		{
			StreamReader reader = new StreamReader(repositoryDir+"\\stock"+id+".txt");
			string line = reader.ReadLine();
			reader.Close();
			string[] lines = line.Split(',');

			int line1 = lines[0].IndexOf('=');
			string stockname = lines[0].Substring(line1+1);

			int line2 = lines[1].IndexOf('=');
			string price = lines[1].Substring(line2+1);

			int line3 = lines[2].IndexOf('=');
			string num = lines[2].Substring(line3+1).TrimEnd(']');

			//Assert.AreEqual("", stockname+"_"+price+"_"+num);

			Stock stock = new Stock(stockname, Convert.ToDouble(price.Replace(".", ",")), Convert.ToDouble(num.Replace(".", ",")));
			stock.Id = Convert.ToInt32(id);
			return stock;
			
		}

		public List<Asset> FindAllStocks()
		{
			int count = repositoryDir.GetFiles().Length;
			List<Asset> assets = new List<Asset>();
			for (int i = 1; i <= count; i++)
			{
				Stock a = LoadStock(i);
				assets.Add(a);
			}
			return assets;
		}

		public void Clear()
		{
			foreach(FileInfo file in repositoryDir.GetFiles())
			{
				file.Delete();
			}
		}

		public string StockFileName(long id)
		{
			return "stock"+id+".txt";
		}

		public string StockFileName(Stock stock)
		{
			return "stock"+stock.Id+".txt";
		}
	}
}
