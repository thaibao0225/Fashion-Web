using Fashion_Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Fashion_Fuction.Services;
using System.Security.Claims;
using Fashion_Fuction.Extension;
using Fashion_Fuction.Models;
using Fashion_Infrastructure.Data.StaticData;
using Abp.Domain.Uow;
using Fashion_Fuction.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Admin.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;
        private IProductService _productService;
        private IBufferedFileUploadService _bufferedFileUploadService;
        private ICategoryService _categoryService;
        //private readonly IUnitOfWorkManager _unitOfWorkManager;

        public ProductsController(ApplicationDbContext context, IBufferedFileUploadService bufferedFileUploadService
            //, IUnitOfWorkManager unitOfWorkManager
            ,IProductService productService
            )
        {
            _context = context;
            //_productService = new ProductService(context);
            _productService = productService;
            _categoryService = new CategoryService(context);
            _bufferedFileUploadService = bufferedFileUploadService;
            //_unitOfWorkManager = unitOfWorkManager;
        }
        // GET: ProductsController
        [Route("/products")]
        public ActionResult Index()
        {
            return View(_productService.GetAllList());
        }

        // GET: ProductsController/Details/5
        [Route("/products/details")]
        public ActionResult Details(string id)
        {
            return View(_productService.GetProductById(id));
        }

        // GET: ProductsController/Create
        [Route("/products/create")]
        public ActionResult Create()
        {

            ViewBag.categoryList = _categoryService.GetAllCategory();


            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [Route("/products/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection,
            IFormFile product_ImgFile1,
            IFormFile product_ImgFile2,
            IFormFile product_ImgFile3,
            IFormFile product_ImgFile4,
            IFormFile product_ImgFile5)
        {
            try
            {
                ProductModel productModel = new ProductModel();
                productModel.product_Id = collection["product_Id"];
                productModel.product_Name = collection["product_Name"];
                productModel.product_Description = collection["product_Description"];
                productModel.product_ShortDescription = collection["product_ShortDescription"];
                productModel.product_Price = double.Parse(collection["product_Price"]);
                productModel.product_Type = collection["product_Type"];
                productModel.product_CategoryId = collection["product_CategoryId"];


                string productFileName1 = "";
                string productFileName2 = "";
                string productFileName3 = "";
                string productFileName4 = "";
                string productFileName5 = "";

                if (product_ImgFile1 != null)
                {
                    productFileName1 = product_ImgFile1.FileName;
                    productModel.product_Img1 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName1;
                }

                if (product_ImgFile2 != null)
                {
                    productFileName2 = product_ImgFile2.FileName;
                    productModel.product_Img2 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName2;
                }

                if (product_ImgFile3 != null)
                {
                    productFileName3 = product_ImgFile3.FileName;
                    productModel.product_Img3 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName3;
                }

                if (product_ImgFile4 != null)
                {
                    productFileName4 = product_ImgFile4.FileName;
                    productModel.product_Img4 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName4;
                }

                if (product_ImgFile5 != null)
                {
                    productFileName5 = product_ImgFile5.FileName;
                    productModel.product_Img5 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName5;
                }

                await _bufferedFileUploadService.UploadFile(product_ImgFile1, productFileName1, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile2, productFileName2, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile3, productFileName3, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile4, productFileName4, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile5, productFileName5, productModel.product_Id);

                await _productService.CreateProduct(productModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        [Route("/products/edit")]
        public ActionResult Edit(string id)
        {
            ViewBag.categoryList = _categoryService.GetAllCategory();

            return View(_productService.GetProductById( id));
        }

        // POST: ProductsController/Edit/5
        [Route("/products/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(IFormCollection collection,
            IFormFile product_ImgFile1,
            IFormFile product_ImgFile2,
            IFormFile product_ImgFile3,
            IFormFile product_ImgFile4,
            IFormFile product_ImgFile5)
        {
            try
            {
                //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                ProductModel productModel = new ProductModel();
                productModel.product_Id = collection["product_Id"];
                productModel.product_Name = collection["product_Name"];
                productModel.product_Description = collection["product_Description"];
                productModel.product_ShortDescription = collection["product_ShortDescription"];
                productModel.product_Price = double.Parse(collection["product_Price"]);
                productModel.product_Type = collection["product_Type"];
                productModel.product_CategoryId = collection["product_CategoryId"];


                string productFileName1 = "";
                string productFileName2 = "";
                string productFileName3 = "";
                string productFileName4 = "";
                string productFileName5 = "";

                if (product_ImgFile1 != null)
                {
                    productFileName1 = product_ImgFile1.FileName;
                    productModel.product_Img1 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName1;
                }

                if (product_ImgFile2 != null)
                {
                    productFileName2 = product_ImgFile2.FileName;
                    productModel.product_Img2 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName2;
                }

                if (product_ImgFile3 != null)
                {
                    productFileName3 = product_ImgFile3.FileName;
                    productModel.product_Img3 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName3;
                }

                if (product_ImgFile4 != null)
                {
                    productFileName4 = product_ImgFile4.FileName;
                    productModel.product_Img4 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName4;
                }

                if (product_ImgFile5 != null)
                {
                    productFileName5 = product_ImgFile5.FileName;
                    productModel.product_Img5 = BaseData.ImgUrl + productModel.product_Id + "/" + productFileName5;
                }

                await _bufferedFileUploadService.UploadFile(product_ImgFile1, productFileName1, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile2, productFileName2, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile3, productFileName3, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile4, productFileName4, productModel.product_Id);
                await _bufferedFileUploadService.UploadFile(product_ImgFile5, productFileName5, productModel.product_Id);

                await _productService.UpdateProductById(productModel.product_Id, productModel);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        [Route("/products/delete")]
        public ActionResult Delete(string id)
        {
            return View(_productService.GetProductById(id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [Route("/products/delete")]
        [ValidateAntiForgeryToken]
        [UnitOfWork]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                string productId = collection["product_Id"];

                await _productService.DeleteProductById(productId);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
