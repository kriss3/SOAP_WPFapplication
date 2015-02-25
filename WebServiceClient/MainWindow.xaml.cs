using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebServiceClient
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			txtBox1.Text = string.Empty;
			txtBox2.Text = string.Empty;
			
		}

		private string GetTxtFromRichTextBox(RichTextBox rbx)
		{
			var val = new TextRange(rbx	.Document.ContentStart, rbx.Document.ContentEnd);
			return val.Text;
		}

		private string GetResults(string val1, string val2, int function)
		{
			MyServiceReference.CalculatorWebServiceSoapClient client = new MyServiceReference.CalculatorWebServiceSoapClient();

			int a, b;
			string result = string.Empty; ;


			if (!int.TryParse(val1, out a))
			{
				lblResults.Content = "Something wrong with the first argument";
				return string.Empty;
			}


			if (!int.TryParse(val2, out b))
			{
				lblResults.Content = "Something wrong with the second argument";
				return string.Empty;
			}

			try
			{
				switch (function)
				{
					case 0:
						result = val1 + " + " + val2 + " = " + client.Add(a, b);
						break;
					case 1:
						result = val1 + " - " + val2 + " = " + client.Subtract(a, b);
						break;
					case 2:
						result = val1 + " * " + val2 + " = " + client.Multiply(a, b);
						break;
					case 3:
						result = val1 + " / " + val2 + " = " + client.Divide(a, b);
						break;
					case 4:
						result = client.GetMyString(GetTxtFromRichTextBox(rTxtBoxOne));
						break;
					default:
						result = "Wrong function picked !!!";
						break;
				}

			}
			catch (Exception e)
			{
				MessageBox.Show("Cannot divide by 0\n" + e.Message);
				throw;
			}

			return result;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (txtBox1.Text != string.Empty && txtBox2.Text != string.Empty)
			{
				lblResults.Content = GetResults(txtBox1.Text, txtBox2.Text, cbFunctions.SelectedIndex);
			}
		}

	}
}
