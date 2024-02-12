# Data Structures CS

O projeto de estruturas de dados visa estudar sobre alguns dos principais conceitos relacionados ao campo, visando a implementação de algoritmos de busca e ordenação com base no entendimento sobre o funcionamento do algoritmo.

Adendo: durante toda a construção do projeto, busquei minimizar a visualização de códigos prontos, contudo em alguns momentos tornou-se necessário.

## 🌍 Linguagens

[🇧🇷 Portuguese](./PORTUGUESE.md)

[🇺🇸 English](./README.md)

## 🚀 Tecnologias

- `.NET SDK 8`
- `C#`
- `Dotnet Cli`

## 🔑 Desafios

Como o estudo baseava-se no entendimento dos algoritmos e seu funcionamento, as grandes dificuldades vieram justamente da forma como eu as entendia, sendo assim, a cada problema no código era oportunidade para olhar novamente para o algoritmo. 

## 📖 O que eu aprendi

Durante o projeto, por mais que o objetivo final relacionava-se com o sucesso da implementação dos algoritmos, também obtive conhecimento sobre outras técnicas.

### 🕵️ Busca Sequencial

A busca sequencial é a mais simples das formas de busca, pois ela realiza a busca em cada um dos índices do array, sendo assim, há de perceber que a depender da localização do número e do tamanho do array, essa busca pode ser demorada e pouco flexivél.

Complexidade: `O(n)`

### 🕵️ Busca Binária

A busca binária é uma forma muito mais interessante de realizar buscas de valores, pois ela vai dividindo o array por partes e comparando o número requerido com o valor do array médio. O funcionamento da busca binária é simples de se entender:

Com um array previamente **ordenado**, a primeira decisão é buscar o índice `mínimo,` `médio` e `máximo` do array. Com os três valores devidamente calculados, o passo seguinte é comparar o valor armazenado no array com o valor a ser procurado, sendo algo como: `array[medio] == alvo`. Se o valor alvo for igual, então já sabe-se onde ele está localizado, finalizando o algoritmo. Caso o valor não seja igual, é realizado uma comparação, buscando entender se o valor alvo é maior ou menor que o encontrado no array[medio]. Se for menor, sabe-se então que o valor alvo está localizado na parte a esquerda do array, necessitando então que o índice `máximo` seja trocado para o valor onde o índice `médio` se localizava, completando o algoritmo e reiniciando-o. Se for maior, sabe-se que o valor alvo está localizado na parte a direita, então o índice `mínimo` é trocado para o valor do índice `médio`, fechando o algoritmo e realizando novamente a busca.

Nas duas ocasiões onde busca-se entender onde o valor alvo se localiza, o índice `médio` é constantemente recalculado com base nos dois outros, para possibilitar novamente a busca.

Complexidade: `O(log2 n)`

### ☁️ Ordenação por flutuação (Bubble Sort)

A ordenação por flutuação tem um conceito muito simples. Dado um array, os dois primeiros valores dos índices (0 e 1) são comparados, se o primeiro for maior que o segundo, há a realização da troca, se não, essa dupla de índices andam uma casa para frente, ou seja, agora a análise é feita entre os índices 1 e 2. A cada nova análise a comparação é feita, até que todos os valores estejam deviamente ordenados. 

Complexidade: `O(n²)`

### ↪️ Ordenação por inserção (Insertion Sort)

A ordenação por inserção é um dos conceitos mais divertidos, a ideia é muito referênciada por meio de cartas, onde uma pessoa busca ordenar seu baralho, e realiza esse feito pegando uma carta e a pondo no lugar exato onde ela deve estar, de forma que fique ordenado. 

Ao iniciar a ordenação, o primeiro loop é iníciado e o primeiro índice é capturado do array. O valor do índice é comparado, se for menor, então sabe-se que deve ir para frente. Essa comparação é feita até que seja identificado a sua posição, finalizando o primeiro loop. Os loops ocorrem até que todos os valores estejam ordenados.

Complexidade: `O(n²)`

