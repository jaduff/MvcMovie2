using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie2.Controllers
{
	public class HelloWorldController : Controller
	{
		public string Index()
		{
			return "This is my default action...";
		}

		public string Welcome(string name, int numTimes = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}");
		}
	}
}
