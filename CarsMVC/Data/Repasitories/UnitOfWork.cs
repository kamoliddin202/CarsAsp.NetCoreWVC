using CarsMVC.Data.Interfaces;

namespace CarsMVC.Data.Repasitories
{
    public class UnitOfWork : IUnifOfWork
    {
        private readonly AppDbContext appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IBrendInterface IBrendInterface => new BrandRepasitory(appDbContext);

        public ICategoryInterface Category => new CategoryRepasitory(appDbContext);

        public ICarInterface Car => new CarRepasitory(appDbContext);

        public IColorInterface Color => new ColorRepasitory(appDbContext);

        public IImageInterface Image => new ImageRepasitory(appDbContext);

        public IModelInterface Model => new ModelRepasitory(appDbContext);

        public IOrderInterface Order => new OrderRepasitory(appDbContext);

        public IUserInterface User => new UserRepasitory(appDbContext);
    }
}
