using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vunesp.Pagamento.Domain.Interfaces;
using Vunesp.Pagamento.Data.Context;

namespace Vunesp.Pagamento.Data.Repository
{
    public class RepositoryDefault<T> : IRepositoryDefault<T> where T : class
    {
        private readonly ContextEF _context;

        /// <summary>
        /// Recebe o context instanciado
        /// </summary>
        public RepositoryDefault(ContextEF context)
        {
            _context = context;
        }

        public async Task<T> Inserir(T obj)
        {
            //await _context.Set<T>().AddAsync(obj);
            return obj;
        }

        public async Task<T> Atualizar(T obj, int key)
        {
            if (obj == null) return null;
            T exist = await _context.Set<T>().FindAsync(key);

            if (exist != null)
                _context.Entry(exist).CurrentValues.SetValues(obj);

            return exist;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
