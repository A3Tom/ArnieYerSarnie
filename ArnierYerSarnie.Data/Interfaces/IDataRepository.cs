using System.Threading.Tasks;

namespace ArnieYerSarnie.Data.Interfaces
{
    public interface IDataRepository
    {
        Task<T> GetMenu<T>();
    }
}