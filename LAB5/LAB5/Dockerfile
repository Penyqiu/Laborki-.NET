FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LAB5/LAB5.csproj", "LAB5/"]
RUN dotnet restore "LAB5/LAB5.csproj"
COPY . .
WORKDIR "/src/LAB5"
RUN dotnet build "LAB5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LAB5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LAB5.dll"]
