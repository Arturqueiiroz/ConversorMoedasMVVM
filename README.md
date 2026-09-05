# Conversor de Moedas — MVVM

Aplicativo desktop de conversão de moedas desenvolvido em .NET MAUI utilizando a arquitetura MVVM (Model-View-ViewModel). Desenvolvido no contexto acadêmico para a prática de desenvolvimento de aplicações desktop e aplicação de padrões de arquitetura.

## Visão Geral

Este projeto foi desenvolvido como parte de atividades acadêmicas com o objetivo de aplicar conceitos da arquitetura MVVM em .NET MAUI.

O aplicativo permite a conversão entre diferentes moedas utilizando uma tabela de taxas de conversão predefinidas, com uma interface dinâmica e organizada para utilização em desktop.

## Funcionalidades

* **Conversão de moedas:** conversão entre diferentes moedas com base em taxas predefinidas;
* **Arquitetura MVVM:** separação entre Model, View e ViewModel, promovendo melhor organização e manutenção do código;
* **Interface desktop:** interface desenvolvida para utilização em computadores;
* **Data Binding:** utilização de vinculação de dados para sincronização entre a View e o ViewModel.

## Estrutura do Projeto

```text
ConversorMoedasMVVM/
├── ConversorMoedasMVVM/             # Projeto principal da aplicação
│   ├── Models/                      # Modelos de dados
│   │   └── RateTable.cs             # Tabela de taxas de conversão
│   ├── ViewModels/                  # ViewModels da aplicação
│   │   └── MainViewModel.cs         # ViewModel principal da conversão
│   ├── Views/                       # Views (telas) da aplicação
│   │   ├── MainPage.xaml            # Página principal de conversão
│   │   └── MainPage.xaml.cs         # Code-behind da página principal
│   ├── Resources/                   # Recursos (imagens, fontes e estilos)
│   ├── Platforms/                   # Configurações específicas da plataforma
│   ├── Properties/                  # Propriedades do projeto
│   ├── App.xaml                     # Configuração principal da aplicação
│   ├── AppShell.xaml                # Shell de navegação
│   ├── MauiProgram.cs               # Configuração e inicialização do .NET MAUI
│   └── ConversorMoedasMVVM.csproj   # Configuração do projeto
├── ConversorMoedasMVVM.sln          # Solução do Visual Studio
├── .gitignore                       # Arquivo de configuração do Git
└── README.md                        # Documentação do projeto
```

## Tecnologias Utilizadas

* **C#:** linguagem de programação utilizada no desenvolvimento;
* **.NET MAUI:** framework utilizado para o desenvolvimento da aplicação desktop;
* **MVVM:** padrão de arquitetura Model-View-ViewModel;
* **XAML:** linguagem de marcação utilizada na construção da interface;
* **Data Binding:** mecanismo utilizado para sincronização de dados entre a View e o ViewModel.

## Como Executar

### Pré-requisitos

* .NET 8.0 SDK ou superior instalado;
* Visual Studio 2022 com o workload do .NET MAUI;
* Windows para execução da aplicação desktop.

### Passos

1. Clone o repositório:

   ```bash
   git clone https://github.com/Arturqueiiroz/ConversorMoedasMVVM.git
   cd ConversorMoedasMVVM
   ```

2. Restaure as dependências:

   ```bash
   dotnet restore
   ```

3. Compile o projeto:

   ```bash
   dotnet build
   ```

4. Execute a aplicação pelo Visual Studio, selecionando o destino Windows.

### Executar no Visual Studio

1. Abra o arquivo `ConversorMoedasMVVM.sln` no Visual Studio;
2. Selecione o projeto de inicialização;
3. Selecione o destino **Windows Machine**;
4. Pressione `F5` para executar e depurar a aplicação.

## Contexto Acadêmico

Este projeto foi desenvolvido como parte de atividades acadêmicas, com foco na aplicação prática de conceitos relacionados ao desenvolvimento de aplicações desktop e à arquitetura de software.

Durante o desenvolvimento, foram trabalhados os seguintes conhecimentos:

* Prática de desenvolvimento de aplicações desktop com .NET MAUI;
* Implementação do padrão de arquitetura MVVM;
* Aplicação de conceitos de Data Binding e comandos;
* Separação de responsabilidades entre Model, View e ViewModel;
* Organização do código utilizando uma estrutura baseada em camadas.

## Autor

**Artur Queiroz**

GitHub: [@Arturqueiiroz](https://github.com/Arturqueiiroz)

## Licença

Este projeto foi desenvolvido para fins acadêmicos e está disponível para estudo e contribuições.

---

*Projeto desenvolvido no contexto acadêmico para aprendizado e prática de desenvolvimento desktop com .NET MAUI e arquitetura MVVM.*
