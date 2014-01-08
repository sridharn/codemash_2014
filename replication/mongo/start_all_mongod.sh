#!/bin/sh
mongod --config ./mongod_rs1.conf
mongod --config ./mongod_rs2.conf
mongod --config ./mongod_rs3.conf