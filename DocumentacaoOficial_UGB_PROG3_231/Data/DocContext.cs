using DocumentacaoOficial_UGB_PROG3_231.Models.BLOG;
using DocumentacaoOficial_UGB_PROG3_231.Models.POST;
using Microsoft.EntityFrameworkCore;

namespace DocumentacaoOficial_UGB_PROG3_231.Data
{
    public class DocContext : DbContext
    {
        public DocContext(DbContextOptions<DocContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
