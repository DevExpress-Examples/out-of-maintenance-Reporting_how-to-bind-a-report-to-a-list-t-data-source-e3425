using System;
using System.Collections.Generic;
// ...

namespace docITypedList {

    public class Supplier {
        static int nextID = 0;
        int id;
        string name;

        List<Product> products = new List<Product>();

        public IList<Product> Products { get { return products; } }
        public int SupplierID { get { return id; } }
        public string CompanyName { get { return name; } }

        public Supplier(string name) {
            this.name = name;

            this.id = nextID;
            nextID++;
        }
        public void Add(Product product) {
            products.Add(product);
        }
    }

    public class Product {
        static int nextID = 0;

        List<OrderDetail> orderDetails = new List<OrderDetail>();
        int suppID;
        int prodID;
        string name;

        public int SupplierID { get { return suppID; } }
        public int ProductID { get { return prodID; } }
        public string ProductName { get { return name; } }
        
        public IList<OrderDetail> OrderDetails { get { return orderDetails; } }

        public Product(int suppID, string name) {
            this.suppID = suppID;
            this.name = name;

            this.prodID = nextID;
            nextID++;
        }

        internal void AddRange(OrderDetail[] orderDetailArray) {
            orderDetails.AddRange(orderDetailArray);
        }
    }

    public class OrderDetail {
        int prodID;
        short quantity;
        public int ProductID { get { return prodID; } }
        public short Quantity { get { return quantity; } }

        public OrderDetail(int prodID, int quantity) {
            this.prodID = prodID;
            this.quantity = Convert.ToInt16(quantity);
        }
    }

}
