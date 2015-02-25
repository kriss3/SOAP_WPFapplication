using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebService
{
	/// <summary>
	/// This SOAP Service will have 5 WebMethods to be exposed via proxy
	/// different clients (C#, ASP.Net page, Java) should be able to "tap" into those methods
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/", 
		Description = "A Simple Web Calculator Service",
		Name = "CalculatorWebService")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class MyService : System.Web.Services.WebService
	{
		[WebMethod]
		public int Add(int x, int y)
		{
			return x + y;
		}

		[WebMethod]
		public int Subtract(int x, int y)
		{
			return x - y;
		}

		[WebMethod]
		public int Multiply(int x, int y)
		{
			return x * y;
		}

		[WebMethod]
		public double Divide(double x, double y)
		{
			if (y == 0)
			{
				throw new ArithmeticException("Please check the argument passed to the method, the value is: " + y);
			}
			else
			{
				return x / y;
			}
		}

		[WebMethod]
		public string GetMyString(string messageValue)
		{
			return messageValue.ToUpperInvariant();
		}
	}
}