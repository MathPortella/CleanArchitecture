#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["Gcsb.Connect.CleanArch.WebAPI/Gcsb.Connect.CleanArch.WebAPI.csproj", "Gcsb.Connect.CleanArch.WebAPI/"]
COPY ["Gcsb.Connect.CleanArch.Infrastructure/Gcsb.Connect.CleanArch.Infrastructure.csproj", "Gcsb.Connect.CleanArch.Infrastructure/"]
COPY ["Gcsb.Connect.CleanArch.Application/Gcsb.Connect.CleanArch.Application.csproj", "Gcsb.Connect.CleanArch.Application/"]
COPY ["Gcsb.Connect.CleanArch.Domain/Gcsb.Connect.CleanArch.Domain.csproj", "Gcsb.Connect.CleanArch.Domain/"]
RUN dotnet restore "Gcsb.Connect.CleanArch.WebAPI/Gcsb.Connect.CleanArch.WebAPI.csproj"
COPY . .
WORKDIR "/src/Gcsb.Connect.CleanArch.WebAPI"
RUN dotnet build "Gcsb.Connect.CleanArch.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gcsb.Connect.CleanArch.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gcsb.Connect.CleanArch.WebAPI.dll"]