using Activity3_2.Models;
using Activity3_2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity3_2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();
            return View(products.GetAllProducts());
        }
        public IActionResult Search(string searchTerm)
        {
            return View();
        }
        public IActionResult SearchResult(string searchTerm)
        {
            ProductsDAO product = new ProductsDAO();
            List<ProductModel> productList = product.SearchProducts(searchTerm);
            return View("index",productList);
        }
        public IActionResult ShowDetails(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }
        public IActionResult ShowOneProductJson(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return Json(foundProduct);
        }
        public IActionResult EditForm(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("EditForm", foundProduct);
        }
        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index",products.GetAllProducts());
        }
        public IActionResult ProcessEditPartial(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return PartialView("_productCard", product);
        }
        public IActionResult Delete(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            products.Delete(foundProduct);
            return View("Index", products.GetAllProducts());
        }
        public IActionResult Create()
        {
            return View("CreateForm");
        }
        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Insert(product);
            return View("Index", products.GetAllProducts());
        }
    }
}
