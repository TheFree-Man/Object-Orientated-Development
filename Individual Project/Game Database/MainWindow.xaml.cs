﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    // Name: Mark Gilmartin
    // Student Number S00198957
    // Github Link: https://github.com/TheFree-Man/Object-Orientated-Development/tree/master/Individual%20Project
    public partial class MainWindow : Window
    {
        // Initialing database
        Model1Container db = new Model1Container();

        //Initialising list
        List<GameDB> allGames = new List<GameDB>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            // Initialising Objects
            FPS g1 = new FPS() { GameName = "Half-Life: Alyx", CreatedBy = "Valve Software", MetacriticRating = 93 };
            FPS g2 = new FPS() { GameName = "F.E.A.R", CreatedBy = "Monolith Productions", MetacriticRating = 88 };

            RPG g3 = new RPG() { GameName = "The Elder Scrolls V: Skyrim", CreatedBy = "Bethesda Game Studios", MetacriticRating = 94 };
            RPG g4 = new RPG() { GameName = "Disco Elysium", CreatedBy = "ZA/UM", MetacriticRating = 91 };

            RTS g5 = new RTS() { GameName = "Starcraft II", CreatedBy = "Blizzard Entertainment", MetacriticRating = 93 };
            RTS g6 = new RTS() { GameName = "Ashes of the Singularity: Escalation", CreatedBy = "Stardock Oxide Games", MetacriticRating = 81 };

            Adventure g7 = new Adventure() { GameName = "Psychonauts", CreatedBy = "Double Fine Productions", MetacriticRating = 87 };
            Adventure g8 = new Adventure() { GameName = "Star Wars Jedi: Fallen Order", CreatedBy = "Respawn Entertainment", MetacriticRating = 81 };

            Puzzle g9 = new Puzzle() { GameName = "Baba is You", CreatedBy = "Hempuli Oy", MetacriticRating = 87 };
            Puzzle g10 = new Puzzle() { GameName = "Superliminal", CreatedBy = "Pillow Castle Games", MetacriticRating = 74 };

            // Adding objects to games listbox
            allGames.Add(g1);
            allGames.Add(g2);
            allGames.Add(g3);
            allGames.Add(g4);
            allGames.Add(g5);
            allGames.Add(g6);
            allGames.Add(g7);
            allGames.Add(g8);
            allGames.Add(g9);
            allGames.Add(g10);

            lstbx_Games.ItemsSource = allGames;
            */

            // Querying Database to get list of games for games listbox
            var lstbxGamesQuery = from n in db.Games
                                  select n;

            lstbx_Games.ItemsSource = lstbxGamesQuery.ToList();
        }

        private void cbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstbx_Games_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Initialising lists for database querying
            Game selectedGame = lstbx_Games.SelectedItem as Game;
            Review selectedReview = lstbx_Games.SelectedItem as Review;

            // Querying database to get information for Name, Developers, Metacritic rating, and description textboxes
            var gameQuery = from n in db.Games
                                 where n.Id == selectedGame.Id
                                 select n;

            var gameResults = gameQuery.ToList();

            tbxName.ItemsSource = gameResults;
            tbxCreatedBy.ItemsSource = gameResults;
            tbxMetacriticRating.ItemsSource = gameResults;
            tbxDescription.ItemsSource = gameResults;
            lstbxCoverArt.ItemsSource = gameResults;

            // Querying database to get information for Reviwer name, and Review content textboxes
            var reviewQuery = from r in db.Reviews
                                 where r.GameId == selectedGame.Id
                                 select r;

            var reviewResults = reviewQuery.ToList();

            tbxReviewer.ItemsSource = reviewResults;
            tbxReviews.ItemsSource = reviewResults;



        }
    }
}
