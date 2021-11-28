FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["editor-vowel-count.csproj", "editor-vowel-count/"]
RUN dotnet restore "editor-vowel-count/editor-vowel-count.csproj"
WORKDIR "/src/editor-vowel-count"
COPY . .
RUN dotnet build "editor-vowel-count.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "editor-vowel-count.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "editor_vowel_count.dll"]
