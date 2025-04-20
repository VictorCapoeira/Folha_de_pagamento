# 📋 Documento de Levantamento de Requisitos

## 🧾 Nome do Projeto

**Sistema de Folha de Pagamento BR - Windows Forms**

---

## 🧠 Visão Geral do Projeto

Sistema de folha de pagamento com base nas normas brasileiras vigentes, desenvolvido com C# e Windows Forms. O sistema permite calcular o salário líquido com base em informações fornecidas pelo usuário, aplicar as fórmulas corretas (INSS, IRRF, VT, FGTS, Hora extra, Faltas, Pensao, beneficios e descontos adicionaiis, vale-alimentação, Periculosidade e insalubridade), personalizar parâmetros usados no cálculo e exportar os resultados em PDF.

---

## ⚖️ Regras de Negócio

1. O cálculo do **INSS** deve seguir as alíquotas e faixas salariais progressivas definidas pelo governo federal.
2. O cálculo do **IRRF** deve considerar a base de cálculo (Salário Bruto - INSS) e deduções conforme tabela vigente.
3. O **Vale-Transporte (VT)** deve ser descontado em até 6% do salário base, ou menos, se o custo real for inferior.
4. O **FGTS** deve ser calculado com 8% sobre o salário bruto (a título informativo, não desconto).
5. As **Horas extras** deve ser um valor creditado ao trabalhador, conforme número de hora extra trabalhadas.
6. A **Periculosidade** deve ser um valor creditado ao trabalhador, conforme 30% sobre o sálario base.
7. A **Insalubridade** deve ser um valor reduzido ao trabalhador, conforme (10%,20%,30%) sobre o sálario minimo.
8. As **Faltas** deve ser um valor decreditadto ao trabalhador, conforme o número de hora de faltas.
10. A aplicação deve permitir que os valores de alíquota, faixas, e benefícios sejam **atualizáveis manualmente** no formulário de padronização.
11. A geração do **PDF** do holerite deve conter: nome do colaborador, valores de entrada, descontos detalhados, adicionais (como salário-família), e salário líquido.

---

## ✅ Requisitos Funcionais (RF)

| Código | Descrição |
|--------|-----------|
| RF01 | O sistema deve permitir o cadastro dos dados do colaborador para cálculo. |
| RF02 | O sistema deve permitir o preenchimento de salário base, horas extras, adicionais e descontos. |
| RF03 | O sistema deve calcular automaticamente o INSS com base em faixas progressivas. |
| RF04 | O sistema deve calcular o IRRF com base na base de cálculo (Salário Bruto - INSS). |
| RF05 | O sistema deve calcular e aplicar o desconto de vale-transporte (VT). |
| RF06 | O sistema deve aplicar o acréscimo de salário com base na periculosidade. |
| RF07 | O sistema deve aplicar o acréscimo de salário com base na insalubridade. |
| RF08 | O sistema deve aplicar o acréscimo de salário com base nas horas extras. |
| RF09 | O sistema deve apresentar o salário líquido resultante. |
| RF10 | O sistema deve permitir a personalização de alíquotas, faixas e benefícios no formulário de padronização. |
| RF11 | O sistema deve exportar a folha de pagamento em formato PDF. |
| RF12 | O sistema deve possuir dois formulários: um para cálculo e outro para padronização. |
| RF13 | O sistema deve calcular e aplicar o desconto de faltas. |
| RF14 | O sistema deve calcular e aplicar o desconto da pensão(sobre o provento liquido ou bruto). |

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
