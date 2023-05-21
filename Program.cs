using ConsloleAppTOCalculationsDamageForOscar;
using System.Linq.Expressions;

internal class Program
{
    static Random random = new Random();
    private static void Main(string[] args)
    {
        SwordDamage sword = new SwordDamage(RollDice(3));
        ArrowDamage arrow = new ArrowDamage(RollDice(1));
        while (true)
        {
            Console.Write("\nM - miecz, S - strzały, inne znaki - koniec");
            char key = char.ToUpper(Console.ReadKey(true).KeyChar);
            Console.WriteLine("0 - ani magiczny ani płonący; 1 - magiczny; 2 - płonący; 3 - magiczny i płonący; inne wartości koniec");
            Console.Write("Wybierza atak: ");
            char userchose;

            switch (key)
            {
                case 'M':
                    
                    userchose = Console.ReadKey().KeyChar;


                    if (userchose != '0' && userchose != '1' && userchose != '2' && userchose != '3') return;
                    sword.Roll = RollDice(3);
                    sword.Magic = (userchose == '1' || userchose == '3');
                    sword.Flaming = (userchose == '2' || userchose == '3');
                    Console.WriteLine("\nRzut: " + sword.Roll + ", punty obrazen: " + sword.Damage);
                    Console.WriteLine('\n');
                    break;

                case 'S':
                    
                    userchose = Console.ReadKey().KeyChar;


                    if (userchose != '0' && userchose != '1' && userchose != '2' && userchose != '3') return;
                    arrow.Roll = RollDice(1);
                    arrow.Magic = (userchose == '1' || userchose == '3');
                    arrow.Flaming = (userchose == '2' || userchose == '3');
                    Console.WriteLine("\nRzut: " + arrow.Roll + ", punty obrazen: " + arrow.Damage);
                    Console.WriteLine('\n');
                    break;

                default:
                    return;
                    
            }
        }
    }

    private static int RollDice(int amountDice)
    {
        int roll = 0;
        for(int i =0; i< amountDice; i++)
        {
            roll += random.Next(1, 7);
        }
        return roll;
    }
}