# GestorDeTarefas

Aplicação Demonstração

Esta é uma aplicação feita em .NET 5, utilizando Entity Framework (EF) e banco de dados SQLite. A aplicação consiste em um CRUD para realizar o cadastro de tarefas a serem realizadas, juntamente com uma página de currículo.

## Funcionalidades

- Cadastro de tarefas: Permite aos usuários cadastrados criar, editar e excluir suas tarefas a serem realizadas.

- Página de currículo: Exibe informações sobre o desenvolvedor da aplicação, incluindo suas habilidades e experiência profissional.

## Autenticação e Acesso

A aplicação conta com um sistema de autenticação, e para fazer o login basta cadastrar um e-mail fictício e uma senha forte. Cada usuário logado só poderá ver as tarefas cadastradas por ele mesmo, garantindo a privacidade das informações.

## Tecnologias Utilizadas

- .NET 5: A plataforma utilizada para desenvolver a aplicação.

- Entity Framework (EF): Utilizado para a criação e gerenciamento do banco de dados SQLite.

- Banco de Dados SQLite: Um banco de dados leve e simples que é armazenado em um arquivo local, adequado para aplicações de menor porte.

## Como Executar o Projeto

Para executar a aplicação, siga os passos abaixo:

1. Clone o repositório para o seu ambiente local.

2. Certifique-se de que você possui o .NET 5 instalado em sua máquina.

3. Abra o projeto em sua IDE (Visual Studio, Visual Studio Code, etc.).

4. Execute o comando `dotnet restore` para restaurar as dependências do projeto.

5. Execute o comando `dotnet run` para iniciar a aplicação.

6. Acesse a aplicação no navegador através da URL `http://localhost:porta` (substitua "porta" pela porta em que a aplicação está sendo executada).

## Notas

- Esta aplicação é apenas uma demonstração e pode não conter todos os recursos e tratamentos de erro que uma aplicação real teria
(Mas o basico tem hehe).

- Os dados de autenticação e tarefas são armazenados localmente no banco de dados SQLite e podem ser reiniciados a qualquer momento.

- Sinta-se à vontade para explorar e utilizar o código-fonte como base para seus próprios projetos.
