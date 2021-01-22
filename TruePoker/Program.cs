using System;

namespace TruePoker
{
    class Program
    {
        static void Main(string[] args)
        {
            Random seed = new Random();
            string flopCard1;
            string flopCard2;
            string flopCard3;
            string turnCard;
            string riverCard;
            string kap1;
            string kap2;
            string tech1;
            string tech2;

            flopCard1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            flopCard2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            flopCard3 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            turnCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            riverCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            kap1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            kap2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            tech1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            tech2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];

            while (kap2 == kap1)
            {
                kap1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }
            Console.WriteLine("TheKaptain");
            Console.WriteLine(kap1 + " - " + kap2 + "\n");

            while (tech1 == kap1 || tech1 == kap2 || tech2 == kap1 || tech2 == kap2)
            {
                tech1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
                tech2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }
            Console.WriteLine("TechnoM4ncer");
            Console.WriteLine(tech1 + " - " + tech2 + "\n");


            while (flopCard1 == kap1 || flopCard1 == kap2 || flopCard1 == tech1 || flopCard1 == tech2)
            {
                flopCard1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine("Flop");
            Console.WriteLine(flopCard1);


            while (flopCard2 == flopCard1 || flopCard2 == kap1 || flopCard2 == kap2 || flopCard2 == tech1 || flopCard2 == tech2)
            {
                flopCard2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine(flopCard2);

            while (flopCard3 == flopCard2 || flopCard3 == flopCard1 || flopCard3 == kap1 || flopCard3 == kap2 || flopCard3 == tech1 || flopCard3 == tech2)
            {
                flopCard3 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine(flopCard3 + "\n");

            while (turnCard == flopCard1 || turnCard == flopCard2 || turnCard == flopCard3 || turnCard == kap1 || turnCard == kap2 || turnCard == tech1 || turnCard == tech2)
            {
                turnCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine("Turn");
            Console.WriteLine(turnCard + "\n");

            while (riverCard == flopCard1 || riverCard == flopCard2 || riverCard == flopCard3 || riverCard == turnCard || riverCard == kap1 || riverCard == kap2 || riverCard == tech1 || riverCard == tech2)
            {
                riverCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine("River");
            Console.WriteLine(riverCard);

            Console.ReadKey();
        }
    }
}
