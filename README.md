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
| <kbd>POST /token</kbd>     | Gera um token para acesso aos Endpoints [request details](#post-token-detail)
| <kbd>GET /employees</kbd>     | Retorna uma lista dos funcionários registrados [response details](#get-employee-detail)
| <kbd>POST /employees</kbd>     | Adiciona um novo funcionário [params details](#post-employee-detail)
| <kbd>GET /categories</kbd>     | Retorna uma lista das categorias registradas [response details](#get-categories-detail)
| <kbd>POST /categories</kbd>     | Adiciona uma nova categoria [request details](#post-categories-detail)
| <kbd>PUT /categories/{id}</kbd>     | Altera registro de categoria com base no Id [request details](#put-categories-detail)
| <kbd>GET /products</kbd>     | Retorna uma lista de produtos [response details](#get-products-detail)
| <kbd>GET /products/showcase</kbd>     | Retorna uma lista de produtos, permite requisição anônima [response details](#get-productsShowcase-detail)
| <kbd>GET /products/sold</kbd>     | Retorna um relatório de produtos mais vendidos [response details](#get-products-sold-detail)
| <kbd>POST /products</kbd>     | Adiciona um novo registro de produto [request details](#post-products-detail)
| <kbd>POST /orders</kbd>     | Adiciona um novo registro de pedido [request details](#post-order-detail)
| <kbd>GET /orders/{id}</kbd>     | Retorna uma lista [response details](#get-order-detail)




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

<h3 id="get-employee-detail">GET /employees</h3>

**PARAMS**
|Parâmetro | Descrição
|----------------------|-----------------------------------------------------
| <kbd>page</kbd>     | Qual página de registros retornar
| <kbd>rows</kbd>     | Quantos registros retornar


<h3 id="post-employee-detail">POST /employees</h3>

**REQUEST**
```json
{
  "Name": "João",
  "Email": "joao@gmail.com",
  "Password": "123",
  "EmployeeCode": "022"
}
```

<h3 id="get-categories-detail">GET /categories</h3>

**RESPONSE**
```json
{
  "Id": "a960b778-aebc-49e8-ad6c-0f5d35a1154a",
  "Name": "Tech",
  "Active": true
}
```

<h3 id="post-categories-detail">POST /categories</h3>

**REQUEST**
```json
{
  "Name": "Tech"
}
```

<h3 id="put-categories-detail">PUT /categories/{id}</h3>

**REQUEST**
```json
{
  "Name": "SmartPhone",
  "Active": false
}
```

<h3 id="get-products-detail">GET /products</h3>

**RESPONSE**
```json
[
  {
    "id": "93f2dec2-87c7-4725-bc99-0e9ba8bce166",
    "name": "Iphone 15",
    "categoryName": "Tech",
    "description": "Good mobile with a freat camera",
    "hasStock": true,
    "price": 2000.00,
    "active": true
  },
  {
    "id": "097b5f66-4fba-4d76-88b0-d057986f87ca",
    "name": "Mi 12 pro+",
    "categoryName": "Tech",
    "description": "Good mobile with a freat camera",
    "hasStock": true,
    "price": 4000.00,
    "active": true
  }
]
```

<h3 id="get-productsShowcase-detail">GET /products/showcase</h3>

**PARAMS**
|Parâmetro | Descrição
|----------------------|-----------------------------------------------------
| <kbd>page</kbd>     | Qual página de registros retornar
| <kbd>rows</kbd>     | Quantos registros retornar

**RESPONSE**
```json
[
  {
    "id": "93f2dec2-87c7-4725-bc99-0e9ba8bce166",
    "name": "Iphone 15",
    "categoryName": "Tech",
    "description": "Good mobile with a freat camera",
    "hasStock": true,
    "price": 2000.00,
    "active": true
  },
  {
    "id": "097b5f66-4fba-4d76-88b0-d057986f87ca",
    "name": "Mi 12 pro+",
    "categoryName": "Tech",
    "description": "Good mobile with a freat camera",
    "hasStock": true,
    "price": 4000.00,
    "active": true
  }
]
```

<h3 id="get-products-sold-detail">GET /products/sold</h3>

**PARAMS**
|Parâmetro | Descrição
|----------------------|-----------------------------------------------------
| <kbd>page</kbd>     | Qual página de registros retornar
| <kbd>rows</kbd>     | Quantos registros retornar

**RESPONSE**
```json
[
    {
        "id": "93f2dec2-87c7-4725-bc99-0e9ba8bce166",
        "name": "Iphone 15",
        "price": 2000.00,
        "amount": 10
    },
    {
        "id": "c3bef498-4404-473f-9f54-498af160c085",
        "name": "S19+",
        "price": 1000.00,
        "amount": 10
    },
    {
        "id": "097b5f66-4fba-4d76-88b0-d057986f87ca",
        "name": "Mi 12 pro+",
        "price": 4000.00,
        "amount": 4
    }
]
```

<h3 id="post-products-detail">POST /products</h3>

**REQUEST**
```json
{
  "Name": "Iphone 15",
  "Description": "Good mobile with a great camera",
  "CategoryId": "a960b778-aebc-49e8-ad6c-0f5d35a1154a",
  "HasStock": true,
  "Price": 5000
}
```

<h3 id="post-order-detail">POST /orders</h3>

**REQUEST**
```json
{
"ProductIds":
    ["93f2dec2-87c7-4725-bc99-0e9ba8bce166",
    "c3bef498-4404-473f-9f54-498af160c085",
    "097b5f66-4fba-4d76-88b0-d057986f87ca"],

"deliveryAddress": "Rua principal, 01"
}
```

<h3 id="get-order-detail">GET /orders/{id}</h3>

**RESPONSE**
```json
{
    "id": "80daccda-71c6-459a-ab6f-023002c2987a",
    "clientName": "Client",
    "products": [
        {
            "id": "93f2dec2-87c7-4725-bc99-0e9ba8bce166",
            "name": "Iphone 15"
        },
        {
            "id": "c3bef498-4404-473f-9f54-498af160c085",
            "name": "S19+"
        }
    ],
    "total": 3000.00,
    "deliveryAddress": "Rua principal"
}
```


<h4 align="center"> Projeto em Desenvolvimento </h4>
