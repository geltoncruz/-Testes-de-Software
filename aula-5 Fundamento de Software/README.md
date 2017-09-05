# Fundamentos em testes de software

Constantemente testamos coisas na vida
![Sempre testamos coisas](../img/024.jpg "Sempre testamos coisas")


## O que é teste de software?
> " Verificação feita sobre um sistema ou parte dele para garantir que uma determinada entrada produza, **sempre**, uma saída esperada.

> **IUPIIIIIIII**
![Reação como planejado](../img/023.jpg "Reação como planejado")
![IUUPII](../img/020.jpg "IUPIIIII")

### Exemplos do que se esperar
##### Ex1: Tranferencia bancária

![Tranferencia Bancaria](../img/021.jpg "Tranferencia Bancaroa")
##### Ex2: Post no facebook
![Post Facebook](../img/022.jpg "Post Facebook")

##### Ex3: Envio de e-mail
![Teste Software](../img/026.gif "Teste Software")

> Conceito de teste é o mesmo de quando testamos outras coisas, porém em nosso caso específico é software.
![Teste Software](../img/025.jpg "Teste Software")

### Verdades sobre testes
1. Testes não verificam completamente as saída de um sistema, pois as entradas são infinitas
![Teste não verificam todas as entradas](../img/027.jpg)
2. Testes não garantem qualidade.
3. Teste custam em média 20% a 30% dos custos de elaboração de um software.

### Problemas por falta de testes
#### Caso Tríade UNEB
![Triade Uneb](../img/028.jpg)
![Triade Uneb](../img/029.jpg)

#### Caso ARIANE 5
![Ariane 5](../img/030.jpg)

* Projeto Agência Européia Especial
    *  10 Anos de trabalho.
    * Investimento de US$ 8 bilhões
* Vôo programado para 1996
* Carga de US$ 500 milhôes 
* Explodiu 40''


#### Caso Quase 3 Guerra
![Aviso de Míssel americado](../img/031.jpg)

##  A situação das empresas

* Prazos apertados para entrega de sistemas
* Clientes menos tolerantes a atrasos nas
entregas
* Precisam lançar software de boa qualidade
* Clientes menos tolerantes a falhas

# Fundamentos de teste de software
* Níveis de Testes (Quando testar ?)
* Técnicas de Testes (Como Testar ?)
* Tipos de Testes (O que testar ?)
![Fundamentos de teste de software](../img/032.jpg "Fundamentos de teste de software")

## Níveis de teste

![Níveis de teste](../img/033.jpg "Níveis de teste")

### Teste de unidade

* **Objetivo:** encontrar falhas de funcionamento dentro de uma pequena parte do sistema funcionando independentemente do todo  

* **Quem Executa:** Programador.  

* **Alvo:**  subrotinas, métodos, classes, i.e., as menores unidades do sistema
* Geralmente é automatizado, através de ferramentas como junit, PHPunit
* Pode ser realizado antes do sistema esta concluído.

![Arquitetura Teste de Unidade](../img/034.jpg "Arquitetura Teste de Unidade")

```java
 import junit.framework.TestCase;
 /**
 * Teste de unidade para classe pessoa
 */
 public class TestCarro extends TestCase{
     /**
     * Um teste para avaliar se a placa do carro esta formatada corretamento
     */
     public void testObterPlaca(){
         Placa p = new placa("JKL", 4709);
         assertEquals("JKL-4709", p.getPlacaCarro());
     }
 }
```

### Teste de Integração

* **Objetivo:** validar a comunicação entre os componentes de um sistema
* **Quem executa:** Programador
* **Alvo:** funcionalidades que envolvem a integração de componentes.
* Geralmente é automatizado, através de ferramentas como junit, PHPunit
* Pode ser realizado antes do sistema esta concluído.

![Arquitetura Teste de Integração](../img/035.jpg "Arquitetura Teste de Integração")

### Teste de Sistemas

* **Objetivo:**  executar o sistema sob ponto de vista de seu usuário final, varrendo as funcionalidades em busca de falhas em relação aos objetivos originais
* **Quem executa:** Equipe de teste
* **Alvo:** Cenários de teste coerentes com os requisitos especificados para o sistema.
* Geralmente é automatizado, através de ferramentas como junit, PHPunit
* Será realizado **após** do sistema esta concluído.

![Arquitetura Teste de Sistema](../img/036.jpg "Arquitetura Teste de Sistema")

