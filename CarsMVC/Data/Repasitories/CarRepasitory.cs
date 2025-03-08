using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class CarRepasitory : Repasitory<Car>, ICarInterface
    {
        public CarRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
