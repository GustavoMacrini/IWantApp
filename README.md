<h1 align="center" style="font-weight: bold;">IWantApp 💻</h1>

<p align="center">
    <b>API Desenvolvida como projeto final do curso .NET 6 WEB API - Do zero ao avançado</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- ASP.NET CORE
- Entity Framework
- SQL Server

<h2 id="routes">📍 API Endpoints</h2>

| Rota               | Descrição                                          
|----------------------|-----------------------------------------------------
| <kbd>POST /token</kbd>     | Gera um token para acesso aos Endpoints [response details](#get-token-detail)
| <kbd>GET /employees</kbd>     | Retorna uma lista dos funcionários registrados [response details](#get-employee-detail)
| <kbd>POST /employees</kbd>     | Adiciona um novo funcionário [response details](#get-employee-detail)
| <kbd>GET /categories</kbd>     | Retorna uma lista das categorias registradas [response details](#get-categories-detail)
| <kbd>POST /categories</kbd>     | Adiciona uma nova categoria [response details](#get-categories-detail)
| <kbd>PUT /categories/{id}</kbd>     | Altera registro de categoria com base no Id [response details](#get-categories-detail)
| <kbd>DELETE /categories/{Id}</kbd>     | Deleta categoria com base no Id [response details](#get-categories-detail)
| <kbd>GET /products/{Id}</kbd>     | Retorna uma lista de produtos [response details](#get-products-detail)
| <kbd>GET /products/showcase</kbd>     | Retorna uma lista de produtos, permite requisição anônima [response details](#get-products-detail)
| <kbd>POST /products</kbd>     | Adiciona um novo registro de produto [response details](#get-products-detail)




# Autenticação 

Esta API utiliza JWT Token como forma de autenticação/autorização.

## Solicitando tokens de acesso

Para testar a API, é necessário um usuário pré cadastrado no banco de dados, sendo assim o administrador inicial.
Para gerar o token seguir Endpoint POST.



<h3 id="post-token-detail">POST /token</h3>

**REQUEST**
```json
{
  "email": "user@gmail.com",
  "password": "123"
}
```


<h3 id="get-categories-detail">GET /categories</h3>

**RESPONSE**
```json
{
  "id": "a960b778-aebc-49e8-ad6c-0f5d35a1154a",
  "name": "Tech",
  "active": true
}
```

<h3 id="get-employee-detail">GET /employees</h3>

**PARAMS**
|Parâmetro | Descrição
|----------------------|-----------------------------------------------------
| <kbd>page</kbd>     | Qual página de registros retornar
| <kbd>rows</kbd>     | Quantos registros retornar


<h3 id="get-employee-detail">POST /employees</h3>

**REQUEST**
```json
{
  "name": "João",
  "email": "joao@gmail.com",
  "senha": "123",
  "EmployeeCode": "022"
}
```

<h3 id="get-categories-detail">POST /categories</h3>

**REQUEST**
```json
{
  "name": "Tech"
}
```

<h3 id="get-categories-detail">PUT /categories</h3>

**REQUEST**
```json
{
  "name": "SmartPhone",
  "active": false
}
```

<h3 id="get-products-detail">GET /products/showcase</h3>

**PARAMS**
|Parâmetro | Descrição
|----------------------|-----------------------------------------------------
| <kbd>page</kbd>     | Qual página de registros retornar
| <kbd>rows</kbd>     | Quantos registros retornar


<h3 id="get-products-detail">POST /products</h3>

**REQUEST**
```json
{
  "name": "Iphone 15",
  "description": "Good mobile with a freat camera",
  "categoryId": "a960b778-aebc-49e8-ad6c-0f5d35a1154a",
  "HasStock": true,
  "Price": 5000
}
```


<h4 align="center"> Projeto em Desenvolvimento </h4>
