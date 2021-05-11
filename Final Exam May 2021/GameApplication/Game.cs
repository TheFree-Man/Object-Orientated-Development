using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication
{
    public class Game
    {
        public string Name { get; set; }
        public int MetariticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string Game_Image { get; set; }
        public int GameID { get; set; }

        public Game()
        {

        }

        public Game(string name, int metacriticScore, string description, string platform, decimal price, string game_image)
        {
            Name = name;
            MetariticScore = metacriticScore;
            Description = description;
            Platform = platform;
            Price = price;
            Game_Image = game_image;
        }

        public void DecreasePrice(decimal priceDrop)
        {
            Price -= Price * priceDrop;
        }

        public class GameData : DbContext
        {
            public GameData() : base("GameInformation") { }

            public DbSet<Game> Games { get; set; }
        }
    }
}
