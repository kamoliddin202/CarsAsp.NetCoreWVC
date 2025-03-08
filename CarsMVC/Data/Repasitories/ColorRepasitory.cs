using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class ColorRepasitory : Repasitory<Color>, IColorInterface
    {
        public ColorRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
