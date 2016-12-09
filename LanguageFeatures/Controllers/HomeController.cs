﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() // => View(Product.GetProducts().Select(p => p?.Name));
        {
            var products = new[] {
                  new { Name = "Kayak", Price = 275M },
                  new { Name = "Lifejacket", Price = 48.95M },
                  new { Name = "Soccer ball", Price = 19.50M },
                  new { Name = "Corner flag", Price = 34.95M }
              };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));


            // first product format
            /*
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }

            return View(results);
            */

            // lambada Filter shoppingCart
            /*
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };



            Product[] productArray = {
                  new Product {Name = "Kayak", Price = 275M},
                  new Product {Name = "Lifejacket", Price = 48.95M},
                  new Product {Name = "Soccer ball", Price = 19.50M},
                  new Product {Name = "Corner flag", Price = 34.95M}
              };

            decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(p => p?.Name[0] == 'S').TotalPrices();

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"});
            */
        }
    }
}
