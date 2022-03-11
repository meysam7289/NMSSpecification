// See https://aka.ms/new-console-template for more information
using NMSSpecification.Sample.InMemory.SampleData;
using NMSSpecification.Sample.InMemory.Specifications;

Console.WriteLine("NMSSpecification.Sample.InMemory started!!!");

var luxuryProductSpecification = new LuxuryProductSpecification();
var luxuryPruducts = SampleProducts.List().Where(x=>luxuryProductSpecification.IsSatisfiedBy(x));

var expensiveProductSpecification = new ExpensiveProductSpecification();
var expensiveProducts = SampleProducts.List().Where(x=>expensiveProductSpecification.IsSatisfiedBy(x));

var goldColorProductSpecification = new GoldColorProductSpecification();
var goldColorProducts = SampleProducts.List().Where(x=> goldColorProductSpecification.IsSatisfiedBy(x));

Console.WriteLine("luxuryPruducts is: {0}",string.Join(',', luxuryPruducts.Select(x=>x.Name).ToArray()));
Console.WriteLine("expensiveProducts is: {0}",string.Join(',', expensiveProducts.Select(x=>x.Name).ToArray()));
Console.WriteLine("goldColorProducts is: {0}",string.Join(',', goldColorProducts.Select(x=>x.Name).ToArray()));