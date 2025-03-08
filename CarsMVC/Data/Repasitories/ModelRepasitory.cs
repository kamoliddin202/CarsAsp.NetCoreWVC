using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class ModelRepasitory : Repasitory<Model>, IModelInterface
    {
        public ModelRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
