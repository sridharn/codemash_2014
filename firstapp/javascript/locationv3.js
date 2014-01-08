db = db.getSiblingDB("firstapp")

location_3 = {
      name: "El Capitan",
      address: "345 University Ave",
      city: "Palo Alto",
      zipcode: 94301, 
      tags: ["restaurant", "tacos"],
      lat_long: [52.5184, 13.387]
}

db.locations.insert(location_3)

db.locations.find({lat_long: {$near:[52.53, 13.4]}})

db.locations.ensureIndex({lat_long: "2d"})

db.locations.findOne({lat_long: {$near:[52.53, 13.4]}})
