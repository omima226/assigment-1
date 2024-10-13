using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_1
{
    internal class Product
    {
        private string Name { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0) throw new ArgumentException("please enter positive value ");
                price = value;
            }

        }
        private int stockQuantity;
        public int StockQuantity
        {
            get { return stockQuantity; }
            set
            {
                if (value <= 0) throw new ArgumentException("please enter positive value");
                stockQuantity = value;
            }
        }
        private bool isAvailable;
        public bool IsAvailable
        {
            get { return stockQuantity > 0; }
        }
        //bouns
        public void UpdateStock(int changes)
        {
            stockQuantity += changes;
        }
    }
}
