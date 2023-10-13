//using Service.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DLL_Namespace_Abstraction.Controller
//{
//    internal class ProductController

//    {
//        private readonly ProductService _productService;
//        public ProductController()
//        {
//            _productService = new ProductService();
//        }
//        public void GetAllByCount()
//        {
//            foreach( var item in _productService.GetAllByCount(14))
//            {
//                Console.WriteLine($"{item.Name} - {item.Count} - {item.Color}");
//            }
//        }
//    }
//}
