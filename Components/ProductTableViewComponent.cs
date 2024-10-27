using Microsoft.AspNetCore.Mvc;
using Lr9.Net.Models;
using System.Collections.Generic;

namespace Lr9.Net.Components
{
	public class ProductTableViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(List<Product> products)
		{
			return View(products);
		}
	}
}
