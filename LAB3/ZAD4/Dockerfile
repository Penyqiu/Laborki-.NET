FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ZAD4/ZAD4.csproj", "ZAD4/"]
RUN dotnet restore "ZAD4/ZAD4.csproj"
COPY . .
WORKDIR "/src/ZAD4"
RUN dotnet build "ZAD4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZAD4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZAD4.dll"]
