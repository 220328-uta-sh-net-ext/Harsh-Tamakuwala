#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
#http
EXPOSE 443
#https

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RestaurantApi/RestaurantApi.csproj", "RestaurantApi/"]
RUN dotnet restore "RestaurantApi/RestaurantApi.csproj"
COPY . .
WORKDIR "/src/RestaurantApi"
RUN dotnet build "RestaurantApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestaurantApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantApi.dll"]
