FROM microsoft/aspnetcore
WORKDIR /app
COPY . .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet SampleWebApi.dll