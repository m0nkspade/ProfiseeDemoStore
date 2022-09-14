# Build Stage 
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restopre "./ProfiseeDemoStore/ProfiseeDemoStore.csproj" --disable-parallel
RUN dotnet publish "./ProfiseeDemoStore/ProfiseeDemoStore.csproj" -c release -o /app --no-restore
# Serve Stage
