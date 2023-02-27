FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NextflowRunner.Client/NextflowRunner.Client.csproj", "NextflowRunner.Client/"]
RUN dotnet restore "NextflowRunner.Client/NextflowRunner.Client.csproj"
COPY . .
WORKDIR "/src/NextflowRunner.Client"
RUN dotnet build "NextflowRunner.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NextflowRunner.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NextflowRunner.Client.dll"]
