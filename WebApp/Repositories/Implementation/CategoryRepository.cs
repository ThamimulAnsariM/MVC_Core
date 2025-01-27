using DataAccessLayer;
using DataAccessLayer.Entities;
using Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DemoDbContext _context;
        public CategoryRepository()
        {
            _context = new DemoDbContext();
        }
        public IEnumerable<Category> GetAll()
        {
            var category=_context.Categories.ToList();
            return category;
        }
    }
}
