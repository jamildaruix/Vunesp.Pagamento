using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vunesp.Pagamento.Domain.Interfaces
{
    public interface IRepositoryDefault<T> : IDisposable where T : class
    {
        Task<T> Inserir(T obj);
        Task<T> Atualizar(T obj, int key);
    }
}
