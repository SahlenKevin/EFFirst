// See https://aka.ms/new-console-template for more information

using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;


using var productContext = new ProductContext();

//productContext.Products.Add(
//    new()
//    {
//        Name = "Banan",
//        Description = "Ett bär",
//        Price = 4.5
//    }
//);

//productContext.Products.Add(
//    new()
//    {
//        Name = "Äpple",
//        Description = "En stenfrukt",
//        Price = 10.5
//    }
//);

//productContext.SaveChanges();


//var products = productContext.Products.ToList();

//foreach (var product in products)
//{
//    Console.WriteLine($"{product.Id}: {product.Name}, {product.Description} Pris: {product.Price}");
//}

//var productsBefore = productContext.Products;

//foreach (var product in productsBefore)
//{
//    product.Price *= 0.9;
//}


//var bananas = productContext.Products.Find(1);
//Console.WriteLine($"{bananas.Id} {bananas.Name} {bananas.Description} {bananas.Price}");

//bananas.Price *= 1.1;
//bananas.Description = "Ett gult bär";

//productContext.Update(bananas);

//productContext.SaveChanges();

//var prod1 = productContext.Products.Find(1);
//var pro2 = productContext.Products.Find(2);

//productContext.Remove(prod1);
//productContext.Remove(pro2);

//productContext.SaveChanges();





//var productsStartingWithB = db.Products.Where(p => p.Name.StartsWith("B")).ToList();

//productsStartingWithB.ForEach(p => p.Price *= 1.1);

//db.Products.UpdateRange(productsStartingWithB);
//db.SaveChanges();
//foreach (var product in productsStartingWithB)
//{
//    Console.WriteLine(product.Name);
//}

//var niklasFrukthandel = new Store();
//niklasFrukthandel.Name = "Niklas Frukthandel";

//productContext.Stores.Add(niklasFrukthandel);

var niklasFrukthandel =
    productContext.
        Stores.
        Include(s => s.Products).
        FirstOrDefault(s => s.Id == 1);

var banana = productContext.Products.Find(1);
var apple = productContext.Products.Find(2);

niklasFrukthandel.Products.Add(banana);
niklasFrukthandel.Products.Add(apple);

productContext.SaveChanges();
