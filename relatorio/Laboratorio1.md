# Exercícios  - Laboratório 1


### **Exercício 1**
Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo: Número = 3025 Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . A soma de 30 com 25 é igual a 55 O Quadrado de 55 é igual a 3025. Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

#### Resolução: 
Foi feita uma função para verificar se o número pertence a regra desejada. Dentro dela, primeiramente, passou o número para string, em seguida foi utilizado o método Substring para pegar os dois primeiros números e também os dois últimos, transformando cada um deles em int depois. Após isso foi feita uma verificação se a soma dos dois números ao quadrado é igual ao número inicial. Dentro da main foi feito uma repetição de 1000 a 9999 e para cada número foi chamada a função de verificação.


#### Exemplo:
![Laboratorio 1 - Exercicio 1](/relatorio/Imagens/Laboratorio1/Exc1.jpg)

#

### **Exercício 2**

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele. Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo. Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6. Faça um programa que liste os números perfeitos de 1 a 1000.

#### Resolução:
Para saber se o número é primo, foi feita uma repetição começando de 2 até o número e verificado se o resto da divisão do número dividido por cada um dos seus antecessores maiores que 2 é igual a 0, caso seja, é retornado false significando que o número não é primo. 

Para verificar se o número é perfeito, foi feita uma função com uma repetição de 1 até o número que deseja verificar, caso o resto da divisão do  número dividido por seu antecessor seja igual a 0, é incrementado na soma. No final é verificado se a soma é igual ao número inicial. Na main foi feita uma repetição de 1 a 1000 em que para cada número é chamada a função descrita acima.


#### Exemplo1:
![Laboratorio 1  - Exercicio 2](/relatorio/Imagens/Laboratorio1/Exc2.jpg)

#### Exemplo2:
![Laboratorio 1  - Exercicio 2_2](/relatorio/Imagens/Laboratorio1/Exc2_2.jpg)

#

### **Exercício 3**

Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. Considere que nenhum dos vetores possui elementos repetidos. Crie um vetor resultante C que possua os elementos comuns entre A e B. Crie um vetor resultante D que contenha os elementos de A que não existam em B.

#### Resolução:

Para preencher os vetores A e B foi utilizado a função Random de números no intervalo de 1 a 15. Para pegar a interseção VETORES A e B foi feita uma função com dois For. O primeiro For para os valores de A e o segundo para os valores de B. Para cada valor de A é verificado se existe um valor igual dentro do vetor B, se existir, esse valor é adicionado no vetor C. Para  pegar os valores de A que não existem em B foi feito também dois for que irá verificar, para cada valor de A se possui um valor igual em B, se não possuir, adiciona o valor em D.



#### Exemplo:
![Laboratorio 1 - Exercicio 3](/relatorio/Imagens/Laboratorio1/Exc3.jpg)

#

 **Exercício 4**

Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

#### Resolução:
Para somar as linhas da matriz foi feito dois For, sendo que o For externo percorre as linhas e o For interno percorre as colunas, para que desta forma, para cada linha, seja percorrido e somados todos os valores dela. Já para somar as colunas da matriz foi feito dois For, sendo que o For externo percorre as colunas e o For interno percorre as linhas, para que desta forma, para cada coluna, seja percorrido e somados todos os valores dela.


#### Exemplo:
![Laboratorio 1 - Exercicio 4](/relatorio/Imagens/Laboratorio1/Exc4.jpg)

#

### **Exercício 5**

Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

#### Resolução:
Para calcular o fatorial do número foi feita uma função que contém uma repetição com decremento começando no número - 1 até maior que 0 e assim multiplicado o número por todos os seus antecessores maiores que 0.


#### Exemplo:
![Laboratorio 1 - Exercicio 5](/relatorio/Imagens/Laboratorio1/Exc5.jpg)

#

### **Exercício 6**

Faça um programa que chame uma função capaz de calcular x<sup>y</sup>, sendo x e y inteiros. Utilize passagem de parâmetros por referência.

#### Resolução:
Para calcular x<sup>y</sup> foi feita uma função com passagens de valor por referência e utilizado a função Math.Pow para elevar x a y.


#### Exemplo:
![Laboratorio 1 - Exercicio 6](/relatorio/Imagens/Laboratorio1/Exc6.jpg)

