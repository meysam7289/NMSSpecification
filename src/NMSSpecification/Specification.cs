using System.Linq.Expressions;
using NMSSpecification.Abstract;

namespace NMSSpecification
{
    public abstract class Specification<T> : CompositeSpecification<T>
    {
        public abstract Expression<Func<T,bool>> AsExpression();
        public override bool IsSatisfiedBy(T candidate)
        {
            return AsExpression().Compile()(candidate);
        }
    }
}