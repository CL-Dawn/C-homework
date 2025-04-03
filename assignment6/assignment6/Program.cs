using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static assignment6.Program;

namespace assignment6
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    // 商品类
    public class Product : IEquatable<Product>
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public bool Equals(Product other) => other != null && ProductId == other.ProductId;
        public override bool Equals(object obj) => Equals(obj as Product);
        public override int GetHashCode() => ProductId.GetHashCode();
        public override string ToString() => $"{Name} (ID:{ProductId}) 单价: {Price:C}";
    }

    // 客户类
    public class Customer : IEquatable<Customer>
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

        public bool Equals(Customer other) => other != null && CustomerId == other.CustomerId;
        public override bool Equals(object obj) => Equals(obj as Customer);
        public override int GetHashCode() => CustomerId.GetHashCode();
        public override string ToString() =>
            $"{Name} (ID:{CustomerId}) 联系方式: {Contact}";
    }

    // 订单明细类（调整为包含Product对象）
    public class OrderDetails : IEquatable<OrderDetails>
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public bool Equals(OrderDetails other)
        {
            return other != null &&
                   Product.Equals(other.Product) &&
                   Quantity == other.Quantity;
        }

        public override bool Equals(object obj) => Equals(obj as OrderDetails);
        public override int GetHashCode() => HashCodeHelper.Combine(Product, Quantity);
        public override string ToString() =>
            $"{Product} × {Quantity}, 小计: {Product.Price * Quantity:C}";
    }

    // 订单类（Customer改为对象引用）
    public class Order : IEquatable<Order>
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }  // 改为对象引用
        private List<OrderDetails> details = new List<OrderDetails>();

        public decimal TotalAmount => details.Sum(d => d.Product.Price * d.Quantity);

        public void AddDetail(OrderDetails detail)
        {
            if (details.Contains(detail))
                throw new ArgumentException("订单明细已存在");
            details.Add(detail);
        }

        public bool RemoveDetail(OrderDetails detail) => details.Remove(detail);

        public IEnumerable<OrderDetails> Details => details.AsReadOnly();

        public bool Equals(Order other) => other != null && OrderId == other.OrderId;

        public override bool Equals(object obj) => Equals(obj as Order);

        public override int GetHashCode() => OrderId.GetHashCode();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"订单号: {OrderId}");
            sb.AppendLine($"客户信息: {Customer}");
            sb.AppendLine($"总金额: {TotalAmount:C}");
            sb.AppendLine("商品明细:");
            foreach (var d in details)
                sb.AppendLine("  " + d.ToString());
            return sb.ToString();
        }
    }

    // 增强的订单服务类
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        // 添加客户和商品的数据管理（简单内存存储）
        private List<Customer> customers = new List<Customer>();
        private List<Product> products = new List<Product>();

        public void AddCustomer(Customer customer)
        {
            if (customers.Contains(customer))
                throw new ArgumentException("客户已存在");
            customers.Add(customer);
        }

        public Customer FindCustomer(string customerId) =>
            customers.FirstOrDefault(c => c.CustomerId == customerId);

        public void AddProduct(Product product)
        {
            if (products.Contains(product))
                throw new ArgumentException("商品已存在");
            products.Add(product);
        }

        public Product FindProduct(string productId) =>
            products.FirstOrDefault(p => p.ProductId == productId);

        public void AddOrder(Order order)
        {
            if (order == null) throw new ArgumentNullException();
            if (orders.Any(o => o.OrderId == order.OrderId))
                throw new ArgumentException($"订单{order.OrderId}已存在");
            orders.Add(order);
        }

        // 其他方法保持类似结构，调整查询逻辑...
        public IEnumerable<Order> QueryByProduct(string productName) =>
            orders.Where(o => o.Details.Any(d =>
                d.Product.Name.Contains(productName)))
                .OrderBy(o => o.TotalAmount);

        public IEnumerable<Order> QueryByCustomer(string customerId) =>
            orders.Where(o => o.Customer.CustomerId == customerId)
                .OrderBy(o => o.TotalAmount);

        public void RemoveOrder(string orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new ArgumentException($"订单{orderId}不存在");
            orders.Remove(order);
        }

        
    }

    // 控制台交互增强实现
    class Program
    {
        static OrderService service = new OrderService();

        static void Main()
        {
            
        }

        
    }
}
