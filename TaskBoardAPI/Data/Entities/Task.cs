using System.ComponentModel.DataAnnotations;
using TaskBoardAPI.Models.Enum;

namespace TaskBoardAPI.Data.Entities
{
    public class WorkTask
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public TaskStatusEnum Status { get; set; }
    }
}
