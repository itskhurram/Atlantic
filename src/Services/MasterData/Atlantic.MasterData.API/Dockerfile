#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Services/MasterData/Atlantic.MasterData.API/Atlantic.MasterData.API.csproj", "src/Services/MasterData/Atlantic.MasterData.API/"]
COPY ["src/Services/MasterData/Atlantic.MasterData.Data/Atlantic.MasterData.Data.csproj", "src/Services/MasterData/Atlantic.MasterData.Data/"]
COPY ["src/Services/MasterData/Atlantic.MasterData.Domain/Atlantic.MasterData.Domain.csproj", "src/Services/MasterData/Atlantic.MasterData.Domain/"]
COPY ["src/Services/MasterData/Atlantic.MasterData.Application/Atlantic.MasterData.Application.csproj", "src/Services/MasterData/Atlantic.MasterData.Application/"]
COPY ["src/Services/MasterData/Atlantic.MasterData.Infrastructure/Atlantic.MasterData.Infrastructure.csproj", "src/Services/MasterData/Atlantic.MasterData.Infrastructure/"]
RUN dotnet restore "src/Services/MasterData/Atlantic.MasterData.API/Atlantic.MasterData.API.csproj"
COPY . .
WORKDIR "/src/src/Services/MasterData/Atlantic.MasterData.API"
RUN dotnet build "Atlantic.MasterData.API.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "Atlantic.MasterData.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#COPY --from=src/services/masterdata/atlantic.mastersata.api/data /app/publish/data .
ENTRYPOINT ["dotnet", "Atlantic.MasterData.API.dll"]
