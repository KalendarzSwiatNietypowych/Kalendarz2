using Kalendarz2.Domain.Common.Models.Holiday;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json;

namespace Kalendarz2.Infrastructure.EntityFramework;

public class CalendarDbContext : DbContext
{
    public CalendarDbContext(DbContextOptions<CalendarDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Holiday> Holidays { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<Participation> Participations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(x => x.Email)
            .IsRequired();
        modelBuilder.Entity<User>()
            .Property(x => x.FirstName)
            .IsRequired();
        modelBuilder.Entity<User>()
            .Property(x => x.LastName)
            .IsRequired();
        modelBuilder.Entity<User>()
            .Property(x => x.PasswordHash)
            .IsRequired();

        modelBuilder.Entity<Holiday>()
            .Property(x => x.Name)
            .IsRequired();
        modelBuilder.Entity<Holiday>()
            .Property(x => x.Date)
            .IsRequired();

        modelBuilder.Entity<Event>()
            .Property(x => x.AuthorId)
            .IsRequired();
        modelBuilder.Entity<Event>()
            .Property(x => x.Title)
            .IsRequired();
        modelBuilder.Entity<Event>()
            .Property(x => x.StartEvent)
            .IsRequired();
        modelBuilder.Entity<Event>()
            .Property(x => x.EndEvent)
            .IsRequired();

        modelBuilder.Entity<Reminder>()
            .Property(x => x.AuthorId)
            .IsRequired();
        modelBuilder.Entity<Reminder>()
            .Property(x => x.RemindMe)
            .IsRequired();

        modelBuilder.Entity<Participation>()
            .HasKey(p => new { p.ParticipantId, p.EventId });
        modelBuilder.Entity<Participation>()
            .HasOne(p => p.Participant)
            .WithMany(u => u.Participations)
            .HasForeignKey(p => p.ParticipantId);
        modelBuilder.Entity<Participation>()
            .HasOne(p => p.Event)
            .WithMany(e => e.Participants)
            .HasForeignKey(p => p.EventId);

        using (StreamReader r = new StreamReader("holidaysJSON.txt"))
        {
            string json = r.ReadToEnd();
            List<HolidayDTO> items = JsonConvert.DeserializeObject<List<HolidayDTO>>(json);
            int id_num = 1;
            foreach (var item in items)
            {
                modelBuilder.Entity<Holiday>().HasData(new Holiday { Id = id_num, Name = item.Name, Date = item.Date, Description = item.Description });
                id_num++;
            }
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }

}