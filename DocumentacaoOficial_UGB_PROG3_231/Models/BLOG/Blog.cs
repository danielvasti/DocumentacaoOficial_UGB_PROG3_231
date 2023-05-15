using DocumentacaoOficial_UGB_PROG3_231.Models.POST;

namespace DocumentacaoOficial_UGB_PROG3_231.Models.BLOG
{
    public class Blog
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual Uri SiteUri { get; set; }
        public ICollection<Post> Posts { get; }
    }
}
