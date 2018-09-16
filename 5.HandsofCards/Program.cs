using System;
using System.Collections.Generic;
using System.Linq;


namespace _5.HandsofCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            // string[] hand = Console.ReadLine().Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] hand = Console.ReadLine().Split(':').ToArray();

            int totalSum = 0;
            string name = "";
            string cards = "";

            while (hand[0] != "JOKER")
            {
                cards = hand[1];
                cards = cards.Trim();
                List<string> cardsList = new List<string>();
                cardsList = cards.Split(",".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Distinct().ToList();

                name = hand[0];

                if (!players.ContainsKey(name))
                {
                    players.Add(name, cardsList);
                }
                else
                {
                    players[name].AddRange(cardsList);
                    players[name] = players[name].Distinct().ToList();
                }
                hand = Console.ReadLine().Split(':').ToArray();
            }

            foreach (var player in players)
            {
                foreach (var card in player.Value)
                {
                    int multiplier = 0;

                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                    }

                    int power = 0;
                    var cardTemp = card.Remove(card.Length - 1);

                    try
                    {
                        power = int.Parse(cardTemp);
                    }
                    catch
                    {
                        switch (cardTemp)
                        {
                            case "J":
                                power = 11;
                                break;
                            case "Q":
                                power = 12;
                                break;
                            case "K":
                                power = 13;
                                break;
                            case "A":
                                power = 14;
                                break;
                        }
                    }
                    totalSum += power * multiplier;

                }
                Console.WriteLine($"{player.Key}: {totalSum}");
                totalSum = 0;
            }
        }
    }
}