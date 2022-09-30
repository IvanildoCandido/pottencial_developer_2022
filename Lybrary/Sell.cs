using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lybrary.Models
{
    public class Sell
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime SellDate { get; set; }

        public Sell()
        {

        }
        public Sell(int id, string description, decimal price, DateTime sellDate)
        {
            Id = id;
            Description = description;
            Price = price;
            SellDate = sellDate;
        }
    }
}