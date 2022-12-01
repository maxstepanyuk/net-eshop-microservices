# FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-dev
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-dev
WORKDIR /app

COPY *.csproj ./   
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/sdk:5.0
FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY --from=build-dev /app/out .
ENTRYPOINT [ "dotnet", "PlatformService.dll" ]
