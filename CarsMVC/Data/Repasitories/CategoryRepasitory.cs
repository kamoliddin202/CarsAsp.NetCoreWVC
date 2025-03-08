using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class CategoryRepasitory : Repasitory<Category>, ICategoryInterface
    {
        public CategoryRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
