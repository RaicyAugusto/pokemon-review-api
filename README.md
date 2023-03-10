# Pokemon Review API
Esta é uma API desenvolvida em C# ASP.NET Core que fornece endpoints para criar, atualizar, obter e excluir avaliações de pokemons.<br>
Usando relacionamento many to many (muitos para muitos).

# Instalação
Para instalar e executar esta API, você precisará ter o .NET SDK instalado em sua máquina.

Em seguida, execute o seguinte comando no terminal para clonar o repositório:<br>

git clone https://github.com/seu-usuario/pokemon-review-api.git

Depois de clonar o repositório, abra o terminal na pasta do projeto e execute o seguinte comando para compilar e executar a aplicação:<br>

dotnet run

# A API  fornece os  endpoints atraves dos controllers :<br>
Category.<br>
Country.<br>
Owner.<br>
Pokemon.<br>
Review.<br>
Reviewer.<br>

# Endpoints para o controlador Category:

A API  fornece os seguintes endpoints atraves do controller pokemon:

GET /api/Category: retorna todas as categorias de Pokemon;<br>
GET /api/Category/{categoryId}: retorna a categoria de Pokemon com o ID especificado;<br>
GET /api/Category/pokemon/{categoryId}: retorna todos os Pokemons pertencentes a uma determinada categoria de Pokemon, com o ID especificado;<br>
POST /api/Category: cria uma nova categoria de Pokemon;<br>
PUT /api/Category/{categoryId}: atualiza os dados de uma categoria de Pokemon existente com o ID especificado;<br>
DELETE /api/Category/{categoryId}: exclui uma categoria de Pokemon existente com o ID especificado.<br>

# Endpoints para o controlador Country:


GET /api/Country: retorna todos os países existentes na aplicação;<br>
GET /api/Country/{countryId}: retorna o país com o ID especificado;<br>
GET /api/Country/owners/{ownerId}: retorna o país de um proprietário específico;<br>
POST /api/Country: cria um novo país na aplicação;<br>
PUT /api/Country/{countryId}: atualiza os dados de um país existente com o ID especificado;<br>
DELETE /api/Country/{countryId}: exclui um país existente com o ID especificado.<br>

# Endpoints para o controlador Owner:

GET /api/owner: Retorna uma lista de todos os proprietários no sistema.<br>
GET /api/owner/{ownerId}: Retorna o proprietário com o id especificado.<br>
GET /api/owner/pokemons/{pokeId}: Retorna o proprietário do Pokémon com o id especificado.<br>
GET /api/owner/{ownerId}/pokemon: Retorna uma lista de todos os Pokémons de um proprietário específico.<br>
POST /api/owner: Cria um novo proprietário no sistema com base nos dados fornecidos no corpo da solicitação. O ID do país é fornecido como um parâmetro de consulta na URL.<br>
PUT /api/owner/{ownerId}: Atualiza as informações do proprietário com o id especificado com base nos dados fornecidos no corpo da solicitação.<br>
DELETE /api/owner/{ownerId}: Exclui o proprietário com o id especificado do sistema.<br>

# Endpoints para o controlador Pokemon:

GET api/Pokemon: Retorna uma lista de todos os Pokémons registrados no sistema.<br>
GET api/Pokemon/{pokeId}: Retorna informações detalhadas sobre um Pokémon específico, identificado por um ID.<br>
GET api/Pokemon/{pokeId}/rating: Retorna a avaliação média de um Pokémon específico, identificado por um ID.<br>
POST api/Pokemon: Cria um novo Pokémon com as informações fornecidas no corpo da solicitação, associando-o a um proprietário e a uma categoria fornecidos nos parâmetros da solicitação.<br>
PUT api/Pokemon/{pokeId}: Atualiza as informações de um Pokémon específico, identificado por um ID. As novas informações são fornecidas no corpo da solicitação e o proprietário e a categoria são fornecidos como parâmetros da solicitação.<br>
DELETE api/Pokemon/{pokeId}: Exclui um Pokémon específico, identificado por um ID. Todos as avaliações associadas a esse Pokémon também são excluídas.<br>

# Endpoints para o controlador Review:

GET api/Review: Retorna uma lista de todos os comentários.<br>
GET api/Review/{reviewId}: Retorna um comentário específico com base no ID fornecido.<br>
GET api/Review/pokemon/{pokeId}: Retorna uma lista de comentários relacionados a um determinado Pokemon, com base no ID do Pokemon fornecido.<br>
POST api/Review: Cria um novo comentário com base nas informações fornecidas no corpo da solicitação.<br>
PUT api/Review/{reviewId}: Atualiza um comentário específico com base no ID fornecido e nas informações fornecidas no corpo da solicitação.<br>
DELETE api/Review/{reviewId}: Exclui um comentário específico com base no ID fornecido.<br>
DELETE api/DeleteReviewsByReviewer/{reviewerId}: Exclui todos os comentários de um revisor específico com base no ID do revisor fornecido.<br>

# Endpoints para o controlador Reviewer:

GET api/Reviewer: Obtém todos os revisores.<br>
GET api/Reviewer/{reviewerId}: Obtém um revisor específico com base no ID do revisor.<br>
GET api/Reviewer/{reviewerId}/reviews: Obtém todas as avaliações feitas por um revisor específico com base no ID do revisor.<br>
POST api/Reviewer: Cria um novo revisor.<br>
PUT api/Reviewer/{reviewerId}: Atualiza um revisor existente com base no ID do revisor.<br>
DELETE api/Reviewer/{reviewerId}: Exclui um revisor existente com base no ID do revisor.<br>


















