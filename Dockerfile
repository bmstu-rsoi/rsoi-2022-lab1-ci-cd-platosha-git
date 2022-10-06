FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["People/People/People.csproj", "People/People/"]
RUN dotnet restore "People/People/People.csproj"
COPY . .
WORKDIR "/src/People"
RUN dotnet build "People/People.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "People/People.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "People.dll"]