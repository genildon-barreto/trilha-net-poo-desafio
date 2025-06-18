# 📱 DIO - Trilha .NET - Programação Orientada a Objetos: Modelagem de Smartphone

---

Este projeto é um desafio da **Trilha .NET da Digital Innovation One (DIO)**, focado em aplicar os conceitos de Programação Orientada a Objetos (POO) para modelar um sistema de celulares. O objetivo é criar uma abstração de `Smartphone` e implementar classes específicas para diferentes marcas, como Nokia e iPhone, demonstrando reuso de código e polimorfismo.

**Fork do projeto original, realizado de acordo com as instruções do professor Leonardo Buta.**
[https://github.com/digitalinnovationone/trilha-net-poo-desafio.git](https://github.com/digitalinnovationone/trilha-net-poo-desafio.git)
---

## 💻 Tecnologias Utilizadas

* **C#:** Linguagem de programação principal utilizada.
* **.NET:** Framework de desenvolvimento da Microsoft.

---

## ✨ Funcionalidades

O sistema modela a abstração de um smartphone e suas especificidades para diferentes fabricantes, contemplando as seguintes funcionalidades e conceitos de POO:

* **Classe Abstrata `Smartphone`:** Serve como um modelo base, definindo comportamentos comuns a todos os celulares (como ligar, receber ligação e número), mas não pode ser instanciada diretamente.
* **Classes `Nokia` e `iPhone`:** Herdam da classe `Smartphone`, implementando suas próprias lógicas específicas, principalmente para a instalação de aplicativos.
* **Polimorfismo:** O método `InstalarAplicativo` é sobrescrito nas classes `Nokia` e `iPhone`, demonstrando que diferentes objetos podem ter suas próprias implementações para um mesmo método.
* **Reuso de Código:** Através da herança, funcionalidades comuns são definidas na classe base `Smartphone` e reutilizadas pelas classes filhas.
* **Diagramas de Classe UML:** Interpretação e utilização de diagramas de classe para planejar e visualizar a estrutura das classes e seus relacionamentos.

---

## 🚀 Instruções de Execução

Este projeto é uma aplicação de console em .NET. Para executá-lo:

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/genildon-barreto/trilha-net-poo-desafio.git](https://github.com/genildon-barreto/trilha-net-poo-desafio.git)
    ```
2.  **Navegue até o diretório do projeto:**
    ```bash
    cd trilha-net-poo-desafio
    ```
3.  **Restaure as dependências do projeto:**
    ```bash
    dotnet restore
    ```
4.  **Execute o projeto:**
    ```bash
    dotnet run
    ```
    O programa será executado no console, e você poderá interagir com as instâncias de `Nokia` e `iPhone`.

---

## 🧠 Aprendizados do Projeto

Durante o desenvolvimento deste desafio, pude consolidar e aprofundar meus conhecimentos em:

* **Conceitos Fundamentais de POO:** Encapsulamento, Herança e Polimorfismo.
* **Classes Abstratas:** Entendimento e aplicação de classes abstratas para definir modelos e contratos.
* **Sobrescrita de Métodos (`override`):** Implementação de comportamentos específicos para métodos herdados.
* **Modelagem de Classes:** Habilidade de abstrair entidades do mundo real em classes e suas relações.
* **Estrutura de Projetos .NET:** Organização e execução de projetos de console em C#.

---

## 🎓 Digital Innovation One

[DIO](https://www.dio.me)

---

## 🤝 Contribuições

Este projeto foi fornecido como um desafio pela DIO, e foi completado seguindo as instruções do professor **Leonardo Buta**. Contribuições para aprimorar o código ou adicionar novas funcionalidades são sempre bem-vindas nesse projeto, no original da DIO ou em forks pessoais!