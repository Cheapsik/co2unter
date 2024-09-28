ARG IMAGE_TAG=latest

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS builder
WORKDIR /build/co2unter
COPY ./*.sln ./
COPY ./*/*.csproj ./

# Debugging: List .csproj files to verify they are copied correctly
RUN ls -la

RUN for file in $(ls *.csproj); do mkdir -p ${file%.*}/ && mv $file ${file%.*}/; done
RUN dotnet restore
COPY ./ ./
RUN dotnet publish -c Release -o /opt/co2unter co2unter.API/co2unter.API.csproj

WORKDIR /opt/co2unter

FROM mcr.microsoft.com/dotnet/aspnet:8.0

RUN apt-get -y update && apt-get -y install procps

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8

WORKDIR /opt/co2unter
COPY --from=builder /opt/co2unter .

ENV ASPNETCORE_URLS=http://+:80 \
    DOTNET_RUNNING_IN_CONTAINER=true \
    DOTNET_USE_POLLING_FILE_WATCHER=true \
    NUGET_XMLDOC_MODE=skip

EXPOSE 80
CMD ["dotnet", "co2unter.API.dll", "--environment=Docker"]
