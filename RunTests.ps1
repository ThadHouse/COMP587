dotnet test --collect:"XPlat Code Coverage"
dotnet reportgenerator -reports:**/coverage.cobertura.xml -targetdir:reports -reporttypes:lcov
dotnet reportgenerator -reports:**/coverage.cobertura.xml -targetdir:reportshtml -reporttypes:html
