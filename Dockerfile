FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# copy all the layers' csproj files into respective folders
COPY ["./UserDomain.Contracts/UserDomain.Contracts.csproj", "src/UserDomain.Contracts/"]
COPY ["./UserDomain.Migrations/UserDomain.Migrations.csproj", "src/UserDomain.Migrations/"]
COPY ["./UserDomain.Infrastructure/UserDomain.Infrastructure.csproj", "src/UserDomain.Infrastructure/"]
COPY ["./UserDomain.Core/UserDomain.Core.csproj", "src/UserDomain.Core/"]
COPY ["./UserDomain.API/UserDomain.API.csproj", "src/UserDomain.API/"]

# run restore over API project - this pulls restore over the dependent projects as well
RUN dotnet restore "src/UserDomain.API/UserDomain.API.csproj"

COPY . .

# run build over the API project
WORKDIR "/src/UserDomain.API/"
RUN dotnet build -c Release -o /app/build

# run publish over the API project
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS runtime
WORKDIR /app

COPY --from=publish /app/publish .
RUN ls -l
ENTRYPOINT [ "dotnet", "UserDomain.API.dll" ]