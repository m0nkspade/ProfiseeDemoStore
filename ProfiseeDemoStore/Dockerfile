# Build Stage 
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./ProfiseeDemoStore/ProfiseeDemoStore.csproj" --disable-parallel
RUN dotnet publish "./ProfiseeDemoStore/ProfiseeDemoStore.csproj" -c release -o /app --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "ProfiseeDemoStore.dll"]