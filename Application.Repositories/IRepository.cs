using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IRepository<TEntidad>
    {
        void add(TEntidad tEntidad);
        void delete(int id);

        TEntidad update(TEntidad tEntidad);
        TEntidad get(int id);
        List<TEntidad> findAll();


    }
}
