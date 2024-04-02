using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set;} = new List<Seller>();

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Department()
        {
        }

        private void addSeller(Seller seller) 
        {
            this.Sellers.Add(seller);
        }

        private double totalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(s => s.TotalSales(initial, final));
        }
    }
}
