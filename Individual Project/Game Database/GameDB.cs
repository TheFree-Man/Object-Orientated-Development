using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Database
{
    public abstract class GameDB : IComparable
    {
        // Initialising Game objects
        public string GameName { get; set; }
        public string CreatedBy { get; set; }
        public int MetacriticRating { get; set; }

        public GameDB(string name, string cretedBy, int metacriticRating)
        {
            GameName = name;
            CreatedBy = cretedBy;
            MetacriticRating = metacriticRating;
        }

        // Default layout if object displayed in the listbox
        public GameDB() : this ("Unknown", "Unknown", 71) { }

        public override string ToString()
        {
            return GameName;
        }

        public int CompareTo(object obj)
        {
            GameDB otherGame = obj as GameDB;
            throw new NotImplementedException();
        }
    }

    // Inherits original method and appends Genreto the end of each game
    public class FPS : GameDB
    {
        public override string ToString()
        {
            return base.ToString() + " - FPS";
        }
    }

    public class RPG : GameDB
    {
        public override string ToString()
        {
            return base.ToString() + " - RPG";
        }
    }

    public class RTS : GameDB
    {
        public override string ToString()
        {
            return base.ToString() + " - RTS";
        }
    }

    public class Adventure : GameDB
    {
        public override string ToString()
        {
            return base.ToString() + " - Adventure";
        }
    }

    public class Puzzle : GameDB
    {
        public override string ToString()
        {
            return base.ToString() + " - Puzzle";
        }
    }
}
