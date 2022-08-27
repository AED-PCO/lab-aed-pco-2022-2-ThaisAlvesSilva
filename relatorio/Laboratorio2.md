# Exercícios  - Laboratório 2


### Exercício 1

Escreva um método recursivo que retorne o fatorial de um número.

#### Resolução:

Foi feito uma função recursiva que a cada interação houvesse a multiplicação do número pela chamada da função passando como prâmetro o número -1, para que assim houvesse a multiplicação do número por todos os seus antecessores até 2.

#### Exemplo:
![Laboratorio 2 - Exercicio 1](/relatorio/Imagens/Laboratorio2/Exc1.jpg)

#

### Exercício 2

Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por parâmetro.

#### Resolução:

Para realizar a multiplicação dos dois números, foi feita uma função que recebe dois parâmetros e quantas vezes deseja-se multiplicar, para que,desta forma, a função pudesse retornar o número mais a chamada da função passando como parâmetro o número a ser multiplicado e o segundo parâmetro  com o número sempre - 1.

#### Exemplo:
![Laboratorio 2 - Exercicio 2](/relatorio/Imagens/Laboratorio2/Exc2.jpg)

#

### Exercício 3

Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de A<sup>B</sup>

#### Resolução:

Para realizar a potenciação foi feito uma função que recebe a base e o expoente. Com isso, a função realiza a multiplicação da base com a chamada da função passando sempre o expoente -1.

#### Exemplo:
![Laboratorio 2 - Exercicio 3](/relatorio/Imagens/Laboratorio2/Exc3.jpg)

#

### Exercício 4

Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

#### Resolução:

Foi feita uma função que recebe a frase e a letra que deseja contar. A cada interação é feito uma verificação para ver se a letra na última posição da frase é igual a letra que procura. Para a chamada da função foi utilizado o método Substring que irá pegar a frase do inicio até a sua ultima posição(frase.Length -1).

#### Exemplo:
![Laboratorio 2 - Exercicio 4](/relatorio/Imagens/Laboratorio2/Exc4.jpg)

#

### Exercício 5

Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

#### Resolução:

Para realizar a soma foi feita uma função recursiva que recebe sempre o vetor e um parâmetro que será decrementado a cada operação. Dentro da função é feita uma verificação para saber o resto da divisão do número por 2 é igual a 0, ou seja, se ele é par, se isso for verdade é feito a soma e a chamada da função recursiva. 

#### Exemplo:
![Laboratorio 2 - Exercicio 5](/relatorio/Imagens/Laboratorio2/Exc5.jpg)

#
### Exercício 6

Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.

#### Resolução:

Foi feita uma função que recebe a frase. A cada interação é feito uma verificação para ver se a letra na última posição da frase é igual a uma das vogais. Para a chamada da função foi utilizado o método Substring que irá pegar a frase do inicio até a sua ultima posição.


#### Exemplo:
![Laboratorio 2 - Exercicio 6](/relatorio/Imagens/Laboratorio2/Exc6.jpg)

### Exercício 7

Escreva um método recursivo para saber qual é o número na sequencia de Fibonacci em determinada posição. 

#### Resolução:
Para calcular o número foi feita a chamada da função duas vezes e realiza a soma do resultado.

#### Exemplo:
![Laboratorio 2 - Exercicio 7](/relatorio/Imagens/Laboratorio2/Exc7.jpg)


