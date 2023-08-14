using TaskBoardAPI.Models.Enum;

namespace TaskBoardAPI.Models.DTOs
{
    public class WorkTaskDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public TaskStatusEnum Status { get; set; }
    }
}
