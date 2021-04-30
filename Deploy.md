* Deploy

heroku login
heroku container:login

docker build -t test-api-alexdev .
docker tag test-api-alexdev registry.heroku.com/test-api-alexdev/web

docker push registry.heroku.com/test-api-alexdev/web

heroku container:release web --app test-api-alexdev