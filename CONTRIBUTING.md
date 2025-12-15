# Contribuindo

Obrigado por considerar contribuir com o **Direction.NFSe.Danfe**.

## Fluxo sugerido

1. Abra uma Issue (bug/feature) descrevendo o problema e como reproduzir.
2. Faça um fork do repositório.
3. Crie uma branch:
   - `feature/<breve-descricao>`
   - `fix/<breve-descricao>`
4. Envie um Pull Request (PR) para `main`.

## Padrões

- **C#**: seguir `.editorconfig` e manter `dotnet format` limpo.
- **Template HTML**: manter `npm run format` limpo (Prettier).
- Evite mudanças “grandes” sem discussão prévia (Issue).

## Testes

Ao corrigir bugs, inclua um teste quando possível.  
Os testes ficam em `tests/Danfe.Tests`.

## Checklist para PR

- [ ] Build e testes passam (`dotnet build`, `dotnet test`)
- [ ] `dotnet format` não gera alterações
- [ ] `npm run format:check` passa
- [ ] README atualizado (se necessário)
