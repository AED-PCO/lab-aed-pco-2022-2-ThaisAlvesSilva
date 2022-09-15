# Exercícios - Complexidade

### Exercício 1

![Complexidade - Exercicio 1](/relatorio/Imagens/Complexidade/Exc1.jpg)

**Operação mais relevante:** Atribuição, pois possui o maior custo

|Operação   | Quantidade  | Total |
|------|-----------------------------------------|----|
|Atribuições:| (1 * (n -1)) + 1 | n | 
|Multiplicações:| 1 * (n - 1)  | n - 1 |

**Há variação de casos?** Não


#

### Exercício 2

![Complexidade - Exercicio 2](/relatorio/Imagens/Complexidade/Exc2.jpg)

**Operação mais relevante:** Comparação 

**Operações:** Comparações e retorno

**Há variação de casos?** Sim.

Melhor caso: o valor procurado já estar na primeira posição do vetor, que assim será feita a comparação apenas uma vez.

Pior caso: o valor procurado estar na última posição ou não existir no vetor, pois assim, será feito n comparações, ou seja, o vetor inteiro será percorrido e todas as suas posições comparadas.

Caso médio: o valor procurado estar entre a última e a primeira posição.

#

### Exercício 3

![Complexidade - Exercicio 3](/relatorio/Imagens/Complexidade/Exc3.jpg)

**Operação mais relevante:** Comparação


|Operação   | Quantidade  |
|------|-----------------------------------------|
|Atribuições:| n<sup>2</sup> - n  |
|Comparações:| n<sup>2</sup> |
|Divisões:| n<sup>2</sup> - n  |





**Há variação de casos?** Não

#

### Exercício 4

![Complexidade - Exercicio 4](/relatorio/Imagens/Complexidade/Exc4.jpg)

**Operação mais relevante:** Comparações

|Operação    | Quantidade  | 
|------|-----------------------------------------|
|Atribuições:| (m * n) + 2n + 1 |
|Somas:| (m * n) + n  |
|Divisões:| n  | n |

**Há variação de casos?** Não
