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

            Console.WriteLine(" Enter Option To Display Data \n----------------------------------------------\n1. To View Data\n2. To view Top 3 Data\n3. To view Rating > 3\n4. To Count ProductID \n5. To view ProductID and Review From Record List" +
                "\n\nEnter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    {
                        getMethod.ViewData(table);
                        break;
                    }
                case 2:
                    {
                        getMethod.TopThreeData(table);
                        break;
                    }

                case 3:
                    {
                        getMethod.SpecificRecords(table);
                        break;
                    }

                case 4:
                    {
                        getMethod.Count(table);
                        break;
                    }

                case 5:
                    {
                        getMethod.SelectOperator(table);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid Number");
                        break;
                    }
            }
        }
    }
}