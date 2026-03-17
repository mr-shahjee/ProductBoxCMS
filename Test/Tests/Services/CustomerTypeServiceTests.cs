using FluentAssertions;
using Moq;
using ReactAndAspApp.Server.Models;
using ReactAndAspApp.Server.Repositories;
using ReactAndAspApp.Server.Services;
using Xunit;

public class CustomerTypeServiceTests
{
    private readonly Mock<ICustomerTypeRepository> _repoMock;
    private readonly CustomerTypeService _service;

    public CustomerTypeServiceTests()
    {
        _repoMock = new Mock<ICustomerTypeRepository>();
        _service = new CustomerTypeService(_repoMock.Object);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnTypes()
    {
        var types = new List<CustomerType>
        {
            new CustomerType { Id = 1, Name = "Regular" }
        };

        _repoMock.Setup(x => x.GetAllAsync())
                 .ReturnsAsync(types);

        var result = await _service.GetAllAsync();

        result.Should().HaveCount(1);
    }
}