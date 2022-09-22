## Busca binária

#### Resolução: 

Para resolução desse problema foi feita uma função recursiva que recebe como parâmetro 4 valores: o vetor, o valor que deseja procurar, a posição inicial do vetor e a posição final. Para cada iteração é feita a verificação se o número procurado é igual ao valor que está na posição do meio do vetor, se é maior que o valor do meio ou se é menor. Se o valor for igual ao valor do meio, é feito é retornado a posição do meio. Se o valor for maior que o valor do meio, é feito uma chamada recursiva passando os parâmetros da seguinte forma: a posição inicial passa a ser a posição do meio do vetor + 1, já a posição final continua sendo o vetor.Length - 1. Caso o valor procurado seja menor que o meio é feita a chamada recursiva de outra forma: a posição inicial passa a ser a posição 0 do vetor e a posição final será o meio do vetor -1. A condição de parada da função é a posição final ser menor  que a posição inicial, pois nesse caso o vetor terá chegado ao seu fim. 


#### Exemplo:

![Laboratorio 3 - Exercicio 1](/relatorio/Imagens/Laboratorio3/BuscaEOrdenacao/buscaComPos/buscaBinariaComPos.jpg)

![Laboratorio 3 - Exercicio 1](/relatorio/Imagens/Laboratorio3/BuscaEOrdenacao/buscaComPos/Grafico.png)

## Busca binária sem passar a posição

#### Resolução:

Para resolução desse problema foi feita uma função recursiva que recebe como parâmetro 2 valores: o vetor e o valor que se deseja procurar. Para cada iteração é feita a verificação se o número procurado é igual ao valor que está na posição do meio do vetor, se é maior que o valor do meio ou se é menor. Se o valor for igual ao valor do meio, é feito é retornado a posição do meio. Se o valor for maior que o valor do meio, é feito uma cópia dos valores do vetor da posição meio + 1 até o seu final para ser passado na chamada da função recursiva. Já se o valor procurado seja menor que o meio é feito uma cópia dos valores do vetor da posição 0 do vetor até a posição do meio para ser passado na chamada recursiva. Vale ressaltar que o vetor para o qual será copiado os valores já é criado com a quantidade de valores exatos que serão copiados, assim: se o valor do meio for maior que o valor procurado, o vetor cópia terá tamanho da posição do meio, já se o valor do meio for menor que o valor procurado, o vetor cópia terá o tamanho =  vetor.Length - posição do meio + 1. 

#### Exemplo:

![Laboratorio 3 - Exercicio 2](/relatorio/Imagens/Laboratorio3/BuscaEOrdenacao/buscaSemPos/buscaBinariaSemPos.jpg)

![Laboratorio 3 - Exercicio 2](/relatorio/Imagens/Laboratorio3/BuscaEOrdenacao/buscaSemPos/Grafico.png)
