using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public class Order
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value == 0) throw new ArgumentException();
                _id = value;
            }
        }

        public DateTime Date { get; set; }

        private readonly List<OrderDetail> _orderDetails;
        public IReadOnlyList<OrderDetail> OrderDetails => _orderDetails;

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
            _orderDetails = new List<OrderDetail>();
        }

        public void AddOrderDetail(int id, string productName, decimal productPrice, int orderId)
        {
            _orderDetails.Add(new OrderDetail(id, productName, productPrice, orderId));
        }
    }
}
