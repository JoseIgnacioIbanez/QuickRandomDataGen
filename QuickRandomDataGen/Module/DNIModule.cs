﻿using System;
using System.IO;
using System.Net.Http;

namespace QuickRandomDataGen.Module
{
	public class DNIModule : BaseRandLabel
	{
		private char[] _DNILetters = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};

		public DNIModule()
		{
			LabelText = "DNI";
		}

		internal async override void GenerateText()
		{
			int number = new Random().Next(1, 99999999);
			MainText = $"{number:00000000}{_DNILetters[number % 23]}";
		}
	}
}
