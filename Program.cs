class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till Quizet!");

        Console.WriteLine("Fråga 1: Vilken är huvudstaden i Frankrike?");

        int poäng = 0;
        string svar = Console.ReadLine().ToLower();

        if (svar == "paris")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        Console.WriteLine("Vilken brukar kallas för den röda planeten?");

        svar = Console.ReadLine().ToLower();

        if (svar == "mars")
        {
            Console.WriteLine("Rätt svar!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        Console.WriteLine("Nu är quizet klart. Du fick " + poäng + " poäng");
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