using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

var client = new MongoClient();
var server = client.GetServer();
var database = server.GetDatabase("firstapp");
var usersCollection = database.GetCollection("users");
var user1 = new BsonDocument() 
{
	{ "_id", "sridhar@mongodb.com" },
    { "name", "Sridhar" },
    { "twitter", "snanjund" },
    { "checkins", new BsonArray 
    	{
       		new BsonDocument 
       		{ 
       			{ "location", "Lotus Flower" }, 
       			{ "ts", new DateTime(2013, 12, 21, 11, 52, 27, 442) }
       		},
       		new BsonDocument 
       		{ 
       			{ "location", "Taj Mahal" }, 
       			{ "ts", new DateTime(2014, 1, 02, 11, 52, 27, 442) }
       		}
       	}
    }
};

usersCollection.Save(user1);
usersCollection.EnsureIndex(IndexKeys.Ascending("checkins.location"));

// find all users who've checked in here:
var cursor = usersCollection.Find(Query.EQ("checkins.location", "Lotus Flower"));
var result = cursor.SetFields(Fields.Include("names", "checkins")).ToArray();
foreach (var doc in result) {
    Console.WriteLine(doc);
}

// find the last 10 checkins here: - Warning!
cursor = usersCollection.Find(Query.EQ("checkins.location", "Lotus Flower"));
result = cursor.SetFields(Fields.Include("names", "checkins")).SetSortOrder(SortBy.Descending("checkins.ts")).SetLimit(10).ToArray();
foreach (var doc in result) {
    Console.WriteLine(doc);
}
