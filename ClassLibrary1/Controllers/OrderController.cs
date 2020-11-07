using ClassLibrary1.Application;
using ClassLibrary1.Models;
using MediatR;
using System;

namespace ClassLibrary1.Controllers
{
    public class OrderController
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void CreateOrder()
        {
            Order o1 = GetOrder();
            var createOrderCommand = new CreateOrderCommand(o1);
            _mediator.Send(createOrderCommand);
        }

        private Order GetOrder()
        {
            var o1 = new Order(1, DateTime.UtcNow);

            o1.AddOrderDetail(1, "p1", 10.5m, 1);
            o1.AddOrderDetail(2, "p2", 20.5m, 1);
            o1.AddOrderDetail(3, "p3", 20.5m, 1);
            o1.AddOrderDetail(4, "p4", 50.5m, 1);

            return o1;
        }
    }
}
