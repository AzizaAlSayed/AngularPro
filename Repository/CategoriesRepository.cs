using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public class CategoriesRepository:ICategoriesRepository
    {
        masterContext _context;

        public CategoriesRepository(masterContext context)
        {
            _context = context;
        }

        public Categories GetCategory(int CategoryId)
        {
            Categories categories = _context.Categories.Find(CategoryId);
            return categories;
        }

        public Categories CreateCategories(Categories Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            return Category;
        }

        public Categories Delete(int CategoryId)
        {
            Categories categories = _context.Categories.Find(CategoryId);
            if (categories != null)
            {
                _context.Categories.Remove(categories);
                _context.SaveChanges();
            }
            return categories;
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            return _context.Categories;
        }

        public Categories Update(Categories Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            return Category;
        }
    }
}
