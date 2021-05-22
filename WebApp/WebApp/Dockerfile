#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApp/WebApp.csproj", "WebApp/"]
COPY ["Doctors.Domain/Doctors.Domain.csproj", "Doctors.Domain/"]
COPY ["Doctors.Infrastractures/Doctors.Infrastractures.csproj", "Doctors.Infrastractures/"]
RUN dotnet restore "WebApp/WebApp.csproj"
COPY . .
WORKDIR "/src/WebApp"
RUN dotnet build "WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
<<<<<<< HEAD
<<<<<<< HEAD
ENTRYPOINT ["dotnet", "WebApp.dll"]
=======
ENTRYPOINT ["dotnet", "WebApp.dll"]
>>>>>>> 420e772f1bf40fd54f838bd040a14dcc66c5d7d1
=======
ENTRYPOINT ["dotnet", "WebApp.dll"]
>>>>>>> parent of 420e772 (Wygenerowane dockerfile, kontenery pushniete na zdalne repozytoria)
