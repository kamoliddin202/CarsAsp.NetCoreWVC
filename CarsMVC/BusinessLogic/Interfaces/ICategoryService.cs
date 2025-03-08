using CarsMVC.BusinessLogic.DTOs.CategoryDTOs;

namespace CarsMVC.BusinessLogic.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryDto> GetCategories();
        CategoryDto GetCategoryById(int id);
        void AddCategoryDto(AddCategoryDto categoryDto);
        void UpdateCategoryDto(CategoryDto categoryDto);
        void DeleteCategoryDto(int id); 
    }
}
