using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_code_cs
{
    public class Item
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }

    public class Basket
    {
        public List<Item> items = null;

        public Basket(List<Item> items)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("List is empty.");
            }
            this.items = items;
        }

        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                if (item.Discount > 0)
                {
                    total += (100- item.Discount)/100 *(item.Price * item.Quantity);
                    Console.WriteLine($"Item under discount of {item.Discount}%, total: {total}");
                }
                else
                {
                    total += item.Price * item.Quantity;
                    Console.WriteLine($"Item with regular price total: {total}");
                }
            }
            return total;
        }

    }
}
