using Microsoft.EntityFrameworkCore;
using ArticleWeb.ViewModels;

namespace Article.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<UserInformationModel> UserInformationDb { get; set; }
    }
}
