#!/bin/sh
mongod --config ./mongod_config.conf
mongod --config ./mongod_shard1.conf
mongod --config ./mongod_shard2.conf
mongos --config ./mongos.conf