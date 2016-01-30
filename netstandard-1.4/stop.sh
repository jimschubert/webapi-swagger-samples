#!/usr/bin/env bash
if [ -f ./PID ]; then 
    echo "Stopping existing container $(cat ./PID)"
    docker stop $(cat PID)
    rm PID
fi
