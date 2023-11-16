using CheckList.Database;
using CheckList.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CheckList;

internal class Program
{
    static  void Main(string[] args)
    {
            

        MainMethod();
    }

    public async static void MainMethod()
    {
        var serviceProvider = new ServiceCollection()
            .AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=CheckList.db"))
            .AddScoped<SQLiteBoardRepository>()
            .AddScoped<BoardService>()
            .BuildServiceProvider();

        var boardService = serviceProvider.GetRequiredService<BoardService>();

        Console.WriteLine("sadf");

        boardService.CreateAsync(new Database.Entities.Board {  Name = "Test2", Creator = 2,Description="Description2" });
        var a = await boardService.GetByIdAsync(1);

        if (serviceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}
