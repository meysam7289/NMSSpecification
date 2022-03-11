using System.Linq.Expressions;
using NMSSpecification.Sample.InMemory.Model;
using NMSSpecification;

namespace NMSSpecification.Sample.InMemory.Specifications
{
    public class GoldColorProductSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> AsExpression()
        {
            return x=>x.Color == ProductColor.Gold;
        }
    }
}