using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_9
{
    internal abstract class Person
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Person(string name)
        {
            this.name = name;
        }
        public abstract void Print();
    }
    enum Country
    {
        Россия,
        Франция,
        Китай,
        Казахстан
    }
    internal class Player : Person
    {
        private Country country;
        public Player(string name, Country country) : base(name)
        {
            this.country = country;
        }
        public override void Print()
        {
            Console.WriteLine($"Страна: {country}\nИмя: {name}");
        }
    }
    internal class Organisator : Person
    {
        public Organisator(string name) : base(name)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Организтор: {name}");
        }
    }
    internal class Team
    {
        private List<Player> players;
        public List<Player> Players
        {
            get{return players;}
        }
        private List<IGame> games;
        public List<IGame> Games
        {
            get{return games;}
        }
        //public Team()
        //{
        //}
        public Team(List<Player> players)
        {
            this.players = players;
        }
        public Team(List<Player> players, List<IGame> games)
        {
            this.players = players;
            this.games = games;
        }
        public void AddGame(IGame game)
        {
            games.Add(game);
        }

        public void PlayGame()
        {
            foreach (var game in games)
            {
                game.Play();
            }
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
    }
}