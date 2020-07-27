Instruções do teste prático
-------------------------------

### Database

O banco de dados escolhido foi o SQLite pela facilidade e leveza aderentes ao tipo de desenvolvimento prosposto.
Um aplicativo portável para o SQLite pode ser encontrado [aqui](https://portableapps.com/apps/development/sqlite_database_browser_portable).

Existem outros softwares disponíveis na internet.

A pasta Database no repositório contém o modelo de dados, o dicionário de dados, os scripts de criação do banco de dados e o próprio arquivo do banco dados vazio.
 

 
### Fontes
 
 A pasta fontes contém 3 projetos em C#:
* Configurador: projeto Windows Form com as interfaces gráficas.
* Procesamento: projeto Windows Console para a execução dos processamentos.
* Biblioteca: projeto Windows Library com as classes desenvolvidas.

Para a execução dos programas e necessário editar o arquivo xml  .config e indicar o caminho correto do arquivo SQLite na key="SQLitePath";


### Justificativas de desenvolvimento

Na raiz se encontra um arquivo texto com as justificativas para a escolha das opções de desenvolvimento.
