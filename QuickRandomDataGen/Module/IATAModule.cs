using System;
using System.IO;
using System.Net.Http;

namespace QuickRandomDataGen.Module
{
	public class IATAModule : BaseRandLabel
	{
		public IATAModule()
		{
			LabelText = "IATA";
		}

		internal async override void GenerateText()
		{
			int iata = Random.Shared.Next(100000, 999999);
			int check = iata % 7;
			MainText = $"{iata}{check}";
		}
	}
}
