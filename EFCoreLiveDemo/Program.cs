// See https://aka.ms/new-console-template for more information

using DataAccess;


using var productContext = new ProductContext();

productContext.Products.Add(
    new()
    {
        Name = "Banan",
        Description = "Ett bär",
        Price = 4.5
    }
);

productContext.Products.Add(
    new()
    {
        Name = "Äpple",
        Description = "En stenfrukt",
        Price = 10.5
    }
);

productContext.SaveChanges();

//var products = db.Products.ToList();
//var productsStartingWithB = db.Products.Where(p => p.Name.StartsWith("B")).ToList();

//productsStartingWithB.ForEach(p => p.Price *= 1.1);

//db.Products.UpdateRange(productsStartingWithB);
//db.SaveChanges();
//foreach (var product in productsStartingWithB)
//{
//    Console.WriteLine(product.Name);
//}