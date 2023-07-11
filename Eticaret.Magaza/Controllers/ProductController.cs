﻿using Microsoft.AspNetCore.Mvc;
using Eticaret.Model;
using Eticaret.Magaza.Services;

namespace Eticaret.Magaza.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet, Route("")]
        public async Task<IActionResult> Index()
        {
            List<Product>? products = await _productService.GetAllAsync();
            return View(products);
        }

        [HttpGet, Route("edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            Product? product = await _productService.GetAsync(id);
            return View(product);
        }

        [HttpPost, Route("edit")]
        public async Task<IActionResult> Update(Product model)
        {
            await _productService.UpdateAsync(model);
            return RedirectToAction("Index");
        }
        
        [HttpGet, Route("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost, Route("new")]
        public async Task<IActionResult> New(Product model)
        {
            await _productService.CreateAsync(model);
            return RedirectToAction("Index");
        }
    }
}
