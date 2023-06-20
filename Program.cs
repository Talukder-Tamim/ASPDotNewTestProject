// See https://aka.ms/new-console-template for more information
using EFCoreExample.Database;
using EFCoreExample.EntityModels;

Category aCategory = new Category()
{
    Name = "Electronics",
    Description = "This is a Electronic Category"
};

Product aProduct = new Product()
{
    ProductNo = "P123",
    ProductName = "Yamaha",
};

Customer aCustomer = new Customer()
{
    firstName = "Tamim",
    lastName = "Talukder",
    Address =  "Demra, Dhaka",
    dateOfBirth = "22/08/1995",
    gender = "Male"
};

ApplicationDbContext db = new ApplicationDbContext();

db.Categories.Add(aCategory);
db.Products.Add(aProduct);
db.Customers.Add(aCustomer);


int successCount = db.SaveChanges();

if (successCount > 0)
{
    Console.WriteLine("Total number of affected row:"+ successCount + "");
}
else
{
    Console.WriteLine("Data update failed");
}
