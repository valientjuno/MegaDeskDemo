using System;

namespace MegaDeskDemo
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public Desk Desk { get; set; }
        public decimal Price { get; set; }
    }
}