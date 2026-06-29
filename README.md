# Gentelella ASP.NET Core Template

Template ASP.NET Core MVC com o Gentelella atualizado para a versao oficial v4.0.2.

## Versoes

- ASP.NET Core: conforme `TargetFramework` em `Gentelella2.csproj`
- Gentelella: v4.0.2
- Frontend Gentelella v4: vanilla JavaScript, SCSS e Vite
- O Gentelella v4 nao usa Bootstrap nem jQuery

## Como rodar

```powershell
dotnet run
```

Abra a URL exibida pelo .NET. A rota inicial redireciona para:

```text
/gentelella/production/index.html
```

## Estrutura

- `Controllers/`: mantem as rotas MVC antigas apontando para paginas equivalentes do Gentelella v4.
- `Views/`: views Razor antigas preservadas como referencia do template anterior.
- `wwwroot/gentelella/`: build estatico oficial do Gentelella v4.0.2.
- `wwwroot/gentelella/production/`: paginas HTML prontas do template.
- `wwwroot/gentelella/assets`, `wwwroot/gentelella/js`, `wwwroot/gentelella/images`: assets gerados pelo build.

## Observacoes

Este repositorio continua sendo um template base. Ele nao implementa autenticacao, banco de dados, sessoes ou regras de negocio. As telas de login e formularios sao exemplos visuais do Gentelella.

## Como atualizar o Gentelella novamente

1. Baixe a tag oficial desejada do repositorio `ColorlibHQ/gentelella`.
2. Rode o build com base path `/gentelella/`.
3. Substitua o conteudo de `wwwroot/gentelella` pelo novo `dist`.
4. Ajuste os redirects dos controllers se alguma pagina mudar de nome.
