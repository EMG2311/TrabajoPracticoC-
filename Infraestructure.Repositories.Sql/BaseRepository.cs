using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;

namespace Application.Repositories.Sql
{
    public class BaseRepository<TEntidad> : 
    {
        public void add(TEntidad tEntidad)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntidad> findAll()
        {
            throw new NotImplementedException();
        }

        public TEntidad get(int id)
        {
            throw new NotImplementedException();
        }

        public TEntidad update(TEntidad tEntidad)
        {
            throw new NotImplementedException();
        }
    }
}
