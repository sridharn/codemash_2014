using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

var client = new MongoClient();
var server = client.GetServer();
var database = server.GetDatabase("firstapp");
var locationsCollection = database.GetCollection("locations");
var location2 = new BsonDocument() 
{
    { "name", "Lotus Flower" },
    { "address", "234 University Ave" },
    { "city", "Palo Alto" },
    { "zipcode", 94301 },
    { "tags", new BsonArray {"restaurant", "dumplings"} }
};
locationsCollection.Insert(location2);
Console.WriteLine(locationsCollection.FindOne(Query.EQ("tags", "dumplings")));
locationsCollection.EnsureIndex(IndexKeys.Ascending("tags"));
Console.WriteLine(locationsCollection.Find(Query.EQ("tags", "dumplings")).Explain());
