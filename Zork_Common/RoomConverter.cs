using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Zork_Common
{
    public class RoomConverter : JsonConverter
    {
       public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));

       public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
       {
           dynamic jsonObject = JObject.Load(reader);

           string name = jsonObject["Name"];
           string description = jsonObject["Description"];
         
           Dictionary<Directions, string> neighborNames = jsonObject["Neighbors"].ToObject<Dictionary<Directions, string>>();
           if (jsonObject.TryGetValue("Neighbors", out JToken neighborNamesToken))
           {
               neighborNames = neighborNamesToken.ToObject<Dictionary<Directions, string>>();
           }
           else
           {
               neighborNames = new Dictionary<Directions, string>();
           }

           return new Room(name, description, neighborNames);
       }

       public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
       {
           Room room = (Room)value;
           JToken neighborNamesToken = JToken.FromObject(room.Neighbors.ToDictionary(pair => pair.Key, pair => pair.Value.Name), serializer);

           JObject roomObject = new JObject
           {
               { nameof(Room.Name), room.Name },
               { nameof(Room.Description), room.Description },
               { nameof(Room.Neighbors), neighborNamesToken }

           };

           roomObject.WriteTo(writer);
       }
    }
}