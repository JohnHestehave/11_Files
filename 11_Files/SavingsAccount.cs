using System;

namespace _11_Files
{
	internal class SavingsAccount : Asset
	{
		public string AccountName;
		public double Value;
		public double InterestRate;

		public SavingsAccount(string name, double value, double interest)
		{
			AccountName = name;
			Value = value;
			InterestRate = interest;
		}

		public override string ToString()
		{
			return "SavingsAccount[value="+this.Value.ToString("##.0", System.Globalization.CultureInfo.GetCultureInfo("en-GB"))+",interestRate="+this.InterestRate.ToString("##.#", System.Globalization.CultureInfo.GetCultureInfo("en-GB"))+"]";
		}

		internal void ApplyInterest()
		{
			double procent = (InterestRate / 100) + 1;
			Value = Value * procent;
		}

		
		public double GetValue()
		{
			return Value;
		}

		public string GetName()
		{
			return AccountName;
		}

	}
}