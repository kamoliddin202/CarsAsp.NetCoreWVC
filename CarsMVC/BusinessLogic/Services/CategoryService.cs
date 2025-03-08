using CarsMVC.BusinessLogic.Common;
using CarsMVC.BusinessLogic.DTOs.CategoryDTOs;
using CarsMVC.BusinessLogic.Interfaces;
using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.BusinessLogic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnifOfWork _unifOfWork;

        public CategoryService(IUnifOfWork unifOfWork)
        {
            _unifOfWork = unifOfWork;
        }
        public void AddCategoryDto(AddCategoryDto categoryDto)
        {
            if(categoryDto == null)
                throw new ArgumentNullException("Category was null !");

            if (string.IsNullOrEmpty(categoryDto.Name))
                throw new CustomException("Category Name Required !");

            if (categoryDto.Name.Length < 3 == categoryDto.Name.Length > 30)
                throw new CustomException("Category name must be between 3 and 30");

            Category category = new Category()
            {
                Name = categoryDto.Name,
            };

            _unifOfWork.Category.AddEntity(category);
        }

        public void DeleteCategoryDto(int id)
        {
            if(id == null)
                throw new ArgumentNullException(nameof(id));

            var category = _unifOfWork.Category.GetById(id);
            if(category == null) 
                throw new KeyNotFoundException(category.Name);

            _unifOfWork.Category.DeleteEntity(id);

        }

        public List<CategoryDto> GetCategories()
        {
            var categories = _unifOfWork.Category.GetAll();

            var list = categories.Select(c => new CategoryDto()
            {
                Id = c.Id,
                Name = c.Name,

            }).ToList();

            return list;
            
        }

        public CategoryDto GetCategoryById(int id)
        {
            var category = _unifOfWork.Category.GetById(id);
            if (category == null)
            {
                throw new CustomException("Category not found !");
            }

            CategoryDto cate = new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
            };

            return cate;
        }

        public void UpdateCategoryDto(CategoryDto categoryDto)
        {
            if (categoryDto == null)
                throw new ArgumentNullException("Category was null !");

            if (string.IsNullOrEmpty(categoryDto.Name))
                throw new CustomException("Category Name Required !");

            if (categoryDto.Name.Length < 3 == categoryDto.Name.Length > 30)
                throw new CustomException("Category name must be between 3 and 30");

            Category category = new Category()
            {
                Id = categoryDto.Id,    
                Name = categoryDto.Name,
            };

            _unifOfWork.Category.UpdateEntity(category);
        }
    }
}
