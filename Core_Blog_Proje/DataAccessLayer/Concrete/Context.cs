using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NKLMS7G\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Comment>()
                .HasOne(x => x.AppUser)
                .WithMany(y => y.Comments)
                .HasForeignKey(z => z.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Comment>()
                .HasOne(x => x.Blog)
                .WithMany(y => y.Comments)
                .HasForeignKey(z => z.BlogID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<About> Abouts {get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<MailSubscribe> MailSubscribes { get; set; }

        public DbSet<BlogRating> BlogRatings { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Message> Messages { get; set; }


    }
}
