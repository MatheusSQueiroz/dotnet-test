# API .NET Core para Gerenciamento de Produtos e Categorias

Esta é uma API .NET Core para gerenciamento de produtos e categorias, utilizando as seguintes tecnologias:

- **Entity Framework Core:** Um framework de mapeamento objeto-relacional (ORM) que permite interagir com o banco de dados de forma fácil e intuitiva.
  
- **FluentValidation:** Uma biblioteca para validação de objetos .NET. Utilizada para validar os dados de entrada na criação e edição de produtos e categorias.

- **Newtonsoft.Json:** Uma biblioteca para serialização e desserialização de objetos JSON.

- **Arquitetura MVC:** Utilizamos o padrão de arquitetura MVC (Model-View-Controller) para organizar o código, separando responsabilidades e tornando-o mais modular e fácil de manter.

- **Microsoft SQL Server:** Um sistema de gerenciamento de banco de dados relacional amplamente utilizado para armazenar dados de produtos e categorias.

## Configuração do Projeto

### Pré-requisitos

- .NET Core SDK (v3.1 ou superior) instalado no seu sistema. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

- SQL Server instalado e configurado na sua máquina ou servidor.

### Passos para Execução

1. **Clone o Repositório:**

   ```bash
   git clone https://github.com/MatheusSQueiroz/dotnet-test.git
   ```

   ```bash
   cd dotnet-test
   ```

2. **Configuração do Banco de Dados:**

   - Abra o arquivo `appsettings.json` e configure sua string de conexão no campo `"DefaultConnection"` para apontar para o seu banco de dados SQL Server.

3. **Aplicar Migrações:**

   ```bash
   dotnet ef database update
   ```

4. **Executar a Aplicação:**

   ```bash
   dotnet run
   ```

   A aplicação será iniciada e estará disponível em `https://localhost:5000`.

## Endpoints da API

### Produto
- **GET /produtos:** Retorna a lista de todos os produtos.
- **GET /produtos/{id}:** Retorna um produto específico pelo seu ID.
- **POST /produtos:** Cria um novo produto.
- **PUT /produtos/{id}:** Atualiza um produto existente pelo seu ID.
- **DELETE /produtos/{id}:** Exclui um produto pelo seu ID.

### Categoria

- **GET /api/categorias:** Retorna a lista de todas as categorias.
- **GET /api/categorias/{id}:** Retorna uma categoria específica pelo seu ID.
- **POST /api/categorias:** Cria uma nova categoria.
- **PUT /api/categorias/{id}:** Atualiza uma categoria existente pelo seu ID.
- **DELETE /api/categorias/{id}:** Exclui uma categoria pelo seu ID.


## Validando Dados de Entrada

A validação dos dados de entrada, incluindo produtos e categorias, é feita automaticamente pela API. Se os dados de entrada não atenderem aos critérios definidos, a API retornará uma resposta de erro adequada.

## Notas Adicionais

- **Validações Personalizadas:** Além das validações automáticas, também foram implementadas validações personalizadas para garantir a integridade dos dados no banco de dados.

- **Operações Assíncronas:** Todas as operações de banco de dados são realizadas de forma assíncrona para garantir a escalabilidade e a responsividade da aplicação.

- **Documentação:** A documentação da API, incluindo detalhes sobre endpoints, parâmetros de requisição e respostas, pode ser acessada em `https://localhost:5000/swagger` após iniciar a aplicação.