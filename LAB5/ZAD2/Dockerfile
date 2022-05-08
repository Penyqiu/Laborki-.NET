FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ZAD2/ZAD2.fsproj", "ZAD2/"]
RUN dotnet restore "ZAD2/ZAD2.fsproj"
COPY . .
WORKDIR "/src/ZAD2"
RUN dotnet build "ZAD2.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZAD2.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZAD2.dll"]
