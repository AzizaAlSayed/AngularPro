using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularPro.Models;
using AngularPro.Repository;
using AngularPro.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoriesRepository categoriesRepository, IMapper mapper)
        {
            _categoriesRepository = categoriesRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult index()
        {
            var category = _categoriesRepository.GetAllCategories();
            return Ok(_mapper.Map<IEnumerable<CategoriesVM>>(category));
        }

        [HttpGet("{CategoryId}")]
        public IActionResult GetCategory(int CategoryId)
        {
            var category = _categoriesRepository.GetCategory(CategoryId);
            return Ok(_mapper.Map<CategoriesVM>(category));

        }

        [HttpPost]
        public IActionResult Create([FromBody] CategoriesVM Category)
        {
            var category = _mapper.Map<Categories>(Category);  
            _categoriesRepository.CreateCategories(category);
            return Ok(category);
        }

        [HttpDelete("{CategoryId}")]
        public IActionResult Delete(int CategoryId)
        {
            var category = _categoriesRepository.GetCategory(CategoryId);
            if (category == null) return NotFound();
            _categoriesRepository.Delete(CategoryId);
            return Ok();
        }

        [HttpPut("{CategoryId}")]
        public IActionResult Update(int CategoryId, [FromBody] CategoriesVM Category)
        {
            //to update any attribute in category by id
            var category = _categoriesRepository.GetCategory(CategoryId);
            if (category == null) return NotFound();
            _mapper.Map(Category, category);
            _categoriesRepository.Update(category);
            return Ok(_mapper.Map<CategoriesVM>(category));
        }

    }
}

