namespace CalculadoraCumDAL.Domain
{
    public interface IGenericRepository<T> : ICreateRepository<T>,IReadRepository<T> where T : class
    {
        
    }
}