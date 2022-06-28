// See https://aka.ms/new-console-template for more information

using System;
using System.Data;

namespace ProductReview
{
    public class Program
    {



        public static void Main(string[] args)
        {
            ProductManagement getMethod = new ProductManagement();
            var table = getMethod.AddData();
            var dataTable = getMethod.DataTable();

            Console.WriteLine("1 - Add And Display Review \n2 - Get Top Three Reviews \n3 - Sort By Rating Of Products 101,103,105" +
               "\n4 - Get Product Review Count \n5 - Select Specific Column \n6 - Skip Top Five Review \n7 - Add And Display Review Usign DataTable" +
               "\n8 - Sort By Is Like \n10 - Sort By Review Message");
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
                case 6:
                    {
                        getMethod.SkipRecords(table);
                        break;
                    }
                case 7:
                    {
                        getMethod.ViewDataTable(dataTable);
                        break;
                    }

                case 8:
                    {
                        getMethod.IsLike(dataTable);
                        break;
                    }

                case 9:
                    {
                        getMethod.AverageRating(dataTable);
                        break;
                    }

                case 10:
                    getMethod.ReviewMessage(dataTable);
                    break;

                default:
                    {
                        Console.WriteLine("Enter a valid Number");
                        break;
                    }
            }
        }
    }
}
