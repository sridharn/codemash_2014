user_2 = {
      _id: "user2@10gen.com",
      name: "user2",
      twitter: "user2",
      checkins: [
       {location: "Lotus Flower", ts: ISODate("2013-09-21T11:52:27.442Z")},
       {location: "Taj Mahal", ts: ISODate("2013-01-02T07:15:00.442Z")}
      ]
  }

db.users.save(user_2)

user_3 = {
      _id: "user3@10gen.com",
      name: "user3",
      twitter: "user3",
      checkins: [
       {location: "Lotus Flower", ts: ISODate("2014-01-07T11:52:27.442Z")}
      ]
  }

db.users.save(user_3)

db.users.find({"checkins.location":"Lotus Flower"}, {name:1, checkins:1}).sort({"checkins.ts": -1}).limit(10).pretty()