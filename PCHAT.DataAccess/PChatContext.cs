using Microsoft.EntityFrameworkCore;
using PCHAT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCHAT.DataAccess
{
    public class PChatContext : DbContext
    {
        public PChatContext(DbContextOptions<PChatContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>().Property(x => x.UserName).IsRequired();
            modelbuilder.Entity<User>().Property(x => x.PasswordHash).IsRequired();
            modelbuilder.Entity<User>().Property(x => x.Gender).IsRequired();

            modelbuilder.Entity<User>().HasMany<Message>();

            modelbuilder.Entity<Message>().HasOne<User>();

            modelbuilder.Entity<Message>()
                .HasOne(x => x.Sender)
                .WithMany(x => x.MessagesSent)
                .OnDelete(DeleteBehavior.Restrict);

            modelbuilder.Entity<Message>()
                .HasOne(x => x.Recipient)
                .WithMany(x => x.MessagesRecieved)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
