#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RelTransCustomer.WebApi/RelTransCustomer.WebApi.csproj", "RelTransCustomer.WebApi/"]
COPY ["RelTransCustomer.Application/RelTransCustomer.Application.csproj", "RelTransCustomer.Application/"]
COPY ["RelTransCustomer.Domain/RelTransCustomer.Domain.csproj", "RelTransCustomer.Domain/"]
COPY ["RelTransCustomer.Identity/RelTransCustomer.Identity.csproj", "RelTransCustomer.Identity/"]
COPY ["RelTransCustomer.Persistence/RelTransCustomer.Persistence.csproj", "RelTransCustomer.Persistence/"]
COPY ["RelTransCustomer.Shared/RelTransCustomer.Shared.csproj", "RelTransCustomer.Shared/"]
RUN dotnet restore "./RelTransCustomer.WebApi/./RelTransCustomer.WebApi.csproj"
COPY . .
WORKDIR "/src/RelTransCustomer.WebApi"
RUN dotnet build "./RelTransCustomer.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./RelTransCustomer.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RelTransCustomer.WebApi.dll"]