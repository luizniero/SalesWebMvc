using Microsoft.EntityFrameworkCore.Internal;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            // DB já existe (já tem registros)
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) return;


            Department d1 = new Department()
            {
                Id = 1,
                Name = "Computers",
            };
            Department d2 = new Department()
            {
                Id = 2,
                Name = "Eletronics",
            };
            Department d3 = new Department()
            {
                Id = 3,
                Name = "Fashon",
            };
            Department d4 = new Department()
            {
                Id = 4,
                Name = "Books",
            };

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new System.DateTime(1992, 02, 01), 1000.0, d1);
            Seller s2 = new Seller(1, "Sasha Grey", "sasha@gmail.com", new System.DateTime(1992, 02, 01), 1000.0, d1);
            Seller s3 = new Seller(1, "Tony Red", "tony@gmail.com", new System.DateTime(1992, 02, 01), 1000.0, d1);
            Seller s4 = new Seller(1, "Carmen blue", "carmen@gmail.com", new System.DateTime(1992, 02, 01), 1000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new System.DateTime(2018, 09, 25), 1.000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new System.DateTime(2019, 09, 25), 2.000, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new System.DateTime(2020, 09, 25), 3.000, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new System.DateTime(2021, 09, 25), 4.000, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();
        }
    }
}
