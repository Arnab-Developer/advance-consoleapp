using ClassLibrary1.Models;
using MediatR;

namespace ClassLibrary1.Application
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public Order Order { get; set; }

        public CreateOrderCommand(Order order)
        {
            Order = order;
        }
    }
}
