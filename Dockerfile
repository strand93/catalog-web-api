FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CatalogWebApi.csproj", "CatalogWebApi/"]
RUN dotnet restore "CatalogWebApi/CatalogWebApi.csproj"
WORKDIR "/src/CatalogWebApi"
COPY . .
RUN dotnet build "CatalogWebApi.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "CatalogWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CatalogWebApi.dll"]

CMD ASPNETCORE_URLS=http://*:$PORT dotnet CatalogWebApi.dll