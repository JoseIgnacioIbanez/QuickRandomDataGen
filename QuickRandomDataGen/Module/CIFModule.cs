using System;
using System.IO;
using System.Net.Http;

namespace QuickRandomDataGen.Module
{
	public class CIFModule : BaseRandLabel
	{
		HttpClient _client = new HttpClient();

		public CIFModule()
		{
			LabelText = "CIF";
		}

		internal async override void GenerateText()
		{
			MainText = "Loading...";
			string response = await _client.GetStringAsync("https://api.generadordni.es/v2/doi/cif?results=1");
			MainText = response[2..^2];
		}
	}
}
