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
			int iata = Random.Shared.Next(1, 9_999_999);
			int check = iata % 7;
			MainText = $"{iata:0000000}{check}";
		}
	}
}
