FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ZAD1/ZAD1.fsproj", "ZAD1/"]
RUN dotnet restore "ZAD1/ZAD1.fsproj"
COPY . .
WORKDIR "/src/ZAD1"
RUN dotnet build "ZAD1.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZAD1.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZAD1.dll"]
