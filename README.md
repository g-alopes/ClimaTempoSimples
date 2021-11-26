# :cloud: Clima Tempo Simples

Com o projeto Clima Tempo Simples pode-se verificar a lista das três cidades com menores e maiores temperaturas e a previsão do tempo semanal para a cidade escolhida.

### Requisitos:

.NetFramework 4.6.1; 
Visual Studio;
MS SQL Server e MS SQL Server Management Studio;

Para executar o projeto deixei separadas as queries de criação do banco de dados, criação de tabelas e inserção de dados no diretório "Banco de Dados" que se encontra no root desse projeto. É necessário o uso do MS SQL Server e do MS SQL Server Management Studio para executar os comandos contidos no diretório "Banco de Dados".

Você deverá executar as queries na seguinte ordem:

Create.Database
dbo.Estado
dbo.Cidade
dbo.PrevisaoClima
dbo.Estado.data
dbo.Cidade.data
dbo.PrevisaoClima.data

### Para executar:

1) Você deve fazer uma cópia do projeto através do comando git clone ou fazer o download do .zip do projeto.

2) Abra o arquivo ClimaTempoSimplesContext.cs que está na pasta Context, localizada na raiz do projeto, e altere o método OnConfiguring(), em optionsBuilder.UseSqlServer() adicionando o nome do seu servidor.

3) Execute o projeto.


