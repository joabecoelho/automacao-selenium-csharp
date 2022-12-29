## Automação

- Arquitetura Projeto
  - Linguagem - [CSharp](https://docs.microsoft.com/pt-br/dotnet/csharp/ "CSharp")
  - Framework de desenvolvimento - [.Net Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
  - Execução dos testes - [SeleniumGrid](https://github.com/SeleniumHQ/selenium)
  - Orquestrador de testes - [NUnit 3.12.0](https://github.com/nunit/nunit)
  - Framework interação com elementos web - [Selenium.WebDriver 4.7.0](https://www.seleniumhq.org/download/ "Selenium.WebDriver")
  - Relatório de testes automatizados - [ExtentReports.Core 1.0.2](https://www.nuget.org/packages/ExtentReports.Core/)

## .Net Core e Visual Code

A IDE utilizada para o desenvolvimento foi o Visual Studio Code com a liguagem CSharp que estão em framework .Net Core, para isso recomenda-se a configuração da ferramenta e seus recursos conforme artigo explicativo: [clique aqui](https://medium.com/@saymowan/configurando-seu-vscode-para-desenvolver-projetos-de-testes-automatizados-netcore-nunit-476e73aa7b01).

## Arquitetura

**Premissas de uma boa arquitetura de automação de testes:**

- Facilitar o desenvolvimento dos testes automatizados (reuso).
- Facilitar a manutenção dos testes (refatoração).
- Tornar o fluxo do teste o mais legível possível (fácil entendimento do que está sendo testado).

**Arquitetura padrão Base2**

Para facilitar o entendimento da arquitetura do projeto de testes automatizados, foi criado um fluxograma baseado nas features principais que envolvam a arquitetura conforme imagem abaixo:

![alt text](https://i.imgur.com/AXY9ukW.png)

# Padrões de escrita de código

O padrão adotado para escrita é o “CamelCase” onde uma palavra é separada da outra através de letras maiúsculas. Este padrão é adotado para o nome de pastas, classes, métodos, variáveis e arquivos em geral exceto constantes. Constantes devem ser escritas com todas suas letras em maiúsculo separando as palavras com “\_”.

Ex: `PreencherUsuario(), nomeUsuario, LoginPage etc.`

**Padrões por tipo de componente**

- Pastas: começam sempre com letra maiúscula. Ex: `Pages, DataBaseSteps, Queries, Bases`
- Classes: começam sempre com letra maiúscula. Ex: `LoginPage, LoginTests`
- Arquivos: começam sempre com letra maiúscula. Ex: `DataDrivenFile.csv`
- Métodos: começam sempre com letra maiúscula. Ex: `VerificarElementoXPTO()`
- Variáveis: começam sempre com letra minúscula. Ex: `botaoXPTO`
- Objetos: começam sempre com letra minúscula. Ex: `loginPage`

**Padrão de siglas e palavras com uma letra**

No caso de siglas, manter o padrão da primeira letra, de acordo com o padrão do tipo que será nomeado, ex:

```
nomeField (variável)
PreencherNome() (método)
```

No caso de palavras com uma letra, as duas devem ser escritas juntas de acordo com o padrão do tipo que será nomeado, ex:`retornaSeValorEOEsperado()`

**Padrões de escrita: Classes e Arquivos**

Nomes de classes e arquivos devem terminar com o tipo de conteúdo que representam, em inglês, ex:

```
LoginPage (classe de PageObjects)
LoginTests (classe de testes)
LoginTestData.csv (planilha de dados)
```

OBS: Atenção ao plural e singular! Se a classe contém um conjunto do tipo que representa, esta deve ser escrita no plural, caso seja uma entidade, deve ser escrita no singular.

**Padrões de escrita: Geral**

Nunca utilizar acentos, caracteres especiais e “ç” para denominar pastas, classes, métodos, variáveis, objetos e arquivos.

**Padrões de escrita: Objetos**

Nomes dos objetos devem ser exatamente os mesmos nomes de suas classes, iniciando com letra minúscula, ex:

```
LoginPage (classe) loginPage (objeto)
LoginFlows (classe) loginFlows (objeto)
```

<br />

## O projeto ficou estruturado da seguinte forma:

- SeleniumAutomationMantis\Bases
  <br />PageBase (Contém as ações das pages: GetText, Click e Sendkeys)
  <br />TestBase (Contém as ações padrão para a execução dos testes) - O [SetUp], o qual executará ações antes de executar o método de teste. - O [TearDown], o qual executará ações após a execução do método de teste.

- SeleniumAutomationMantis\DataBaseSteps
  <br />Ações que serão executadas no banco de dados, para preparação da massa de dados.

- SeleniumAutomationMantis\Flows
  <br />Ações de fluxos que serão executadas diversas vezes.

- SeleniumAutomationMantis\Pages

  - CriarTarefaPage.cs
    <br />Mapeamento e as ações que serão executadas na página de criação de tarefas.

  - GerenciarCamposPersonalizadosPage.cs
    <br />Mapeamento e as ações que serão executadas na página de gerenciar campos personalizados.

  - GerenciarMarcadoresPage.cs
    <br />Mapeamento e as ações que serão executadas na página de gerenciar marcadores.

  - GerenciarPage.cs
    <br />Mapeamento e as ações que serão executadas na página de gerenciar.

  - GerenciarPerfisGlobaisPage.cs
    <br />Mapeamento e as ações que serão executadas na página de gerenciar perfis globais.

  - GerenciarProjetosPage.cs
    <br />Mapeamento e as ações que serão executadas na página de gerenciar projetos.

  - GerenciarUsuariosPage.cs
    <br />Mapeamento e as ações que serão executadas na página de gerenciar usuários.

  - LoginPage.cs
    <br />Mapeamento e as ações que serão executadas na página de login.

  - MainPage.cs
    <br />Mapeamento e as ações que serão executadas na página principal.

  - MinhaVisaoPage.cs
    <br />Mapeamento e as ações que serão executadas na página minha visão.

  - VerDetalhesDaTarefaPage.cs
    <br />Mapeamento e as ações que serão executadas na página de ver detalhes da tarefa.

  - VerTarefasPage.cs
    <br />Mapeamento e as ações que serão executadas na página de ver tarefas.

- SeleniumAutomationMantis\Queries

  - GerenciarQueries
    <br />Queries de SQL executadas nos testes de gerenciamento.

  - LimparDadosBanco
    <br />Queries de SQL executadas para limpeza/reset do banco de dados do Mantis.

  - TarefaQueries
    <br />Queries de SQL executadas nos testes de tarefas.

- SeleniumAutomationMantis\Tests

  - CriarTarefaDataDrivenTests.cs
    <br />Execução dos testes de criar tarefa utilizando o Data Driven.

  - CriarTarefaTests.cs
    <br />Execução dos testes de criar tarefas.

  - GerenciarCamposPersonalizadosTests.cs
    <br />Execução dos testes de campos personalizados.

  - GerenciarMarcadoresTests.cs
    <br />Execução dos testes de gerenciar marcadores.
  
  - GerenciarPerfisGlobaisTests.cs
    <br />Execução dos testes de gerenciar perfis globais.

  - GerenciarProjetosTests.cs
    <br />Execução dos testes de gerenciar projetos.

  - GerenciarUsuariosTests.cs
    <br />Execução dos testes de gerenciar usuários.

  - LoginTests.cs
    <br />Execução dos testes de login, que foram executados utilizando o JS (JavaScript).

  - VerTarefasTests.cs
    <br />Execução dos testes de ver tarefas.

- SeleniumAutomationMantis\appsettings.json
  <br />Gerenciar os parâmetros de execução dos testes.

  <br />"BROWSER": "chrome", (navegador para a execução dos testes)
  <br />"EXECUTION": "local", (definir execução local ou remota)
  <br />"DEFAULT_TIMEOUT_IN_SECONDS": "30" (tempo de espera limite para estourar uma exceção),
  <br />"HEADLESS": "false",
  <br />"SELENIUM_HUB": "http://localhost:4444",

  <br />"DB_URL": "localhost" (endereço de acesso local),
  <br />"DB_PORT": "3306", (porta usada pelo banco de dados)
  <br />"DB_NAME": "bugtracker", (nome do banco de dados do Mantis)
  <br />"DB_USER": "mantis", (usuário do banco de dados)
  <br />"DB_PASSWORD": "mantis", (senha do banco de dados)
  <br />"DB_CONNECTION_TIMEOUT": "50"(tempo de espera limite para conexão com o bando de dados),

  <br />"REPORT_NAME": "TestExecutionReport", (nome do relatório de execução dos testes)

  <br />"DEFAULT_APPLICATION_URL": "http://192.168.200.242:8989/login_page.php", (Url da aplicação a ser testada)
  <br />"GET_SCREENSHOT_FOR_EACH_STEP": "true"

- Foi utilizado para geração do relatorio da execução dos testes o ExtentReport.
  Os relatórios são armazenados no seguinte diretório:
  SeleniumAutomationMantis\bin\Debug\netcoreapp3.1\Reports
  <br />
 ## Evidências da execução local:
  #### Relatório de testes:
  ![image](https://user-images.githubusercontent.com/74142987/209825538-c6066a9c-6efa-410e-b9a2-6229ba3bc5b8.png)
  
  ![image](https://user-images.githubusercontent.com/74142987/209825582-b0892784-c3f9-4194-b6a7-140edb4e6747.png)

## Evidências da execução dos testes utilizando Selenium GRID
  #### Chrome:
  ![chrome](https://user-images.githubusercontent.com/74142987/209727073-45025649-4c35-4298-a755-d6e88cb411ee.gif)
  
  #### Edge:
  ![edge](https://user-images.githubusercontent.com/74142987/209727186-2e58f475-c108-4cde-a0bf-90f28bee3723.gif)

  #### Firefox:
  ![firefox](https://user-images.githubusercontent.com/74142987/209727258-b54ec5be-aeb3-40d1-957f-58184f5f31a7.gif)
  
  #### Video de todos os testes: [DRIVE - CLIQUE PARA ACESSAR](https://drive.google.com/drive/folders/1KFv8FeY-2eSX_g8eTRMoIsE8R3KnRHDa?usp=share_link)

## Evidências da execução dos testes na pipeline no AzureDevOps
  #### Testes em execução: 
  ![image](https://user-images.githubusercontent.com/74142987/209858325-967ecdb2-abd1-4f8b-afec-62a8abae778b.png)

  #### Execução dos testes finalizada:
  ![image](https://user-images.githubusercontent.com/74142987/209858761-bb333d85-c0e1-4d59-998f-3c64005842e6.png)
  
  #### Relatório de testes:
  ![image](https://user-images.githubusercontent.com/74142987/209858870-564c4838-f58e-495e-8204-9067da097c02.png)

