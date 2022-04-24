FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ZAD5/ZAD5.csproj", "ZAD5/"]
RUN dotnet restore "ZAD5/ZAD5.csproj"
COPY . .
WORKDIR "/src/ZAD5"
RUN dotnet build "ZAD5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZAD5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZAD5.dll"]
