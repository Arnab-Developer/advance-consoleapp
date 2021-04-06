Contributions are welcome. Please create a new issue or pick an existing 
issue to work on. Let me know on which issue you are going to work before 
raising a pull request.

You need Visual Studio 2019, .NET Core 3.1, EF Core and SQL Server to run 
this app locally. Create database `ConsoleApp1Db` and table `Orders` and
`OrderDetails` based on below models.

```c#
public class Order
{
    private int _id;   

    public DateTime Date { get; set; }
    
    private readonly List<OrderDetail> _orderDetails;
    public IReadOnlyList<OrderDetail> OrderDetails => _orderDetails;
}

public class OrderDetail
{
    private int _id;

    private string _productName;

    private decimal _productPrice;

    private int _orderId;

    public Order? Order { get; set; }
}
```
