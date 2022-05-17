using Kalendarz2.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz2.Tests;

public class TestDatabaseFixture
{
    private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=EFTestSample;Trusted_Connection=True";

    private static readonly object _lock = new();
    private static bool _databaseInitialized;

    //https://docs.microsoft.com/pl-pl/ef/core/testing/testing-with-the-database
    public TestDatabaseFixture()
    {
        lock (_lock)
        {
            if (!_databaseInitialized)
            {
                using (var context = CreateContext())
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    context.SaveChanges();
                }

                _databaseInitialized = true;
            }
        }
    }

    public CalendarDbContext CreateContext()
        => new CalendarDbContext(
            new DbContextOptionsBuilder<CalendarDbContext>()
                .UseSqlServer(ConnectionString)
                .Options);
}
