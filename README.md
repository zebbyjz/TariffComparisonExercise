# TariffComparisonExercise

# Steps to run
## Windows:
### Command Prompt:
1. cd Backend/TariffCalculator && dotnet run --project TariffCalculator.API/TariffCalculator.API.csproj

2. cd Frontend && npm install && npm run dev

### Powershell:
1. cd Frontend; npm install; npm run dev; cd ..\..\Backend\TariffCalculator
2. cd Backend/TariffCalculator; dotnet run --project TariffCalculator.API\TariffCalculator.API.csproj


## Linux:
1. cd Frontend && npm install && npm run dev
2. cd Backend/TariffCalculator && dotnet run --project TariffCalculator.API/TariffCalculator.API.csproj


# Features:
1. Backend in .NET 8
2. Used Clean architecture
3. Mocked External service provider
4. Used Abstract classes for Tariff for extensibility
5. Frontend in React using Vite
6. Used react-hook-form for forms
7. Used zod validation library in conjunction with react-hook-forms for input validation
8. Used TailwindCss library for design
9. Used Axios for data fetching

# Missing Features:
1. Robust network error handling in frontend.
2. Exhaustive exception handling in backend.
3. Dockerfile for easy setup for both frontend and backend
