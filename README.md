# Conversor de Moedas - MVVM

Aplicativo de conversao de moedas desenvolvido em .NET MAUI com arquitetura MVVM (Model-View-ViewModel). Desenvolvido no contexto academico para pratica de desenvolvimento mobile multiplataforma e aplicacao de padroes de arquitetura.

## Visao Geral

Este projeto foi desenvolvido como parte de atividades academicas com o objetivo de aplicar conceitos de arquitetura MVVM em .NET MAUI. O aplicativo permite a conversao entre diferentes moedas utilizando uma tabela de taxas de conversao, com interface dinamica e responsiva para dispositivos moveis.

## Funcionalidades

- **Conversao de moedas**: conversao entre diferentes moedas com base em taxas pre-definidas;
- **Arquitetura MVVM**: separacao clara entre Model, View e ViewModel para melhor organizacao e manutenibilidade;
- **Interface responsiva**: layout adaptado para dispositivos moveis utilizando .NET MAUI;
- **Binding de dados**: utilizacao de data binding para sincronizacao entre view e viewmodel.

## Estrutura do Projeto

```
ConversorMoedasMVVM/
├── ConversorMoedasMVVM/          # Projeto principal do aplicativo
│   ├── Models/                   # Modelos de dados
│   │   └── RateTable.cs          # Tabela de taxas de conversao
│   ├── ViewModels/               # ViewModels da aplicacao
│   │   └── MainViewModel.cs      # ViewModel principal da tela de conversao
│   ├── Views/                    # Views (telas) da aplicacao
│   │   ├── MainPage.xaml         # Pagina principal de conversao
│   │   └── MainPage.xaml.cs      # Code-behind da pagina principal
│   ├── Resources/                # Recursos (imagens, fontes, estilos)
│   ├── Platforms/                # Configuracoes especificas por plataforma
│   ├── Properties/               # Propriedades do projeto
│   ├── App.xaml                  # Aplicativo principal
│   ├── AppShell.xaml             # Shell de navegacao
│   ├── MauiProgram.cs            # Ponto de entrada do .NET MAUI
│   └── ConversorMoedasMVVM.csproj  # Configuracao do projeto
├── ConversorMoedasMVVM.sln       # Solucao do Visual Studio
├── .gitignore                    # Arquivo de ignoracao do Git
└── README.md                     # Documentacao do projeto
```

## Tecnologias Utilizadas

- **C#**: linguagem de programacao;
- **.NET MAUI**: framework para aplicacoes multiplataforma (iOS, Android, Windows, macOS);
- **MVVM**: padrao de arquitetura Model-View-ViewModel;
- **XAML**: linguagem de marcacao para interfaces;
- **Data Binding**: sincronizacao automatica entre view e viewmodel.

## Como Executar

### Pre-requisitos

- .NET 8.0 SDK ou superior instalado;
- Visual Studio 2022 com workload do .NET MAUI;
- Emulador Android, iOS ou dispositivo fisico para testes.

### Passos

1. Clone o repositorio:
   ```bash
   git clone https://github.com/Arturqueiiroz/ConversorMoedasMVVM.git
   cd ConversorMoedasMVVM
   ```

2. Restaure as dependencias:
   ```bash
   dotnet restore
   ```

3. Compile o projeto:
   ```bash
   dotnet build
   ```

4. Execute o aplicativo:
   ```bash
   dotnet run
   ```

### Executar no Visual Studio

1. Abra o arquivo `ConversorMoedasMVVM.sln` no Visual Studio;
2. Selecione o projeto de inicializacao e a plataforma de destino (Android, iOS, Windows);
3. Pressione F5 para executar e depurar o aplicativo.

## Contexto Academico

Este projeto foi desenvolvido como parte de atividades academicas, com foco em:

- Pratica de desenvolvimento mobile multiplataforma com .NET MAUI;
- Implementacao do padrao de arquitetura MVVM;
- Aplicacao de conceitos de data binding e comandos;
- Organizacao de codigo em camadas (Model, View, ViewModel).

## Autor

**Artur Queiroz**  
GitHub: [@Arturqueiiroz](https://github.com/Arturqueiiroz)

## Licenca

Este projeto foi desenvolvido para fins academicos e esta disponivel para estudo e contribuicoes.

---

*Projeto desenvolvido no contexto academico para aprendizado e pratica de desenvolvimento mobile com .NET MAUI e arquitetura MVVM.*
