using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickRandomDataGen.Module
{
	/// <summary>
	/// Interaction logic for BaseRandLabel.xaml
	/// </summary>
	public abstract partial class BaseRandLabel : UserControl, INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		private string _LabelText;

		public string LabelText
		{
			get { return _LabelText; }
			set { _LabelText = value; OnPropertyChanged(nameof(LabelText)); }
		}


		private string _MainText = "";

		public string MainText
		{
			get { return _MainText; }
			set { _MainText = value; OnPropertyChanged(nameof(MainText)); }
		}

		public BaseRandLabel()
		{
			InitializeComponent();
			this.DataContext = this;
			GenerateText();
		}

		private void CopyToClipboard(object sender, RoutedEventArgs e)
		{
			Clipboard.SetText(MainText);
		}

		private void Regenerate(object sender, RoutedEventArgs e)
		{
			GenerateText();
		}

		internal abstract void GenerateText();
	}
}
