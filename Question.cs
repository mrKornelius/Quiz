namespace Quiz;
class Question
{
    public string Text { get; set; }
    public string Answer { get; set; }
    public int Points { get; set; }

    public Question(string text, string answer, int points = 1)
    {
        Text = text;
        Answer = answer;
        Points = points;
    }
}