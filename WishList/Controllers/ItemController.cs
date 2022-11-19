﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _context;

        ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listOfItems = _context.Items.ToList();
            return View("Index", listOfItems);
        }
        [HttpGet]
    public IActionResult Create()
    {
        return View("Create");
    }
    [HttpPost]
    public IActionResult Create(Item item)
    {
        _context.Items.Add(item);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Delete(int id)
    {
        Item item = _context.Items.FirstOrDefault(r => r.Id == id);
        _context.Items.Remove(item);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
}
