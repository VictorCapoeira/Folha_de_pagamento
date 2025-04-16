# 🧾 Folha de Pagamento 

Este projeto tem como objetivo o desenvolvimento de um sistema de folha de pagamento completo, utilizando **C# com Windows Forms**, totalmente adaptado às normas brasileiras. A aplicação permite o cálculo do salário líquido com base em informações como salário bruto, descontos (INSS, IRRF, VT), adicionais e geração de PDF do demonstrativo.

## ⚙️ Funcionalidades

- Cálculo de salário bruto, descontos obrigatórios e salário líquido.
- Cálculo progressivo de INSS e IRRF conforme tabelas vigentes.
- Desconto proporcional de vale-transporte.
- Geração de PDF com demonstrativo da folha.
- Interface visual intuitiva com dois formulários:
  - **Formulário de Cálculo**
  - **Formulário de Padronização (Parâmetros)**

## 🛠️ Tecnologias Utilizadas

- C#
- Windows Forms (WinForms)
- .NET Framework
- PDFSharp (ou iTextSharp)

## 🗂️ Etapas Concluídas

- [x] Levantamento de requisitos (regras de negócio, requisitos funcionais e não funcionais)
- [x] Definição das fórmulas de cálculo (INSS, IRRF, VT, FGTS)

## 📋 Backlog (em desenvolvimento)

- [ ] Criar interface do Formulário de Cálculo
- [ ] Criar interface do Formulário de Padronização
- [ ] Implementar lógica de cálculo com base nas fórmulas definidas
- [ ] Adicionar funcionalidade para exportação em PDF
- [ ] Implementar alertas e validações de dados
- [ ] Adicionar armazenamento local por meio de txt
- [ ] Criar instalador leve para distribuição

## 📄 Licença

Este projeto está licenciado sob a Licença MIT - consulte o arquivo [LICENSE](LICENSE) para mais detalhes.
