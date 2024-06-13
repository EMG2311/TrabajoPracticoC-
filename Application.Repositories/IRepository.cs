using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IRepository<TEntidad> where TEntidad : class
    {
        void Add(TEntidad entity);
        void Delete(int id);
        List<TEntidad> FindAll();
        TEntidad Get(int id);
        TEntidad Update(TEntidad entity);

    }
}
