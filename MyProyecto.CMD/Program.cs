using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyProyecto.CMD;
using MyProyecto.CMD.Entidades;

internal static class  Program 
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.CuilCuit = "asd";
        customer.DocumentNumber = "22313";
        customer.Email = "asdas@gmail.com";
        customer.EmailConfirmed = true;
        customer.Name = "asd";
        customer.LastName = "asdasd";
        customer.Status = CustomerStatus.activo;

        CustomerRespotirory customerRespotirory = new CustomerRespotirory(new MyDbContext());
        customerRespotirory.Add(customer);
        
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