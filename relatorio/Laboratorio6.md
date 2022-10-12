# Métodos de ordenação  - Laboratório 6

Para os testes e construções dos gráficos dos métodos de foram utilizados vetores de 10, 100, 1000 e 10000 posições preenchidos aleatóriamente.

### Bubblesort

Para ordenação do vetor utilizando o método do Bubblesort foi feito dois laços de repetição, um que irá controlar a posição de referência começando na última posição do vetor e vai até a posição 0, já o outro laço será para verificar as posições que estão antes da posição de referência, começando sempre na posição 0 e vai até o tamanho do vetor - 1 - a posição de referência. 


![Laboratorio 6 - BubbleSort](/relatorio/Imagens/Laboratorio6/bubblesortGrafico.png)


#

### Selection-sort

Foi feito dois laços de repetição, um dos laços que irá controlar a posição de referência indo da posição 0 até a última posição do vetor. O outro laço irá percorrer as posições restantes após a posição de referência, indo da posição de referência + 1 até a última posição vetor. Dentro do segundo for possui um if que irá verificar se o valor da posição atual é menor que o valor do vetor na posição do posMenor(que começa sempre na posição de referência) se for menor, o posMenor irá receber a posição atual e no final, será feito a troca do vetor na posMenor com o vetor na posição de referência.

![Laboratorio 6 - SelectionSort](/relatorio/Imagens/Laboratorio6/selectionsortGrafico.png)

#

### Insertion-sort

Para construção do método de inserção foi feito primeiramente um for que irá ser a posição de referência começando do valor 1 e indo até a última posição do vetor. Dentro desse for, possui um outro laço de repetição que irá começar sempre na posição de referência e irá diminuindo enquanto a o seu controlador for maior que 0 e também o vetor na posição atual -1 seja maior que a posição de referência, para que dessa forma seja encontrado o lugar certo para inserir o valor da posição de referência. 


![Laboratorio 6 - InsertionSort](/relatorio/Imagens/Laboratorio6/insertionsortGrafico.png)

#

### MergeSort

Foi feita uma chamada recursiva que irá realizar as divisões do vetor em subvetores e uma função que irá fazer a ordenação e junção dos subvetores.


![Laboratorio 6 - MergeSort](/relatorio/Imagens/Laboratorio6/mergeSort.png)

#

### QuickSort

Foi feita uma função quue escolhe o pivot e é feito comparações e trocas no array de tal forma a organizar para que os elementos à esquerda sejam menores ou iguais ao pivot e os elementos à direita sejam maiores.

![Laboratorio 6 - QuickSort](/relatorio/Imagens/Laboratorio6/quickSort.png)

#

### ShellSort:

Para o método do shellsort foi feito um while que irá controlar o hop, um laço de repetição que irá controlar a referência e um um outro laço que irá verificar as posições antes da posição de referência.


![Laboratorio 6 - ShellSort](/relatorio/Imagens/Laboratorio6/shellSortGrafico.png)

#

### Ordenação por contagem:

#### Exemplo:

![Laboratorio 6 - por contagem](/relatorio/Imagens/Laboratorio6/porContagemExemplo.jpg)

![Laboratorio 6 - porContagem](/relatorio/Imagens/Laboratorio6/porContagemGrafico.png)

