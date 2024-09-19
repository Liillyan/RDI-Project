# RDI-Project

# GeladeiraRDI

## Descrição

A **GeladeiraRDI** Demonstra a aplicação de conceitos de Programação Orientada a Objetos (POO) como encapsulamento, herança e abstração.

## Estrutura do Projeto

O projeto é dividido em várias classes que representam a estrutura da geladeira e suas operações. As principais classes são:

### **1. Geladeira**

- **Responsabilidade**: Gerencia a geladeira como um todo, incluindo a inicialização dos andares e containers, e fornece métodos para adicionar, remover e imprimir itens.
- **Métodos**:
  - `Inicializar()`: Popula a geladeira com itens iniciais.
  - `AdicionarElemento(int andar, int container, int posicao, string item)`: Adiciona um item na posição especificada.
  - `RemoverElemento(int andar, int container, int posicao)`: Remove o item da posição especificada.
  - `ImprimirItens()`: Imprime todos os itens armazenados na geladeira.

### **2. Andar**

- **Responsabilidade**: Representa um andar na geladeira, contendo containers. Pode ser estendido para incluir mais funcionalidades no futuro.

### **3. Container**

- **Responsabilidade**: Representa um container dentro de um andar, onde os itens são armazenados. Também pode ser estendido para incluir mais funcionalidades.

### **4. ItemGeladeira**

- **Responsabilidade**: Representa um item armazenado na geladeira.
- **Propriedades**:
  - `Nome`: O nome do item.

### **5. Armazenamento (Base Abstrata)**

- **Responsabilidade**: Define a estrutura base para o armazenamento de itens, permitindo a reutilização de código em classes derivadas.
- **Métodos Abstratos**:
  - `ImprimirItens()`: Método que deve ser implementado por classes derivadas para imprimir os itens armazenados.

## Implementação de POO

- **Encapsulamento**: As propriedades e métodos das classes são encapsulados para proteger os dados e fornecer uma interface controlada para interações externas. Por exemplo, a classe `Geladeira` encapsula a estrutura interna da geladeira e fornece métodos públicos para manipulação.
- **Herança**: A classe `Armazenamento` serve como uma base para outras classes, permitindo a reutilização de código e a extensão das funcionalidades. As classes `Andar` e `Container` podem herdar de `Armazenamento` se precisarem implementar funcionalidades comuns.
- **Abstração**: A classe `Armazenamento` é uma classe abstrata que define uma interface comum para todas as classes que representam diferentes partes da geladeira. Isso permite que diferentes tipos de armazenamento implementem a lógica específica para impressão de itens.

## Como Funciona

1. **Inicialização**: O sistema inicializa a geladeira com alguns itens de exemplo.
2. **Manipulação de Itens**: Itens podem ser adicionados ou removidos usando os métodos fornecidos pela classe `Geladeira`.
3. **Impressão de Itens**: Todos os itens presentes na geladeira são impressos para visualização.

## Estrutura de Classes

- **Geladeira**: Gerencia andares e containers, fornece operações sobre itens.
- **Andar**: Contém containers, é responsável por armazenar e organizar os containers.
- **Container**: Contém itens, organiza o armazenamento de itens.
- **ItemGeladeira**: Representa um item individual na geladeira.
- **Armazenamento**: Classe base para armazenar e gerenciar itens, fornecendo uma interface comum.

