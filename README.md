# NMSSpecification - Specification pattern on .net
## What is the Specification Pattern?
When selecting a subset of objects, it allows to separate the statement of **what kind of objects can be selected** from the **object that does the selection**. 

Ex: 

> A cargo has a separate storage specification to describe what kind of
> container can contain it. The specification object has a clear and
> limited responsibility, which can be separated and decoupled from the
> domain object that uses it.

## What can you do with Specification Pattern?
1. **Validate an object** or check that only suitable objects are used for a certain role
2. **Select a subset of objects** based a specified criteria, and refresh the selection at various times
3. Describe what an object might do, without explaining the details of how the object does it, but in such a way that **a candidate might be built to fulfill the requirement**

## How to use:
### 1: `Linq expression based Specification` ##
use `Specification<T>` as parent class:
```csharp
public class ExpensiveProductSpecification : Specification<Product>
{
    public override Expression<Func<Product, bool>> AsExpression()
    {
        return x=>x.Price>=100000; //criteria
    }
}

//----------------------------------------------------------------

public class GoldColorProductSpecification : Specification<Product>
{
    public override Expression<Func<Product, bool>> AsExpression()
    {
        return x=>x.Color == ProductColor.Gold;
    }
}
```
### 2: `Composition based Specification` ##
use `CompositeSpecification<T>` as parent class:
```csharp
public class LuxuryProductSpecification : CompositeSpecification<Product>
{
    public override bool IsSatisfiedBy(Product candidate)
    {
        var specs =  new ExpensiveProductSpecification().And(new GoldColorProductSpecification());
        return specs.IsSatisfiedBy(candidate);
     }
}
```


## References:
http://martinfowler.com/apsupp/spec.pdf

https://domainlanguage.com/ddd/