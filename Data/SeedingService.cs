using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

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
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //banco de dados já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.00, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1997, 4, 21), 2000.00, d2);
            Seller s3 = new Seller(3, "Alex", "alex@gmail.com", new DateTime(1987, 4, 21), 3000.00, d3);
            Seller s4 = new Seller(4, "Martha", "martha@gmail.com", new DateTime(1976, 4, 21), 2500.00, d1);
            Seller s5 = new Seller(5, "Donald", "donald@gmail.com", new DateTime(1969, 4, 21), 1000.00, d1);
            Seller s6 = new Seller(6, "Erik", "erikb@gmail.com", new DateTime(1975, 4, 21), 4000.00, d2);
            Seller s7 = new Seller(7, "John", "john@gmail.com", new DateTime(1970, 4, 21), 3600.00, d4);
            Seller s8 = new Seller(8, "Paul", "paul@gmail.com", new DateTime(1932, 4, 21), 2400.00, d4);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.00, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 09, 24), 500.00, SalesStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 09, 23), 900.00, SalesStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 09, 24), 10.00, SalesStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 09, 24), 100.00, SalesStatus.Billed, s1);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 09, 25), 1000.00, SalesStatus.Billed, s5);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 09, 25), 800.00, SalesStatus.Billed, s6);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 09, 25), 80.00, SalesStatus.Billed, s7);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 09, 21), 500.00, SalesStatus.Billed, s8);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2018, 09, 20), 200.00, SalesStatus.Billed, s2);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 09, 20), 1800.00, SalesStatus.Billed, s5);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 09, 22), 17000.00, SalesStatus.Billed, s7);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 09, 22), 18000.00, SalesStatus.Billed, s8);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2018, 09, 23), 8000.00, SalesStatus.Billed, s2);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2018, 09, 24), 61000.00, SalesStatus.Billed, s2);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2018, 09, 21), 1000.00, SalesStatus.Billed, s1);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 09, 22), 3000.00, SalesStatus.Billed, s5);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2018, 09, 25), 600.00, SalesStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s7);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18);

            _context.SaveChanges();

        }
    }
}
