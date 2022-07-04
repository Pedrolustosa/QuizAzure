using Microsoft.EntityFrameworkCore;

namespace QuizAzureAPI.Models
{
    public class QuizAzureDBContext : DbContext
    {
        public QuizAzureDBContext(DbContextOptions<QuizAzureDBContext> options) : base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
