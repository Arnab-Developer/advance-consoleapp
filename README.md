# Console app with DI and configuration support

This is an example console application to show how we can use dependency injection and 
configuration support in console app with .NET Core hosting.

This is a normal console application. I have added `Microsoft.Extensions.Hosting` nuget 
package to take advantage of dependency injection, configuration etc in it.

```xml
<PackageReference Include="Microsoft.Extensions.Hosting" Version="3.1.9" />
```

Now I can use dependency injection in the `Main` method.

```c#
IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddMediatR(typeof(OrderController));
        services.AddDbContext<ConsoleApp1Context>(option =>
            option.UseSqlServer(context.Configuration.GetConnectionString("ConsoleApp1DbConStr")));
    })
    .Build();
```
