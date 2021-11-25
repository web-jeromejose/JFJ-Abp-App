using Jfj.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Jfj.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}