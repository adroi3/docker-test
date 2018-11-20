FROM microsoft/dotnet AS builder
WORKDIR /source

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish --output /app/ --configuration Release

 FROM microsoft/dotnet:2.1-aspnetcore-runtime
 WORKDIR /app
 COPY --from=builder /app .

EXPOSE 80/tcp

ENTRYPOINT ["dotnet", "u.dll"]