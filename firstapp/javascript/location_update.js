db = db.getSiblingDB("firstapp")

db.locations.update(
   {name: "Lotus Flower"},
   {$push: {
        tips: {
           user: "Sridhar",
           date: ISODate("2014-01-02T11:52:27.442Z"),
           tip: "The sesame dumplings are awesome!"
       }
    }}
)

db.locations.findOne({name:/^Lot/})
