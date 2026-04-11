

using OnKtrGiuaKi;

var products = new List<Product>
{
    new Product { P_ID = 1, Name = "Laptop", Price = 1500 },
    new Product { P_ID = 2, Name = "Mouse", Price = 25 },
    new Product { P_ID = 3, Name = "Keyboard", Price = 45 },
    new Product { P_ID = 4, Name = "Monitor", Price = 300 },
    new Product { P_ID = 5, Name = "Headphone", Price = 80 }
};

var customers = new List<Customer>
{
    new Customer { ID = 1, Name = "An", Age = 20 },
    new Customer { ID = 2, Name = "Binh", Age = 22 },
    new Customer { ID = 3, Name = "Cuong", Age = 25 }
};

var orders = new List<Order>
{
    new Order { OrderID = 1, Date = DateTime.Now, CusID = 1 },
    new Order { OrderID = 2, Date = DateTime.Now, CusID = 2 },
    new Order { OrderID = 3, Date = DateTime.Now, CusID = 1 },
    new Order { OrderID = 4, Date = DateTime.Now, CusID = 3 }
};

var orderDetails = new List<OrderDetail>
{
    new OrderDetail { OrderID = 1, ProductID = 1, Quantity = 2 },
    new OrderDetail { OrderID = 1, ProductID = 2, Quantity = 5 },
    new OrderDetail { OrderID = 2, ProductID = 1, Quantity = 3 },
    new OrderDetail { OrderID = 2, ProductID = 3, Quantity = 4 },

    new OrderDetail { OrderID = 3, ProductID = 2, Quantity = 1 },
    new OrderDetail { OrderID = 3, ProductID = 4, Quantity = 2 },

    new OrderDetail { OrderID = 4, ProductID = 1, Quantity = 6 },
    new OrderDetail { OrderID = 4, ProductID = 5, Quantity = 3 }
};

/*

var result =
    from c in customers
    where c.Age > 20
    select c;

foreach (var c in result)
{
    Console.WriteLine(c.Name);
}



var result1 =
    from c in customers
    select c;

foreach (var c in result1)
{
    Console.WriteLine(c.Name);
}



var result2 = new
{
    totalorder = orders.Count()
};

  Console.WriteLine(result2.totalorder);



var result3 =
    from c in orders
    group c by c.CusID into g
    select new
    {
        CusID = g.Key,
        totalOrders = g.Count()
    };

foreach (var item in result3)
{
    Console.WriteLine($"CusID: {item.CusID}, TotalOrders: {item.totalOrders}");
}


List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

var result4 =
    from c in numbers
    where c % 2 == 0
    select c;

foreach (var x in result4)
{
    Console.WriteLine(x); 
}

var result5 =
    from c in orderDetails
    group c by c.ProductID into g
    select new
    {
        producid = g.Key,
        totalP = g.Sum(x => x.Quantity)
    };

foreach (var item in result5)
{
    Console.WriteLine("ProducID: " + item.producid + " total: " + item.totalP);
}



var result6 =
    from c in orderDetails
    group c by c.ProductID into g
    orderby g.Sum(x => x.Quantity) descending
    select new
    {
        productID = g.Key,
        totalProduct = g.Sum(x => x.Quantity)
    };

foreach (var item in result6)
{
    Console.WriteLine("ProducID: " +  item.productID  + " total: " + item.totalProduct);
}



var result7 =
    from c in customers
    join o in orders on c.ID equals o.CusID
    select new
    {
        customerName = c.Name,
        id = o.OrderID,
    };

foreach (var item in result7)
{
    Console.WriteLine($"Name: {item.customerName}, OrderID: {item.id}");
}





var result8 =
    from o in orders
    join od in orderDetails on o.OrderID equals od.OrderID
    group od by o.CusID into g
    select new
    {
        customerID = g.Key,
        total = g.Sum(x => x.Quantity)
    };

foreach (var item in result8)
{
    Console.WriteLine($"ID: {item.customerID}, Total: {item.total}");
}



var result9 =
    from c in products
    where c.Price >= 500
    select new
    {
        n = c.Name,
        p = c.Price,
    };

foreach (var item in result9)
{
    Console.WriteLine( item.n + " - " + item.p);
}



var result10 =
    from c in products
    orderby c.Price
    select c.Price;

foreach (var item in result10)
{
    Console.WriteLine(item);
}



Console.WriteLine("--------------------");

var result11 =
    (from c in products
     orderby c.Price
     select c).Take(3);

foreach (var item in result11)
{
    Console.WriteLine(item.Price);
}



Console.WriteLine("Nhap ten san pham: ");
string keyword = Console.ReadLine();

var result12 =
    from c in products
    where c.Name.ToLower().Contains(keyword.ToLower())
    select c;

foreach (var item in result12)
{
    Console.WriteLine(item.Name);
}



double result13 =
    (from c in products
     select c.Price).Average();

Console.WriteLine(result13);



var result14 =
    from p in products
    join o in orderDetails on p.P_ID equals o.ProductID
    group new { p,o} by new{p.P_ID, p.Name} into g
    select new
    {
        Productid = g.Key.P_ID,
        Productname = g.Key.Name,
        Revenue = g.Sum(x => x.o.Quantity * x.p.Price)
    };

foreach (var item in result14)
{
    Console.WriteLine(item.Productname + " - " + item.Revenue);
}



var result15 =
    (from p in products
     join o in orderDetails on p.P_ID equals o.ProductID
     group new { p, o } by new { p.P_ID, p.Name } into g
     orderby g.Sum(x => x.o.Quantity) descending
     select new
     {
         Productid = g.Key.P_ID,
         Productname = g.Key.Name,
         Revenue = g.Sum(x => x.o.Quantity)
     }).Take(3);

foreach (var item in result15)
{
    Console.WriteLine(item.Productname + " - " + item.Revenue);
}



var result16 =
    (from c in orderDetails
     join od in orders on c.OrderID equals od.OrderID
     group c by od.CusID into g
     orderby g.Sum(x => x.Quantity) descending
     select new
     {
         name = g.Key,
         totalBought = g.Sum(x => x.Quantity)
     }).First();

Console.WriteLine("CustomerID: " + result16.name +
                  " - Total: " + result16.totalBought);

*/