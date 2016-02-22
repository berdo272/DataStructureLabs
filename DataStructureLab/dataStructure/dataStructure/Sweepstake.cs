using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Sweepstake
    {
        Dictionary<string, string> Contestants = new Dictionary<string, string>();

        string Name;



        public Sweepstake(string name)
        {
            this.Name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            Contestants.Add(contestant._name, contestant._phoneNumber);

        }
        public string pickWinner()
        {
            KeyValuePair<string,string> winner;
            List<KeyValuePair<string, string>> drawPool;
            Random rnd = new Random();

            drawPool = Contestants.ToList();

            winner = drawPool[rnd.Next(drawPool.Count)];


            return ("The winner of the sweepstake is " + winner.Key + " Phone Numer: " + winner.Value);

        }
        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant._name + "Phone Number: " + contestant._phoneNumber);
        }
    }
}
