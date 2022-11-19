using Microsoft.EntityFrameworkCore;
using WishList.Models;


namespace WishList.Data
{
    public class ApplicationDbContext: DbContext
    {
        ApplicationDbContext(DbContextOptions options): base(options)
        { }

        public DbSet<Item> Item  {get; set; }

}
}
