﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

public class Program
{
    private static void Main(string[] args)
    {
        //ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var item in categoryManager.GetAll().Data)
        {
            Console.WriteLine(item.CategoryName);
        }  
    }

    //private static void ProductTest()
    //{
    //    ProductManager productManager = new ProductManager(new EfProductDal(), categ);

    //    var result = productManager.GetProductDetails();

    //    if (result.Success == true)
    //    {
    //        foreach (var product in result.Data)
    //        {
    //            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine(result.Message);
    //    }

        
    //}
}