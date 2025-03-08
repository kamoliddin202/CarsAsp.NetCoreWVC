namespace CarsMVC.Data.Interfaces
{
    public interface IUnifOfWork 
    {
        IBrendInterface IBrendInterface { get; }
        ICategoryInterface Category { get; }
        ICarInterface Car { get; }
        IColorInterface Color { get; }
        IImageInterface Image { get; }
        IModelInterface Model { get; }
        IOrderInterface Order { get; }
        IUserInterface User { get; } 
    }
}
