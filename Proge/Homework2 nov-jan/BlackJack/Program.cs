using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {

        static void Main(string[] args)
        {

            // Mängu reeglite kirjeldus
            Console.WriteLine("Blakjack\n" +
                "\nMängu eesmärk: Saa majast suurem punktisumma, mis jääb alla 22!\n\n" +
                "Kaartide väärtused:\n" +
                "2-10 = 2-10 punkti\n" +
                "Poiss(P), Emand(E), Kuningas(K) = 10 punkti\n" +
                "Äss(A)= 1 või 11 punkti\n" +
                "\n" +
                "Võimalikud valikud:\n" +
                "vajuta [1] - lisa 1 kaart\n" +
                "vajuta [2] - lõpeta\n");




            //KaardipakkiValik//////////////////////////////////////////

            int[] segamataKaardid = Enumerable(1, 52);
            int[] segatudKaardipakk = new int[52];

            Random rnd = new Random();

            int kohaLugeja = 0;
            int Asukoht = 0;
            int i = 0;

            for (paigutatudKaardid = 0; paigutatudKaardid < 52; paigutatudKaardid++)
            {

                int rN = rnd.Next(0, 52);
                Asukoht = rN;

                while (kohaLugeja <= Asukoht)
                {
                    if (segamataKaardid[kohalugeja] = 0


            {
                        Asukoht++


            }
                    kohaLugeja++


        }
                segatudKaardipakk[i] = segamataKaardid[Asukoht];
                segamataKaardid[Asukoht] = 0;
                i++


    }


            // Mängu algus: kaartide jagamine.///////////////////////////////////

            int mängijaPunktid = 0;
            int majaPunktid = 0;

            int mängijaÄssad = 0;
            int majaÄssad = 0;
            int kasutatudMängijaÄssad = 0;
            int kasutatudMajaÄssad = 0;

            tõlkimine(segatudKaardipakk[i]);
            if (kaardipunktid = 11) { mängijaÄssad++}
            mängijaPunktid = mängijaPunktid + kaardipunktid;
            i++

        string kaart1 = kaart


        tõlkimine(segatudKaardipakk[i]);
            if (kaardipunktid = 11) { majaÄssad++}
            majaPunktid = majaPunktid + kaardipunktid;
            i++

        string kaart2 = kaart


        tõlkimine(segatudKaardipakk[i]);
            if (kaardipunktid = 11) { mängijaÄssad++}
            mängijaPunktid = mängijaPunktid + kaardipunktid;
            i++

        string kaart3 = kaart


        tõlkimine(segatudKaardipakk[i]);
            if (kaardipunktid = 11) { majaÄssad++}
            majaPunktid = majaPunktid + kaardipunktid;
            i++


        Console.WriteLine("Teile jagatud kaardid: " + kaart1 + kaart3);
            Console.WriteLine("Majale jagatud kaardid: " + kaart2 + "[?]" + "\n");

            //


            //Kaartide lisamine & mängu lõpp/////////////////////////////////////////////

            while (true)
            {
                Console.WriteLine("lisa kaart(1) või lõpeta(2)");
                Console.Write("Teie valik: ")


        string input = Console.ReadKey();

                if (input = "1")
                {
                    tõlkimine(segatudKaardipakk[i]);
                    if (kaardipunktid = 11) { mängijaÄssad++}
                    mängijaPunktid = mängijaPunktid + kaardipunktid;
                    if ((mängijaPunktid > 21) && (mängijaÄssad > kasutatudMängijaÄssad))
                    {
                        mängijapunktid = mängijapunktid - 10


            kasutatudMängijaÄssad++;
                    }
                    i++


        string lisaKaart = kaart;
                    Console.WriteLine("Teile jagatud kaart: " + lisaKaart);
                    if (mängijaPunktid > 21) { break}
                }

                while (majaPunktid < mängijaPunktid)
                {
                    tõlkimine(segatudKaardipakk[i]);
                    if (kaardipunktid = 11) { majaÄssad++}
                    majaPunktid = majaPunktid + kaardipunktid;
                    if ((majaPunktid > 21) && (majaÄssad > kasutatudMajaÄssad))
                    {
                        majapunktid = majapunktid - 10


            kasutatudMajaÄssad++;
                    }
                    i++


        Console.WriteLine("Majale jagatud kaart: [?]");
                    ˇ       if (majaPunktid > 21) { break}
                }

                elseif(input = "2") { break}
		else { Console.WriteLine("Sisestasite vale märgi! Proovige uuesti!"); }
            }





            Console.WriteLine("Teie punktid on " + mängijapunktid + ", maja punktid on " + majapunktid ".");
            if (((mängijapunktid > majapunktid) && (mängijapunktid < 22)) || (majapunktid > 21))
            {
                Console.WriteLine("Palju õnne, võitsite!");
            }
            elseif((mängijapunktid < majapunktid) && (majapunktid < 22) || (mängijapunktid > 21))
            {
                Console.WriteLine("Kahjuks kaotasite.");
            }
            else (mängijapunktid = majapunktid) {
                Console.WriteLine("Jäite viiki.");
            }
            Console.ReadKey();

        }
        {
}
    }
}
