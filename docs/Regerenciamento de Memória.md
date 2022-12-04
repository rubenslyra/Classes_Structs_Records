# Gerenciamento de Memória em .NET

### O que é o Gerenciamento de Memória?

O gerenciamento de memória é um processo que consiste em alocar e desalocar memória dinamicamente. O gerenciamento de memória é feito pelo CLR (Common Language Runtime) e é responsável por gerenciar a memória de forma eficiente, garantindo que a aplicação não fique sem memória e que não ocorra vazamento de memória.

## Stack, Heap e Garbage Collector

### **Stack**

A Stack possui um tamanho fixo e é alocada na memória quando a aplicação é iniciada. A Stack é utilizada para armazenar variáveis locais e parâmetros de métodos. Quando um método é chamado, uma nova Stack é criada e quando o método é finalizado, a Stack é desalocada. A Stack é uma estrutura LIFO (Last In First Out), ou seja, o último elemento a entrar é o primeiro a sair.

| Sistema Operacional | Tamanho da Stack |
| :--- | :--- |
| x32 | 1 MB |
| x64 | 4 MB |

A Stack aloca apenas tipos primitivos e tipos de valor. Quando um tipo de valor é criado, ele é armazenado na Stack. Quando um tipo de valor é passado como parâmetro para um método, ele é copiado para a Stack do método. Quando um tipo de valor é retornado de um método, ele é copiado para a Stack do método que o chamou.

Lembrando que o tamanho da Stack pode ser alterado através do parâmetro -Xss.

### **Heap**

A Heap é uma região de memória que não possui tamanho fixo e é alocada na memória quando a aplicação é iniciada. A Heap é utilizada para armazenar objetos e é compartilhada por todas as threads da aplicação. A Heap é uma estrutura FIFO (First In First Out), ou seja, o primeiro elemento a entrar é o primeiro a sair.

### Como o CLR gerencia a memória?

O CLR utiliza o Garbage Collector (GC) para gerenciar a memória. O GC é um processo que é executado em segundo plano e que é responsável por monitorar a memória e identificar objetos que não estão mais sendo utilizados. Quando o GC identifica um objeto que não está mais sendo utilizado, ele é removido da memória.


### Garbage Collector

O Garbage Collector é um processo que é executado em segundo plano e que é responsável por monitorar a memória e identificar objetos que não estão mais sendo utilizados. Quando o GC identifica um objeto que não está mais sendo utilizado, ele é removido da memória.

O GC é executado quando a memória está próxima de esgotar. O GC é executado de forma incremental, ou seja, ele não para a aplicação para executar a limpeza de memória. O GC é executado em 3 fases:

1. **Marking**: Nesta fase, o GC identifica os objetos que estão sendo utilizados e os objetos que não estão sendo utilizados.
2. **Sweeping**: Nesta fase, o GC remove os objetos que não estão sendo utilizados da memória.
3. **Compactação**: Nesta fase, o GC compacta a memória para que os objetos que estão sendo utilizados fiquem próximos um dos outros.

### Gen1, Gen2 e Gen3

O que é Gen1:

Gen1 é a primeira geração de objetos. Os objetos que são criados na Gen1 são objetos que são criados com frequência e que são utilizados com frequência. Os objetos que são criados na Gen1 são armazenados na Heap.

   * O GC é executado a cada 0 a 2 segundos.
   * 85% dos objetos são removidos da memória.
   * 85% dos objetos são compactados.
   * 85% dos objetos são movidos para Gen2.
   * 15% dos objetos são movidos para Gen3.

O que é Gen2:

Gen2 é a segunda geração de objetos. Os objetos que são criados na Gen2 são objetos que são criados com frequência e que são utilizados com frequência. Os objetos que são criados na Gen2 são armazenados na Heap.

   * O GC é executado a cada 10 segundos.
   * 10% dos objetos são removidos da memória.
   * 10% dos objetos são compactados.
   * 10% dos objetos são movidos para Gen3.

O que é Gen3:

Gen3 é a terceira geração de objetos. Os objetos que são criados na Gen3 são objetos que são criados com frequência e que são utilizados com frequência. Os objetos que são criados na Gen3 são armazenados na Heap.

   * O GC é executado a cada 60 segundos.
   * 1% dos objetos são removidos da memória.
   * 1% dos objetos são compactados.


### Como o GC funciona?

O GC funciona da seguinte forma:

1. O GC identifica objetos que não estão mais sendo utilizados.
2. O GC marca esses objetos como "não utilizados".
3. O GC remove os objetos marcados da memória.
4. O GC compacta a memória.
5. O GC retorna a memória para o sistema operacional.
6. O GC executa novamente o processo.
7. O GC repete o processo até que não haja mais objetos para serem removidos.


## Classe, Struct e Record

### **Classe**

Uma classe é um tipo de referência que é definido pelo usuário. Uma classe é uma estrutura que contém dados e métodos. Uma classe é declarada utilizando a palavra-chave class. Uma classe pode conter:

   * Campos
   * Propriedades
   * Métodos
   * Construtores
   * Destrutores
   * Eventos
   * Índices
   * Operadores

### Struct

Uma struct é um tipo de valor que é definido pelo usuário. Uma struct é uma estrutura que contém dados e métodos. Uma struct é declarada utilizando a palavra-chave struct. Uma struct pode conter:

   * Campos
   * Propriedades
   * Métodos
   * Construtores
   * Destrutores
   * Eventos
   * Índices
   * Operadores

## Record

Um record é um tipo de valor que é definido pelo usuário. Um record é uma estrutura que contém dados e métodos. Um record é declarado utilizando a palavra-chave record. Um record pode conter:

   * Campos
   * Propriedades
   * Métodos
   * Construtores
   * Destrutores
   * Eventos
   * Índices
   * Operadores

_________ 
Referências:

* [CLASSES vs STRUCTS vs RECORDS - Eduardo Pires](https://www.youtube.com/watch?v=17YCZK4_RHI&t=19s)

* https://desenvolvedor.io 

* docs.microsoft.com

* https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/types/ 
