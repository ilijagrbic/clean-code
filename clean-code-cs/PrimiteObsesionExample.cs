using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_code_cs
{
    //public enum PaymentMethod
    //{
    //    CARD, CASH, PAYPAL
    //}
    public class PrimitiveObsession
    {
        public static void Main(string[] args)
        {
            String s = "CARd ";
            //PaymentMethod paymentType = Enum.Parse<PaymentMethod>(s.Trim().ToUpper());


            new PrimitiveObsession().HandlePrimitiveObsession(s);
        }

        public Dictionary<long, Dictionary<string, int>> Process(string paymentMethod)
        {
            long customerId = 1L;
            int product1Count = 2;
            int product2Count = 4;
            return new Dictionary<long, Dictionary<string, int>>
            {
                { customerId, new Dictionary<string, int>
                    {
                        { "Table", product1Count },
                        { "Chair", product2Count }
                    }
                }
            };
        }


        public void HandlePrimitiveObsession(string paymentMethod)
        {
            // Possible payment methods are CARD and CASH, PAYPAL is also possible in the system but not supported in this method
            if (paymentMethod != "CARD" && paymentMethod != "CASH")
            {
                throw new ArgumentException("Only CARD payment method is supported");
            }
            // Fetches user payment items from the DB, this method returns a Map<long, string> for each cid (customer id)
            var map = Process(paymentMethod);
            foreach (var e in map)
            {
                string pl = string.Join(", ", e.Value.Select(entry => $"{entry.Value} pcs. of {entry.Key}"));
                Console.WriteLine($"cid={e.Key} got {pl}");
            }
        }

       // public readonly record struct CustomerId(long Id); // typealias
       // public readonly record struct ProductCount(string ProductName, uint Count); // typealias
    }
}
