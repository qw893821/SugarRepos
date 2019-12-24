using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace sugarrepo.Models
{
    public class SugarModel{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get;set;}

        [BsonElement("NDBNo")]
        public string NDBNo;
        [BsonElement("UPCNo")]
        public string UPCNo;
        [BsonElement("LongName")]
        public string LongName;
        [BsonElement("Ingredients")]
        public string Ingredients;
    } 

}