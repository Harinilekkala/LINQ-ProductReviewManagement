using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    public class ProductManagement
    {
        //UC-1 Creating table gor adding and dispalying the data
        public List<ProductModel> AddData()
        {
            List<ProductModel> table = new List<ProductModel>()
            {
                new ProductModel() {productID = 10, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 10, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 10, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 11, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 11, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 11, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 12, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 12, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 12, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 13, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 13, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 13, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 14, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 14, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 14, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 15, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 15, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 15, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 16, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 16, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 16, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 17, userID = 1, rating = 4.2, review = "Good", isLike = true},
                new ProductModel() {productID = 17, userID = 2, rating = 3.0, review = "Bad", isLike  = false},
                new ProductModel() {productID = 17, userID = 3, rating = 3.7, review = "Okay", isLike = true},
                new ProductModel() {productID = 18, userID = 1, rating = 4.2, review = "Good", isLike = true}
            };
            return table;
        }
        public void ViewData(List<ProductModel> model)
        {
            foreach (var data in model)
            {
                Console.WriteLine("ProductID: " + data.productID + "\t --------\t UserID: " + data.userID + "\t -------- \t Rating: " + data.rating + "\t -------- Review: " +
                    data.review + "\t -------- \t IsLike: " + data.isLike);
            }
        }
        
        //Uc-2 for displaying records to which is have high rating

        public void TopThreeData(List<ProductModel> products)
        {
            var data = (from item in products orderby item.rating descending select item).Take(3);

            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tUserID: " + item.userID + "\tRating: " + item.rating + "\tReview: " +
                     item.review + "\tIsLike: " + item.isLike);
            }
        }

        //Uc-3 displaying greater than 3 records of high rate

        public void SpecificRecords(List<ProductModel> products)
        {
            var data = from item in products
                       where item.rating > 3 && (item.productID == 11 || item.productID == 14 || item.productID == 17)
                       select item;

            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tUserID: " + item.userID + "\tRating: " + item.rating + "\tReview: " +
                     item.review + "\tIsLike: " + item.isLike);
            }
        }
    }
}
