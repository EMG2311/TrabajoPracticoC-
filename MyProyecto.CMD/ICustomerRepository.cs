using Application.Repositories;
using Microsoft.EntityFrameworkCore.Migrations;
using MyProyecto.CMD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProyecto.CMD
{
    internal interface ICustomerRepository:IRepository<Customer>
    {
    }
}
