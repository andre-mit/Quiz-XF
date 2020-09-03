namespace Quiz.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public int Correct { get; set; }
        public string[] Alternatives { get; set; }
    }
}
