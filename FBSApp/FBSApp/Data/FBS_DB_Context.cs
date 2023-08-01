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
        public DbSet<Team> Teams { get; set; }
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
                var dictionary = new Dictionary<string, string>() {
                                {"Afghanistan", ""},
                                {"Albania", ""},
                                {"Algeria", ""},
                                {"Andorra", ""},
                                {"Angola", ""},
                                {"Antigua & Deps", ""},
                                {"Argentina", ""},
                                {"Armenia", ""},
                                {"Australia", ""},
                                {"Austria", ""},
                                {"Azerbaijan", ""},
                                {"Bahamas", ""},
                                {"Bahrain", ""},
                                {"Bangladesh", ""},
                                {"Barbados", ""},
                                {"Belarus", ""},
                                {"Belgium", ""},
                                {"Belize", ""},
                                {"Benin", ""},
                                {"Bhutan", ""},
                                {"Bolivia", ""},
                                {"Bosnia Herzegovina", ""},
                                {"Botswana", ""},
                                {"Brazil", ""},
                                {"Brunei", ""},
                                {"Bulgaria", ""},
                                {"Burkina", ""},
                                {"Burundi", ""},
                                {"Cambodia", ""},
                                {"Cameroon", ""},
                                {"Canada", ""},
                                {"Cape Verde", ""},
                                {"Central African Rep", ""},
                                {"Chad", ""},
                                {"Chile", ""},
                                {"China", ""},
                                {"Colombia", ""},
                                {"Comoros", ""},
                                {"Congo", ""},
                                {"Congo {Democratic Rep}", ""},
                                {"Costa Rica", ""},
                                {"Croatia", ""},
                                {"Cuba", ""},
                                {"Cyprus", ""},
                                {"Czech Republic", ""},
                                {"Denmark", ""},
                                {"Djibouti", ""},
                                {"Dominica", ""},
                                {"Dominican Republic", ""},
                                {"East Timor", ""},
                                {"Ecuador", ""},
                                {"Egypt", ""},
                                {"El Salvador", ""},
                                {"England", "iVBORw0KGgoAAAANSUhEUgAAAH0AAABQCAMAAAADbIr/AAAABGdBTUEAALGPC/xhBQAAACBjSFJN AAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAABGlBMVEX9/f3+/v78/Pz6fn74 Kir4MjL4MTH4MDD4LCz5TEz83d37/f37+vr7+/v6+vr6+fn5+fnq6ur//////v78f3/6Kir6MjL6 MTH6MDD6LCz7TEz/39/v7u75Kir5MjL5MTH5MDD5LCz6TEz+3t7+/f3u7e3u7u7v7+/y8vLz8/Pz 8vL19fX29vb49/f4+Pj8fn76S0v+3d3+/Pz8+/v8gYH+4uL8///+6ur+6+v8dXX5LS36SUn9z8/+ 7Oz+6en86Oj6T0/6UFD6OTn5Ly/6NDT6UVH7UFD5T0/5Kyv6Kyv5KSn6KSn8oKD8oqL7V1f5Li76 Pz/8j4/8o6P9oaH6n5/8goL6TU3+5ub9///9/v77fn74KSn7/Pz8+vrpDZJXAAAAAWJLR0QSe7xs AAAAAAlwSFlzAAAOwwAADsMBx2+oZAAAAAd0SU1FB+cIARIgMZSh/rgAAAGXSURBVGje7ZpXU8JA FIU3agQRIm4wGwsQMPaG2LGLBbH3/v//hmEmSoKgeMZhx8n9nvJ0vpyXu/fhMuagfAv7Shtr71A7 XUJquCvSHY3VRYtqFXrqENd6GQfQdZ7oM4SLafQPDHIdyBn6oXdDEslU2sVKZbLDig2EjGDdFZ5I ero7dm7/trwTItc+GtTuXOFjUu3jAbZPkD2Q9skAd58KsH1aqn2G7IG0zwa4e1yqPSbVrpFdkj3G bIw5nz03b+eBkAWou8Oiv/sSFLLMViBW17z2wvrG5haQss12IHb3iqKKtZ87AEIOj1gJoyisT7kp rAyScVxiBoZHXtEjESkjxUwQ4QNJsITFhDTITvb/ZTcbfDdP2rGj08ZvR6dNGaOQrg4cUxSTSMZJ mZ1CnJ1nPM0vLq+ugZCbW/R9v/O97/cPUMgjtNvk83+12+gIil671+k2ENImdaskO9nJ3ko7IzvZ yU52spOd7GQne6vt9S6dLBf40gns7rvyEvCVl9KcXeH+X2ZPzy9q6AM1nI28vtVctjVD/B0uqWEu qUmgPwAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAyMy0wOC0wMVQxODozMjozNiswMDowMCVp8VgAAAAl dEVYdGRhdGU6bW9kaWZ5ADIwMjMtMDgtMDFUMTg6MzI6MzYrMDA6MDBUNEnkAAAAAElFTkSuQmCC"},
                                {"Equatorial Guinea", ""},
                                {"Eritrea", ""},
                                {"Estonia", ""},
                                {"Ethiopia", ""},
                                {"Fiji", ""},
                                {"Finland", ""},
                                {"France", ""},
                                {"Gabon", ""},
                                {"Gambia", ""},
                                {"Georgia", ""},
                                {"Germany", ""},
                                {"Ghana", ""},
                                {"Greece", ""},
                                {"Grenada", ""},
                                {"Guatemala", ""},
                                {"Guinea", ""},
                                {"Guinea-Bissau", ""},
                                {"Guyana", ""},
                                {"Haiti", ""},
                                {"Honduras", ""},
                                {"Hungary", ""},
                                {"Iceland", ""},
                                {"India", ""},
                                {"Indonesia", ""},
                                {"Iran", ""},
                                {"Iraq", ""},
                                {"Ireland {Republic}", ""},
                                {"Israel", ""},
                                {"Italy", ""},
                                {"Ivory Coast", ""},
                                {"Jamaica", ""},
                                {"Japan", ""},
                                {"Jordan", ""},
                                {"Kazakhstan", ""},
                                {"Kenya", ""},
                                {"Kiribati", ""},
                                {"Korea North", ""},
                                {"Korea South", ""},
                                {"Kuwait", ""},
                                {"Kyrgyzstan", ""},
                                {"Laos", ""},
                                {"Latvia", ""},
                                {"Lebanon", ""},
                                {"Lesotho", ""},
                                {"Liberia", ""},
                                {"Libya", ""},
                                {"Liechtenstein", ""},
                                {"Lithuania", ""},
                                {"Luxembourg", ""},
                                {"Macedonia", ""},
                                {"Madagascar", ""},
                                {"Malawi", ""},
                                {"Malaysia", ""},
                                {"Maldives", ""},
                                {"Mali", ""},
                                {"Malta", ""},
                                {"Marshall Islands", ""},
                                {"Mauritania", ""},
                                {"Mauritius", ""},
                                {"Mexico", ""},
                                {"Micronesia", ""},
                                {"Moldova", ""},
                                {"Monaco", ""},
                                {"Mongolia", ""},
                                {"Montenegro", ""},
                                {"Morocco", ""},
                                {"Mozambique", ""},
                                {"Myanmar {Burma}", ""},
                                {"Namibia", ""},
                                {"Nauru", ""},
                                {"Nepal", ""},
                                {"Netherlands", ""},
                                {"New Zealand", ""},
                                {"Nicaragua", ""},
                                {"Niger", ""},
                                {"Nigeria", ""},
                                {"Norway", ""},
                                {"Oman", ""},
                                {"Pakistan", ""},
                                {"Palau", ""},
                                {"Panama", ""},
                                {"Papua New Guinea", ""},
                                {"Paraguay", ""},
                                {"Peru", ""},
                                {"Philippines", ""},
                                {"Poland", ""},
                                {"Portugal", ""},
                                {"Qatar", ""},
                                {"Romania", ""},
                                {"Russian Federation", ""},
                                {"Rwanda", ""},
                                {"St Kitts & Nevis", ""},
                                {"St Lucia", ""},
                                {"Saint Vincent & the Grenadines", ""},
                                {"Samoa", ""},
                                {"San Marino", ""},
                                {"Sao Tome & Principe", ""},
                                {"Saudi Arabia", ""},
                                {"Scotland", ""},
                                {"Senegal", ""},
                                {"Serbia", ""},
                                {"Seychelles", ""},
                                {"Sierra Leone", ""},
                                {"Singapore", ""},
                                {"Slovakia", ""},
                                {"Slovenia", ""},
                                {"Solomon Islands", ""},
                                {"Somalia", ""},
                                {"South Africa", ""},
                                {"South Sudan", ""},
                                {"Spain", ""},
                                {"Sri Lanka", ""},
                                {"Sudan", ""},
                                {"Suriname", ""},
                                {"Swaziland", ""},
                                {"Sweden", ""},
                                {"Switzerland", ""},
                                {"Syria", ""},
                                {"Taiwan", ""},
                                {"Tajikistan", ""},
                                {"Tanzania", ""},
                                {"Thailand", ""},
                                {"Togo", ""},
                                {"Tonga", ""},
                                {"Trinidad & Tobago", ""},
                                {"Tunisia", ""},
                                {"Turkey", ""},
                                {"Turkmenistan", ""},
                                {"Tuvalu", ""},
                                {"Uganda", ""},
                                {"Ukraine", ""},
                                {"United Arab Emirates", ""},
                                {"United Kingdom", ""},
                                {"United States", ""},
                                {"Uruguay", ""},
                                {"Uzbekistan", ""},
                                {"Vanuatu", ""},
                                {"Vatican City", ""},
                                {"Venezuela", ""},
                                {"Vietnam", ""},
                                {"Wales", ""},
                                {"Yemen", ""},
                                {"Zambia", ""},
                                {"Zimbabwe", ""}
                };

                var id = 1L;
                foreach (var e in dictionary)
                {
                    byte[] array = Convert.FromBase64String(e.Value);
                    country.HasData(new { Id = id++, Name = e.Key, Flag = array });
                }

            });
            #endregion
            modelBuilder.Entity<Address>().HasKey(a => a.Id);
            modelBuilder.Entity<Address>().Property(a => a.Street).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.City).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.Number).IsRequired(false);
            modelBuilder.Entity<Address>().HasOne(a => a.Country).WithMany().HasForeignKey(a => a.CountryId).IsRequired(false);
            #region AddressData
            modelBuilder.Entity<Address>(address =>
            {
                address.HasData(new { Id = 1L, Street = "Sir Matt Busby Way", City = "Manchester", CountryId = 54L });
                address.HasData(new { Id = 2L, Street = "High Road", City = "London", CountryId = 54L });
                address.HasData(new { Id = 3L, Street = "Queen Elizabeth Olympic Park", City = "London", CountryId = 54L });
                address.HasData(new { Id = 4L, Street = "Drayton Park", City = "London", Number = "75", CountryId = 54L });
                address.HasData(new { Id = 5L, Street = "Etihad Campus", City = "Manchester", CountryId = 54L });
                address.HasData(new { Id = 6L, Street = "Merseyside", City = "Liverpool", CountryId = 54L });
                address.HasData(new { Id = 7L, Street = "Newcastle upon Tyne", City = "Newcastle", CountryId = 54L });
                address.HasData(new { Id = 8L, Street = "Trinity Road", City = "Birmingham", CountryId = 54L });
                address.HasData(new { Id = 9L, Street = "Fulham Road", City = "London", CountryId = 54L });
                address.HasData(new { Id = 10L, Street = "Goodison Road", City = "Liverpool", CountryId = 54L });
                address.HasData(new { Id = 11L, Street = "Granville Road", City = "Sheffield", CountryId = 54L });
                address.HasData(new { Id = 12L, Street = "Village Way", City = "Brighton", CountryId = 54L });
                address.HasData(new { Id = 13L, Street = "Waterloo Road", City = "Wolverhampton", CountryId = 54L });
                address.HasData(new { Id = 14L, Street = "Whitehorse Lane", City = "London", CountryId = 54L });
                address.HasData(new { Id = 15L, Street = "Stevenage Road", City = "London", CountryId = 54L });
                address.HasData(new { Id = 16L, Street = "Harry Potts Way", City = "Burnley", CountryId = 54L });
                address.HasData(new { Id = 17L, Street = "Kings Park", City = "Bournemouth", CountryId = 54L });
                address.HasData(new { Id = 18L, Street = "Sloper Road", City = "Cardiff", CountryId = 195L });
                address.HasData(new { Id = 19L, Street = "Britannia Road", City = "Cardiff", CountryId = 54L });
                address.HasData(new { Id = 20L, Street = "Filbert Way", City = "Leicester", CountryId = 54L });
                address.HasData(new { Id = 21L, Street = "Vicarage Road", City = "Watford", CountryId = 54L });
                address.HasData(new { Id = 22L, Street = "Stadium Way", City = "Huddersfield", CountryId = 54L });
                address.HasData(new { Id = 23L, Street = "Carrow Road", City = "Norwich", CountryId = 54L });
            });
            #endregion
            modelBuilder.Entity<Stadium>().HasKey(s => s.Id);
            modelBuilder.Entity<Stadium>().Property(s => s.Name).IsRequired();
            modelBuilder.Entity<Stadium>().HasOne(s => s.Address).WithMany().HasForeignKey(s => s.AddressId).IsRequired();
            #region StadiumData
            modelBuilder.Entity<Stadium>(stadium =>
            {
                stadium.HasData(new { Id = 1L, Name = "Old Traford", AddressId = 1L });
                stadium.HasData(new { Id = 2L, Name = "Tottenham Hotspur Stadium", AddressId = 2L });
                stadium.HasData(new { Id = 3L, Name = "Londond Stadium", AddressId = 3L });
                stadium.HasData(new { Id = 4L, Name = "Emirates Stadium", AddressId = 4L });
                stadium.HasData(new { Id = 5L, Name = "Etihad Stadium", AddressId = 5L });
                stadium.HasData(new { Id = 6L, Name = "Anfield", AddressId = 6L });
                stadium.HasData(new { Id = 7L, Name = "St. James' Park", AddressId = 7L });
                stadium.HasData(new { Id = 8L, Name = "Villa Park", AddressId = 8L });
                stadium.HasData(new { Id = 9L, Name = "Stamford Bridge", AddressId = 9L });
                stadium.HasData(new { Id = 10L, Name = "Goodison Park", AddressId = 10L });
                stadium.HasData(new { Id = 11L, Name = "Bramall Lane", AddressId = 11L });
                stadium.HasData(new { Id = 12L, Name = "Falmer Stadium", AddressId = 12L });
                stadium.HasData(new { Id = 13L, Name = "Molineux", AddressId = 13L });
                stadium.HasData(new { Id = 14L, Name = "Selhurst Park", AddressId = 14L });
                stadium.HasData(new { Id = 15L, Name = "Craven Cottage", AddressId = 15L });
                stadium.HasData(new { Id = 16L, Name = "Turf Moor", AddressId = 16L });
                stadium.HasData(new { Id = 17L, Name = "Dean Court", AddressId = 17L });
                stadium.HasData(new { Id = 18L, Name = "Cardiff City Stadium", AddressId = 18L });
                stadium.HasData(new { Id = 19L, Name = "St Mary's Stadium", AddressId = 19L });
                stadium.HasData(new { Id = 20L, Name = "King Power Stadium", AddressId = 20L });
                stadium.HasData(new { Id = 21L, Name = "Vicarage Road", AddressId = 21L });
                stadium.HasData(new { Id = 22L, Name = "Kirklees Stadium", AddressId = 22L });
                stadium.HasData(new { Id = 23L, Name = "Carrow Road", AddressId = 23L });
            });
            #endregion
            modelBuilder.Entity<Team>().HasKey(t => t.Id);
            modelBuilder.Entity<Team>().Property(t => t.Name).IsRequired();
            modelBuilder.Entity<Team>().Property(t => t.Logo).IsRequired(false);
            modelBuilder.Entity<Team>().HasOne(t => t.Stadium).WithMany().HasForeignKey(t => t.StadiumId).IsRequired();
            modelBuilder.Entity<Team>().HasOne(t => t.Country).WithMany().HasForeignKey(t => t.CountryId).IsRequired();
            #region TeamData
            modelBuilder.Entity<Team>(team =>
            {
                team.HasData(new { Id = 1L, Name = "Manchester United", StadiumId = 1L, CountryId = 54L });
                team.HasData(new { Id = 2L, Name = "Tottenham Hotspur", StadiumId = 2L, CountryId = 54L });
                team.HasData(new { Id = 3L, Name = "West Ham United", StadiumId = 3L, CountryId = 54L });
                team.HasData(new { Id = 4L, Name = "Arsenal", StadiumId = 4L, CountryId = 54L });
                team.HasData(new { Id = 5L, Name = "Manchester City", StadiumId = 5L, CountryId = 54L });
                team.HasData(new { Id = 6L, Name = "Liverpool", StadiumId = 6L, CountryId = 54L });
                team.HasData(new { Id = 7L, Name = "Newcastle United", StadiumId = 7L, CountryId = 54L });
                team.HasData(new { Id = 8L, Name = "Aston Villa", StadiumId = 8L, CountryId = 54L });
                team.HasData(new { Id = 9L, Name = "Chelsea", StadiumId = 9L, CountryId = 54L });
                team.HasData(new { Id = 10L, Name = "Everton", StadiumId = 10L, CountryId = 54L });
                team.HasData(new { Id = 11L, Name = "Sheffield United", StadiumId = 11L, CountryId = 54L });
                team.HasData(new { Id = 12L, Name = "Brighton & Hove Albion", StadiumId = 12L, CountryId = 54L });
                team.HasData(new { Id = 13L, Name = "Wolverhampton Wanderers", StadiumId = 13L, CountryId = 54L });
                team.HasData(new { Id = 14L, Name = "Crystal Palace", StadiumId = 14L, CountryId = 54L });
                team.HasData(new { Id = 15L, Name = "Fulham", StadiumId = 15L, CountryId = 54L });
                team.HasData(new { Id = 16L, Name = "Burnley", StadiumId = 16L, CountryId = 54L });
                team.HasData(new { Id = 17L, Name = "AFC Bournemouth", StadiumId = 17L, CountryId = 54L });
                team.HasData(new { Id = 18L, Name = "Cardiff City", StadiumId = 18L, CountryId = 195L });
                team.HasData(new { Id = 19L, Name = "Southampton", StadiumId = 19L, CountryId = 54L });
                team.HasData(new { Id = 20L, Name = "Leicester", StadiumId = 20L, CountryId = 54L });
                team.HasData(new { Id = 21L, Name = "Watford", StadiumId = 21L, CountryId = 54L });
                team.HasData(new { Id = 22L, Name = "Huddersfield Town", StadiumId = 22L, CountryId = 54L });
                team.HasData(new { Id = 23L, Name = "Norwich City", StadiumId = 23L, CountryId = 54L });
            });
            # endregion
        }
    }
}
