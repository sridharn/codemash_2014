db = db.getSiblingDB("firstapp")

location_2 = {
      name: "Lotus Flower",
      address: "234 University Ave",
      city: "Palo Alto",
      zipcode: 94301,
      tags: ["restaurant", "dumplings"]
}

db.locations.insert(location_2)

db.locations.findOne({tags: "dumplings"})

db.locations.ensureIndex({tags: 1}) 

db.locations.find({tags: "dumplings"}).explain()
