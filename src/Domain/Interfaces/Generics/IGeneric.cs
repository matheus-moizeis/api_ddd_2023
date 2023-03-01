namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objeto);
        Task Updatade(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetElementById(int Id);
        Task<List<T>> List();
    }
}