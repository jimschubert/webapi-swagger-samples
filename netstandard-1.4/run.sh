#!/usr/bin/env bash
# docker build -t petstore-netstandard-1.4 .
sh ./stop.sh
echo "Starting a new container"
docker run -d -p 5000:5000 -v $(pwd):/app -t petstore-netstandard-1.4 > PID
echo "Browse to http://$(docker-machine ip $(docker-machine active)):5000"
echo "You can stop this container by executing stop.sh or manually using docker commands."
