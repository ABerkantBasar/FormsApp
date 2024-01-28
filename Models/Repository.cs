using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
         private static readonly List<Category> _categories = new();
        
static Repository(){
    _categories.Add(new Category{CategoryId=1,Name="Telefon"});
    _categories.Add(new Category{CategoryId=2,Name="Bilgisayar"});

    _products.Add(new Product{ProductId=1,Name="Iphone 14",Price=40000,IsActive=true,Image="14.jpg",CategoryId=1});
    _products.Add(new Product{ProductId=2,Name="Iphone 15",Price=50000,IsActive=true,Image="15.jpg",CategoryId=1});
    _products.Add(new Product{ProductId=3,Name="Iphone 14 Pro",Price=45000,IsActive=true,Image="14-pro.jpg",CategoryId=1});
    _products.Add(new Product{ProductId=4,Name="Iphone 13",Price=35000,IsActive=true,Image="13.jpg",CategoryId=1});
    _products.Add(new Product{ProductId=5,Name="Iphone 12",Price=30000,IsActive=true,Image="12.jpg",CategoryId=1});
    
    _products.Add(new Product{ProductId=6,Name="Macbook Air",Price=60000,IsActive=true,Image="Macbook Air.jpg",CategoryId=2});
    _products.Add(new Product{ProductId=7,Name="Macbook Pro",Price=70000,IsActive=true,Image="Macbook Pro.jpg",CategoryId=2});
}

        public static List<Product> Products
        {
            get{
                return _products;
            }
        }
        public static void CreateProduct(Product entity){
            _products.Add(entity);
        }

         public static void EditProduct(Product updatedProduct){
            var entity =_products.FirstOrDefault(p=>p.ProductId==updatedProduct.ProductId);
            if(entity!=null){
                entity.Name=updatedProduct.Name;
                entity.Price=updatedProduct.Price;
                entity.Image=updatedProduct.Image;
                entity.CategoryId=updatedProduct.CategoryId;
            }    
            
        
        }

        public static void DeleteProduct(Product deletedProduct){
            var entity =_products.FirstOrDefault(p=>p.ProductId==deletedProduct.ProductId);
            if(entity!=null){
                _products.Remove(entity);
            }  
        }
        public static List<Category> Categories
        {
            get{
                return _categories;
            }
        }

       

    }
}