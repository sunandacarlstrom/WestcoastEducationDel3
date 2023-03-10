namespace WestcoastEducation.Web.ViewModels.Classrooms;

public class ClassroomListViewModel
{
    public int ClassroomId { get; set; }
    public string Number { get; set; } = "";
    public string Name { get; set; } = "";
    public string Title { get; set; } = "";
    public string Content { get; set; } = "";
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public TimeSpan Length { get => End - Start; }
    public bool IsOnDistance { get; set; } = false;
}