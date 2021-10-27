#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Hepsiburada.Api/Hepsiburada.Api.csproj", "Hepsiburada.Api/"]
COPY ["Hepsiburada.Infrastructure/Hepsiburada.Infrastructure.csproj", "Hepsiburada.Infrastructure/"]
COPY ["Hepsiburada.Domain/Hepsiburada.Domain.csproj", "Hepsiburada.Domain/"]
COPY ["Hepsiburada.Application/Hepsiburada.Application.csproj", "Hepsiburada.Application/"]
RUN dotnet restore "Hepsiburada.Api/Hepsiburada.Api.csproj"
COPY . .
WORKDIR "/src/Hepsiburada.Api"
RUN dotnet build "Hepsiburada.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hepsiburada.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hepsiburada.Api.dll"]