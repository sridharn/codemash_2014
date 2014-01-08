#!/bin/sh
githome="/Users/sridhar/git/sridharn/codemash_2014"
datadir="$githome/firstapp/data"
if [ ! -d "$datadir" ]; then
    mkdir -p "$datadir"
fi
export PATH=$PATH:/opt/mongodb-osx-x86_64-2.4.3/bin