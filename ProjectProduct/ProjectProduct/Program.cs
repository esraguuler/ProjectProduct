﻿using Business;
using Business.ValidationRules;
using EntityLayer;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace ProjectProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager cm = new CategoryManager();
            ProductManager pm = new ProductManager();
            foreach (var item in pm.GetAll())
            {
                Console.WriteLine("ID: " + item.ProductID + "Ürün Adı: " + item.ProductName + " Stok: " + item.Stock);
            }

            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();
            string proname = "Avengers";
            foreach (var item in pm.GetByName(proname))
                {

                Console.WriteLine("ID: " + item.ProductID + "Ürün Adı: " + item.ProductName + " Stok: " + item.Stock);
            }
            Console.WriteLine();

            Category c = new Category();
            c.CategoryName = "Dram";
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(c);
            if(results.IsValid)
            {
                cm.BLAdd(c);
                Console.WriteLine("Kategori Eklendi");

            }

            else
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }
            

            //Category c = new Category();
            //c.CategoryID = 3;
            //c.CategoryName = "Romantik Komedi";
            //cm.BLUpdate(c);
 
            //foreach (var item in cm.GetAll())
            //{
            //    Console.WriteLine("ID: " + item.CategoryID + " - Kategori Adı: " + item.CategoryName);
            //}
            //Category ct = new Category();
            //ct.CategoryName = "Romantik";
            //cm.BLAdd(ct);
            // cm.BLDelete(5);
            Console.ReadLine();
        }
    }
}
