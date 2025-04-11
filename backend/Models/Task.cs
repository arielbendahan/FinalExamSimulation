namespace FinalExamSimulation.Models
{
    public class TaskModel
    {
        public int ID { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Completed { get; set; }
    }
}