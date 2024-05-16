# API de Cadastro e Listagem de Produtos

Esta é uma API simples desenvolvida em ASP.NET 8, criada para demonstrar o uso do ADO.NET para operações básicas de cadastro e listagem de produtos. A API possui dois end-points principais: `list` e `new-product`.

## End-points

### 1. Listagem de Produtos

Este end-point retorna uma lista de produtos cadastrados no banco de dados.

- **Método:** GET
- **URL:** `/list`
- **Retorno:** Uma lista de produtos, cada um com os seguintes atributos:
  - `product_id`: O identificador único do produto.
  - `product_name`: O nome do produto.
  - `product_price`: O preço do produto.
  - `product_quantity`: A quantidade disponível do produto.

#### Exemplo de Uso:

```bash
GET /list
```

#### Resposta de Exemplo:

```json
[
    {
        "product_id": 1,
        "product_name": "Produto 1",
        "product_price": 10.99,
        "product_quantity": 20
    },
    {
        "product_id": 2,
        "product_name": "Produto 2",
        "product_price": 15.5,
        "product_quantity": 15
    }
]
```

### 2. Cadastro de Novo Produto

Este end-point permite cadastrar um novo produto no banco de dados.

- **Método:** POST
- **URL:** `/new-product`
- **Corpo da Requisição:** Deve conter os dados do novo produto a ser cadastrado com os seguintes atributos:
  - `product_name`: O nome do produto.
  - `product_price`: O preço do produto.
  - `product_quantity`: A quantidade disponível do produto.

#### Exemplo de Uso:

```bash
POST /new-product
```

#### Corpo da Requisição de Exemplo:

```json
{
    "product_name": "Novo Produto",
    "product_price": 25.99,
    "product_quantity": 10
}
```

#### Resposta de Exemplo:

```json
{
    "product_id": 3,
    "product_name": "Novo Produto",
    "product_price": 25.99,
    "product_quantity": 10
}
```

## Configuração da Conexão com o Banco de Dados

Para que a API funcione corretamente, é importante configurar a connection string no arquivo `appsettings.json` do seu projeto ASP.NET. A connection string deve apontar para o banco de dados onde os produtos serão armazenados. 

Exemplo de como adicionar a connection string no arquivo `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "ContextString": "Server=NomeDoServidor;Database=NomeDoBancoDeDados;User Id=Usuario;Password=Senha;"
  }
}
```

Substitua `"NomeDoServidor"`, `"NomeDoBancoDeDados"`, `"Usuario"` e `"Senha"` pelos valores correspondentes ao seu ambiente de banco de dados.

Certifique-se de que a chave da connection string (`DefaultConnection`, neste exemplo) corresponde à chave usada na inicialização do contexto do banco de dados na sua aplicação.

## Tecnologias Utilizadas

- ASP.NET 8
- ADO.NET


## Licença

Este projeto está licenciado sob a [Licença MIT](https://opensource.org/licenses/MIT).