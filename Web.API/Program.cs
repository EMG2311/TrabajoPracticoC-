using Web.API;

public class Program
{
    static void Main(String[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    static IHostBuilder CreateHostBuilder(string[] args)
    {

        return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }

}