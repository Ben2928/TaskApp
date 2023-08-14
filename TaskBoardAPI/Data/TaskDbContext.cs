using Microsoft.EntityFrameworkCore;
using TaskBoardAPI.Data.Entities;
using TaskBoardAPI.Models.Enum;

namespace TaskBoardAPI.Data;

public class TaskDbContext : DbContext
{
    public TaskDbContext(DbContextOptions options)
            : base(options)
    {
    }

    public DbSet<WorkTask> WorkTasks => Set<WorkTask>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkTask>().HasData(
            new WorkTask
            {
                Id = 1,
                Title = "Task 1",
                Description = "Description for Task 1",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Status = TaskStatusEnum.InProgress
            },
            new WorkTask
            {
                Id = 2,
                Title = "Task 2",
                Description = "Description for Task 2",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Status = TaskStatusEnum.Done
            },
            new WorkTask
            {
                Id = 3,
                Title = "Task 3",
                Description = "Description for Task 3",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Status = TaskStatusEnum.Todo
            },
            new WorkTask
            {
                Id = 4,
                Title = "Task 4",
                Description = "Description for Task 4",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Status = TaskStatusEnum.InProgress
            },
            new WorkTask
            {
                Id = 5,
                Title = "Task 5",
                Description = "Description for Task 5",
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Status = TaskStatusEnum.Done
            }
        );
    }
}

