using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_2
{
    class DealCards : Deck
    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] sortedPlayerHand;
        private Card[] sortedComputerHand;

        public DealCards()
        {
            playerHand = new Card[5];
            sortedComputerHand = new Card[5];
            computerHand = new Card[5];
            sortedPlayerHand = new Card[5];
        }

        public void Deal()
        {
            setUpDeck(); // maakt het deck en schud het
            getHand();
            sortCards();
            displayCards();
            evaluateHands();
        }

        public void getHand()
        {
            // kaarten voor de speler
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];
            // 5 kaarten voor de computer
            for (int i = 5; i < 10; i++)
                computerHand[i -5] = getDeck[i];
        }

        public void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.MyValue
                              select hand;

            var queryComputer = from hand in computerHand
                                orderby hand.MyValue
                                select hand;

            var index = 0;
            foreach (var element in queryPlayer.ToList())
            {
                sortedPlayerHand[index] = element;
                index++;

            }
            index = 0;
            foreach (var element in queryComputer.ToList())
            {
                sortedComputerHand[index] = element;
                index++;

            }
        }

        public void displayCards()
        {
            Console.Clear();
            int x = 0; // x positie van de muis, bewegen links naar rechts
            int y = 1; // y positie van de muis, bewegen omhoog en omlaag

            //laat de spelers hand zien
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("PLAYERS HAND");
            for (int i = 0; i < 5; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedPlayerHand[i], x, y);
                x++;
            }
            y = 15; //verplaatst de rij van computers kaarten onder de spelers kaarten
            x = 0; // herstelt x positite
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 5; i < 10; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedComputerHand[i - 5], x, y);
                x++; //beweegt naar rechts
            }

        }
       

        public void evaluateHands()
        {

        }
    }
}
