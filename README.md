# Gestor Financeiro Familiar myfinance

Uma aplicação web desenvolvida em ASP.NET Core MVC com SQL Server para o gerenciamento de receitas e despesas familiares. O projeto ajuda a organizar as finanças por meio da categorização de transações e relatórios detalhados.


## Objetivo

Fornecer às famílias uma ferramenta intuitiva para:

Registrar receitas e despesas;
Organizar as transações usando um Plano de Contas;
Gerar relatórios detalhados para análise financeira por períodos.


## Tecnologias Utilizadas

- Framework Backend: ASP.NET Core MVC
- Banco de Dados: SQL Server
- Frontend: HTML5 / CSS3 / JS


## Arquitetura Utulizada

- Model View Controller(MVC)


## Banco de dados

- Criação do Banco de Dados
- Criação das Tabelas: PlanoConta, Transacao
- Consultas de exemplo

Para criar o banco e as tabelas, execute os scripts em um servidor SQL Server local:

- 1º - Abra o SQL Server Management Studio (SSMS).
- 2º - Execute o arquivo de script SQL encontrado em BDSQLSERVER.
- 3º - Verifique a criação das tabelas no banco de dados.

## Como Executar o Projeto

Pré-requisitos:
- .NET SDK 6.0 
- SQL Server
- IDE: Visual Studio ou VS Code com extensão C#

1º passo
- Clone o repospitório do projeto
comando: git clone https://github.com/seu-usuario/gestor-financeiro.git

2º passo
- Crie o banco utilizando os scripts da pasta BDSQLSERVER.
- Configure a string de conexão no appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True"
  }
}

3º passo
- Restaure as dependências:
Comando: dotnet restore

4º passo
- Execute o comando: dotnet run

5º passo 
- http://localhost:8080
