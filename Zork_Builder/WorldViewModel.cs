using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zork_Common;


namespace Zork_Builder

{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public BindingList<StartingLocation> StartingLocations { get; set; }


        public WorldViewModel()
        {
            Rooms = new BindingList<Room>(Array.Empty<Room>());
            StartingLocations = new BindingList<StartingLocation>(Array.Empty<StartingLocation>());
        }

        public Game Game
        {
            set
            {
                if (mGame != value)
                {
                    mGame = value;
                    if (mGame != null && mGame.World != null && mGame.World.Rooms != null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms.ToList());
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveGame()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mGame);
            }
        }

        private Game mGame;
    }
}