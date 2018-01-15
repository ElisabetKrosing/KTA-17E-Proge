using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack21
{
    class Card
    {
        private String name;
        private int value;
        private int number;

        public Card(int n)
        {
            this.SetNumber(n);
            this.NameLogic();
        }

        public void SetNumber(int n)
        {
            number = n;
        }

        public void SetName(string s)
        {
            name = s;
        }

        public void NameLogic()
        {
            string suit;
            string grade;
            int moduled = number%13;



            if ((number / 13) <= 1)
            {
                suit = "C";

            }
            else if(((number / 13) <= 2) && (number / 13) > 1){
                suit = "D";
             
            }
            else if (((number / 13) <= 3) && (number / 13) > 2){
                suit = "H";
             
            }
            else{
                suit = "S";
             
            }

            switch (moduled)
            {

                case 0:
                    grade = "K";
                    value = 10;
                    break;
                case 1:
                    grade = "A";
                    value = 11;     // 1 tuleb punktide arvutamisel
                    break;
                case 11:
                    grade = "J";
                    value = 10;
                    break;
                case 12:
                    grade = "Q";
                    value = 10;
                    break;
                default:
                    grade = moduled.ToString();
                    value = moduled;
                    break;
            }

            string whole = grade + suit;
            this.SetName(whole);
        }

        public int GetValue()
        {
            return value;
        }
        public int GetNumber()
        {
            return number;
        }
        public string GetName()
        {
            return name;
        }
    }
}
