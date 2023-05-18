using AdIntegration.Business.Services;
using AdIntegration.Data.Entities;
using AdIntegration.Repository.Repositories;
using Bogus;
using Moq;

namespace AdIntegration.UnitTest;

public class TaskServiceTests
{
    private readonly Mock<TaskRepository> _taskRepositoryMock;
    private readonly TaskService _taskService;
    public TaskServiceTests()
    {
        _taskRepositoryMock = new Mock<TaskRepository>();
        _taskService = new TaskService(_taskRepositoryMock.Object);
    }

    [Fact]
    public void CreateTask_WithValidTask_ReturnsCreatedTask()
    {
        // Arrange
        var task = new AdminTask();
        var createdTask = new Faker<AdminTask>()
            .RuleFor(t => t.Name, f => f.Random.Word())
            .RuleFor(t => t.Topic, f => f.Lorem.Word())
            .RuleFor(t => t.Description, f => f.Lorem.Paragraph())
            .RuleFor(t => t.Status, f => f.Random.Word())
            .Generate();

        // Act

        // Assert
    }
}
