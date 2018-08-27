FROM microsoft/aspnetcore:2.0-jessie AS base
WORKDIR /app
EXPOSE 80
#
#
FROM microsoft/aspnetcore-build:2.0-jessie AS builder
WORKDIR /src
COPY . .
WORKDIR /src/Alfred.WebApi
RUN dotnet build -c Release -o /app
#
#
FROM builder AS publish
RUN dotnet publish -c Release -o /app
#
#
FROM base AS production
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Alfred.WebApi.dll"]


# docker build -t alfred03 .
# docker run -p 8080:80 alfred03
# docker images
# docker tag alfred03 ivanpaulovich/alfred
# docker push ivanpaulovich/alfred