﻿using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class CategoryManager : ICategoryService
	{
		private readonly IRepositoryManagaer _manager;

		public CategoryManager(IRepositoryManagaer manager)
		{
			_manager = manager;
		}

		public IEnumerable<Category> GetAllCategories(bool trackChanges)
		{
			return _manager.Category.FindAll(trackChanges);
		}
	}
}
