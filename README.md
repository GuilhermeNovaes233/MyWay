# MyWay - Sistema de Cadastro e Pesquisa de eventos

## Configuração do Projeto

Para rodar o projeto é necessário ter instalado a ferramenta Angular CLI no seu computador.

Abra o cmd na pasta raiz e execute o seguinte comando 
```
npm i @angular/cli

```
## Estrutura do Projeto

O projeto esta divido em 3 camadas:

  1. Camada da API
      Contém as controllers e os objetos de transferência de dados(DTOs)
      Camada mais externa do Projeto, ela que recebe as chamadas do aplicativo angular
      "É como se fosse o cérebro da aplicação, redireciona para os lugares certos e retorna os valores"
      
  2. Camada de Dominío(Domain)
      Contém todas as entidades(Parece com uma Model) e regras de negócio do projeto --> Por conter as regras de negócio, deve ser a camada mais segura
      
  3. Camada de Repositório(Repository)
      Faz as consultas ao banco 
      
Antigamente o MVC era o padrão mais usado no desenovolvimento de software, porém surgiu a necessidade de separar o projeto em várias partes com responsabilidades exclusivas. 



## Banco de dados

  Atualmente salvei os dados em um SqlLite, mais simples e mais de boas de usar. 
  
## Gerar o Banco - caso faça alguma alteração nas models
  
  Você vai precisar criar uma nova migration, então exclua a pasta "Migrations" que fica dentro do projeto repository. Agora abra o terminal e entre no diretório MyWay.Repository. Assim: 
  
      ```
        cd MyWay.Repository
      ```
        
    e digite dotnet ef --startup-project ..\MyWay.API\ migrations add init 

    
    Uma nova pasta chamada Migrations deve ter sido criada no repository
    
    Agora digite
    
     ```
      dotnet ef --startup-project ..\MyWay.API\ update database 
    
     ```
     
## Rodar Projeto

Rodar API
  ```
    cd Intuitive.Api
    dotnet run
  ```
  
 Postman
    Você deve usar o Postman ou lago outro para fazer requisições a api 
    
    
    
