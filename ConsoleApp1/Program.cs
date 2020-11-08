using ClassLibrary1.Controllers;
using ClassLibrary1.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddMediatR(typeof(OrderController));
                    services.AddDbContext<ConsoleApp1Context>(option =>
                        option.UseSqlServer(context.Configuration.GetConnectionString("ConsoleApp1DbConStr")));
                })
                .Build();

            var orderController = ActivatorUtilities.CreateInstance<OrderController>(host.Services);
            orderController.CreateOrder();
        }
    }
}
