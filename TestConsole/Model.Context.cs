﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsole
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IndustrialMonitoringEntities : DbContext
    {
        public IndustrialMonitoringEntities()
            : base("name=IndustrialMonitoringEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemsLog> ItemsLogs { get; set; }
        public virtual DbSet<ItemsLogLatest> ItemsLogLatests { get; set; }
        public virtual DbSet<NotificationItem> NotificationItems { get; set; }
        public virtual DbSet<NotificationItemsLog> NotificationItemsLogs { get; set; }
        public virtual DbSet<NotificationItemsLogLatest> NotificationItemsLogLatests { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Tab> Tabs { get; set; }
        public virtual DbSet<TabsItem> TabsItems { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersItemsPermission> UsersItemsPermissions { get; set; }
        public virtual DbSet<UsersServicesPermission> UsersServicesPermissions { get; set; }
    }
}