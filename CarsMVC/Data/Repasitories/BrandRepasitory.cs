using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class BrandRepasitory : Repasitory<Brand>, IBrendInterface
    {
        public BrandRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
