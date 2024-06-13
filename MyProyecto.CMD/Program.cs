using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyProyecto.CMD;
using MyProyecto.CMD.Entidades;

internal static class  Program 
{
    private static void Main(string[] args)
    {
        CustomerRespotirory customerRespotirory = new CustomerRespotirory(new MyDbContext());

        // ADD
        
         Customer customer = new Customer();
        customer.CuilCuit = "papa";
        customer.DocumentNumber = "sadasd";
        customer.Email = "asdas@gmail.com";
        customer.EmailConfirmed = true;
        customer.Name = "asd";
        customer.LastName = "asdasd";
        customer.Status = CustomerStatus.activo;

        customerRespotirory.Add(customer);
        
        /*List
        List<Customer> customers = customerRespotirory.FindAll();
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.Id);
        }
        */
        /*Actualizacion y get
         * Customer customer = customerRespotirory.Get(1);
        customer.Name = "German";
        customerRespotirory.Update(customer);
        */

        /* Delete
        customerRespotirory.Delete(1);
        */


    }

    private static IServiceCollection CreateDependencies()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddDbContext<MyDbContext>(options =>
        {
            options.UseMySQL("Server=localhost;port=3306;Database=productos;User=root;Password=root;"); ;
        }, ServiceLifetime.Scoped);
        services.AddTransient<ICustomerRepository, ICustomerRepository>();
        return services;

    }
     
    private static T GetRequiredDependency<T>(this IServiceCollection service)
    {
        IServiceProvider provider = service.BuildServiceProvider().CreateScope().ServiceProvider;
        return provider.GetRequiredService<T>();
    }


}