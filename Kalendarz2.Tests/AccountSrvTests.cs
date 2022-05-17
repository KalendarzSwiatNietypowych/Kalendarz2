using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Models.User;
using Kalendarz2.Infrastructure.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kalendarz2.Tests;

public class AccountSrvTests
{
    [Fact]
    public async void RegisterUser_ValidData_ReturnsOkClassification()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<CalendarDbContext>()
            .UseInMemoryDatabase(databaseName: "CalendarDatabase")
            .Options;
        var mockDbContex = new CalendarDbContext(options);
        var mockPasswordHasher = new Mock<IPasswordHasher<User>>();
        var mockToken = new Mock<IOptions<JSONWebTokensSettings>>();

        //https://docs.microsoft.com/pl-pl/ef/core/testing/testing-with-the-database
        var service = new AccountSrv(mockDbContex, mockPasswordHasher.Object, mockToken.Object);

        //Act
        var userToRegister = new RegisterDTO
        {
            Email = "test@test",
            FirstName = "Adam",
            LastName = "Test",
            Password = "Test123!@#"
        };
        var result = service.RegisterUser(userToRegister);

        //Assert
        Assert.IsType<UserDTO>(result);
        Assert.Equal(new UserDTO { Id = 1, FirstName = "Adam", LastName = "Test", Token = null}, result);
    }
}
