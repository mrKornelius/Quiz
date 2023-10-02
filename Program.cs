class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till Quizet!");
        int poäng = 0;

        AskQuestions("Vilken är huvudstaden i Frankrike?", "paris");
        AskQuestions("Vilken brukar kallas för den röda planeten?", "mars");
        AskQuestions("Vilken hundras är Lassie?", "collie");

        Console.WriteLine("Nu är quizet klart. Du fick " + poäng + " poäng");
    }

    static void AskQuestions(string fråga, string svaretPåFrågan)
    {
        Console.WriteLine(fråga);

        string svar = Console.ReadLine();

        if (svar == svaretPåFrågan)
        {
            Console.WriteLine("Rätt!");
        }
        else
        {
            Console.WriteLine("Fel!");
        }
    }

}

// Välkommen till Quizet!
// Första frågan: Vilken är huvudstaden i Frankrike?
// Svar: paris
// Rätt! 1 poäng!
// Andra frågan: Vilken brukar kallas för den röda planeten?
// Svar: jupiter
// Fel! Rätt svar är Mars. 
// ...
// Nu är quizet klart, du fick 17 poäng. 