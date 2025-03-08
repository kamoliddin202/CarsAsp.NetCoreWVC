using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class UserRepasitory : Repasitory<User>, IUserInterface
    {
        public UserRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
