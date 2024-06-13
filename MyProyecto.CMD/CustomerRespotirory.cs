using Application.Repositories;
using Infraestructure.Repositories.Sql;
using MyProyecto.CMD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProyecto.CMD
{
    internal class CustomerRespotirory:BaseRepository<Customer>,IRepository<Customer>
    {
        public CustomerRespotirory(MyDbContext myDbContext):base(myDbContext) { }
    }
}
