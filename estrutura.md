# arquitetura inicial
GlobalContent.Api
│
├── Controllers
├── DTOs
├── Entities
├── Interfaces
├── Repositories
├── Services
├── Data
├── Configurations
├── Middlewares
├── Validators
└── Security

 - inicialmente, não vai ser usado isso tudo, mas vou montar pensando no futuro

# PACOTES DE DADOS
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

# SWEGGER
dotnet add package Swashbuckle.AspNetCore

