admindb=db.getSiblingDB("admin");
conf = {
    _id:"dataweek2013",
    members:[
        {_id:0, host:"localhost:27018"},
        {_id:1, host:"localhost:27019"},
        {_id:2, host:"localhost:27020"}
    ]
}
admindb.adminCommand({replSetInitiate:conf})
admindb.adminCommand("replSetGetStatus");