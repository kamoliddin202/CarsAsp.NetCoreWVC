using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class ImageRepasitory : Repasitory<Image>, IImageInterface
    {
        public ImageRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
