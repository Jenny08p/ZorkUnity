using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;



namespace Zork_Common

{
    [JsonConverter(typeof(RoomConverter))]
    public class Room : IEquatable<Room>
    { 
        //[JsonProperty(Order = 1)]
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborsNames { get; set; }

       [JsonIgnore]
       public Dictionary<Directions, Room> Neighbors { get; set; }
        public int rooms { get; set; }

        public Room():
            this(string.Empty, string.Empty, new Dictionary<Directions, string>())
        {

        }
        public Room(string name, string description, Dictionary<Directions, string> neighboreNames)
        { 
            Name = name;
            Description = description; 
            NeighborsNames = neighboreNames;
            Neighbors = new Dictionary<Directions, Room>();
        }

        public void UpdateNeighbors(List<Room> rooms)
        {
            Neighbors = (from entry in NeighborsNames
                         let room = rooms.Find(i => i.Name.Equals(entry.Value, System.StringComparison.InvariantCultureIgnoreCase))
                         where room != null
                         select (Direction: entry.Key, Room: room)).
                         ToDictionary(pair => pair.Direction, pair => pair.Room);

            NeighborsNames.Clear();             
        }

        public override string ToString() => Name;

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;


        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborsNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room)).ToDictionary(pair => pair.Direction, pair => pair.Room);
    }
}
