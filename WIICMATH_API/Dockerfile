#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WIICMATH_API/WIICMATH_API.csproj", "WIICMATH_API/"]
COPY ["WIICMATH_ServerLibrary/WIICMATH_ServerLibrary.csproj", "WIICMATH_ServerLibrary/"]
RUN dotnet restore "WIICMATH_API/WIICMATH_API.csproj"
COPY . .
WORKDIR "/src/WIICMATH_API"
RUN dotnet build "WIICMATH_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WIICMATH_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WIICMATH_API.dll"]