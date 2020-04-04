FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build
WORKDIR /app

# copy csproj and restore
COPY src/MyWeb/*.csproj src/MyWeb/MyWeb.csproj
RUN  dotnet restore src/MyWeb

# copy all files and build
COPY src/MyWeb src/MyWeb
RUN dotnet publish src/MyWeb -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine as runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT [ "dotnet", "MyWeb.dll" ]