# Falastrões no Comando - Backend (C# + SQL Server)

Este é o projeto backend do "Falastrões no Comando", desenvolvido com ASP.NET Core MVC e Entity Framework Core, utilizando SQL Server como banco de dados.

 ## ⚖️ Requisitos

 - .NET 8 SDK
 - SQL Server (pode ser local ou em container)

 ## 📂 Clonando o Projeto
     git clone https://github.com/seu-usuario/falastroes-no-comando.git  

 ## ⚙️ Configurando Banco de Dados
 #### 1. Edite o arquivo appsettings.Development.json e configure a sua connection string:
    "ConnectionStrings": {
        "ConexaoFalastroes": "Server=localhost\\sqlexpress;
     Initial Catalog=DbPolitical_Proposal; Integrated Security=True;"
    }

 #### 2. ⚠️ Atenção:
 > - Server=localhost\\sqlexpress é o nome padrão da instância do SQL Server Express.
 > - Se você estiver usando outra instância do SQL Server, substitua por ela. Por exemplo:
 >      - localhost (instância padrão) 
 >   - localhost\\MSSQLSERVER (instância nomeada) 
 >   - 192.168.0.10 (servidor remoto)

 #### 3. A connection string acima cria a conexão com o DB chamado DbPolitical_Proposal.

 ## 📚 Criando o Banco de Dados

Com o projeto clonado e configurado, use o arquivo .bat para usuarios Windonws ou .sh para usuarios Linux, para aplicar as Migrations automaticamente e criar o banco de dados.
#### Como usar:
1. Localize o arquivo (.bat ou .sh) na raiz do projeto
2. Dê dois cliques no arquivo
3. Ele vai executar tudo automaticamente

## 🚀 Rodando o Projeto
     dotnet run

