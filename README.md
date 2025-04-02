#Minimal RESTful API em ASP.NET Core

Este projeto é uma **Minimal API** desenvolvida com **ASP.NET Core**, que fornece um conjunto de endpoints para operações CRUD em um banco de dados usando **Entity Framework Core**.

## 📌 Funcionalidades
✅ CRUD de Entidades (Games, Genres)  
✅ Uso de DTOs para transferência de dados  
✅ Mapeamento de entidades para DTOs e vice-versa  
✅ Persistência de dados com **Entity Framework Core**  
✅ Arquitetura baseada em boas práticas  

##Arquitetura do Projeto
📦 GameStore.Api
 ┣ 📂 src
 ┃ ┣ 📂 Application
 ┃ ┃ ┣ 📂 DTOs                 # Objetos de transferência de dados
 ┃ ┃ ┗ 📂 Mappings             # Conversão entre Entidades e DTOs
 ┃ ┣ 📂 Domain
 ┃ ┃ ┗ 📂 Entities             # Entidades do domínio
 ┃ ┣ 📂 Infrastructure
 ┃ ┃ ┗ 📂 Data                 # Configuração do banco de dados e Migracoes 
 ┃ ┣ 📂 Presentation
 ┃ ┃ ┗ 📂 Endpoints            # Implementação dos endpoints da API
 ┃ ┣ 📂 Properties             # Arquivos de configuração
 ┗ 📂 tests
   ┗ 📂 SeuProjeto.Tests       # Testes unitários e de integração


## 🚀 Tecnologias Utilizadas

- **ASP.NET Core** - Framework para desenvolvimento da API 
- **Entity Framework Core** - ORM para acesso ao banco de dados  
- **SQLite** - Banco de dados  
- **Minimal APIs** - Estilo leve e performático para construção da API  
