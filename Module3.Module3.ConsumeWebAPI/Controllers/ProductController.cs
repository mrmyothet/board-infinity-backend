using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module3.Module3.ConsumeWebAPI.Models;
using Newtonsoft.Json;

namespace Module3.Module3.ConsumeWebAPI.Controllers;

public class ProductController : Controller
{
    private readonly string baseUrl = "https://localhost:7006/";

    // GET: ProductController
    public async Task<ActionResult> Index()
    {
        List<Product> products = new List<Product>();

        string productsUrl = baseUrl + "api/products";

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(productsUrl);

            string jsonResponse = await response.Content.ReadAsStringAsync();
            if (jsonResponse is null)
                return BadRequest(jsonResponse);

            products = JsonConvert.DeserializeObject<List<Product>>(jsonResponse)!;
        }

        return View(products);
    }

    // GET: ProductController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: ProductController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ProductController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ProductController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: ProductController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ProductController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: ProductController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
