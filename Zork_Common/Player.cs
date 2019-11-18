using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork_Common

{
    public class Player
    {
        public event EventHandler<int> ScoreChanged;  
        public int Moves { get; set; }

        private int mScore;

        public World World { get; }

        [JsonIgnore]

        public Room Location { get; private set; }


        [JsonIgnore]

        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }

        public void ScoreChange(Game game, CommandContext commandContext)
        {
           
        }

        public int Score
        {
            get => mScore;
            set
            {
                mScore = value;
            }
        }
    }
}