# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

EXPOSE 80
EXPOSE 7125

# Copy csproj and restore as distinct layers
COPY rest/*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY rest/ ./
RUN dotnet publish -c Release -o out  --no-restore

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /out .
ENTRYPOINT ["dotnet", "rest.dll"]

