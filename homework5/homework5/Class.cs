using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homework5
{
    class Order
    {
        public int orderId { get; set; }
        public customer customer { get; set; }
        public double totalCost
        {
            get => Details.Sum(d => d.GoodNum);
        }
        public DateTime dealTime { get; set; }

        public List<orderDetails> Details { get; } = new List<orderDetails>();
        public Order(int id, customer Customer)
        {
            orderId=id;
            customer = Customer;
            dealTime = DateTime.Now;
        }
        public void addDetails(orderDetails details)
        {
            Details.Add(details);
        }
        public void deleteDetails(orderDetails details)
        {
            Details.Remove(details);
        }
        public bool IsValid()
        {
            return this.orderId != 0 && this.Details != null && this.Details.Count > 0;
        }
        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.orderId == orderId;
        }
        public override int GetHashCode()
        {
            return orderId;
        }
        public override string ToString()
        {
            String orderMessage = "订单号："+orderId + "  交易时间: "+dealTime+"  顾客: "+customer+"  总价："+totalCost;
            Details.ForEach(detail => orderMessage += "\n\t" + detail);
            return orderMessage;
        }
    }
    class orderDetails
    {
        public int orderId { get; set; } 
        public good Good { get; set; }
        public int GoodNum{ get; set; }
        public double priceSum()
        {
            return Good.Price * GoodNum;
        }
        public orderDetails(good good, int goodNum)
        {
            this.Good = good;
            this.GoodNum = goodNum;
        }
        public override bool Equals(object obj)
        {
            good m = obj as good;
            return m != null && m.goodId == orderId;
        }
        public override string ToString()
        {
            return "订单号:  " + orderId + "  商品名:   " + Good.Name + "  单价:  " + Good.Price;
        }
        public override int GetHashCode()
        {
            return orderId;
        }

    }
    class good
    {
        public int goodId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public good (int id,string name,double price)
        {
            goodId = id;
            Name = name;
            Price = price;
        }
        public override bool Equals(object obj)
        {
            good m = obj as good;
            return m != null && m.goodId == goodId;
        }
        public override string ToString()
        {
            return "商品订单号:  " + goodId + "  商品名:   " + Name + "  单价:  " + Price;
        }
        public override int GetHashCode()
        {
            return goodId;
        }
    }
    class customer
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        public customer(int id,string name)
        {
            customerId = id;
            Name=name;
        }
        public override string ToString()
        {
            return "顾客姓名： " + Name;;
        }
    }

    class orderService
    {
        public List<Order> orderList = new List<Order>();
        public void addOrder(Order order)
        {
            if (order == null || !order.IsValid())
            {
                throw new ApplicationException("该订单不存在");
            }
            if (orderList.Contains(order))
            {
                throw new ApplicationException("该订单已经存在");
            }
            orderList.Add(order);
        }
        public void deleteOrder(int orderId)
        {
            orderList.RemoveAll(o => o.orderId == orderId);
        }
        public void Update(Order order)
        {
            Order orderInList = GetById(order.orderId);
            if (orderInList == null)
            {
                throw new ApplicationException($"the order {order.orderId} does not exist!");
            }
            orderList.Remove(orderInList);
            orderList.Add(order);
        }
        public Order GetById(int orderId)
        {
            return orderList.Where(o => o.orderId == orderId).FirstOrDefault();
        }
        public List<Order> QueryAll()
        {
            return orderList.OrderBy(o => o.totalCost).ToList<Order>();
        }

        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = orderList
              .Where(o => o.Details.Any(d => d.Good.Name == goodsName))
              .OrderBy(o => o.totalCost);
             return query.ToList();
        }

        public List<Order> QueryByTotalAmount(float totalAmount)
        {
            var query = orderList
              .Where(o => o.totalCost >= totalAmount)
              .OrderBy(o => o.totalCost);
            return query.ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList
                .Where(o => o.customer.Name == customerName)
                .OrderBy(o => o.totalCost);
             return query.ToList();
        }
        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orderList
              .Where(o => condition(o))
              .OrderBy(o => o.totalCost);
        }
        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

    }

}
