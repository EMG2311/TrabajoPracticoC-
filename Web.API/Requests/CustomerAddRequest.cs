using MyProyecto.CMD.Entidades;

namespace Web.API.Requests
{
    public class CustomerAddRequest
    {
        public string CuilCuit { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public CustomerStatus Status { get; set; }
    }
}
