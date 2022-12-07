# start the app
dotnet build
dotnet run
#kill -> ctrl+c


# docker build the_container() from  build_context(.)
# docker build -t your_name/platform-service .
docker build -t maksstep/platform-service .

# docker run the the NEW instanse of a container (port mapping/forwarding)
# docker run -p 8080:80 -d maksstep/platform-service #in background
docker run -p 8080:80 maksstep/platform-service #in terminal

#docker push to web dockerhub
docker push maksstep/platform-service


# docker show running containers
docker ps

# docker stop running a container
# docker stop edebf0c7a4e6
docker stop the_id

# docker start the container
# docker start edebf0c7a4e6
docker start the_id

# docker remove the container
# docker rm edebf0c7a4e6
docker rm the_id
