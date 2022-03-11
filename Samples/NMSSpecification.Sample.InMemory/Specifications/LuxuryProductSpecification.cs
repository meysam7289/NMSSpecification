using System.Linq.Expressions;
using NMSSpecification.Sample.InMemory.Model;
using NMSSpecification.Abstract;

namespace NMSSpecification.Sample.InMemory.Specifications
{
    public class LuxuryProductSpecification : CompositeSpecification<Product>
    {
        public override bool IsSatisfiedBy(Product candidate)
        {
            var specs =  new ExpensiveProductSpecification().And(new GoldColorProductSpecification());
            return specs.IsSatisfiedBy(candidate);
        }
    }
}