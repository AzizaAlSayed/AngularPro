using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public interface ICategoriesRepository
    {
        public Categories CreateCategories(Categories Category);
        public Categories Delete(int CategoryId);
        public Categories GetCategory(int CategoryId);
        public Categories Update(Categories Category);
        public IEnumerable<Categories> GetAllCategories();
    }
}
