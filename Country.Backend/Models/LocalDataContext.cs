namespace Country.Backend.Models
{
    using Domain;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Country.Domain.User> Users { get; set; }
    }
}