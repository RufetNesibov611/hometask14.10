using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductService
    {
        private Product[] GetAll()
        {
            return new Product[]
            {
                new Product{ Id =1 , Name ="iphone 14" , Price = 3000 , Color = "White" , Count = 10 },
                new Product{ Id =2 , Name ="iphone 12" , Price = 2000 , Color = "Black" , Count = 20 },
                new Product{ Id =3 , Name ="iphone 11" , Price = 1000 , Color = "Sliver" , Count = 5 },
                new Product{ Id =4 , Name ="iphone 15" , Price = 4000 , Color = "White" , Count = 10},
            };
        }

        public Product[] GetAllByCount(int count)
        {
            Product[] products = GetAll();
            return products.Where(m=>m.Count > count).ToArray();
        }


    }
}
