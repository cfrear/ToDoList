namespace ToDoList.Models
{
    public class ListItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly DueDate { get; set; }
        public bool Completed { get; set; }
    }
}
