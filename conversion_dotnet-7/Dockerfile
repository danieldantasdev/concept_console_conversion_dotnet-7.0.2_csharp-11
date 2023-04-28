FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["conversion_dotnet-7/conversion_dotnet-7.csproj", "conversion_dotnet-7/"]
RUN dotnet restore "conversion_dotnet-7/conversion_dotnet-7.csproj"
COPY . .
WORKDIR "/src/conversion_dotnet-7"
RUN dotnet build "conversion_dotnet-7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "conversion_dotnet-7.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "conversion_dotnet-7.dll"]
