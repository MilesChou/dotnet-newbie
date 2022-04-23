FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Courses/Courses.csproj", "Courses/"]
RUN dotnet restore "Courses/Courses.csproj"
COPY . .
WORKDIR "/src/Courses"
RUN dotnet build "Courses.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Courses.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Courses.dll"]
