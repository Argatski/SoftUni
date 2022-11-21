using System;
using System.Collections.Generic;

namespace _03.Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] desk = Console.ReadLine()
                 .Split(", ");
            List<Card> cards = new List<Card>();

            for (int i = 0; i < desk.Length; i++)
            {
                try
                {
                    string[] input = desk[i]
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string face = input[0].ToUpper();
                    string suit = input[1].ToUpper();
                    Card card = new Card(face, suit);
                    cards.Add(card);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid card!");
                }
            }

            foreach (var card in cards)
            {
                Console.Write($"[{card}] ");
            }
        }
    }

    public class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        public string Face
        {
            get { return this.face; }
            private set
            {
                value = ValidFace(value.ToUpper());
                this.face = value;
            }
        }



        public string Suit
        {
            get { return this.suit; }
            private set
            {
                value = ValidSuit(value.ToUpper());
                this.suit = value;
            }
        }

        private string ValidSuit(string v)
        {
            string result = "";
            switch (v)
            {
                case "S":
                    result = "\u2660";
                    break;
                case "H":
                    result = "\u2665";
                    break;
                case "D":
                    result = "\u2666";
                    break;
                case "C":
                    result = "\u2663";
                    break;
                default:
                    throw new ArgumentException();
            }
            return result;
        }

        private string ValidFace(string value)
        {
            string result = "";
            switch (value)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    result = value;
                    break;
                default:
                    throw new ArgumentException();
            }
            return result;
        }

        public override string ToString()
        {
            return $"{this.face}{this.Suit}";
        }
    }
}
