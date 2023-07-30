using FBSApp.Models;
using FBSApp.SupportClasses.PasswordHasher;
using Microsoft.EntityFrameworkCore;

namespace FBSApp.Data
{
    public class FBS_DB_Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public FBS_DB_Context(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Role).IsRequired();
            #region UserData
            modelBuilder.Entity<User>(user =>
            {
                byte[] salt;
                user.HasData(
                    new
                    {
                        Id = 1L,
                        Email = "admin@gmail.com",
                        Password = PasswordHasher.HashPassword("123", out salt),
                        Salt = salt,
                        Role = "ADMIN",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
            });
            #endregion
            modelBuilder.Entity<Country>().HasKey(r => r.Id);
            modelBuilder.Entity<Country>().Property(r => r.Name).IsRequired();
            modelBuilder.Entity<Country>().Property(r => r.Flag).IsRequired(false);
            #region CountryData
            modelBuilder.Entity<Country>(country =>
            {
                var names = new List<string>() { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan",
                                                 "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina",
                                                 "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep",
                                                 "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "DR Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus",
                                                 "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador",
                                                 "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany",
                                                 "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India",
                                                 "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya",
                                                 "Kiribati", "Korea North", "Korea South", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya",
                                                 "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta",
                                                 "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco",
                                                 "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway",
                                                 "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania",
                                                 "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino",
                                                 "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia",
                                                 "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden",
                                                 "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey",
                                                 "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan",
                                                 "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" };
                var id = 1L;
                foreach (var name in names)
                {
                    country.HasData(new { Id = id++, Name = name });
                }

            });
            #endregion
            modelBuilder.Entity<Address>().HasKey(u => u.Id);
            modelBuilder.Entity<Address>().Property(u => u.Street).IsRequired();
            modelBuilder.Entity<Address>().Property(u => u.City).IsRequired();
            modelBuilder.Entity<Address>().Property(u => u.Number).IsRequired(false);
            #region AddressData
            modelBuilder.Entity<Address>(address =>
            {
                address.HasData(new { Id = 1L, Street = "Sir Matt Busby Way", City = "Manchester" });
                address.HasData(new { Id = 2L, Street = "High Road", City = "London" });
                address.HasData(new { Id = 3L, Street = "Queen Elizabeth Olympic Park", City = "London" });
                address.HasData(new { Id = 4L, Street = "Drayton Park", City = "London", Number = "75" });
                address.HasData(new { Id = 5L, Street = "Etihad Campus", City = "Manchester" });
                address.HasData(new { Id = 6L, Street = "Merseyside", City = "Liverpool" });
                address.HasData(new { Id = 7L, Street = "Newcastle upon Tyne", City = "Newcastle" });
                address.HasData(new { Id = 8L, Street = "Trinity Road", City = "Birmingham" });
                address.HasData(new { Id = 9L, Street = "Fulham Road", City = "London" });
                address.HasData(new { Id = 10L, Street = "Goodison Road", City = "Liverpool" });
            });
            #endregion
            modelBuilder.Entity<Stadium>().HasKey(u => u.Id);
            modelBuilder.Entity<Stadium>().Property(u => u.Name).IsRequired();
            modelBuilder.Entity<Stadium>().HasOne(u => u.Address).WithMany().HasForeignKey(s => s.AddressId).IsRequired();
            #region StadiumData
            modelBuilder.Entity<Stadium>(stadium =>
            {
                stadium.HasData(new { Id = 1L, Name = "Old Traford", AddressId = 1L });
                stadium.HasData(new { Id = 2L, Name = "Tottenham Hotspur Stadium", AddressId = 2L });
                stadium.HasData(new { Id = 3L, Name = "Londond Stadium", AddressId = 3L });
                stadium.HasData(new { Id = 4L, Name = "Emirates Stadium", AddressId = 4L });
                stadium.HasData(new { Id = 5L, Name = "Etihad Stadium", AddressId = 5L });
                stadium.HasData(new { Id = 6L, Name = "Anfield", AddressId = 6L });
                stadium.HasData(new { Id = 7L, Name = "St. James Park", AddressId = 7L });
                stadium.HasData(new { Id = 8L, Name = "Villa Park", AddressId = 8L });
                stadium.HasData(new { Id = 9L, Name = "Stamford Bridge", AddressId = 9L });
                stadium.HasData(new { Id = 10L, Name = "Goodison Park", AddressId = 10L });
            });
            #endregion
        }
    }
}
