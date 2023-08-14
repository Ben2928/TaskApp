using Microsoft.AspNetCore.Mvc;
using TaskBoardAPI.Models.DTOs;
using TaskBoardAPI.Services;

namespace TaskBoardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        //private readonly ICategoryService _CategoryService;
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("getWorkTasks")]
        public async Task<List<WorkTaskDTO>> GetAllCategoryAsync()
        {
            return await _taskService.GetAllWorkTaskAsync();
        }
    }
}
