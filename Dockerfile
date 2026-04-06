# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build
WORKDIR /app

# Copy project files only
COPY PortfolioApi/*.csproj ./PortfolioApi/

# Restore dependencies directly from the project
RUN dotnet restore ./PortfolioApi/PortfolioApi.csproj

# Copy all source files
COPY PortfolioApi/. ./PortfolioApi/

# Build and publish
WORKDIR /app/PortfolioApi
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "PortfolioApi.dll"]