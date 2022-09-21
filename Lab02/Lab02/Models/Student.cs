namespace Lab02.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public float Mark { get; set; }
        public string Grade
        {
            get
            {
                if (Mark >= 8.5) return "A";
                if (Mark >= 7.8) return "B";
                if (Mark >= 5) return "C";
                return "D";
            }
        }
    }
}
