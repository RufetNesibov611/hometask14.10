﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
     public class CaculateService
    {
        public string Calculate(double num1, double num2, string operation)
        {
            string result;
            switch(operation )
            {
                case "+":
                    result = (num1 + num2).ToString();
                    return result;
                case "-":
                    result =  (num1 - num2).ToString();
                    return result;
                    
                case "*":
                    result = (num1 * num2).ToString();
                    return result;
                case "/":
                    result = (num1 / num2).ToString();
                    return result;
                default:
                    result = "Operation invaild";
                    return result;
                    
            }
        }
    }
}
