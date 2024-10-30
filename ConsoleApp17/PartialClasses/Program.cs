using PartialClasses;

Product p = new Product()
{
    ProductID = (int)EnumGroups.ProductID,
    ProductName = "Test",
    ProductCost=100
};
p.PrintBill();