using NMSSpecification.Sample.InMemory.Model;

namespace NMSSpecification.Sample.InMemory.SampleData
{
    public static class SampleProducts
    {
        public static List<Product> List(){
            return new List<Product>{
                new Product{
                    Id = 1,
                    Name = "Product1",
                    Price = 1230400,
                    Color = ProductColor.Red
                },
                new Product{
                    Id = 2,
                    Name = "Product2",
                    Price = 12562,
                    Color = ProductColor.Gold
                },
                new Product{
                    Id = 3,
                    Name = "Product3",
                    Price = 1230760,
                    Color = ProductColor.Gold
                },
                new Product{
                    Id = 4,
                    Name = "Product4",
                    Price = 121330400,
                    Color = ProductColor.Yellow
                },
                new Product{
                    Id = 5,
                    Name = "Product5",
                    Price = 167644000,
                    Color = ProductColor.Gold
                },
                new Product{
                    Id = 6,
                    Name = "Product6",
                    Price = 850000,
                    Color =ProductColor.Silver
                },
                new Product{
                    Id = 7,
                    Name = "Product7",
                    Price = 785154000,
                    Color = ProductColor.Gold
                }
            };
        }
    }
}

