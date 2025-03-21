﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class OrderController : Controller
	{
		private readonly IServiceManager _manager;

		public OrderController(IServiceManager manager)
		{
			_manager = manager;
		}

		public ActionResult Index()
		{
			var order = _manager.OrderService.Orders;
			return View(order);
		}

		[HttpPost]
		public IActionResult Complete([FromForm] int id)
		{
			_manager.OrderService.Complete(id);
			return RedirectToAction("Index");
		}
	}
}
