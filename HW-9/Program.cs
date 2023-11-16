using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    internal interface IGame
    {
        void Play();
    }
    internal class Beach : IGame
    {
        public void Play()
        {
            Console.WriteLine("Пляж");
        }
    }
    internal class MouseTrap : IGame
    {
        public void Play()
        {
            Console.WriteLine("Мышеловка");
        }
    }
    internal class Sea : IGame
    {
        public void Play()
        {
            Console.WriteLine("Море");
        }
    }
    internal class Fishing : IGame
    {
        public void Play()
        {
            Console.WriteLine("Рыбалка");
        }
    }
    internal class Postmans : IGame
    {
        public void Play()
        {
            Console.WriteLine("Почтальоны");
        }
    }
    internal class Slide : IGame
    {
        public void Play()
        {
            Console.WriteLine("Горка");
        }
    }
    internal class NewGame : IGame
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public NewGame()
        {

        }
        public NewGame(string name)
        {
            this.name = name;
        }
        public void Play()
        {
            if (name == null)
            {
                Console.WriteLine("Новая игра");
            }
            else
            {
                Console.WriteLine(name);
            }
        }
    }
    internal class GameEditor : IGame
    {
        private readonly Team team;
        private readonly IGame game;

        public GameEditor(Team team, IGame game)
        {
            this.team = team;
            this.game = game;
        }

        public void Play()
        {
            team.PlayGame();
            game.Play();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IGame> ru_games = new List<IGame>();
            List<Player> rus = new List<Player>();
            Organisator org = new Organisator("Оливье Ганьян");
            Player ru_player1 = new Player("Павел", Country.Россия);
            rus.Add(ru_player1);
            Player ru_player2 = new Player("Олег", Country.Россия);
            rus.Add(ru_player2);
            Player ru_player3 = new Player("Камиль", Country.Россия);
            rus.Add(ru_player3);
            Player ru_player4 = new Player("Камиль", Country.Россия);
            rus.Add(ru_player4);
            Player ru_player5 = new Player("Ростик", Country.Россия);
            rus.Add(ru_player5);
            Player ru_player6 = new Player("Нияз", Country.Россия);
            rus.Add(ru_player6);
            Player ru_player7 = new Player("Крокант", Country.Россия);
            rus.Add(ru_player7);
            Player ru_player8 = new Player("Никита", Country.Россия);
            rus.Add(ru_player8);
            Player ru_player9 = new Player("Адэль", Country.Россия);
            rus.Add(ru_player9);
            Player ru_player10 = new Player("Семен", Country.Россия);
            rus.Add(ru_player10);
            Player ru_player11 = new Player("ЧЕРЕпавел", Country.Россия);
            rus.Add(ru_player11);
            Player ru_player12 = new Player("Булат", Country.Россия);
            rus.Add(ru_player12);
            Player ru_player13 = new Player("Ринат", Country.Россия);
            rus.Add(ru_player13);
            Player ru_player14 = new Player("Данил", Country.Россия);
            rus.Add(ru_player14);
            Player ru_player15 = new Player("Тригон", Country.Россия);
            rus.Add(ru_player15);
            ru_games.Add(new Beach());
            ru_games.Add(new MouseTrap());
            ru_games.Add(new Sea());
            ru_games.Add(new Fishing());
            ru_games.Add(new Postmans());
            ru_games.Add(new Slide());
            Team team_rus = new Team(rus, ru_games);

            List<Player> frn = new List<Player>();
            List<IGame> frn_games = new List<IGame>();
            Player frc_player1 = new Player("Люк", Country.Франция);
            frn.Add(frc_player1);
            Player frc_player2 = new Player("Жан", Country.Франция);
            frn.Add(frc_player2);
            Player frc_player3 = new Player("Леон", Country.Франция);
            frn.Add(frc_player2);
            Player frc_player4 = new Player("Сами", Country.Франция);
            frn.Add(frc_player3);
            Player frc_player5 = new Player("Ямакаси", Country.Франция);
            frn.Add(frc_player4);
            Player frc_player6 = new Player("Фредерик", Country.Франция);
            frn.Add(frc_player5);
            Player frc_player7 = new Player("Мансион", Country.Франция);
            frn.Add(frc_player7);
            Player frc_player8 = new Player("Васаби", Country.Франция);
            frn.Add(frc_player8);
            Player frc_player9 = new Player("Жерар", Country.Франция);
            frn.Add(frc_player9);
            Player frc_player10 = new Player("Петра", Country.Франция);
            frn.Add(frc_player10);
            Player frc_player11 = new Player("Даниэль", Country.Франция);
            frn.Add(frc_player11);
            Player frc_player12 = new Player("Малик", Country.Франция);
            frn.Add(frc_player12);
            Player frc_player13 = new Player("Шарль", Country.Франция);
            frn.Add(frc_player13);
            Player frc_player14 = new Player("Багет", Country.Франция);
            frn.Add(frc_player14);
            Player frc_player15 = new Player("Куасон", Country.Франция);
            frn.Add(frc_player15);
            frn_games.Add(new Beach());
            frn_games.Add(new MouseTrap());
            frn_games.Add(new Sea());
            frn_games.Add(new Fishing());
            frn_games.Add(new Postmans());
            frn_games.Add(new Slide());
            Team team_france = new Team(frn, frn_games);

            List<Player> chn = new List<Player>();
            List<IGame> chn_games = new List<IGame>();
            Player chn_player1 = new Player("Джеки Чан", Country.Китай);
            chn.Add(chn_player1);
            Player chn_player2 = new Player("Саммо Хун", Country.Китай);
            chn.Add(chn_player2);
            Player chn_player3 = new Player("Ван", Country.Китай);
            chn.Add(chn_player3);
            Player chn_player4 = new Player("Ма", Country.Китай);
            chn.Add(chn_player4);
            Player chn_player5 = new Player("Хэ", Country.Китай);
            chn.Add(chn_player5);
            Player chn_player6 = new Player("Ли", Country.Китай);
            chn.Add(chn_player6);
            Player chn_player7 = new Player("Пу", Country.Китай);
            chn.Add(chn_player7);
            Player chn_player8 = new Player("Яо", Country.Китай);
            chn.Add(chn_player8);
            Player chn_player9 = new Player("Сунь", Country.Китай);
            chn.Add(chn_player9);
            Player chn_player10 = new Player("Вынь", Country.Китай);
            chn.Add(chn_player10);
            Player chn_player11 = new Player("Дэн", Country.Китай);
            chn.Add(chn_player11);
            Player chn_player12 = new Player("Цинь", Country.Китай);
            chn.Add(chn_player12);
            Player chn_player13 = new Player("Брюс Ли", Country.Китай);
            chn.Add(chn_player13);
            Player chn_player14 = new Player("Карате пацан", Country.Китай);
            chn.Add(chn_player14);
            Player chn_player15 = new Player("Конфуций", Country.Китай);
            chn.Add(chn_player15);
            chn_games.Add(new Beach());
            chn_games.Add(new MouseTrap());
            chn_games.Add(new Sea());
            chn_games.Add(new Fishing());
            chn_games.Add(new Postmans());
            chn_games.Add(new Slide());
            Team team_chn = new Team(chn, chn_games);


            List<Player> kzh = new List<Player>();
            List<IGame> kzh_games = new List<IGame>();
            Player kzh_player1 = new Player("Абай", Country.Казахстан);
            kzh.Add(kzh_player1);
            Player kzh_player2 = new Player("Аббас", Country.Казахстан);
            kzh.Add(kzh_player2);
            Player kzh_player3 = new Player("Абди", Country.Казахстан);
            kzh.Add(kzh_player3);
            Player kzh_player4 = new Player("Апчхи", Country.Казахстан);
            kzh.Add(kzh_player4);
            Player kzh_player5 = new Player("Абдибас", Country.Казахстан);
            kzh.Add(kzh_player5);
            Player kzh_player6 = new Player("Адидас", Country.Казахстан);
            kzh.Add(kzh_player6);
            Player kzh_player7 = new Player("Абу", Country.Казахстан);
            kzh.Add(kzh_player7);
            Player kzh_player8 = new Player("Ажибай", Country.Казахстан);
            kzh.Add(kzh_player8);
            Player kzh_player9 = new Player("Азат", Country.Казахстан);
            kzh.Add(kzh_player9);
            Player kzh_player10 = new Player("Байбек", Country.Казахстан);
            kzh.Add(kzh_player10);
            Player kzh_player11 = new Player("Умер", Country.Казахстан);
            kzh.Add(kzh_player11);
            Player kzh_player12 = new Player("Бабиджон", Country.Казахстан);
            kzh.Add(kzh_player12);
            Player kzh_player13 = new Player("Яузбек", Country.Казахстан);
            kzh.Add(kzh_player13);
            Player kzh_player14 = new Player("Сурен", Country.Казахстан);
            kzh.Add(kzh_player14);
            Player kzh_player15 = new Player("Алдияр", Country.Казахстан);
            kzh.Add(kzh_player15);
            kzh_games.Add(new Beach());
            kzh_games.Add(new MouseTrap());
            kzh_games.Add(new Sea());
            kzh_games.Add(new Fishing());
            kzh_games.Add(new Postmans());
            kzh_games.Add(new Slide());
            Team team_kazah = new Team(kzh, kzh_games);

            IGame game_rus = new GameEditor(team_rus, new NewGame("Скоростное поедание пельменей в шоколаде"));
            IGame game_frn = new GameEditor(team_france, new NewGame("Скоростное поедание пельменей в шоколаде"));
            IGame game_chn = new GameEditor(team_chn, new NewGame("Скоростное поедание пельменей в шоколаде"));
            IGame game_kzh = new GameEditor(team_kazah, new NewGame("Скоростное поедание пельменей в шоколаде"));

            Console.WriteLine("Игры для России");
            game_rus.Play();

            Console.WriteLine("\nИгры для Франции");
            game_frn.Play();

            Console.WriteLine("\nИгры для команды Китая");
            game_chn.Play();

            Console.WriteLine("\nИгры для команды Казахстана");
            game_kzh.Play();

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}
