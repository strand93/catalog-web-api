## Docker

### Run locally 
```
docker build -t strand93/catalog:v1 .
winpty docker run -it --rm -p 8080:80 strand93/catalog:v1
// winpty docker run -it --rm -p 8080:80 -e MongoDbSettings:Password=admin strand93/catalog:v1
```

### Deploy
```
heroku login
heroku container:login

//Heroku app name
docker build -t catalog-api-test .
docker tag catalog-api-test registry.heroku.com/catalog-api-test/web

docker push registry.heroku.com/catalog-api-test/web

heroku container:release web --app catalog-api-test
``` 
### Extra
Build docker image
docker build -t strand93/catalog:v1 .
docker build -t catalog:v1 .

Retag
docker tag catalog:v1 strand93/catalog:v1 . 

docker tag catalog:v1 registry.heroku.com/catalog-api-test/web

Publish
docker push strand93/catalog:v1

Run docker image
winpty docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password=admin --network=net5tutorial catalog:v1

winpty docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password=admin strand93/catalog:v1
winpty docker run -it --rm -p 8080:80 -e MongoDbSettings:Password=admin strand93/catalog:v1

Run Database
docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=admin -e MONGO_INITDB_ROOT_PASSWORD=admin --network=net5tutorial mongo

## Heroku
docker build -t catalog:v1 .

docker tag catalog:v1 registry.heroku.com/catalog-api-test/web

heroku container:push web -a catalog-api-test

heroku container:release web -a catalog-api-test

## Postman

Run Tests
newman run DockerApiTest.json
newman run ApiTest.json

## Kubernetes

kubectl config current-context

kubectl create secret generic catalog-secrets --from-literal=mongodb-password='admin'

kubectl apply -f ./catalog.yaml
kubectl apply -f ./mongodb.yaml

kubectl get deployments
kubectl get pods

kubectl delete -f ./catalog.yaml
kubectl delete -f ./mongodb.yaml