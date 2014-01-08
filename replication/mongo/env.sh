#!/bin/sh
githome="/Users/sridhar/git/sridharn/codemash_2014"
datadirbase="$githome/replication/data"
datadir="$datadirbase/rs1"
if [ ! -d "$datadir" ]; then
    mkdir -p "$datadir"
fi
datadir="$datadirbase/rs2"
if [ ! -d "$datadir" ]; then
    mkdir -p "$datadir"
fi
datadir="$datadirbase/rs3"
if [ ! -d "$datadir" ]; then
    mkdir -p "$datadir"
fi
export PATH=$PATH:/opt/mongodb-osx-x86_64-2.2.2/bin