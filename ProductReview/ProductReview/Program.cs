// See https://aka.ms/new-console-template for more information

using System;

namespace ProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManagement getMethod = new ProductManagement();
            var table = getMethod.AddData();
            getMethod.ViewData(table);
        }
    }
}