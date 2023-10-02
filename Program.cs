class Program
{

    static void Main()
    {
        while (true)
        {
            int poäng = 0;

            Console.WriteLine("Välkommen till Quizet!");

            poäng += AskQuestions("Vilken är huvudstaden i Frankrike?", "paris");
            poäng += AskQuestions("Vilken brukar kallas för den röda planeten?", "mars");
            poäng += AskQuestions("Vilken hundras är Lassie?", "collie", 3);
            poäng += AskQuestions("Vad heter er lärare i OOP?", "gus");

            Console.WriteLine("Nu är quizet klart. Du fick " + poäng);
            Console.WriteLine("Vill du göra om quizet? (j/n)");

            if (Console.ReadLine() == "n")
            {
                break;
            }
        }

        Console.WriteLine("Tack för ditt quizzande!");
    }

    static int AskQuestions(string fråga, string svaretPåFrågan, int poäng = 1)
    {
        Console.WriteLine(fråga);

        string svar = Console.ReadLine().ToLower();

        if (svar == svaretPåFrågan.ToLower())
        {
            Console.WriteLine("Rätt!");
            return poäng;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        return 0;
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