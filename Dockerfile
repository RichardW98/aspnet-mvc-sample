FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
ENV FOO=bar
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY aspnetmvcapp/*.csproj ./aspnetmvcapp/
COPY aspnetmvcapp/*.config ./aspnetmvcapp/
RUN nuget restore

# copy everything else and build app
COPY aspnetmvcapp/. ./aspnetmvcapp/
WORKDIR /app/aspnetmvcapp
RUN msbuild /p:Configuration=Release -r:False


FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
ENV FOO=bar
WORKDIR /inetpub/wwwroot
COPY --from=build /app/aspnetmvcapp/. ./
