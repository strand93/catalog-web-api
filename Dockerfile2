FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

#ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CatalogWebApi.csproj", "./"]
RUN dotnet restore "CatalogWebApi.csproj"
COPY . .
RUN dotnet publish "CatalogWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CatalogWebApi.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet CatalogWebApi.dll
