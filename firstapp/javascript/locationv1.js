db = db.getSiblingDB("firstapp")

location_1 = {
      name: "Taj Mahal",
      address: "123 University Ave",
      city: "Palo Alto",
      zipcode: 94301
}

db.locations.insert(location_1)

db.locations.findOne({name: "Taj Mahal"})

db.locations.ensureIndex({name: 1})

db.locations.find({name: "Taj Mahal"}).explain()
