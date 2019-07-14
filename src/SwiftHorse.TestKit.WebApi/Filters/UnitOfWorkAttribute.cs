using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SwiftHorse.Repository.EntityFrameworkCore;
using SwiftHorse.TestKit.Infrastructure;

namespace SwiftHorse.TestKit.WebApi.Filters
{
    public class UnitOfWorkAttribute : ServiceFilterAttribute
    {
        public UnitOfWorkAttribute() : base(typeof(UnitOfWorkFilter)) { }
    }

    public class UnitOfWorkFilter : IActionFilter
    {
        private readonly IDbContextProvider<TestKitDbContext> _dbContextProvider;

        public UnitOfWorkFilter(IDbContextProvider<TestKitDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _dbContextProvider.GetDbContext().SaveChanges();
        }
    }
}
