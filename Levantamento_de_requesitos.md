# 📋 Documento de Levantamento de Requisitos

## 🧾 Nome do Projeto

**Sistema de Folha de Pagamento BR - Windows Forms**

---

## 🧠 Visão Geral do Projeto

Sistema de folha de pagamento com base nas normas brasileiras vigentes, desenvolvido com C# e Windows Forms. O sistema permite calcular o salário líquido com base em informações fornecidas pelo usuário, aplicar as fórmulas corretas (INSS, IRRF, VT, FGTS, salário-família, vale-alimentação), personalizar parâmetros usados no cálculo e exportar os resultados em PDF.

---

## ⚖️ Regras de Negócio

1. O cálculo do **INSS** deve seguir as alíquotas e faixas salariais progressivas definidas pelo governo federal.
2. O cálculo do **IRRF** deve considerar a base de cálculo (Salário Bruto - INSS) e deduções conforme tabela vigente.
3. O **Vale-Transporte (VT)** deve ser descontado em até 6% do salário base, ou menos, se o custo real for inferior.
4. O **FGTS** deve ser calculado com 8% sobre o salário bruto (a título informativo, não desconto).
5. O **Salário-Família** deve ser um valor creditado ao trabalhador, conforme número de dependentes e faixa salarial.
6. O **Vale-Alimentação** pode ou não seguir as regras do **PAT** (Programa de Alimentação do Trabalhador):
   - Com PAT: não integra a base de cálculo de encargos.
   - Sem PAT: integra a base de cálculo para INSS e FGTS.
7. A aplicação deve permitir que os valores de alíquota, faixas, e benefícios sejam **atualizáveis manualmente** no formulário de padronização.
8. A geração do **PDF** do holerite deve conter: nome do colaborador, valores de entrada, descontos detalhados, adicionais (como salário-família), e salário líquido.

---

## ✅ Requisitos Funcionais (RF)

| Código | Descrição |
|--------|-----------|
| RF01 | O sistema deve permitir o cadastro dos dados do colaborador para cálculo. |
| RF02 | O sistema deve permitir o preenchimento de salário base, horas extras, adicionais e descontos. |
| RF03 | O sistema deve calcular automaticamente o INSS com base em faixas progressivas. |
| RF04 | O sistema deve calcular o IRRF com base na base de cálculo (Salário Bruto - INSS). |
| RF05 | O sistema deve calcular e aplicar o desconto de vale-transporte (VT). |
| RF06 | O sistema deve aplicar o acréscimo de salário-família com base em dependentes e faixa de salário. |
| RF07 | O sistema deve permitir o controle do vale-alimentação, identificando se integra ou não a base de encargos (com ou sem PAT). |
| RF08 | O sistema deve apresentar o salário líquido resultante. |
| RF09 | O sistema deve permitir a personalização de alíquotas, faixas e benefícios no formulário de padronização. |
| RF10 | O sistema deve exportar a folha de pagamento em formato PDF. |
| RF11 | O sistema deve possuir dois formulários: um para cálculo e outro para padronização. |

---

## 🚫 Requisitos Não Funcionais (RNF)

| Código | Descrição |
|--------|-----------|
| RNF01 | O sistema deve ter desempenho rápido e responsivo para cálculos simples. |
| RNF02 | O sistema deve ter interface intuitiva e clara, mesmo para usuários não técnicos. |
| RNF03 | O sistema deve gerar PDFs com layout limpo, legível e profissional. |
| RNF04 | A aplicação deve ser distribuível como executável único (.exe) ou via instalador leve. |
| RNF05 | O sistema deve permitir atualizações futuras das regras sem alterar o código-fonte. |
| RNF06 | O sistema deve funcionar em ambientes Windows 10 ou superior. |

---

## 🧮 Fórmulas Implementadas

- **Salário Bruto** = Salário Base + Horas Extras + Adicionais
- **INSS** = Cálculo progressivo baseado nas faixas e alíquotas de 2025
- **IRRF** = (Base de Cálculo × Alíquota) - Dedução
- **VT** = Salário Base × 6% (ou custo real, se inferior)
- **FGTS** = Salário Bruto × 8%
- **Salário-Família** = Valor fixo por dependente, conforme faixa salarial
- **Vale-Alimentação**:
  - **Com PAT**: Não incide sobre base de cálculo de encargos
  - **Sem PAT**: Integra salário bruto e incide sobre encargos
- **Salário Líquido** = Salário Bruto + Salário-Família + Benefícios - Descontos (INSS, IRRF, VT, etc.)

---

## 📌 Observações

- O valor do salário-família será parametrizável no formulário de padronização, assim como a faixa de renda para concessão.
- O sistema será modular: lógica de cálculo separada da interface.
- O cálculo do vale-alimentação dependerá de um campo de seleção (PAT: Sim/Não) definido pelo usuário.
- As atualizações nas faixas e alíquotas não devem depender de recompilação.

---

## 📅 Próximos Passos

1. Implementar estrutura de classes para cálculos (INSS, IRRF, FGTS, Salário-Família, VA, VT).
2. Criar o formulário visual de cálculo com campos e botões.
3. Criar o formulário de padronização com campos para modificar faixas/alíquotas/benefícios.
4. Implementar a exportação para PDF com PDFSharp (ou similar).
5. Testes de cálculo com cenários reais.
6. Embalamento da aplicação como `.exe` ou via instalador.

---

