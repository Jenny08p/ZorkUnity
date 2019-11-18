using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Zork_Builder
{
    //[JsonConverter(typeof(PlayerConverter))]
    public class Player //: INotifyPropertyChanged
    {
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public string Name { get; set; }

    //    public int Description { get; set; }

    //    public Player(string name = null, int description = 0)
    //    {
    //        Name = name;
    //        Description = description;
    //    }

    //    public override string ToString() => Name;
    //}

    //public class PlayerConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Player));

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        JObject jsonObject = JObject.Load(reader);

    //        string name = jsonObject["Name"].Value<string>();
    //        int description = jsonObject["Description"].Value<int>();

    //        return new Player(name, description);
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        Player player = (Player)value;

    //        JObject playerObject = new JObject
    //        {
    //            { nameof(Player.Name), player.Name },
    //            { nameof(Player.Description), player.Description },
    //        };

    //        playerObject.WriteTo(writer);
    //    }
    }
}
