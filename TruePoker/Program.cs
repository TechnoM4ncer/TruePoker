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

            flopCard1 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            flopCard2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            flopCard3 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            turnCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            riverCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];

            Console.WriteLine(flopCard1);

            while (flopCard2 == flopCard1)
            {
                flopCard2 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine(flopCard2);

            while (flopCard3 == flopCard2 || flopCard3 == flopCard1)
            {
                flopCard3 = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine(flopCard3);

            while (turnCard == flopCard1 || turnCard == flopCard2 || turnCard == flopCard3)
            {
                turnCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine(turnCard);

            while (riverCard == flopCard1 || riverCard == flopCard2 || riverCard == flopCard3 || riverCard == turnCard)
            {
                riverCard = Deck.number[seed.Next(0, 12)] + " of " + Deck.suit[seed.Next(0, 3)];
            }

            Console.WriteLine(riverCard);

            Console.ReadKey();
        }
    }
}
