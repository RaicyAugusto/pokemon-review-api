#Pokemon Review API
Esta é uma API desenvolvida em C# ASP.NET Core que fornece endpoints para criar, atualizar, obter e excluir avaliações de pokemons.

#Instalação
Para instalar e executar esta API, você precisará ter o .NET SDK instalado em sua máquina.

Em seguida, execute o seguinte comando no terminal para clonar o repositório:
git clone https://github.com/seu-usuario/pokemon-review-api.git

Depois de clonar o repositório, abra o terminal na pasta do projeto e execute o seguinte comando para compilar e executar a aplicação:
dotnet run

#Endpoints

A API fornece os seguintes endpoints:

GET /api/pokemons: Retorna a lista de todos os pokemons cadastrados.
GET /api/pokemons/{id}: Retorna um pokemon específico pelo seu identificador.
POST /api/reviews: Cria uma nova avaliação para um pokemon.
PUT /api/reviews/{id}: Atualiza uma avaliação existente de um pokemon.
DELETE /api/reviews/{id}: Exclui uma avaliação existente de um pokemon.
e mais.

