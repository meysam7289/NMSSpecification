using System.Linq.Expressions;
using NMSSpecification.Sample.InMemory.Model;

namespace NMSSpecification.Sample.InMemory.Specifications
{
    public class ExpensiveProductSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> AsExpression()
        {
            return x=>x.Price>=100000;
        }
    }
}