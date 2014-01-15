using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

var client = new MongoClient();
var server = client.GetServer();
var database = server.GetDatabase("firstapp");
var locationsCollection = database.GetCollection("locations");
var location1 = new BsonDocument() 
{
    { "name", "Taj Mahal" },
    { "address", "123 University Ave" },
    { "city", "Palo Alto" },
    { "zipcode", 94301 }
};
locationsCollection.Insert(location1);
var location = locationsCollection.FindOne();
Console.WriteLine(location);
locationsCollection.EnsureIndex(IndexKeys.Ascending("name"));
var explainPlan = locationsCollection.Find(Query.EQ("name", "Taj Mahal")).Explain();
Console.WriteLine(explainPlan);