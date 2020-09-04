using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemestralkaDataControl.DataInitializers
{
    public static class DataInitializer
    {
        public static void InitializeData(ApplicationContext context)
        {
            if (!context.Categories.Any<Category>())
            {
                var categories = new List<Category>
                {
                new Category{Name = "Monitors"},
                new Category{Name = "Computers"},
                new Category{Name = "Mobile Phones"},
                new Category{Name = "TVs"},
                new Category{Name = "Components"}
                };


                context.Categories.AddRange(categories);





                var products = new List<Product>
                {
                new Product{Name = "ASUS", Category=categories[0]},
                new Product{Name="MSI", Category=categories[0]},
                new Product{Name="Dell", Category=categories[0]},
                new Product{Name="Acer", Category=categories[0]},
                new Product{Name="Alza PC", Category=categories[1]},
                new Product{Name="Hyper PC", Category=categories[1]},
                new Product{Name="CZC PC", Category=categories[1]},
                new Product{Name="Iphone", Category=categories[2]},
                new Product{Name="Samsung Galaxy", Category=categories[2]},
                new Product{Name="Xiaomi", Category=categories[2]},
                new Product{Name="Meizu", Category=categories[2]},
                new Product{Name="Samsung", Category=categories[3]},
                new Product{Name="LG", Category=categories[3]},
                new Product{Name="Sony", Category=categories[3]},
                new Product{Name="Philips", Category=categories[3]},
                new Product{Name="Processor", Category=categories[4]},
                new Product{Name="SSD", Category=categories[4]},
                new Product{Name="HDD", Category=categories[4]},
                new Product{Name="RAM", Category=categories[4]},
                new Product{Name="Motherboard", Category=categories[4]}
                };


                context.Products.AddRange(products);






                var questions = new List<Question>
                {
                new Question{Text="Hello, hello", Email="jirka.novotny@seznam.cz", DateTimeOfCreation=new DateTime(2020,4,14,21,23,55), Product=products[2]},
                new Question{Text="Good morning. My iphone was broken by my wife yesterday, what should i do?", Email="stevejobs@apple.com", Product=products[7], DateTimeOfCreation=new DateTime(2019,3,22,15,53,43)}
                 };


                context.Questions.AddRange(questions);



                context.SaveChanges();

            }
        }

       
    }
}
