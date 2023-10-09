using System;
namespace inlämning_3._3;
class Program
{
    static void Main()

    {
        Console.Write("Ange antal minuter: ");

        int minuter = int.Parse(Console.ReadLine());

        Console.Write("Ange antal sekunder: ");

        int sekunder = int.Parse(Console.ReadLine());

        int totaltSekunder = minuter * 60 + sekunder;

        int minstaLängd = 2 * 60 + 45;

        int störstaLängd = 4 * 60 + 20;

        bool kanSpelas = minstaLängd <= totaltSekunder && totaltSekunder <= störstaLängd;
        
        string resultat = kanSpelas ? "Låten kan spelas på radiostationen då tiden på låten inte är för lång." : "Låten kan inte spelas på radiostationen d tiden på låten är för lång.";

        Console.WriteLine(resultat);
    }
}
