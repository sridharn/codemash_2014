db = db.getSiblingDB("firstapp")

user_1 = {
      _id: "sridhar@mongodb.com",
      name: "Sridhar",
      twitter: "snanjund",
}

db.users2.save(user_1)

location_id_1 = db.locations.findOne({name:"Lotus Flower"}, {_id:1})["_id"]
location_id_2 = db.locations.findOne({name:"Taj Mahal"},    {_id:1})["_id"]

checkin_1 = {
      location: location_id_1,
      user: "sridhar@mongodb.com",
      ts: ISODate("2013-12-21T11:52:27.442Z")
}

db.checkins.save(checkin_1)

checkin_2 = {
      location: location_id_2,
      user: "sridhar@mongodb.com",
      ts: ISODate("2014-01-22T07:15:00.442Z")
}

db.checkins.save(checkin_2)

db.checkins.ensureIndex({user: 1})

db.checkins.find({user: "sridhar@mongodb.com"}).pretty()