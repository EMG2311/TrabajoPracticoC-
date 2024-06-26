namespace Web.API
{
    using Microsoft.EntityFrameworkCore;
    using MyProyecto.CMD;
    public class WebAPIContex:MyDbContext
    {
        public WebAPIContex() { }
        public WebAPIContex(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}
