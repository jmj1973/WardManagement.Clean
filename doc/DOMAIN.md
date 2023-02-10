
# Steps

```
dotnet add src/Core/WardManagement.Domain package Microsoft.Extensions.
DependencyInjection
dotnet add src/Core/WardManagement.Domain package Microsoft.Extensions.
Configuration       
```       

2.1. Create the BaseDomainEntity
   - Common\BaseDomainEntity.cs
   - Common\BaseAuditDomainEntity.cs

```    
    public abstract class BaseDomainEntiry
    {
        public int Id { get; set; }
    }
   
    public abstract class BaseAuditDomainEntity : BaseDomainEntiry
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set;}
    }
   
```

2.2. Create the Presistence Interfaces
   - Presistence\Interfaces\IGenericRepository.cs   
   - Presistence\Interfaces\IUnitOfWork.cs


Query Interface

```
    public interface IQueryObject
    {
        string SortBy { get; set; }
        bool IsSortAscending { get; set; }
        int Page { get; set; }
        int PageSize { get; set; }
    }
```

Query Result

``` 
    public class PageResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
    public class QueryResult<TEntity>
    {
        public PageResult Page { get; set; }
        public IEnumerable<TEntity> PageItems { get; set; }
    }
```
