using Moq;
using ReactAndAspApp.Server.Models;
using ReactAndAspApp.Server.Repositories;
using ReactAndAspApp.Server.Services;
using Xunit;
using FluentAssertions;

public class CustomerServiceTests
{
    private readonly Mock<ICustomerRepository> _repoMock;
    private readonly CustomerService _service;

    public CustomerServiceTests()
    {
        _repoMock = new Mock<ICustomerRepository>();
        _service = new CustomerService(_repoMock.Object);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnCustomers()
    {
        // Arrange
        var data = new List<Customer>
    {
        new Customer { Id = 1, Name = "Ali" }
    };

        _repoMock.Setup(x => x.GetAllWithTypeAsync())
                 .ReturnsAsync(data);

        // Act
        var result = await _service.GetAllAsync();

        // Assert
        result.Should().NotBeNull();
        result.Should().HaveCount(1);
    }
}