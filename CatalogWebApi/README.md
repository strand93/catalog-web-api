**Docker

Build docker image
docker build -t catalog:v1 .

Retag
docker tag catalog:v1 strand93/catalog:v1

Publish
docker push strand93/catalog:v1

Run docker image
winpty docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password=admin --network=net5tutorial catalog:v1

winpty docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password=admin strand93/catalog:v1

Run Database
docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=admin -e MONGO_INITDB_ROOT_PASSWORD=admin --network=net5tutorial mongo

**Postman

Run Tests
newman run DockerApiTest.json
newman run ApiTest.json

** Kubernetes

kubectl config current-context

kubectl create secret generic catalog-secrets --from-literal=mongodb-password='admin'

kubectl apply -f ./catalog.yaml
kubectl apply -f ./mongodb.yaml

kubectl get deployments
kubectl get pods

kubectl delete -f ./catalog.yaml
kubectl delete -f ./mongodb.yaml