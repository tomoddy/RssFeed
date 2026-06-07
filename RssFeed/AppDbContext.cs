using Microsoft.EntityFrameworkCore;

namespace RssFeed
{
    /// <summary>
    /// Database context for the application
    /// </summary>
    /// <param name="options">Context options</param>
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        /// <summary>
        /// RSS feed posts
        /// </summary>
        public DbSet<Post> RSS { get; set; }
    }
}