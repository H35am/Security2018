using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class HeaderContext : DbContext
    {
        public HeaderContext(DbContextOptions<HeaderContext> options)
            : base(options)
        { }

        public DbSet<Header> Headers { get; set; }
       
    }
    
    public class Header
    {
        public int HeaderId { get; set; }
        public string Value { get; set; }
        public TimestampInformation Date { get; set; }

    }
}