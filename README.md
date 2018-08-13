# Construire et lancer l'application

## Builder l'image docker et la lancer
```console
docker build --pull -t aspnetapp .
docker run --rm --name aspnetcore_sample --rm -it -p 8000:80 aspnetapp
```

## Lancer l'application en mode développement sous Windows
docker run --rm -it -p 8000:80 -v C:\devtools\todo-aspnetcore\aspnetapp:/app/ -w /app/aspnetapp microsoft/dotnet:2.1-sdk dotnet watch run

## Lancer l'application en mode développement sous macOS
docker run --rm -it -p 8000:80 -v ~./aspnetapp:/app/ -w /app/aspnetapp microsoft/dotnet:2.1-sdk dotnet watch run