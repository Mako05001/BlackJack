Random card = new Random();
string Last = "Ingen har vunnit än";
Console.WriteLine("Välkommen till blackjack");
string svar = "0";
int Maxcardpoints = 11;
int Mincardpoints = 1;
int Maxpoints = 21;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
while (svar != "4")
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Välj en av alternativen");
    Console.WriteLine("1. Spela");
    Console.WriteLine("2. Visa senaste vinnaren");
    Console.WriteLine("3. Spelets regler");
    Console.WriteLine("4. Avsluta spelet");
    Console.WriteLine();
    svar = Console.ReadLine();
    switch (svar)
    {
        case "1":
            int player = 0;
            int dealer = 0;
            Console.WriteLine("Nu dras två kort");
            dealer += card.Next(Mincardpoints, Maxcardpoints);
            dealer += card.Next(Mincardpoints, Maxcardpoints);
            player += card.Next(Mincardpoints, Maxcardpoints);
            player += card.Next(Mincardpoints, Maxcardpoints);
            string Val = " ";
            while (Val != "n" && player <= Maxpoints)
            {
                Console.WriteLine($"Du har {player}");
                Console.WriteLine($"Dator har {dealer}");
                Console.WriteLine("Vill du dra ett till kort j/n");
                Val = Console.ReadLine();
                switch (Val)
                {
                    case "j":
                        int newcard = card.Next(Mincardpoints, Maxcardpoints);
                        player += newcard;
                        Console.WriteLine($"Du drog {newcard}");
                        Console.WriteLine($"Nu har du {player}");
                        break;
                    case "n":
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Du har inte valt et av alternativen");
                        break;

                }
            }
            if (player > Maxpoints)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du har mer än 21. Du förlorar");
                Console.WriteLine();
                break;
            }
            while (dealer < player && dealer < Maxpoints)
            {
                int newcard = card.Next(Mincardpoints, Maxcardpoints);
                dealer += newcard;
                Console.WriteLine($"datorn drog ett nytt kort som är värt {newcard}");
                Console.WriteLine();
            }
            Console.WriteLine($"Datorn har {dealer} poäng");
            Console.WriteLine();
            if (dealer > Maxpoints)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du har vunnit");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Skriv ditt namn");
                Last = Console.ReadLine();
            }
            if (dealer == player)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingen vann");
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Datorn har vunnit");
                Console.WriteLine();
            }
            break;
        case "2":
            Console.WriteLine(Last);
            Console.WriteLine();
            break;
        case "3":
            Console.WriteLine("Du ska tvinga datron att få över 21");
            Console.WriteLine("Du får poäng genom att du drar kort ");
            Console.WriteLine("Du kan få 1 till 10 poäng från ett kort");
            Console.WriteLine("Du kan dra kort tills du är över 21");
            Console.WriteLine("Om du får mer en 21 vinner datorn");
            Console.WriteLine("Efter du har dragit dina kort så kommer datorn att dra sina");
            Console.WriteLine("tills den har mer poäng än dig eller över 21 poäng");
            break;
        case "4":
            Console.WriteLine("Programmet avslutats");
            break;
        default:
            Console.WriteLine("Du har inte valt ett av alternativen");
            break;
    }
}
