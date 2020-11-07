using ClassLibrary1.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.Application
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly ConsoleApp1Context _consoleApp1Context;

        public CreateOrderCommandHandler(ConsoleApp1Context consoleApp1Context)
        {
            _consoleApp1Context = consoleApp1Context;
        }

        Task<bool> IRequestHandler<CreateOrderCommand, bool>.Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            _consoleApp1Context.Orders!.Add(request.Order);
            _consoleApp1Context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
