using System;
using MongoDB.Bson.Serialization.Attributes;

namespace EAD_MongoLab_Library
{
	public class BookStore
	{
        [BsonId]
        public string ISBN { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        [BsonIgnoreIfNull]
        public int? TotalPages { get; set; }
    }
}

