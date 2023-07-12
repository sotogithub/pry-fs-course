#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["backend/Domain/School/SotoGomezTelesforo.Alumno.Service/SotoGomezTelesforo.Alumno.Service.csproj", "backend/Domain/School/SotoGomezTelesforo.Alumno.Service/"]
RUN dotnet restore "backend/Domain/School/SotoGomezTelesforo.Alumno.Service/SotoGomezTelesforo.Alumno.Service.csproj"
COPY . .
WORKDIR "/src/backend/Domain/School/SotoGomezTelesforo.Alumno.Service"
RUN dotnet build "SotoGomezTelesforo.Alumno.Service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SotoGomezTelesforo.Alumno.Service.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SotoGomezTelesforo.Alumno.Service.dll"]