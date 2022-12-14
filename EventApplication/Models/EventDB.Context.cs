//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EventDBEntities : DbContext
    {
        public EventDBEntities()
            : base("name=EventDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Light> Lights { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<BookingEquipment> BookingEquipments { get; set; }
        public DbSet<BookingFood> BookingFoods { get; set; }
        public DbSet<BookingLight> BookingLights { get; set; }
        public DbSet<BookingFlower> BookingFlowers { get; set; }
        public DbSet<BookingVenue> BookingVenues { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
    }
}
