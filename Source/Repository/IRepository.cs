namespace Repository
{
    public interface IRepository
    {
        IRepositoryContext Context { get; set; }
    }
}