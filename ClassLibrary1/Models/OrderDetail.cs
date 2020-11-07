using System;

namespace ClassLibrary1.Models
{
    public class OrderDetail
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

        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException();
                _productName = value;
            }
        }

        private decimal _productPrice;
        public decimal ProductPrice
        {
            get { return _productPrice; }
            set
            {
                if (value == 0) throw new ArgumentException();
                _productPrice = value;
            }
        }

        private int _orderId;
        public int OrderId
        {
            get { return _orderId; }
            set
            {
                if (value == 0) throw new ArgumentException();
                _orderId = value;
            }
        }

        public Order? Order { get; set; }

        public OrderDetail(int id, string productName, decimal productPrice, int orderId)
        {
            _productName = string.Empty;

            Id = id;
            ProductName = productName;
            ProductPrice = productPrice;
            OrderId = orderId;
        }
    }
}
