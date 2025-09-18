# Calculadora em C# (Desafio DIO)

Este repositório contém o código-fonte de uma **Console Application** de uma calculadora, desenvolvida em C# como parte de um desafio de programação da [Digital Innovation One (DIO)](https://www.dio.me/).

O objetivo do projeto é criar uma calculadora funcional que realiza as quatro operações matemáticas básicas e, como diferencial, armazena um histórico das últimas operações para consulta.

## 🚀 Funcionalidades

O programa apresenta um menu interativo onde o usuário pode escolher entre as seguintes opções:

1.  **Somar**: Realiza a soma de dois números.
2.  **Subtrair**: Realiza a subtração de dois números.
3.  **Multiplicar**: Realiza a multiplicação de dois números.
4.  **Dividir**: Realiza a divisão de dois números.
5.  **Visualizar Histórico**: Exibe uma lista com as últimas operações realizadas.
6.  **Sair**: Encerra a aplicação.

## ✨ Destaque do Projeto

A funcionalidade de **histórico** foi implementada para demonstrar o uso de listas (`List<T>`) em C#. O sistema armazena um número limitado das operações mais recentes, que podem ser consultadas a qualquer momento pelo usuário.

## 🛠️ Tecnologias Utilizadas

-   **C#**: Linguagem de programação.
-   **.NET**: Plataforma de desenvolvimento.

## 📂 Estrutura do Código

-   **`Program.cs`**: Arquivo principal da aplicação. Responsável por exibir o menu, capturar a entrada do usuário e direcionar o fluxo do programa.
-   **`Calculadora.cs`**: Classe que contém toda a lógica de negócio. Nela estão os métodos para as quatro operações matemáticas (`Somar`, `Subtrair`, `Multiplicar`, `Dividir`) e a lógica para gerenciar o histórico de cálculos.

## 🏃 Como Executar

Para testar a calculadora em sua máquina local, siga os passos abaixo:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/jdecdomingues/Calculadora.git
    ```

2.  **Navegue até o diretório do projeto:**
    ```bash
    cd Calculadora
    ```

3.  **Execute a aplicação com o .NET CLI:**
    ```bash
    dotnet run
    ```

Após executar o comando, o menu da calculadora aparecerá em seu terminal, pronto para uso.
