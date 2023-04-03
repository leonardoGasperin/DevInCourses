namespace Domain.Models
{
    internal class CourseModel : _BaseEntety
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Resume { get; set; }
        public TimeOnly Duration { get; set; }
        public string Picture { get; set; }
    }
}
