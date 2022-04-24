FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ZAD3/ZAD3.csproj", "ZAD3/"]
RUN dotnet restore "ZAD3/ZAD3.csproj"
COPY . .
WORKDIR "/src/ZAD3"
RUN dotnet build "ZAD3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZAD3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZAD3.dll"]
