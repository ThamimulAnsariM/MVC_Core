using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {

        static List<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel(){Price=500, ProductId=10, ProductCode="P001", ProductName="Samsung"}
        };

        //Action method
        [Route("Id")]
        [HttpGet]
        public IActionResult GetProductInfo()
        {
            ProductViewModel productVM = new ProductViewModel()
            {
                Price = 15000,
                ProductId = 1,
                ProductName = "Acer",
                ProductCode = "P001"
            };
            //ViewData["Product"] = productViewModel;
            return View("GetProductInfo", productVM);    //Strongly typed view
        }


        [Route("Add")]
        [HttpGet]
        public IActionResult Create()

        {
            return View("CreateV1");
        }


        [Route("save")]
        [HttpPost]
        public IActionResult save(ProductViewModel product)
        {
            if (string.IsNullOrEmpty(product.ProductCode)/*&& DuplicateProduct(product.ProductName)*/)
            {
                ModelState.AddModelError("DuplicateCheck", "Product NAme is already exist");
            }
            if (ModelState.IsValid)
            {
                products.Add(product);
                //return View("Thankyou");
                return RedirectToAction("Summary", "product");
            }
            
                return View("CreateV1");
       

        }

        [HttpGet]
        [Route("product-list")]
        public IActionResult Summary(int view = 0)
        {
            if (view != 0)
            {
                return View("ProductCards", products);
            }
            else
            {
                return View("ProductList", products);
            }

        }
        #region Private Methods
        //private bool DuplicateProduct(string productName)
        //{
        //    var isExist = products.Where(s => s.ProductName.ToLower() == productName.ToLower()).Any();
        //    return isExist;
        //}
        #endregion
    }
}
