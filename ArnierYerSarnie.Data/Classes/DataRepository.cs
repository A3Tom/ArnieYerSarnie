using ArnieYerSarnie.Data.Interfaces;
using System.Threading.Tasks;

namespace ArnieYerSarnie.Data.Classes
{
    public class DataRepository : IDataRepository
    {
        public Task<T> GetMenu<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}
