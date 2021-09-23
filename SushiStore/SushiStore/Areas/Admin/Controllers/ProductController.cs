using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using SushiStore.DAL;
using SushiStore.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using SushiStore.Services;
using SushiStore.DTO.Product;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace WebApplicationPR.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public IWebHostEnvironment _env;
        private readonly IMapper _mapper;
        public ProductController(AppDbContext context, IWebHostEnvironment env, IMapper mapper)
        {
            _context = context;
            _env = env;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.Include(p=>p.Category).Include(p=>p.Prices).Where(p => !p.IsDeleted).OrderByDescending(p=>p.Id).Take(8).ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(c =>!c.IsDeleted).ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductForCreate productDto)
        {
            ViewBag.Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (productDto.ImageFile == null)
            {
                ModelState.AddModelError("", "Sekil mutleq secilmelidir");
                return View(productDto);
            }

            if (!await _context.Categories.AnyAsync(c =>!c.IsDeleted && c.Id == productDto.CategoryId))
            {
                ModelState.AddModelError("", "Kateqoriya duzgun secilmelidir");
                return View(productDto);
            }

            if(await _context.Products.AnyAsync(p => !p.IsDeleted && p.Name.ToLower() == productDto.Name.ToLower()))
            {
                ModelState.AddModelError("", "Bu adda mehsul artiq movcuddur");
                return View(productDto);
            }

            if (!productDto.ImageFile.CheckFileType("image/"))
            {
                ModelState.AddModelError("ImageFile", "Yalniz sekil secile biler");
                return View(productDto);
            }

            if (productDto.ImageFile.CheckFileSize(300))
            {
                ModelState.AddModelError("ImageFile", "Maksimum olcu 300 ola biler.");
                return View(productDto);
            }

            productDto.Image = await productDto.ImageFile.SaveFileAsync(_env.WebRootPath, Path.Combine("assets", "images", "products"));

            Product product = _mapper.Map<Product>(productDto);


            ProductPrice prices = new ProductPrice()
            {
                OldPrice = productDto.OldPrice,
                CurrentPrice = (decimal)Convert.ToDouble(productDto.CurrentPrice),
                ShowOldPrice = productDto.ShowOldPrice
            };

            if(productDto.Oils!=null|| productDto.Oils != null&& productDto.Carbohydrates != null|| productDto.Proteins!= null|| productDto.Calories != null)
            {
                Nutrition nutrition = new Nutrition()
                {
                    Oils = productDto.Oils,
                    Carbohydrates = productDto.Carbohydrates,
                    Proteins = productDto.Proteins,
                    Calories = productDto.Calories
                };
                product.Nutrition = nutrition;
            }
            
            product.CategoryId = productDto.CategoryId;
            product.Prices = prices; 
            product.ProductCode = Guid.NewGuid().ToString() + product.Id;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

     
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            Product product = await _context.Products.
                Include(p => p.Category).
                Include(p => p.Prices).
                Include(p => p.Nutrition).FirstOrDefaultAsync(p => !p.IsDeleted && p.Id == id);

            if (product == null) return NotFound();

            ViewBag.Categories = await _context.Categories.Where(c =>!c.IsDeleted).ToListAsync();

            ProductForCreate productDto = _mapper.Map<ProductForCreate>(product);
            if(product.Nutrition != null)
            {
                productDto.Calories = product.Nutrition.Calories;
                productDto.Carbohydrates = product.Nutrition.Carbohydrates;
                productDto.Oils = product.Nutrition.Oils;
                productDto.Proteins = product.Nutrition.Proteins;
            }
            productDto.CurrentPrice = product.Prices.CurrentPrice;
            productDto.OldPrice = product.Prices.OldPrice;
            productDto.ShowOldPrice = product.Prices.ShowOldPrice;
            

            return View(productDto);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ProductForCreate newproduct)
        {
            if (id == null) return NotFound();


            Product dbProduct = await _context.Products.
                Include(p => p.Prices).
                Include(p=>p.Category).
                Include(p => p.Nutrition).
                FirstOrDefaultAsync(p => !p.IsDeleted && p.Id == id);


            if (dbProduct == null) return NotFound();

            ViewBag.Categories = await _context.Categories.Where(c =>!c.IsDeleted).ToListAsync();
            
            

            if(!await _context.Categories.AnyAsync(c => !c.IsDeleted && c.Id == newproduct.CategoryId))
            {
                newproduct.CategoryId = dbProduct.CategoryId;
                newproduct.Image = dbProduct.Image;
                ModelState.AddModelError("", "Duzgun kateqoriya secilmelidir");
                return View(newproduct);
            }
 
            if(await _context.Products.AnyAsync(p=>!p.IsDeleted&&p.Name.ToLower()==newproduct.Name.ToLower()&&p.Id != id))
            {
                ModelState.AddModelError("Name", "Bu adda mehsul artiq movcuddur");
                return View(newproduct);
            }

            if (newproduct.ImageFile != null)
            {

                if (newproduct.ImageFile.CheckFileSize(300))
                {
                    ModelState.AddModelError("Images", "Faylin olcusu maksimum 300kb ola biler");
                    return View(newproduct);
                }

                if (!newproduct.ImageFile.CheckFileType("image"))
                {
                    ModelState.AddModelError("Images", "Fayl yalniz sekil ola biler");
                    return View(newproduct);
                }


                newproduct.Image = await newproduct.ImageFile.SaveFileAsync(_env.WebRootPath, Path.Combine("assets", "images", "products"));

                FileCheck.DeleteFile(dbProduct.Image, _env.WebRootPath, Path.Combine("assets", "images", "products"));

            }

            Product product = _mapper.Map<Product>(newproduct);


            ProductPrice prices = new ProductPrice()
            {
                OldPrice = newproduct.OldPrice,
                CurrentPrice = Convert.ToDecimal(newproduct.CurrentPrice),
                ShowOldPrice = newproduct.ShowOldPrice
            };

            Nutrition nutrition = new Nutrition()
            {
                Oils = newproduct.Oils,
                Carbohydrates = newproduct.Carbohydrates,
                Proteins = newproduct.Proteins,
                Calories = newproduct.Calories
            };

            dbProduct.Nutrition = nutrition;
            dbProduct.Prices = prices;
            dbProduct.LastUpdateDate = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Product product = await _context.Products.
                Include(p=>p.Category).
                Include(p => p.Prices).
                Include(p => p.Nutrition).FirstOrDefaultAsync(p => !p.IsDeleted && p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Product product = await _context.Products.
            Include(p => p.Category).
            Include(p => p.Prices).
            Include(p => p.Nutrition).FirstOrDefaultAsync(p => !p.IsDeleted && p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null) return NotFound();

            Product product = await _context.Products.
             Include(p => p.Category).
             Include(p => p.Prices).
             Include(p => p.Nutrition).FirstOrDefaultAsync(p => !p.IsDeleted && p.Id == id);

            if (product == null) return NotFound();

            
            FileCheck.DeleteFile(product.Image, _env.WebRootPath, Path.Combine("assets", "images", "products"));
            product.Image = null;
            
            product.IsDeleted = true;
            product.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