### ↪️ Ordenação por mesclagem (Merge Sort)

A ordenação por mesclagem trabalha de um modo diferente, ela utiliza da técnica de `recursividade` para a ordenação, com uma ideia levada a *Dividir para conquistar*. A ordenação Merge deve ser realizada com duas funções, onde a primeira será chamada pelo "cliente", recebendo um array desordenado. O array desordenado é dividido em dois, e cada parte entra novamente na mesma função, onde será dividida novamente. Esses arrays que se dividem serão retornados pela mesma função, que por sua vez utiliza de outra função para ordenação dos arrays.

Complexidade: `O(nlogn)`

### ⚡ Ordenação rápida (Quick Sort)

O Quick Sort é um método de ordenação que também utiliza de recursão igual ao [Merge Sort](#ordenação-por-mesclagem-merge-sort), porém, uma das suas principais características é a forma como ela trabalha. Essa técnica é baseada na escolha de um pivô, onde a partir dele todos os outros valores menores e maiores serão organizados. A organização pelo pivô é baseada na estrutura final da ordenação, pois um array devidamente ordenado de forma ascendente terão valores menores a esquerda e valores maiores a direita, a depender da referência. Ao final do movimento baseado no pivô, é retornado o índice onde o pivô está localizado. Todos esses movimentos são realizados até que o array esteja totalmente organizado.


Complexidade: `O(n²)`

### Ordenação Heap (Heap Sort)

A ordenação Heap é diferenciada, ela utiliza a estrutura heap para ordenação dos elementos. Por conta da peculiaridade da sua estrutura, ela é facilmente representada por uma árvore, que mais tarde entende-se como uma árvore binária especial. A ideia é ordenar utilizando a raíz e seus filhos como referência, sendo assim, caso um dos filhos seja maior que a raíz, troca-se os elementos, e a nova raíz se torna o maior, trazendo a ordenação de forma crescente, ou seja, o maior elemento fica no topo/raíz.

Essa foi uma das estruturas mais complicadas de realizar e entender, pois lida com os dados de uma forma muito diferente, causando uma confusão durante o processo.

Complexidade: `O(nlogn)`

### 💡 Método de troca de valores no array

Durante o algoritmo [Insertion Sort](#↪️-ordenação-por-inserção-insertion-sort), uma das necessidades é realizar a troca de valores entre dois índices. Esse problema é simples e facil de resolver utilizando um auxiliar, contudo, no c# não foi preciso, pois a troca pode ser feita facilmente com uma linha de código, como:

```c#
(randomArray[j], randomArray[j-1]) = (randomArray[j-1], randomArray[j]);
```

### Linq não têm efeitos colaterais

Durante o algoritmo [Merge Sort](#ordenação-por-mesclagem-merge-sort), ocorreu um erro onde no método `Merge` não era possivel ver o array ordenado pois o array não recebia o valor pela função `Append`. Após analisar os codigos *Warnings*, entendi que o Linq em si, ao utilizar apenas o `Append`, não executa diretamente no array, e sim retorna o resultado, sendo assim, torna-se necessário receber o novo array ou utilizar de outro método. Neste caso, foi utilizado o:

```c#
sortedArray = [.. sortedArray, secondPartialArray[0]]; // Por exemplo
```

O *Warning* recebido era: 

    'Merge' chama 'Append' mas não usa o valor retornado pelo método. Os métodos Linq são conhecidos por não terem efeitos colaterais. Use o resultado em uma instrução condicional, atribua o resultado a uma variável ou passe-o como argumento para outro método.

## 📦 Instalação e Execução

### Requerimentos

O projeto é criado com C# juntamente com o .net sdk, sendo assim, há a necessidade do:

- .NET SDK
- Dotnet CLI

### Execução

A instalação do projeto é simples de fazer:

Primeiro, `clone` o projeto juntamente com a solução `.sln`:

```bash
git clone https://github.com/devcavalcant/data-structures-cs.git
```

Tendo o projeto em mãos, entre no projeto e `execute`:

```bash
dotnet run
```
