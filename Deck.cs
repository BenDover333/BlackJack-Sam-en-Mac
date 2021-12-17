using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_2
{
    class Deck : Card
    {
        const int NumOfCards = 52; //aantal kaarten in het spel
        private Card[] deck; //array van alle kaarten in het spel

        public Deck()
        {
            deck = new Card[NumOfCards];

        }

        public Card[] getDeck { get { return deck; } } //haalt het huidige deck

        //aanmaken van het deck met 52 kaarten waarvan 13 waardes(Value) en met 4 kleuren(suit)
        public void setUpDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;

                }
            }
            ShuffleCards();
        }
        //schud het deck
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            //shuffled het deck 1000 keer zodat het deck goed geshuffeld is
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NumOfCards; i++)
                {
                    //wisseld de kaarten
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;

                }
            }
        }

    }
}
