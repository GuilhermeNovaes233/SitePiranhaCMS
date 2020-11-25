# Site com Blog de notícias

Projeto Asp net MVC utilizando o gerenciador de conteúdo Piranha CMS

## Rodar Projeto

Basta clonar o repositório e abrir no seu ambiente de desenvolvimento Asp net.

## Estrutura do Projeto

  Para acessar o portal administrativo basta digital '/manager' no final da url do localhost 
  
  Exemplo: 
  ```
    https://localhost:44335/manager/
  ```
  
  e digitar o login e senha
    ```
       login: admin
       <br>
       senha: password
    ```
  

## Piranha CMS

CMS representa Content Management System, ou Sistema de Gestão de Conteúdos. De forma bem direta, o piranha é um CMS permite que você crie, organize, publique e apague conteúdos do seu site. 

https://piranhacms.org/

## Curiosidade: Como criar um projeto utilizando Piranha CMS

O Piranha CMS é totalmente baseado em pacotes e está disponível no NuGet. A maneira mais fácil de começar é instalar o pacote de modelo do NuGet, que contém todos os modelos de projeto disponíveis .

Instale os modelos
  ```
    dotnet new -i Piranha.Templates
  ```
Depois de fazer isso, basta criar um novo projeto e começar.
  ```
   dotnet new piranha.mvc 
   dotnet restore 
   dotnet run
  ```


  
  
