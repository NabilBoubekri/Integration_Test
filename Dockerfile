# Étape de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copie les fichiers de solution et restaure les dépendances
COPY Test_Unitaire_1/*.csproj Test_Unitaire_1/
COPY Test_Unitaire_1_TestClasse/*.csproj Test_Unitaire_1_TestClasse/
RUN dotnet restore Test_Unitaire_1/Test_Unitaire_1.csproj

# Copie tout le reste et build
COPY . .
RUN dotnet publish Test_Unitaire_1/Test_Unitaire_1.csproj -c Release -o /app/publish

# Étape finale - runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Test_Unitaire_1.dll"]
