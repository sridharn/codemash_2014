using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

var client = new MongoClient();
var server = client.GetServer();
var database = server.GetDatabase("firstapp");
var locationsCollection = database.GetCollection("locations");
var query = Query.EQ("name", "Lotus Flower");
var update = Update.Push("tips", new BsonDocument
	{
	    { "user", "Sridhar" },
	    { "date", new DateTime(2014, 1, 2, 11, 52, 27, 442) },
	    { "tip", "The sesame dumplings are awesome!" } 
	});
locationsCollection.Update(query, update);
Console.WriteLine(locationsCollection.FindOne(Query.Matches("name", "^Lot")));
