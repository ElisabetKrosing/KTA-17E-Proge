using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack21
{
    class Program
    {
        static void Main(string[] args)
        {
            CardPack cardPack = new CardPack();
            cardPack.Shuffle();

            int player = 0;
            int house = 0;
            int i;

            int playerAces = 0;
            int usedPlayerAces = 0;
            int houseAces = 0;
            int usedHouseAces = 0;

            for ( i = 0; i < 4; i++)
            {
                Card card = new Card(cardPack.GetCard(i));
                if (i%2 == 1)
                {
                    house = house + card.GetValue();
                    if (card.GetValue() == 11)
                    {
                        houseAces++;
                    }
                    if (i == 1)
                    {
                        Console.WriteLine("Majale jagati kaart: " + card.GetName());
                    }
                    else
                    {
                        Console.WriteLine("Majale jagati kaart: [?]");
                    }


                }
                else
                {
                    player = player + card.GetValue();
                    if (card.GetValue() == 11)
                    {
                        playerAces++;
                    }
                    Console.WriteLine("Teile jagati kaart: " + card.GetName());
                }
            }

            if ((house == 21) || (player == 21))
            {
                if ((house == 21) && (player == 21))
                {
                    Console.WriteLine("Mõlemal on Blackjack! Viik!");
                }
                else if (house == 21)
                {
                    Console.WriteLine("Majal on Blackjack! Kaotasite!");
                }
                else
                {
                    Console.WriteLine("Teil on Blackjack! Võitsite!");
                }

                Console.ReadKey();
            }

            else
            {
                Boolean keepGoing = true;
                while (keepGoing)
                {
                    keepGoing = false;
                    Console.WriteLine("lisa kaart(1) või lõpeta(2)");
                    Console.Write("Teie valik: ");

                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        keepGoing = true;
                        Card card = new Card(cardPack.GetCard(i));
                        i++;
                        player = player + card.GetValue();
                        Console.WriteLine("Teile jagati kaart: " + card.GetName());
                        if (card.GetValue() == 11)
                        {
                            playerAces++;
                        }
                        if ((player > 21) && (playerAces > usedPlayerAces))
                        {
                            player = player - 10;
                            usedPlayerAces++;
                        }
                        if (player > 21)
                        {
                            break;
                        }
                    }

                    else if(input == "2") 
                    {
                    }

                    else
                    {
                        Console.WriteLine("Sisestasite vale märgi! Proovige uuesti!");
                    }

                    if (house < player)
                    {
                        keepGoing = true;
                        Card card = new Card(cardPack.GetCard(i));
                        i++;
                        house = house + card.GetValue();
                        Console.WriteLine("Majale jagati kaart: [?]");
                        if (card.GetValue() == 11)
                        {
                            houseAces++;
                        }
                        if ((house > 21) && (houseAces > usedHouseAces))
                        {
                            house = house - 10;
                            usedHouseAces++;
                        }
                        if (house > 21)
                        {
                            break;
                        }

                    }
                
      
                }


                Console.WriteLine("Teie punktid on " + player + ", maja punktid on " + house + ".");
                if (((player > house) && (player < 22)) || (house > 21))
                {
                    Console.WriteLine("Palju õnne, võitsite!");
                }
                else if((player < house) && (house < 22) || (player > 21)){
                    Console.WriteLine("Kahjuks kaotasite.");
                }
                else 
                {
                    Console.WriteLine("Jäite viiki.");
                }
                Console.ReadKey();

            }
            Console.ReadKey();
        }
    }
}
