﻿using elTransCustomer.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using RelTransCustomer.Application.Contracts.Services;
using RelTransCustomer.Application.DTOs.Customer;
using RelTransCustomer.Domain.Entities;
using System.Reflection.Emit;

namespace RelTransCustomer.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IDateTimeService _dateTime;
        private readonly IAuthenticatedUserService _authenticatedUser;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDateTimeService dateTime, IAuthenticatedUserService authenticatedUser) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTime = dateTime;
            _authenticatedUser = authenticatedUser;
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<CustomerStatement> CustomerStatements { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<OrderHistoryItem> OrderHistory { get; set; }
        public DbSet<OpenOrderItem> OpenOrders { get; set; }
        public DbSet<ActiveUserTracker> ActiveUserTrackers { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = _dateTime.CurrentDateTime;
                        entry.Entity.CreatedBy = _authenticatedUser.UserId ?? "Admin";
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedDate = _dateTime.CurrentDateTime
                            ;
                        entry.Entity.ModifiedBy = _authenticatedUser.UserId ?? "Admin";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CustomerStatement>().HasNoKey();
            builder.Entity<InvoiceDetail>().HasNoKey();
            builder.Entity<OrderHistoryItem>().HasNoKey();
            builder.Entity<OpenOrderItem>().HasNoKey();
            builder.Entity<ActiveUserTracker>()
      .HasNoKey();
            //All Decimals will have 18,6 Range
            foreach (var property in builder.Model.GetEntityTypes()
            .SelectMany(t => t.GetProperties())
            .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18,6)");
            }
            base.OnModelCreating(builder);
        }
    }
}