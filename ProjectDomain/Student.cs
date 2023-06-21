namespace Tasks.Models
{
    public class Student : People
    {
        public string Teacher { get; set; }
        public int CreatingTask { get; set; }
    }
}
