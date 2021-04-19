using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuxtIntegration.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("id")]
        public string Id { get; set; }

        [BsonElement("bookName")]
        [JsonProperty("bookName")]
        public string BookName { get; set; }

        [BsonElement("price")]
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [BsonElement("category")]
        [JsonProperty("category")]
        public string Category { get; set; }

        [BsonElement("author")]
        [JsonProperty("author")]
        public string Author { get; set; }
    }
}
