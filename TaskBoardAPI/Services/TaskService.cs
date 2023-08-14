using Microsoft.EntityFrameworkCore;
using TaskBoardAPI.Data;
using TaskBoardAPI.Models.DTOs;

namespace TaskBoardAPI.Services;

public interface ITaskService
{
    Task<List<WorkTaskDTO>> GetAllWorkTaskAsync();
}

public class TaskService : ITaskService
{
    TaskDbContext _taskDbContext;
    public TaskService(TaskDbContext taskDbContext)
    {
        _taskDbContext = taskDbContext;
    }

    public async Task<List<WorkTaskDTO>> GetAllWorkTaskAsync()
    {
        return await _taskDbContext.WorkTasks.Select(c => new WorkTaskDTO
        {
            Title = c.Title,
            Description = c.Description,    
            CreatedDate = c.CreatedDate,
            UpdatedDate = c.UpdatedDate,
            Status = c.Status,
        }).ToListAsync();
    }
}

