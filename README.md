# RDI-Project

# Semana 1 
## Sistema de Controle de Itens na Geladeira

Exercicio para criação de um sistema de controle de itens dentro de uma geladeira.

## Descrição do Projeto

Este projeto implementa um sistema para gerenciar itens em uma geladeira com a seguinte estrutura:

- **3 Andares**: A geladeira possui três andares, cada um dedicado a diferentes categorias de alimentos.
- **2 Containers por Andar**: Cada andar contém dois containers.
- **4 Posições por Container**: Cada container possui quatro posições para armazenar os itens.

### Organização dos Andares

- **Andar 0**: Containers voltados para hortifrutis.
- **Andar 1**: Containers voltados para laticínios e enlatados.
- **Andar 2**: Containers para charcutaria, carnes e ovos.

### Funcionalidade

O programa permite a adição de itens à geladeira e imprime todos os produtos armazenados, mostrando o andar e o container de cada item.

## Estrutura de Dados

Para implementar este sistema, foi utilizada uma **matriz tridimensional** (`string[,,]`), que permite organizar os itens de forma estruturada:

- **Dimensões**:
  - Primeira dimensão: Andares (0 a 2)
  - Segunda dimensão: Containers (0 a 1)
  - Terceira dimensão: Posições (0 a 3)
