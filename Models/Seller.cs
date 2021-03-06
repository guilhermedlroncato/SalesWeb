﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Nome deve ser entre 3 e 60")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data Nascimento Obrigatório")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Salario Obrigatório")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(p => p.Date >= initial && p.Date <= final).Sum(p => p.Amount);
        }
    }
}
