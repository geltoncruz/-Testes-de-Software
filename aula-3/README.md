# Qualidade de Software
## SQA Estatítico e norma ISO 9000

* SQA estatística - Garantida da estatística da qualidade.
* Mais métricas de qualidade
    * Confiabilidade
    * Segurança
* Normas ISO 9000
* Como empresas certificam-se ?

> "  Qualidade do processo implica na qualidade do produto "
![Qualidade no processo implica qualidade no produto](../img/007.png "Qualidade no processo implica qualidade no produto")

## Garantia estatística de qualidade

* A qualdade é responsabilidade de **todos** os participantes do desenvolvimento de software.

* Qualidade pode ser obtidade
    * Processo eficiente (Analise, Projeto, Codificação e teste)
    * RTF (Revisão técnica formal) nos trabalhos intermediários.
    * Modificações propostas
* SQA Estatítisca -> Apoio quatitativo
    * Base : Frequência de ocorrência de erros e inconsistencias, ao longo do período de tempo.
    * Objetivo: Aprimorar os elementos do processo que promovem erro:

### PASSO A PASSO PARA A SQA Estatística

1. Coletar informaões sobre os defeitos e catalogar categorias.
    1.1 Alguns defeitos - no processo
    1.2 Outros defeitos - após entrega
2. Rastrear o defeito até encontrar sua causa.
3. Considerar: 20% do código tem 80% dos defeitos.  **Centrar no que importa**.
4. Corrigir os problemas que originaram os defeitos.
![Paretto](../img/008.jpg "Paretto")

#### Possíveis causas dos defeitos

1. Especificações incompletas ou mal formuladas.
2. Má interpretação da comunicação com cliente.
3. Desvio intencional das especificações.
4. Violação dos padrões da programação.
5. Erro na representação de dados.
6. Inconconsistência na interface de componente.
7. Lògica do projeto inconsistente.
8. Teste incompleto ou errôneo.
9. Documentação imprecisa ou incompleta.
19. Erro na tradução do projeto para linguagem.
11. Interface Homem máquina ambígua ou inconsistente.
12. Diversos.

Erros | Total | Grave | Moderado | Simples
----- | ----- | ------|----------|--------
| | Qtd |

Addicionar tabelas.

#### O que a tabela diz?
* Os erros, 1, 2 e 5 - Poucas causas vitais que correspondem a 53% dos erros (Some a coluna Tota % desses 3 grupos de erros).
* Os erros 1,5,7 e 10 - Poucas causas vitais de erros graves ( Conluna qtd de Graves)
* Após detecção dos erros vitais -> Ação corretiva -> novos erros aparecerão.

#### Procedimento - SQA Estatística.

Repetir os passos até que errps sejam sanados.

1. Criar lista de possíveis categorias de Causas.
2. Quantificar, por um tempo determinado, a incidência de erros.
3. Focar nas poucas causas vitais.
    * 20% do projeto/código contem 80% dos erros
4. Corrigir as causas vitais -> Corrigir os erros.
5. Surgem novos erros (Testes são exaustivos)