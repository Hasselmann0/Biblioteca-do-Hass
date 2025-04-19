# 📚 Biblioteca do Hass 📚

Projeto de uma aplicação web para gerenciamento de uma biblioteca, desenvolvido com ASP.NET Core MVC.

## 📚 Sobre o Projeto

A **Biblioteca do Hass** é uma aplicação web que permite o gerenciamento de livros, autores e empréstimos de uma biblioteca. Utiliza o padrão MVC do ASP.NET Core para organizar o código e facilitar a manutenção e escalabilidade do sistema.

## 🚀 Tecnologias Utilizadas

- ASP.NET Core 8.0
- Entity Framework Core
- Razor Pages
- Bootstrap Sketchy Style (para estilização)
- Docker SQL Server Imagem
- DBeaver SGBD

## 📁 Estrutura do Projeto

- `Controllers/`: Contém os controladores que lidam com as requisições HTTP e interagem com os serviços e modelos.
- `Models/`: Define as classes que representam as entidades do domínio, como Livro, Autor, etc.
- `Views/`: Contém as páginas Razor que definem a interface do usuário.
- `Services/`: Inclui classes que implementam a lógica de negócios da aplicação.
- `Dto/`: Contém os Data Transfer Objects utilizados para transferir dados entre as camadas da aplicação.
- `Migrations/`: Armazena as migrações do Entity Framework para controle de versões do banco de dados.
- `wwwroot/`: Diretório para arquivos estáticos como CSS, JavaScript e imagens.

## ⚙️ Como Executar o Projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/Hasselmann0/Biblioteca-do-Hass.git
   ```

2. Navegue até o diretório do projeto:

   ```bash
   cd Biblioteca-do-Hass
   ```

3. Restaure as dependências do projeto:

   ```bash
   dotnet restore
   ```

4. Baixar e rodar o SQL Server no Docker

   Execute o seguinte comando para rodar o SQL Server em um container Docker (gerencie sua imagem com Docker Desktop ou via CLI):

   ```bash
   docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Segredo!1" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2019-latest

   ```

5. Atualize o banco de dados com as migrações:

   ```bash
   dotnet ef database update
   ```

6. Execute a aplicação:

   ```bash
   dotnet run
   ```

## 📝 Funcionalidades

- **Cadastro, edição e exclusão de livros e autores**: Permite gerenciar os dados de livros e autores, com operações completas de CRUD (Criar, Ler, Atualizar e Deletar).
- **Registro de empréstimos e devoluções de livros**: Acompanhe os empréstimos feitos pelos usuários e as devoluções realizadas.
- **Visualização de listas de livros disponíveis e emprestados**: Exibe listas organizadas com os livros disponíveis para empréstimo e os livros que estão atualmente emprestados.
- **Pesquisa por título, autor ou categoria**: Facilita a busca por livros através de filtros como título, autor e categoria.
- **Exporta dados em .xlsx (Excel)**: Exporta os dados inseridos em arquivos .xlsx (Excel)

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests. Caso queira contribuir, siga as etapas abaixo:

1. Faça um fork deste repositório.
2. Crie uma branch para a sua feature (`git checkout -b minha-feature`).
3. Faça suas alterações.
4. Commit suas alterações (`git commit -am 'Adiciona nova feature'`).
5. Envie para o seu fork (`git push origin minha-feature`).
6. Abra um Pull Request para a branch

## 📄 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
