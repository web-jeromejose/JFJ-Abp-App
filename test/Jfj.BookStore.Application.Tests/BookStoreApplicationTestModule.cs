using Volo.Abp.Modularity;

namespace Jfj.BookStore
{
    [DependsOn(
        typeof(BookStoreApplicationModule),
        typeof(BookStoreDomainTestModule)
        )]
    public class BookStoreApplicationTestModule : AbpModule
    {

    }
}