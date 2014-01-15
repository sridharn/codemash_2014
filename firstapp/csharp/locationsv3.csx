using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

var client = new MongoClient();
var server = client.GetServer();
var database = server.GetDatabase("firstapp");
var locationsCollection = database.GetCollection("locations");
var location3 = new BsonDocument() 
{
    { "name", "El Capitan" },
    { "address", "345 University Ave" },
    { "city", "Palo Alto" },
    { "zipcode", 94301 },
    { "tags", new BsonArray {"restaurant", "tacos"} },
    { "lat_long", new BsonArray {52.5184, 13.387} }
};
locationsCollection.Insert(location3);
// The following geo query will not execute without the index being present
// Console.WriteLine(locationsCollection.FindOne(Query.Near("lat_long", 52.53, 13.4)));
locationsCollection.EnsureIndex(IndexKeys.GeoSpatial("lat_long"));
Console.WriteLine(locationsCollection.FindOne(Query.Near("lat_long", 52.53, 13.4)));
Console.WriteLine(locationsCollection.Find(Query.Near("lat_long", 52.53, 13.4)).Explain());
