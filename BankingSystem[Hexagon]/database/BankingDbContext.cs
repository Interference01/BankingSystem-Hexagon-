﻿using BankingSystem_Hexagon_.database.entities;
using System.Data.Entity;

namespace BankingSystem_Hexagon_.database
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext() : base("name = BankingDBConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BankingDbContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
