﻿using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class RepositoryManager : IRepositoryManagaer
	{
		private readonly RepositoryContext _context;
		private readonly IProductRepository _productRepository;
		private readonly ICategoryRepository _categoryRepository;
		private readonly IOrderRepository _orderRepository;


		public RepositoryManager(IProductRepository productRepository, RepositoryContext context, ICategoryRepository categoryRepository, IOrderRepository orderRepository)
		{
			_context = context;
			_productRepository = productRepository;
			_categoryRepository = categoryRepository;
			_orderRepository = orderRepository;
		}

		public IProductRepository Product => _productRepository;

		public ICategoryRepository Category => _categoryRepository;

		public IOrderRepository Order => _orderRepository;

		public void Save()
		{
			_context.SaveChanges();
		}
	}
}