Exemplo

![Arquitetura Teste de Sistema](../img/037.jpg "Arquitetura Teste de Sistema")

### Teste de Aceitação

* **Objetivo:**   executar o sistema sob ponto de vista de seu usuário final, varrendo as funcionalidades em busca de falhas em relação aos objetivos originais.
* Planejados e executados por um grupo restrito de usuários finais do sistema, que simulam operações de rotina do  sistema de modo a verificar se seu comportamento está de acordo com o solicitado.
* Visa permitir ao cliente determinar se aceita ou não o sistema.
* Pode incluir testes funcionais, de recuperação de falhas, de segurança e de desempenho.

![Aceita ou não](../img/038.png "Aceita ou não")
Aceita ou não aceita
#### Arquitetura
![Arquitetura Teste de Sistema](../img/036.jpg "Arquitetura Teste de Sistema")

### Teste de Alfa

* **Objetivo:**   executar o sistema de forma não planejada, sob ponto de vista de seu usuário final, porém, apenas por um grupo **pequeno** de pessoas.

* O grupo restrito de usuários que testarão geralmente é composto por membros da própria organização e também do cliente.
* Visa a identificação de possíveis erros não detectados até o momento, encontrados enquanto mais usuários finais utilizam o sistema de forma natural, não planejada.
* Representantes do time de programadores irão acompanhar de perto estes testes para coletar possíveis falhas a serem corrigidas e melhorias a serem implementadas.
![Teste Alfa](../img/039.jpg)

### Teste de Beta

* **Objetivo:**   executar o sistema de forma não planejada, sob ponto de vista de seu usuário final, porém, por um grupo **grande** de pessoas.
* Representantes do time de programadores **não** irão fazer acompanhamento e coleta de erros. No teste Beta, os usuários é que reportam os erros encontrados.
![Teste Beta](../img/040.jpg)

### Teste de Regressão

* **Objetivo:**    reexecutar testes após alterações serem realizadas no sistema, para conferir se tudo continua funcionando corretamente (detectar efeitos colaterais):

* Após mudanças de regras durante o desenvolvimento
    *  Ex.: youtube agora permite a postagem de vídeos 3D.
    ![Teste Beta](../img/041.jpg)
* Após a correção de uma falha encontrada
* Após a implementação de melhorias para lançamento de novas versões.

![Teste Beta](../img/042.jpg)

## Técnicas de testes ( Como testar ?)

![Tecnicas de teste](../img/043.jpg)


# Teste Automáticos x Testes Manuais

![](../img/044.jpg)

Teste Manuais | Teste Automáticos
------------- | ----------------- 
Velocidade de execução baixa |  Execução muito rápida
Repetitivo e Cansativo | Não cansam e não sentem preguiça.
Não exige tecnologias | Exige domínio de tecnologias específicas.
Alto custo a cada execução | Alto custo apenas na criação
Possuem limitações quando o teste envolve situações de grande paralelismo | Permite testar  situações impossíveis de testar manualmente
Podem explorar além do cenário de teste, quando necessário | Faz apenas o programado para fazer.
Podem avaliar questões visuais como cores e formas | Não avaliam questões visuais. 
Podem avaliar questões de usabilidade | Não avaliam questões de usabilidade.

# Teste Estático x Teste Dinâmico

### Teste Estático

**Objetivo:** analisar o código sem executá-lo e verificar se as boas práticas adotadas foram obedecidas.  
* Obviamente é um teste “Caixa Branca”
* Existem ferramentas que fazem este teste automaticamente **Ex.: Findbugs**
* Exemplos de verificações realizadas:
* Código está documentado?
* Variáveis e constantes possuem boa nomenclatura?
* Código está organizado e com boa legibilidade?
* Existem possíveis NullPointers não tratados pelo programador?
* O programador obedeceu à arquitetura do sistema ao codificar?
* As conexões com o banco de dados estão sendo fechadas após utilizadas?
![Análise estática](../img/045.jpg)
![Checkllist Análise estática](../img/046.jpg)
[Dowload Planilha - checklist](../cenarios/AnaliseEstatica/Checklist.xlsx)

### Teste Dinámicos

**Objetivo:** validar o sistema através de sua execução
* É o método tradicional: insere uma entrada, executa o sistema e confere a saída.
* As análises estáticas e dinâmicas se complementam
![Complementar](../img/047.jpg)