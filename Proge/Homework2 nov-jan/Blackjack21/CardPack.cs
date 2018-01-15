using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack21
{
    class CardPack
    {
        private int[] Cards;

        public CardPack()
        {
            int[] c = Enumerable.Range(1,52).ToArray();
            this.SetCards(c);
        }

        public void SetCards(int[] c)
        {
            Cards = c;
        }

        public int[] GetCards()
        {
            return Cards;
        }

        public int GetCard(int i)
        {
            return Cards[i];
        }

        public void Shuffle()
        {
            int[] c = this.GetCards();

            Random rnd = new Random();

            for (int ii = 0; ii < 52; ii++)
            {
                int rN = rnd.Next(0, (52 - ii));

                int s = c[51 - ii];
                c[51 - ii] = c[rN];
                c[rN] = s;

            }
        }
    }
}
